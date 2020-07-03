# Sample script to execute a set of basic tests using the Admin and User Az modules aganist provided AzureStack Environment 
# First setup Azure PowerShell context by running Initialize-AzurePowerShellEnvironment.ps1
[CmdletBinding()]
param (
)

[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12 

function Log([System.Object] $param)
{
    Write-Verbose -Message "$([datetime]::UtcNow.ToString("o")): $($param | Out-String)" -Verbose
}

function Setup 
{
  Log -param "START: $($MyInvocation.MyCommand)"

  $context = Get-AzContext

  if(-not $context)
  {
    $msg = "First setup AzureStack context by running Initialize-AzurePowerShellEnvironment.ps1" 
    Log -param $msg
    Write-Error -Message $msg
  }
  
  Log -param "Subscription List:"
  Get-AzSubscription

  Log -param "END: $($MyInvocation.MyCommand)"
}

function Get-ArmEndpoint
{
    $context = Get-AzContext
    $ARMEndpoint = $context.Environment.ResourceManagerUrl
    return $ARMEndpoint
}

function Test-AdminModules()
{
    Log -param "START: $($MyInvocation.MyCommand)"
    $ARMEndpoint = Get-ArmEndpoint
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
    $ErrorActionPreference = 'Stop'
    Setup
    Test-AdminModules
    Test-UserModules
}

Main