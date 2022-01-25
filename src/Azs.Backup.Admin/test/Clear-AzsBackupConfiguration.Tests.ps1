. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Clear-AzsBackupConfiguration.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Clear-AzsBackupConfiguration' {
    . $PSScriptRoot\Common.ps1

    AfterEach {
        $global:Client = $null
    }

    It "TestClearBackupLocation" -Skip:$('TestClearBackupLocation' -in $global:SkippedTests) {
        $global:TestName = 'TestClearBackupLocation'

        $location = Clear-AzsBackupConfiguration
        ValidateBackupLocation -BackupLocation $location

        $location                             | Should Not Be $Null
        $location.Path                        | Should -BeNullOrEmpty
        $location.Username                    | Should -BeNullOrEmpty
        $location.Password                    | Should -BeNullOrEmpty
        $location.BlobStorageKey              | Should -BeNullOrEmpty
        $location.BlobStorageUrl              | Should -BeNullOrEmpty
        $location.EncryptionCertBase64        | Should -BeNullOrEmpty
        $location.IsBackupSchedulerEnabled    | Should -BeNullOrEmpty
        $location.BackupFrequencyInHours      | Should be $global:backupFrequencyInHoursDefaultValue
        $location.BackupRetentionPeriodInDays | Should be $global:backupRetentionPeriodInDaysDefaultValue
    }
}
