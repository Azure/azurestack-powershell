<#
.SYNOPSIS
   Validates signed files. Use this code for manual validation of a folder of nupkg files.
.DESCRIPTION
   Recursively validates folder for signed files.
.NOTES
   Use this script to check files for valid signatures before release.
#>

param
(
    [Parameter(Mandatory=$true)]
    # $nupkgPath is the path to the folder of .nupkg files.
    [string] $nupkgPath,
    [string] $extractionPath=[System.IO.Path]::Combine($PSScriptRoot, "extracted")
)

###########
# EXTRACT
###########
$nupkgs = Get-ChildItem -Path $nupkgPath -Filter *.nupkg
$nupkgs | Out-String
if (Test-Path -Path $extractionPath -PathType Container)
{
    New-Item -Path $extractionPath -ItemType Directory
}

$nupkgs | ForEach-Object {Expand-Archive -Path $_.FullName -DestinationPath "${extractionPath}\$($_.BaseName)" -Force}
Write-Host -Message "Extracted nupkg modules to ${extractionPath}."

###########
# VALIDATE
###########
$exclude = @("Unprotect-SecureString.ps1")
$fileInfos = Get-ChildItem -Path $extractionPath -File -Recurse `
    | Where-Object { $_.Name -notin $exclude } `
    | Where-Object { $_.Extension -in @('.dll','.exe','.msi','.cab','.ps1','.psm1','.psd1','.pssc','.ps1xml') }

$filePaths = $fileInfos | ForEach-Object {$_.FullName}
Write-Host "Scanning files:`n"
$filePaths | Out-String

$authenticodeStatuses = $filePaths | Get-AuthenticodeSignature
Write-Host "Statuses of files in the folder ${extractionPath}:`n"
$authenticodeStatuses | Select-Object -Property Status, Path | Out-String -width 4096

$unsignedFiles = $authenticodeStatuses | Where-Object {$_.Status -eq [System.Management.Automation.SignatureStatus]::NotSigned}
$unsignedFilesFormatted = $unsignedFiles  | Select-Object -Property Status, Path | Out-String

if ($unsignedFiles)
{
    Write-Host "ERROR: These files in ${extractionPath} are unsigned:"
    $unsignedFilesFormatted | Out-String -width 4096
    throw "ERROR: The module contains unsigned files."
}