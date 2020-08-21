<#
.SYNOPSIS
   Validates signed files.
.DESCRIPTION
   Recursively validates folder for signed files.
.NOTES
   Use this script to check files for valid signatures before release.
#>

# Resolve -path
$path = Resolve-Path -Path "."
$moduleName = $path.Path.Split([IO.Path]::DirectorySeparatorChar)[-1]
Write-Verbose -Message "Current module: ${moduleName}" -Verbose
Write-Verbose -Message "Current folder: ${PSScriptRoot}" -Verbose

$contents = Get-ChildItem -Path $path
$output = $contents | ForEach-Object {$_.FullName} | Out-String
Write-Verbose -Message "${path} contents: `n${output}" -Verbose

################################# BEGIN EXTRACT NUPKG #################################

$nupkgFolder = Join-Path -Path $path -ChildPath 'bin'
$output = Get-ChildItem -Path $nupkgFolder | ForEach-Object {$_.FullName} | Out-String
Write-Verbose -Message "${nupkgFolder} contents: `n${output}" -Verbose
$pathToValidate = Join-Path -Path $nupkgFolder -ChildPath 'extracted'
$nupkgPath = Get-ChildItem -LiteralPath @($nupkgFolder) | Where-Object {$_.Extension -eq ".nupkg"}

if ($null -eq $nupkgPath)
{
    throw "ERROR: No NUPKG files were found."
}
if ($nupkgPath -is [array])
{
    throw "ERROR: More than one NUPKG file is detected in the ${$nupkgPath} folder."
}
if (!$pathToValidate)
{
    throw "ERROR: The path ${pathToValidate} is invalid."
}

Write-Verbose -Message "Extracting $($nupkgPath.FullName) to ${pathToValidate}." -Verbose
Expand-Archive -LiteralPath $nupkgPath.FullName -DestinationPath $pathToValidate
Write-Verbose -Message "Current path to check for unsigned files: ${pathToValidate}." -Verbose

################################# END EXTRACT NUPKG #################################

if (Test-Path -Path $pathToValidate -PathType Container)
{
    $fileInfos = Get-ChildItem -Path $pathToValidate -File -Recurse `
        | Where-Object { $_.Extension -iin @('.dll','.exe','.msi','.cab','.ps1','.psm1','.psd1','.pssc','.ps1xml') } `
        | Where-Object { $_.FullName -notlike $(Join-Path -Path "*${moduleName}" -ChildPath "test*") }
}
elseif (Test-Path -Path $pathToValidate -PathType Leaf)
{
    $fileInfos = Get-ChildItem -Path $pathToValidate -File
}
else
{
    Write-Error -Message "Invalid path: ${pathToValidate}" -Category InvalidArgument
}

$filePaths = $fileInfos | ForEach-Object {$_.FullName}
$output = $filePaths | Out-String
Write-Verbose -Message "Files to be checked: `n${output}" -Verbose

$authenticodeStatuses = $filePaths | Get-AuthenticodeSignature
Write-Verbose -Message "Statuses of files in the folder ${pathToValidate}:" -Verbose
$authenticodeStatuses | Select-Object -Property Status, Path | Out-String -width 4096

$unsignedFiles = $authenticodeStatuses | Where-Object {$_.Status -eq [System.Management.Automation.SignatureStatus]::NotSigned}
$unsignedFilesFormatted = $unsignedFiles  | Select-Object -Property Status, Path | Out-String

if ($unsignedFiles)
{
    Write-Verbose -Message "ERROR: These files in ${pathToValidate} are unsigned:" -Verbose
    $unsignedFilesFormatted | Out-String -width 4096
    throw "ERROR: The module contains unsigned files."
}

Remove-Item $pathToValidate -Recurse