param
(
    [Parameter(Mandatory = $true)]
    [string] $AzureSubscriptionId,

    # Create a password to protect the exported certificate .pfx file.
    [Parameter(Mandatory = $true)]
    [System.Security.SecureString] $SecureCertPfxPassword,

    [Parameter(Mandatory = $false)]
    [switch] $NodeJS,

    [Parameter(Mandatory = $false)]
    [switch] $Golang,

    # This variable is used to load existing service principal details from another powershell script. The dot notation will be used to load that script. For the existing details,
    # the .ps1 file needs to contain two hashtables for the service principal application and certificate hashtable with the following keys accessible from this script:
    # $azureAppSpInfo["ClientId"]
    # $azureAppSpInfo["ClientSecret"]
    # $azureAppSpInfo["ObjectId"]
    # $azureCertSpInfo["ClientId"]
    # $azureCertSpInfo["CertificateThumbprint"]
    # $azureCertSpInfo["ObjectId"]
    [Parameter(Mandatory = $false)]
    [string] $ExistingServicePrincipalDetails
)

. "C:\CloudDeployment\BVTs\BVTSettingUtils.ps1"
Import-Module $([io.path]::combine($PSScriptRoot, "Common.psm1"))
Import-AzModules -AzVersion "0.10.0" 

# Retrieve BVTSettings.xml settings.
$adminName = Get-Setting -key ServiceAdminUpn
$adminPassSecureString = ConvertTo-SecureString -String (Get-Setting -key ServiceAdminPassword) -AsPlainText -Force
$deploymentId = Get-Setting -key DeploymentId
$adfs = ([System.String](Get-Setting -key AadLoginUri)).EndsWith("/adfs")
$azureTenantId = Get-Setting -key AADTenantID
$azureLocation = Get-Setting -Key AzureStackLocation
$azureAdminArmEndpoint = Get-Setting -key ARMEndpoint

# Log into Azure admin context
Add-AzEnvironment -Name AzureSampleEnvironment -ARMEndpoint $azureAdminArmEndpoint
$username = $adminName
$password = $adminPassSecureString
$credential = [System.Management.Automation.PSCredential]::new($username, $password)
Connect-AzAccount -Environment AzureSampleEnvironment -Credential $credential -Tenant $azureTenantId

# Undocumented 16 character limit for application names for creating service principals.
$uniqueId = ($deploymentId -replace "-", "").Substring(0,6)
$azureAppSpName = "sampappsp${uniqueId}"
$azureCertSpName = "sampcertsp${uniqueId}"
$certName = "azureSampleCert"
$certPfxDir = [io.path]::combine($env:HOMEPATH, "cert")
$certPfxPath = [io.path]::combine($certPfxDir, "azSampleCert.pfx")

if (!(Test-Path $certPfxDir))
{
    New-Item -ItemType "directory" -Path $certPfxDir -Force
}

if (!$ExistingServicePrincipalDetails)
{
    if ($adfs)
    {
        $azureAppSpInfo = New-AzureAppSp -ApplicationName $azureAppSpName -AzureAdminCredential $credential
        $azureCertSpInfo = New-AzureCertSp -ApplicationName $azureCertSpName `
            -CertificateName $certName `
            -AzureAdminCredential $credential `
            -CertPfxOutputPath $certPfxPath `
            -CertPfxPassword $SecureCertPfxPassword
    }
    else 
    {
        $azureAppSpInfo = New-AzureAppSp -ServicePrincipalName $azureAppSpName
        $azureCertSpInfo = New-AzureCertSp -ServicePrincipalName $azureCertSpName `
            -CertificateName $certName `
            -CertPfxOutputPath $certPfxPath `
            -CertPfxPassword $SecureCertPfxPassword
    }
}
else
{
    . $ExistingServicePrincipalDetails
}

$appSpSecret = ConvertTo-SecureString $azureAppSpInfo["ClientSecret"]
$appSpBSTR = [System.Runtime.InteropServices.Marshal]::SecureStringToBSTR($appSpSecret)
$certPassBSTR = [System.Runtime.InteropServices.Marshal]::SecureStringToBSTR($SecureCertPfxPassword)
$certPfxPassword = [System.Runtime.InteropServices.Marshal]::PtrToStringAuto($certPassBSTR)

# Warning: the following code does not work on unix systems as of 5/28/2021 because [System.Environment]::SetEnvironmentVariable is unimplemented for unix.
[System.Environment]::SetEnvironmentVariable('AZURE_TENANT_ID', $azureTenantId, [System.EnvironmentVariableTarget]::Machine)

# Service principal application details
[System.Environment]::SetEnvironmentVariable('AZURE_SP_APP_CLIENT_ID', $azureAppSpInfo["ClientId"], [System.EnvironmentVariableTarget]::Machine)
[System.Environment]::SetEnvironmentVariable('AZURE_SP_APP_SECRET', [System.Runtime.InteropServices.Marshal]::PtrToStringAuto($appSpBSTR), [System.EnvironmentVariableTarget]::Machine)
[System.Environment]::SetEnvironmentVariable('AZURE_SP_APP_OBJECT_ID', $azureAppSpInfo["ObjectId"], [System.EnvironmentVariableTarget]::Machine)

# Service principal certificate details
[System.Environment]::SetEnvironmentVariable('AZURE_SP_CERT_CLIENT_ID', $azureCertSpInfo["ClientId"], [System.EnvironmentVariableTarget]::Machine)
[System.Environment]::SetEnvironmentVariable('AZURE_SP_CERT_THUMBPRINT', $azureCertSpInfo["CertificateThumbprint"], [System.EnvironmentVariableTarget]::Machine)
[System.Environment]::SetEnvironmentVariable('AZURE_SP_CERT_OBJECT_ID', $azureCertSpInfo["ObjectId"], [System.EnvironmentVariableTarget]::Machine)
[System.Environment]::SetEnvironmentVariable('AZURE_SP_CERT_PATH', $certPfxPath, [System.EnvironmentVariableTarget]::Machine)
[System.Environment]::SetEnvironmentVariable('AZURE_SP_CERT_PASS', $certPfxPassword, [System.EnvironmentVariableTarget]::Machine)

[System.Environment]::SetEnvironmentVariable('AZURE_SUBSCRIPTION_ID', $AzureSubscriptionId, [System.EnvironmentVariableTarget]::Machine)
[System.Environment]::SetEnvironmentVariable('AZURE_ARM_ENDPOINT', $azureAdminArmEndpoint, [System.EnvironmentVariableTarget]::Machine)
[System.Environment]::SetEnvironmentVariable('AZURE_LOCATION', $azureLocation, [System.EnvironmentVariableTarget]::Machine)

######################
# SDK SPECIFIC SETUP
######################

switch ($env:PROCESSOR_ARCHITECTURE) 
{
    "AMD64" { $architecture = "x64" }
    "x86" { $architecture = "x86" }
    default { throw "PowerShell package for OS architecture '$_' is not supported." }
}

$logFolder = $([io.path]::combine($env:HOMEPATH, "AzureSampleLogs"))
If (-not (Test-Path -Path $logFolder))
{
    New-Item $logFolder -Type Directory -ErrorAction Stop
}

if ($NodeJS)
{
    # Install NodeJS
    $nodeJSVersion = "v14.17.0"
    $nodeJSDownloadURL = "https://nodejs.org/dist/${nodeJSVersion}/node-${nodeJSVersion}-${architecture}.msi"
    $nodeJSInstallLogFilePath = Join-Path -Path $logFolder -ChildPath "nodejsInstall.log"
    Install-SoftwareFromURL -DownloadURL $nodeJSDownloadURL `
        -RegistryDisplayNameLike "Node.js" `
        -InstallLogFilePath $nodeJSInstallLogFilePath `
        -ForceInstall

    # Set up Azure Stack local certificate for NodeJS.
    $certFolder = [System.IO.Path]::Combine($env:HOMEPATH, "certs")
    if (!(Test-Path -Path $certFolder))
    {
        New-Item -ItemType "directory" -Path $certFolder
    }

    New-NodeJSEnvPem -PemFolder $certFolder
}

if ($Golang)
{
    # Install Golang
    # To get the latest Golang version use:
    #     $wc = New-Object System.Net.WebClient
    #     [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
    #     $latestVersion = $wc.DownloadString("https://golang.org/VERSION?m=text")
    # WARNING: Golang updates usually have breaking changes, becareful when updating.
    $golangVersion = "go1.15.8"
    $downloadFileName = "${golangVersion}.windows-amd64.msi"
    $golangDownloadURL = "https://golang.org/dl/${downloadFileName}"
    $GoSDKInstallLogFilePath = Join-Path -Path $logFolder -ChildPath "goInstall.log"
    Install-SoftwareFromURL -DownloadURL $golangDownloadURL `
        -RegistryDisplayNameLike "Go Programming Language*" `
        -InstallLogFilePath $GoSDKInstallLogFilePath `
        -ForceInstall

}