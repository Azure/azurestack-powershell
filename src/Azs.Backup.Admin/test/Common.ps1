$global:SkippedTests = @(
)

$global:Provider = "Microsoft.Backup.Admin"
$global:username = "AzureStackAdmin"
$global:passwordStr = "password"
[SecureString]$global:password = ConvertTo-SecureString -String $global:passwordStr -AsPlainText -Force
$global:path = "\\su1fileserver\SU1_Infrastructure_1\BackupStore"
$global:blobStorageUrl = "https://pazsbcdrblobstore.blob.core.windows.net/211030-n42r1609-83cbfd32"
$global:blobStorageKey = "hJW2t+LDs2JuF2uw=="
$global:encryptionCertBase64 = "MIIDKcd3D3GOyBw=="
$global:encryptionCertPath = "$env:temp\encryptionCert.cer"
$global:isBackupSchedulerEnabled = $false
$global:backupFrequencyInHours = 10
$global:backupRetentionPeriodInDays = 6
$global:backupFrequencyInHoursDefaultValue = 12
$global:backupRetentionPeriodInDaysDefaultValue = 7
$global:decryptionCertBase64 = "MIIKqnlG/YCAgfQ"
$global:decryptionCertPath = "$env:temp\decryptionCert.pfx"
$global:decryptionCertPassword = ConvertTo-SecureString -String "decryptionCertPassword" -AsPlainText -Force

function ValidateBackup {
    param(
        [Parameter(Mandatory = $true)]
        $Backup
    )

    $Backup             | Should Not Be $null
    # Resource
    $Backup.Id          | Should Not Be $null
    $Backup.Name        | Should Not Be $null
    $Backup.Type        | Should Not Be $null
    # Subscriber Usage Aggregate
    $Backup.RoleStatus          | Should Not Be $null
    $Backup.CreatedDateTime     | Should Not Be $null
    $Backup.Status              | Should Not Be $null
    $Backup.TimeTakenToCreate   | Should Not Be $null
}

function AssertBackupsAreEqual {
    param(
        [Parameter(Mandatory = $true)]
        $expected,
        [Parameter(Mandatory = $true)]
        $found
    )

    # Resource
    if ($null -eq $expected) {
        $found                                    | Should Be $null
    }
    else {
        $found                                    | Should Not Be $null
        # Validate Farm properties
        $expected.Id                              | Should Be $found.Id
        $expected.Type                            | Should Be $found.Type
        $expected.Name                            | Should Be $found.Name
        $expected.CreatedDateTime                 | Should Be $found.CreatedDateTime
        $expected.Status                          | Should Be $found.Status
        $expected.TimeTakenToCreate               | Should Be $found.TimeTakenToCreate
    }
}

function ValidateBackupLocation {
    param(
        [Parameter(Mandatory = $true)]
        $BackupLocation
    )

    $BackupLocation          | Should Not Be $null
    # Resource
    $BackupLocation.Id          | Should Not Be $null
    $BackupLocation.Name        | Should Not Be $null
    $BackupLocation.Type        | Should Not Be $null
    $BackupLocation.Location    | Should Not Be $null
    # Subscriber Usage Aggregate
    $BackupLocation.Password                 | Should -BeNullOrEmpty
    $BackupLocation.EncryptionCertBase64     | Should -BeNullOrEmpty
}

function AssertBackupLocationsAreEqual {
    param(
        [Parameter(Mandatory = $true)]
        $expected,
        [Parameter(Mandatory = $true)]
        $found
    )

    # Resource
    if ($null -eq $expected) {
        $found                                                    | Should Be $null
    }
    else {
        $found                                                    | Should Not Be $null
        # Validate Farm properties
        $expected.Id                              | Should Be $found.Id
        $expected.Type                            | Should Be $found.Type
        $expected.Name                            | Should Be $found.Name
        $expected.Location                        | Should Be $found.Location
        $expected.AvailableCapacity               | Should Be $found.AvailableCapacity
        $expected.BackupFrequencyInHours          | Should Be $found.BackupFrequencyInHours
        $expected.EncryptionCertBase64            | Should Be $found.EncryptionCertBase64
        $expected.IsBackupSchedulerEnabled        | Should Be $found.IsBackupSchedulerEnabled
        $expected.LastBackupTime                  | Should Be $found.LastBackupTime
        $expected.NextBackupTime                  | Should Be $found.NextBackupTime
        $expected.BackupRetentionPeriodInDays     | Should Be $found.BackupRetentionPeriodInDays
        $expected.Password                        | Should Be $found.Password
        $expected.Path                            | Should Be $found.Path
        $expected.UserName                        | Should Be $found.UserName
        $expected.BlobStorageKey                  | Should Be $found.BlobStorageKey
        $expected.BlobStorageUrl                  | Should Be $found.BlobStorageUrl
    }
}
