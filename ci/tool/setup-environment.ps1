# This script installs tools required for the Azure Stack SDK tests.

Import-Module $PSScriptRoot\..\common.psm1

switch ($env:PROCESSOR_ARCHITECTURE) 
{
    "AMD64" { $architecture = "x64" }
    "x86" { $architecture = "x86" }
    default { throw "PowerShell package for OS architecture '$_' is not supported." }
}

$logFolder = "${env:SystemDrive}\azs-sdk-tests\logs\install"
If (-not (Test-Path -Path $logFolder))
{
    New-Item $logFolder -Type Directory -ErrorAction Stop
}

####################
# INSTALL GIT CLI
####################
# Git CLI is used for Go language tests.
# Git CLI also installs OpenSSL, which is required for Python and JavaScript AZSDKTOOLSCTQ and can be found here: C:\Program Files\Git\usr\bin\openssl.exe
$architectureNumber = $architecture.Substring(1,2)
$gitCLIVersion = "2.31.1"
$gitCLIDownloadURL = "https://github.com/git-for-windows/git/releases/download/v${gitCLIVersion}.windows.1/Git-${gitCLIVersion}-${architectureNumber}-bit.exe"
$gitInstallLogFilePath = Join-Path -Path $logFolder -ChildPath "gitInstall.log"
Install-SoftwareFromURL -DownloadURL $gitCLIDownloadURL `
    -RegistryDisplayNameLike "git*" `
    -InstallLogFilePath $gitInstallLogFilePath

####################
# INSTALL PSCORE
####################
# PowerShell Core is required for the PowerShellCore tests.
$psCoreVersion = "7.1.3"
$psCoreDownloadURL = "https://github.com/PowerShell/PowerShell/releases/download/v${psCoreVersion}/PowerShell-${psCoreVersion}-win-${architecture}.msi"
$psCoreInstallLogFilePath = Join-Path -Path $logFolder -ChildPath "pscoreInstall.log"
Install-SoftwareFromURL -DownloadURL $psCoreDownloadURL `
    -RegistryDisplayNameLike "Powershell 7*" `
    -InstallLogFilePath $psCoreInstallLogFilePath `
    -ForceInstall