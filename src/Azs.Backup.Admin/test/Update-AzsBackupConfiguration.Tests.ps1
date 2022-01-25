. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Update-AzsBackupConfiguration.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Update-AzsBackupConfiguration' {
    . $PSScriptRoot\Common.ps1

    AfterEach {
        $global:Client = $null
    }

    It "TestUpdateFileshareBackupLocationExpanded" -Skip:$('TestUpdateFileshareBackupLocationExpanded' -in $global:SkippedTests) {
        $global:TestName = 'TestUpdateFileshareBackupLocationExpanded'

        try
        {
            [System.IO.File]::WriteAllBytes($global:encryptionCertPath, [System.Convert]::FromBase64String($global:encryptionCertBase64))
            $location = Update-AzsBackupConfiguration -Username $global:username -Password $global:password -Path $global:path -EncryptionCertPath $global:encryptionCertPath -IsBackupSchedulerEnabled:$global:isBackupSchedulerEnabled -BackupFrequencyInHours $global:backupFrequencyInHours -BackupRetentionPeriodInDays $global:backupRetentionPeriodInDays
            ValidateBackupLocation -BackupLocation $location

            $location                             | Should Not Be $Null
            $location.Path                        | Should Be $global:path
            $location.Username                    | Should be $global:username
            $location.Password                    | Should -BeNullOrEmpty
            $location.BlobStorageUrl              | Should -BeNullOrEmpty
            $location.BlobStorageKey              | Should -BeNullOrEmpty
            $location.EncryptionCertBase64        | Should -BeNullOrEmpty
            $location.IsBackupSchedulerEnabled    | Should be $global:isBackupSchedulerEnabled
            $location.BackupFrequencyInHours      | Should be $global:backupFrequencyInHours
            $location.BackupRetentionPeriodInDays | Should be $global:backupRetentionPeriodInDays
        }
        finally
        {
            if (Test-Path -Path $global:encryptionCertPath -PathType Leaf)
            {
                Remove-Item -Path $global:encryptionCertPath -Force -ErrorAction Continue
            }
        }
    }

    It "TestUpdateBlobBackupLocationExpanded" -Skip:$('TestUpdateBlobBackupLocationExpanded' -in $global:SkippedTests) {
        $global:TestName = 'TestUpdateBlobBackupLocationExpanded'

        try
        {
            [System.IO.File]::WriteAllBytes($global:encryptionCertPath, [System.Convert]::FromBase64String($global:encryptionCertBase64))
            $location = Update-AzsBackupConfiguration -BlobStorageUrl $global:blobStorageUrl -BlobStorageKey $global:blobStorageKey -EncryptionCertPath $global:encryptionCertPath -IsBackupSchedulerEnabled:$global:isBackupSchedulerEnabled -BackupFrequencyInHours $global:backupFrequencyInHours -BackupRetentionPeriodInDays $global:backupRetentionPeriodInDays
            ValidateBackupLocation -BackupLocation $location

            $location                             | Should Not Be $Null
            $location.Path                        | Should -BeNullOrEmpty
            $location.Username                    | Should -BeNullOrEmpty
            $location.Password                    | Should -BeNullOrEmpty
            $location.BlobStorageUrl              | Should Be $global:blobStorageUrl
            $location.BlobStorageKey              | Should -BeNullOrEmpty
            $location.EncryptionCertBase64        | Should -BeNullOrEmpty
            $location.IsBackupSchedulerEnabled    | Should be $global:isBackupSchedulerEnabled
            $location.BackupFrequencyInHours      | Should be $global:backupFrequencyInHours
            $location.BackupRetentionPeriodInDays | Should be $global:backupRetentionPeriodInDays
        }
        finally
        {
            if (Test-Path -Path $global:encryptionCertPath -PathType Leaf)
            {
                Remove-Item -Path $global:encryptionCertPath -Force -ErrorAction Continue
            }
        }
    }

    It "TestPatchUpdateBlobBackupLocationExpanded" -Skip:$('TestPatchUpdateBlobBackupLocationExpanded' -in $global:SkippedTests) {
        $global:TestName = 'TestPatchUpdateBlobBackupLocationExpanded'

        try
        {
            [System.IO.File]::WriteAllBytes($global:encryptionCertPath, [System.Convert]::FromBase64String($global:encryptionCertBase64))
            $location = Update-AzsBackupConfiguration -BlobStorageUrl $global:blobStorageUrl -BackupRetentionPeriodInDays ($global:backupRetentionPeriodInDays - 1)
            ValidateBackupLocation -BackupLocation $location

            $location                             | Should Not Be $Null
            $location.Path                        | Should -BeNullOrEmpty
            $location.Username                    | Should -BeNullOrEmpty
            $location.Password                    | Should -BeNullOrEmpty
            $location.BlobStorageUrl              | Should Be $global:blobStorageUrl
            $location.BlobStorageKey              | Should -BeNullOrEmpty
            $location.EncryptionCertBase64        | Should -BeNullOrEmpty
            $location.IsBackupSchedulerEnabled    | Should be $global:isBackupSchedulerEnabled
            $location.BackupFrequencyInHours      | Should be $global:backupFrequencyInHours
            $location.BackupRetentionPeriodInDays | Should be ($global:backupRetentionPeriodInDays - 1)
        }
        finally
        {
            if (Test-Path -Path $global:encryptionCertPath -PathType Leaf)
            {
                Remove-Item -Path $global:encryptionCertPath -Force -ErrorAction Continue
            }
        }
    }

    It "TestUpdateFileshareBackupLocation" -Skip:$('TestUpdateFileshareBackupLocation' -in $global:SkippedTests) {
        $global:TestName = 'TestUpdateFileshareBackupLocation'

        try
        {
            [System.IO.File]::WriteAllBytes($global:encryptionCertPath, [System.Convert]::FromBase64String($global:encryptionCertBase64))
            $location = Get-AzsBackupConfiguration
            $location.UserName = $global:username
            $location.Password = $global:passwordStr
            $location.Path = $global:path
            $location.BlobStorageUrl = $null
            $location.BlobStorageKey = $null
            $location.EncryptionCertBase64 = $global:encryptionCertBase64
            $location.IsBackupSchedulerEnabled = $global:isBackupSchedulerEnabled
            $location.BackupFrequencyInHours = $global:backupFrequencyInHours
            $location.BackupRetentionPeriodInDays = $global:backupRetentionPeriodInDays
            $result = $location | Update-AzsBackupConfiguration
            ValidateBackupLocation -BackupLocation $result

            $result                             | Should Not Be $Null
            $result.Path                        | Should Be $global:path
            $result.Username                    | Should be $global:username
            $result.Password                    | Should -BeNullOrEmpty
            $result.BlobStorageUrl              | Should -BeNullOrEmpty
            $result.BlobStorageKey              | Should -BeNullOrEmpty
            $result.EncryptionCertBase64        | Should -BeNullOrEmpty
            $result.IsBackupSchedulerEnabled    | Should be $global:isBackupSchedulerEnabled
            $result.BackupFrequencyInHours      | Should be $global:backupFrequencyInHours
            $result.BackupRetentionPeriodInDays | Should be $global:backupRetentionPeriodInDays
        }
        finally
        {
            if (Test-Path -Path $global:encryptionCertPath -PathType Leaf)
            {
                Remove-Item -Path $global:encryptionCertPath -Force -ErrorAction Continue
            }
        }
    }

    It "TestUpdateBlobBackupLocation" -Skip:$('TestUpdateBlobBackupLocation' -in $global:SkippedTests) {
        $global:TestName = 'TestUpdateBlobBackupLocation'

        try
        {
            [System.IO.File]::WriteAllBytes($global:encryptionCertPath, [System.Convert]::FromBase64String($global:encryptionCertBase64))
            $location = Get-AzsBackupConfiguration
            $location.Path = $null
            $location.Username = $null
            $location.Password = $null
            $location.BlobStorageUrl = $global:blobStorageUrl
            $location.BlobStorageKey = $global:blobStorageKey
            $location.EncryptionCertBase64 = $global:encryptionCertBase64
            $location.IsBackupSchedulerEnabled = $global:isBackupSchedulerEnabled
            $location.BackupFrequencyInHours = $global:backupFrequencyInHours
            $location.BackupRetentionPeriodInDays = $global:backupRetentionPeriodInDays
            $result = $location | Update-AzsBackupConfiguration
            ValidateBackupLocation -BackupLocation $result

            $result                             | Should Not Be $Null
            $result.Path                        | Should -BeNullOrEmpty
            $result.Username                    | Should -BeNullOrEmpty
            $result.Password                    | Should -BeNullOrEmpty
            $result.BlobStorageUrl              | Should Be $global:blobStorageUrl
            $result.BlobStorageKey              | Should -BeNullOrEmpty
            $result.EncryptionCertBase64        | Should -BeNullOrEmpty
            $result.IsBackupSchedulerEnabled    | Should be $global:isBackupSchedulerEnabled
            $result.BackupFrequencyInHours      | Should be $global:backupFrequencyInHours
            $result.BackupRetentionPeriodInDays | Should be $global:backupRetentionPeriodInDays
        }
        finally
        {
            if (Test-Path -Path $global:encryptionCertPath -PathType Leaf)
            {
                Remove-Item -Path $global:encryptionCertPath -Force -ErrorAction Continue
            }
        }
    }

}
