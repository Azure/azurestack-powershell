# Release 3.0.0
* Requires AzureStack Update 2203+
* Breaking changes in Azs.Backup.Admin module
## Azs.Backup.Admin module 
* Adds support for configuring backup location as blob storage
* Removes Set-AzsBackupconfiguration and newly supports Update\Clear-AzsBackupConfiguration
* Update-AzsBackupConfiguration - either updates a part of the backup location configuration or sets it as a whole
    * Migration examples
        * Set backup location configuration as a whole
            * Old usage
            ```
            $location = Set-AzsBackupConfiguration -Username $username -Password $password -Path $path -EncryptionCertPath $encryptionCertPath -IsBackupSchedulerEnabled:$isBackupSchedulerEnabled -BackupFrequencyInHours $backupFrequencyInHours -BackupRetentionPeriodInDays $backupRetentionPeriodInDays
            ```
            * New usage
            ```
            $location = Update-AzsBackupConfiguration -Username $username -Password $password -Path $path -EncryptionCertPath $encryptionCertPath -IsBackupSchedulerEnabled:$isBackupSchedulerEnabled -BackupFrequencyInHours $backupFrequencyInHours -BackupRetentionPeriodInDays $backupRetentionPeriodInDays

            $location = Update-AzsBackupConfiguration -BlobStorageUrl $blobStorageUrl -BlobStorageKey $blobStorageKey -EncryptionCertPath $encryptionCertPath -IsBackupSchedulerEnabled:$isBackupSchedulerEnabled -BackupFrequencyInHours $backupFrequencyInHours -BackupRetentionPeriodInDays $backupRetentionPeriodInDays
            ```
        * Update a part of the backup location configuration
            * Old usage
            ```
            $location = Set-AzsBackupConfiguration -Path $path -BackupRetentionPeriodInDays $backupRetentionPeriodInDays
            ```
            * New usage
            ```
            $location = Update-AzsBackupConfiguration -Path $path -BackupRetentionPeriodInDays $backupRetentionPeriodInDays

            $location = Update-AzsBackupConfiguration -BlobStorageUrl $blobStorageUrl -BackupRetentionPeriodInDays $backupRetentionPeriodInDays
            ```
* Clear-AzsBackupConfiguration - clears the backup location configuration
    * Usage
    ```
    $location = Clear-AzsBackupConfiguration
    ```





# Release 2.2.0
* Requires AzureStack Update 2108+
## Azs.ContainerService.Admin module 
* AzureStack AKS admin powershell commands to manage Container service admin operations
## Azs.ContainerRegistry.Admin module
* AzureStack Container Registry admin power shell commands to setup and manage Container Registry admin operations
## Azs.Compute.Admin module
* Added support for GPU Quotas (DDA and Partitioned GPU VM sizes) to limit tenant usage
    * Affected cmdlets - Get\Set\New\Remove-AzsComputeQuota
* Added support for globally enabling/disabling or locally enabling/disabling features for tenant subscription IDs.
    * Affected cmdlets - Enable\Disable-AzsComputeUserSubscriptionFeature, Get-AzsComputeFeature, Update-AzsComputeGlobalFeatureSetting 
* Get-AzsDisk - adds support for viewing managed disk creation source of returned objects in Get-AzsDisk.
* Get-AzsDisk - adds support for querying the exclusive allocated size of a managed disk with Get-AzsDisk -DiskSizeDetail, AzureStack operator can use this size to estimate the space to be freed after migrating the specific disk.

## All Modules
* All the operator modules are updated for Az.Resources dependency. Az.Resources module version is updated to 0.12.0

# Release 2.1.1
* AzureStack operator module GA version 2.1.1
* Bug fix release for signing a script file
* Bug fix in Az.BootStraper module to update the cache https://github.com/Azure/azurestack-powershell/issues/103

# Release 2.1.0-preview
* Requires AzureStack Update 2102+
* AzureStack operator module GA version 2.1.0, coming out of preview
* AzureStack Operator module version 2.1.0. Requires AzureStack Hub Update 2102+,
* There are no breaking changes from the previous release 2.0.2-preview
* Compatible with AzureStack specific Az module version 1.10.0
* The individual Azs.* module versions are updated to 1.0.0, marking GA
* Fabric Admin module adds support for changing the default Gpu partition on a GPU enabled Azure Stack hub with Set-AzsScaleUnit -NumberOfGPUPartition X

# Release 2.0.2-preview
* Bug fix for the existing 2.0.1-preview release
* Included fix for the issue - https://github.com/Azure/azurestack-powershell/issues/23

# Release 2.0.1-preview
* Minor update to the existing 2.0.0-preview release
* Included fix for the issue - https://github.com/Azure/azurestack-powershell/issues/14

# Release 2.0.0-preview
* AzureStack module generated with [autorest powershell generator](https://github.com/Azure/autorest.powershell)
* This version is compatible with [Az](https://www.powershellgallery.com/packages/Az/0.10.0-preview) modules for AzureStack
* The module is supported on AzureStack versions with Update 2002 and the hotfix

