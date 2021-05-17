# Continuously evaluates an expression ($CheckExpression) until it becomes false.
# If $CheckExpression tries to obtain a resource, then the function returns that resource after timeout, or whatever the evaluation returns when the resource is no longer obtainable, such as $null.
# The function will continue to loop also if there was an exception invoking the $CheckExpression until it has waited $MaxSleepSeconds between checks.
function Wait-IncrementsUntilTimeOut
{
    Param
    (
        # The string of the condition to check until it becomes false.
        [Parameter(Mandatory = $true)]
        [string] $CheckExpression,
        # The maximum seconds to wait before timeout.
        [int] $MaxSleepSeconds=300,
        # The amount of seconds to sleep between each evaulation of the $CheckExpression.
        [int] $SleepSecondsUnit=5,
        # Negates the loop logic based on $CheckExpression, unless there is an exception evaluating $CheckExpression.
        # This is preferable to adding "!" or "-not" where you lose evaluated information by reducing returned information to $true or $false.
        [switch] $Negate
    )
    $currentSeconds = 0
    $expressionResult = $null
    # $currentSeconds should not be compared to a multiple of $sleepSecondUnit since it won't tell us if the operation was successful because it could be that
    # it was successful at the last second. If the $currentSeconds is ($maxSleepSeconds+1) or over, we know for sure the operation took too long.
    while ($currentSeconds -lt ($MaxSleepSeconds + 1))
    {
        # If $expressionResult is $null or $false, then the loop stops. If $expressionResult is non-empty, then the loop continues. Returns $expressionResult.
        try
        {
            $expressionResult = Invoke-Expression $CheckExpression
            $stringOutput = $expressionResult
            $loop = $expressionResult
            if ($Negate)
            {
                $loop = !$expressionResult
            }
        }
        catch
        {
            Write-Verbose -Message "ERROR running command: ${CheckExpression}" -Verbose
            Write-Verbose -Message $_.ScriptStackTrace -Verbose
            Write-Verbose -Message "$($_ | Out-String)" -Verbose
            $loop = $true
        }

        $invalidToString = $false
        try
        {
            $stringOutput = $expressionResult.toString()
        }
        catch
        {
            $invalidToString = $true
            $stringOutput = $expressionResult | Out-String
            Write-Verbose -Message "'${CheckExpression}' does not have a valid toString(), and has an Out-String of '${stringOutput}'." -Verbose
        }

        if (!$invalidToString)
        {
            Write-Verbose -Message "'${CheckExpression}' evaluated to '${stringOutput}'." -Verbose
        }

        # $loop is $true when $CheckExpression evaluates to truthy value, but if $Negate is true, then that logic is reversed
        # $loop is also $true if $CheckExpression evaluation throws an exception.
        if ($loop)
        {
            Write-Verbose -Message "Waited for ${currentSeconds} seconds. Waiting ${SleepSecondsUnit} more seconds and then running again..." -Verbose
            $currentSeconds += $SleepSecondsUnit
            Start-Sleep -Seconds $SleepSecondsUnit
        }
        else
        {
            break
        }
    }

    if ($currentSeconds -ge ($MaxSleepSeconds + 1))
    {
        Write-Verbose -Message "'${CheckExpression}' still evaluates to '${stringOutput}' after timeout of ${MaxSleepSeconds} seconds." -Verbose
    }
    else
    {
        Write-Verbose -Message "'${CheckExpression}' evaluated to a value of '${stringOutput}' before timeout of ${MaxSleepSeconds} seconds." -Verbose
    }

    $expressionResult
}

# Creates a new service principal client Id and secret. Only required if a service principal does not already exist. Requires admin privileges to create.
function New-AzsSPSecret
{
    [CmdletBinding(DefaultParameterSetName = "notAdfs")]
    param
    (
        [Parameter(ParameterSetName = "Adfs", Mandatory = $false)]
        [Parameter(ParameterSetName = "Aad", Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string]$ServicePrincipalName,
        [Parameter(ParameterSetName = "Adfs", Mandatory = $true)]
        [Parameter(ParameterSetName = "Aad", Mandatory = $false)]
        [ValidateNotNullOrEmpty()]
        [string]$ApplicationName,
        [ValidateNotNullOrEmpty()]
        [string]$ErcsVmDnsName= "AzS-ERCS01.azurestack.local"
    )
    Write-Verbose -Message "Creating Service Principal ${ServicePrincipalName}." -Verbose
    $servicePrincipal = $null
    $loginInfo = @{
        "ClientId" = $null;
        "ClientSecret" = $null;
        "ObjectId" = $null
    }

    if ($ApplicationName)
    {
        $ercsVmName = $ErcsVmDnsName.Split(".")[0]
        $session = New-PSSession -ComputerName $ercsVmName -ConfigurationName PrivilegedEndpoint -Credential $ServiceAdminCreds
        $applications = Invoke-Command -Session $session -ScriptBlock { Get-GraphApplication }
        $servicePrincipalApplication = $applications | Where-Object {$_.Name -like "*${ApplicationName}*"}

        if ($servicePrincipalApplication)
        {
            foreach ($application in $servicePrincipalApplication)
            {
                Invoke-Command -Session $session -ScriptBlock { Remove-GraphApplication -ApplicationIdentifier $using:application.Identifier} 
            }

            Get-AzADApplication -DisplayNameStartWith "Azurestack-${ApplicationName}" -ErrorAction SilentlyContinue | Remove-AzADApplication -Force
        }

        $servicePrincipal = Invoke-Command -Session $session -ScriptBlock { New-GraphApplication -Name $using:ApplicationName -GenerateClientSecret}
        $spExistsExpression = "Invoke-Command -Session (Get-PSSession -Id $($session.Id)) -ScriptBlock { Get-GraphApplication -ApplicationIdentifier $($servicePrincipal.ApplicationIdentifier)}"
        $spExists = Wait-IncrementsUntilTimeOut -CheckExpression $spExistsExpression -Negate
        if (!$spExists)
        {
            throw "The service principal $($servicePrincipal.Id) still failed to exist after checking for an alloted amount of time."
        }

        Write-Verbose -Message "Created the following service principal:" -Verbose
        $servicePrincipal | Out-String | Write-Verbose -Verbose
        $roleAssignmentExpression = "(New-AzRoleAssignment -RoleDefinitionName Owner -ApplicationId $($servicePrincipal.ClientId))"
        $role = Wait-IncrementsUntilTimeOut -CheckExpression $roleAssignmentExpression -Negate
        if (!$role)
        {
            throw "Failed to assign role Owner to service principal $($servicePrincipal.ClientId)"
        }
        $loginInfo["ClientId"] = $servicePrincipal.ClientId
        # The client secret in ADFS is in plain text, no need to convert from SecureString for now. Reconsider this in the future if this changes.
        $loginInfo["ClientSecret"] = $servicePrincipal.ClientSecret | ConvertTo-SecureString -AsPlainText -Force | ConvertFrom-SecureString
        $loginInfo["ObjectId"] = $servicePrincipal.ApplicationIdentifier
            
        # Clean up and reset context.
        $session | Remove-PSSession
    }
    else
    {
        $servicePrincipal = Get-AzADServicePrincipal -DisplayName $ServicePrincipalName

        if ($servicePrincipal)
        {
            Remove-AzADServicePrincipal -ObjectId $servicePrincipal.Id -Force
        }

        $servicePrincipalApplication = Get-AzADApplication -DisplayName $ServicePrincipalName

        if ($servicePrincipalApplication)
        {
            $servicePrincipalApplication | Remove-AzADApplication -Force
        }

        $servicePrincipal = New-AzADServicePrincipal -Role Owner -DisplayName $ServicePrincipalName
        $spExistsExpression = "((Get-AzADServicePrincipal -ObjectId $($servicePrincipal.Id)) -and (Get-AzADApplication -DisplayName ${ServicePrincipalName}))"
        $spExists = Wait-IncrementsUntilTimeOut -CheckExpression $spExistsExpression -Negate
        if (!$spExists)
        {
            throw "The service principal $($servicePrincipal.Id) still failed to exist after checking for an alloted amount of time."
        }

        Write-Verbose -Message "Created the following service principal:" -Verbose
        $servicePrincipal | Out-String | Write-Verbose -Verbose
        
        $loginInfo["ClientId"] = $servicePrincipal.ApplicationId
        $loginInfo["ClientSecret"] = ConvertFrom-SecureString $servicePrincipal.Secret
        $loginInfo["ObjectId"] = $servicePrincipal.Id
    }

    if (-not $servicePrincipal)
    {
        throw [System.Exception] "The service principal is null. Failed to create and connect to a service principal context named ${ServicePrincipalName}."
    }

    return $loginInfo
}

function Write-HelloWorld
{
    param
    (
        [ValidateSet("hello", "hello world!")]
        [string] $test
    )
    Write-Host "$test"
}

# Downloads and installs an .msi or .exe software from a url.
function Install-SoftwareFromURL
{
    param
    (
        [Parameter(Mandatory = $true)]
        [string]$DownloadURL,
        # Specify location to install files, currently only used for .exe files.
        [Parameter(Mandatory = $false)]
        [string]$InstallDirectory,
        # Used to name the downloaded file before installation. Must include extension. The last part of URL used as file name and extension by default.
        [Parameter(Mandatory = $false)]
        [string]$DownloadedFileName,
        # The likeness string is used to check if the software is already installed. This is not required.
        [Parameter(Mandatory = $false)]
        [string]$RegistryDisplayNameLike,
        [Parameter(Mandatory = $false)]
        [string]$InstallLogFilePath,
        # Force install doesn't work for msi files since windows will throw 1603 exit code error if the software already exists.
        [Parameter(Mandatory = $false)]
        [switch]$ForceInstall
    )

    if ($DownloadedFileName -and $DownloadedFileName.Split(".").Count -lt 2 )
    {
        throw "Error: `$DownloadedFileName must include an extension!"
    }

    $install = $true
    if (!$ForceInstall -and $RegistryDisplayNameLike)
    {
        $x86_check = ((Get-ItemProperty "HKLM:\Software\Microsoft\Windows\CurrentVersion\Uninstall\*") | where-object { $_.DisplayName -like $RegistryDisplayNameLike } ).DisplayName.Length -gt 0;
        if (Test-Path 'HKLM:\Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall') {
            $x64_check = ((Get-ItemProperty "HKLM:\Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\*") | where-object { $_.DisplayName -like $RegistryDisplayNameLike } ).DisplayName.Length -gt 0;
        }
        if ($x64_check -or $x86_check) {
            $install = $false
            Write-Verbose -Message "The software from ${DownloadURL} was already installed." -Verbose
        }
    }
    if($install)
    {
        if ($ForceInstall)
        {
            Write-Verbose -Message "WARNING: ForceInstall option selected. Might not succeed if software with higher version already installed or other reasons." -Verbose
        }

        Write-Verbose -Message "Downloading: ${DownloadURL}" -Verbose

        if (!($DownloadedFileName))
        {
            $fileName = $DownloadURL.Split("/")[-1]
            $extension = $fileName.Split(".")[-1]
        }
        else
        {
            $fileName = $DownloadedFileName
            $extension = $DownloadedFileName.Split(".")[-1]
        }

        $tempDirObject = New-Item -Path ([System.IO.Path]::GetTempPath()) -Name ([System.IO.Path]::GetRandomFileName()) -ItemType "directory"
        $tempDir = $tempDirObject.FullName
        $downloadedPath = Join-Path -Path $tempDir -ChildPath $fileName
    
        $sleepSecondsUnit = 5
        $maxSleepSeconds = 60
        $currentSeconds = 0
    
        # $currentSeconds should not be compared to a multiple of $sleepSecondUnit since it won't tell us if the operation was successful because it could be that
        # it was successful at the last second. If the $currentSeconds is ($maxSleepSeconds+1) or over, we know for sure the operation took too long.
        while ($currentSeconds -lt $maxSleepSeconds + 1)
        {
            Write-Verbose -Message "Attempting to download ${DownloadURL}, ignore errors until timeout. $($maxSleepSeconds - $currentSeconds) seconds until timeout error." -Verbose
            try
            {
                $webClient = New-Object System.Net.WebClient
                [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
                $webClient.DownloadFile($DownloadURL, $downloadedPath)
                Write-Verbose -Message "Finished downloading ${DownloadURL}." -Verbose
                break
            }
            catch
            {
                Write-Verbose $_
                $currentSeconds += $sleepSecondsUnit
                Start-Sleep -Seconds $sleepSecondsUnit
                Write-Verbose -Message "Failed to download file, retrying..." -Verbose
            }
        }
    
        if ($currentSeconds -ge $maxSleepSeconds + 1)
        {
            Remove-Item $tempDir -Recurse
            throw [System.Exception] "Attempts to download ${DownloadURL} command timed out."
        }
    
        Write-Verbose -Message "Performing quiet install" -Verbose

        ####################
        #   INSTALL EXE
        ####################
        if ($extension -eq "exe")
        {
            $arguments = "/SP- /VERYSILENT /SUPPRESSMSGBOXES /FORCECLOSEAPPLICATIONS InstallAllUsers=1 PrependPath=1"
            if ($InstallDirectory)
            {
                $arguments += " TargetDir=`"${InstallDirectory}`""
            }
            if ($InstallLogFilePath)
            {
                $arguments += " /log=${InstallLogFilePath}"
            }
            $runExpression = "(Start-Process -FilePath '${downloadedPath}' -ArgumentList '${arguments}' -Wait -PassThru -NoNewWindow).ExitCode -ne 0"
            $installFailed = Wait-IncrementsUntilTimeOut -CheckExpression $runExpression -SleepSecondsUnit 60 -MaxSleepSeconds 60
        }

        ####################
        #   INSTALL MSI
        ####################
        elseif ($extension -eq "msi") {
            $arguments = "/i ${downloadedPath} /quiet AllUsers=1"

            if ($InstallLogFilePath)
            {
                $arguments += " /L*V ${InstallLogFilePath}"
            }

            $runExpression = "(Start-Process msiexec -ArgumentList '${arguments}' -Wait -PassThru -NoNewWindow).ExitCode -ne 0"
            $installFailed = Wait-IncrementsUntilTimeOut -CheckExpression $runExpression -SleepSecondsUnit 60 -MaxSleepSeconds 60
        }
        
        if ($installFailed) 
        {
            Remove-Item $tempDir -Recurse
            Write-Verbose -Message "Last error message: $Error[0]" -Verbose
            throw "Failed to install: $DownloadURL"
        }

        Write-Verbose -Message "Successfully installed: $DownloadURL" -Verbose
        Remove-Item $tempDir -Recurse
    }
    else
    {
        Write-Verbose -Message "Skipping installation of software from ${DownloadURL}." -Verbose
    }
}