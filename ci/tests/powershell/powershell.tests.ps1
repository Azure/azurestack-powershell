# Pester test for Azure Stack PowerShell modules.

param
(
    [Parameter(Mandatory=$true)]
    [ValidateNotNullOrEmpty()]
    [string] $EnvironmentName,

    [Parameter(Mandatory=$true)]
    [ValidateNotNull()]
    [ValidateScript({ $_.Scheme -eq [System.Uri]::UriSchemeHttps })]
    [System.Uri] $ResourceManagerUrl,

    [Parameter(Mandatory=$true)]
    [ValidateNotNullOrEmpty()]
    [string] $TenantName,

    [Parameter(Mandatory=$true)]
    [ValidateNotNull()]
    [string] $ServicePrincipalClientId,

    [Parameter(Mandatory=$true)]
    [ValidateNotNull()]
    [System.Security.SecureString] $ServicePrincipalClientSecret,

    # Optional subscription to select as the active / default subscription.
    [Parameter(Mandatory=$false)]
    [ValidateNotNullOrEmpty()]
    [string] $SubscriptionName
)

Import-Module $PSScriptRoot\..\..\common.psm1

Describe 'Test-PowerShell' {
    It "Test-AddAzEnvironment" {
        Write-Host "Checking to see if ${EnvironmentName} already exists."
        $getEnvironment = Get-AzEnvironment -Name $EnvironmentName
        if ($getEnvironment)
        {
            Write-Host "${EnvironmentName} already exists, removing it and creating a new one."
            Remove-AzEnvironment -Name $EnvironmentName | Out-Null
            Get-AzEnvironment -Name $EnvironmentName | Should -BeNullOrEmpty
        }
        Add-AzEnvironment -Name $EnvironmentName -ARMEndpoint $ResourceManagerUrl -ErrorAction Stop | Out-Null
        Get-AzEnvironment -Name $EnvironmentName | Should -Not -BeNullOrEmpty
        Write-Host "Successfully added environment ${EnvironmentName}."
        Write-Host "Environment details for ${EnvironmentName}:"
        Get-AzEnvironment -Name $EnvironmentName | Format-List -Property *
    }

    It "Test-ConnectServicePrincipal" {
        $servicePrincipalCredential = [pscredential]::new($ServicePrincipalClientId, $ServicePrincipalClientSecret)
            
        if ($null -eq $SubscriptionName)
        {
            Connect-AzAccount -Environment $EnvironmentName -ServicePrincipal -Credential $servicePrincipalCredential -Tenant $TenantName
        }
        else
        {
            Connect-AzAccount -Environment $EnvironmentName -ServicePrincipal -Credential $servicePrincipalCredential -Tenant $TenantName -Subscription $SubscriptionName
        }

        $checkExpression = "Get-AzContext"
        $azContext = Wait-IncrementsUntilTimeOut -CheckExpression $checkExpression -SleepSecondsUnit 20 -Negate
        $azContext | Should -Not -BeNullOrEmpty

        Write-Verbose -Message "Current context:" -Verbose
        Get-AzContext | Format-List -Property * | Out-String | Write-Verbose -Verbose
        Write-Verbose -Message "Current account:" -Verbose
        $(Get-AzContext).Account | Format-List -Property * | Out-String | Write-Verbose -Verbose
    }
}
