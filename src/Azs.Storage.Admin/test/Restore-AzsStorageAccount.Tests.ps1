. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Restore-AzsStorageAccount.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Restore-AzsStorageAccount' {

    . $PSScriptRoot\Common.ps1
    
    It "TestRestoreStorageAccount" -Skip:$('TestRestoreStorageAccount' -in $global:SkippedTests) {
        $global:TestName = 'TestRestoreStorageAccount'

        $storageAccounts = Get-AzsStorageAccount 
        { Restore-AzsStorageAccount  -Name $storageAccounts[0].Name -Force } | Should Not Throw
    }
}
