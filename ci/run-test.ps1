param
(
    [ValidateSet("cli", "dotnet", "golang", "java", "javascript", "powershell", "python")]
    [String] $Type,
    [Parameter(Mandatory=$true)]
    [string]$EnvironmentName,
    [Parameter(Mandatory=$true)]
    [string]$ResourceManagerUrl,
    [Parameter(Mandatory=$true)]
    # The tenant name, e.g., for aka.ms/azsbellevue Azure Stack environment, the name is "masselfhost.onmicrosoft.com".
    # You can get the tenant name with:
    # (Get-AzEnvironment -Name "bellevue-aad-admin").ActiveDirectoryServiceEndpointResourceId.split("/")[2].split(".", 2)[1]
    [string]$TenantName,
    [Parameter(Mandatory=$true)]
    [string]$ServicePrincipalClientId,
    [Parameter(Mandatory=$true)]
    [System.Security.SecureString]$ServicePrincipalClientSecret,
    [Parameter(Mandatory=$false)]
    [ValidateNotNullOrEmpty()]
    [string] $SubscriptionName = "Default Provider Subscription"
)

switch ($Type)
{
    "cli"
    {
        Write-Host "TODO: ${Type} SDK tests are not implemented, it will be added in the future."
        break
    }
    "dotnet"
    {
        Write-Host "TODO: ${Type} SDK tests are not implemented, it will be added in the future."
        break
    }
    "golang"
    {
        Write-Host "TODO: ${Type} SDK tests are not implemented, it will be added in the future."
        break
    }
    "java"
    {
        Write-Host "TODO: ${Type} SDK tests are not implemented, it will be added in the future."
        break
    }
    "javascript"
    {
        Write-Host "TODO: ${Type} SDK tests are not implemented, it will be added in the future."
        break
    }
    "powershell"
    {
        $pesterVersion = "5.2.1"
        Install-Module -Name Pester -RequiredVersion $pesterVersion -Force
        Import-Module -Name Pester -RequiredVersion $pesterVersion
        $powerShellTestFile = [io.path]::combine("${PSScriptRoot}", "tests", "powershell", "powershell.tests.ps1")
        $container = New-PesterContainer -Path $powerShellTestFile -Data @{ 
            EnvironmentName = $EnvironmentName;
            ResourceManagerUrl = $ResourceManagerUrl;
            TenantName = $TenantName;
            ServicePrincipalClientId = $ServicePrincipalClientId;
            ServicePrincipalClientSecret = $ServicePrincipalClientSecret;
            SubscriptionName = $SubscriptionName;
        }
        Invoke-Pester -Container $container -Output Detailed
        break
    }
    "python"
    {
        Write-Host "TODO: ${Type} SDK tests are not implemented, it will be added in the future."
        break
    }
    default
    {
        throw "Invalid test type ${Type}, no test will be run."
    }
}