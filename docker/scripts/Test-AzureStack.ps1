# Execute a set of basic tests using the Admin and User Az modules aganist provided AzureStack Environment 
[CmdletBinding()]
param (
    [string]
    $ARMEndpoint = $ENV:ARMEndpoint,

    [string]
    $ClientId = $ENV:ClientId,

    [string]
    $ClientSecret = $ENV:ClientSecret,

    [string]
    $TenantId = $ENV:TenantId
)

[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12 

function Log([System.Object] $param)
{
    Write-Verbose -Message "$([datetime]::UtcNow.ToString("o")): $($param | Out-String)" -Verbose
}

function Setup 
{
  Log -param "START: $($MyInvocation.MyCommand)"

  Import-Module Az.Accounts
  Add-AzEnvironment -Name AzureStack -ARMEndpoint $ARMEndpoint
  $creds = New-Object pscredential($ClientId, (ConvertTo-SecureString -String $ClientSecret -AsPlainText -Force))
  Login-AzAccount -Environment AzureStack -Credential $creds -Tenant $TenantId -ServicePrincipal
  
  Log -param "Subscription List:"
  Get-AzSubscription

  Log -param "END: $($MyInvocation.MyCommand)"

}
function Test-AdminModules()
{
    Log -param "START: $($MyInvocation.MyCommand)"
    if($ARMEndpoint -ilike "https://adminmanagement.*")
    {
      Import-Module AzureStack
      Get-AzsUpdate
    }
    else 
    {
      Log -param "Test not applicable against Admin ARM"  
    }

    Log -param "END: $($MyInvocation.MyCommand)"
}

function Test-UserModules()
{
  Log -param "START: $($MyInvocation.MyCommand)"

  Import-Module Az.Resources
  Get-AzResourceGroup | Format-Table -AutoSize

  Log -param "END: $($MyInvocation.MyCommand)"
}

function Main()
{
  if($ARMEndpoint -and $ClientId -and $ClientSecret)
  {
    Setup
    Test-AdminModules
    Test-UserModules
  }
  else 
  {
    Log -param "Required env parameters: ARMEndpoint, ClientId, ClientSecret not provided."  
  }
}

Main