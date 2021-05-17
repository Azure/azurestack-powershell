<#
    Run this script before setting up the agent.
#>

. $PSScriptRoot/common.ps1

Install-Module -Name PowerShellGet -RequiredVersion 2.2.5 -Force
Import-Module -Name PowerShellGet -RequiredVersion 2.2.5

##############################################
# Set-up local Azure Stack modules directory
##############################################
if (!(Test-Path -Path "$($env:SystemDrive)\azs-modules"))
{
    New-Item -Path "$($env:SystemDrive)\" -Name "azs-modules" -ItemType "directory"
}
if (Get-PSRepository | Where-Object {$_.Name -eq "azs-modules"})
{
    Unregister-PSRepository -Name "azs-modules"
}

$azsModulesFolder = "$($env:SystemDrive)\azs-modules"
$azsModulesUrl = "https://azsdevtoolstest.blob.core.windows.net/psrepo/azs-modules.zip"
$ZipFile = "$azsModulesFolder\$(Split-Path -Path $azsModulesUrl -Leaf)"
Write-Host "Downloading ${azsModulesUrl}."
Invoke-WebRequest -Uri $azsModulesUrl -OutFile $ZipFile 
Write-Host "Expanding ${ZipFile}."
Expand-Archive -LiteralPath $ZipFile -DestinationPath $azsModulesFolder -Force -PassThru
Write-Host "Removing ${ZipFile}."
Remove-Item -Path $ZipFile

##############################################
# Set-up Azure Stack PowerShell repository
##############################################
$parameters = @{
  Name = "azs-modules"
  SourceLocation = $azsModulesFolder
  PublishLocation = $azsModulesFolder
  InstallationPolicy = 'Trusted'
}

Register-PSRepository @parameters
Write-Host "Installing Az modules."
Install-Module Az -Repository "azs-modules"
Write-Host "Installing Azure Stack modules."
Install-Module AzureStack -Repository "azs-modules"