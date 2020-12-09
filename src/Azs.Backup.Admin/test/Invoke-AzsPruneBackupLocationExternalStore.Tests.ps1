. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-AzsPruneBackupLocationExternalStore.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-AzsPruneBackupLocationExternalStore' {
    It 'TestPrune' -Skip:$('TestPrune' -in $global:SkippedTests) {
        $global:TestName = 'TestPrune'

        $res = Invoke-AzsPruneBackupLocationExternalStore -OperationType DryRun
        $res | Should Not Be $null
        $res[0] | Should Be "masbackup/progressivebackup/BackupEncryptionCert.pfx"

        $res = Invoke-AzsPruneBackupLocationExternalStore
        $res | Should Not Be $null
        $res[0] | Should Be "masbackup/progressivebackup/BackupEncryptionCert.pfx"

        $res = Invoke-AzsPruneBackupLocationExternalStore
        $res | Should Be $null
    }
}
