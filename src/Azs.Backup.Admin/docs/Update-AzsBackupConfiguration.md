---
external help file:
Module Name: Azs.Backup.Admin
online version: https://docs.microsoft.com/en-us/powershell/module/azs.backup.admin/update-azsbackupconfiguration
schema: 2.0.0
---

# Update-AzsBackupConfiguration

## SYNOPSIS
Patch update a backup location.

## SYNTAX

### UpdateFileshareViaIdentityExpanded (Default)
```
Update-AzsBackupConfiguration [-InputObject <IBackupAdminIdentity>] [-Location <String>]
 [-BackupFrequencyInHours <Int32>] [-BackupRetentionPeriodInDays <Int32>] [-EncryptionCertPath <String>]
 [-IsBackupSchedulerEnabled] [-Password <SecureString>] [-Path <String>] [-Tag <Hashtable>]
 [-UserName <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-AzsBackupConfiguration -Backup <IBackupLocation> [-Location <String>] [-ResourceGroupName <String>]
 [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateBlobExpanded
```
Update-AzsBackupConfiguration [-Location <String>] [-ResourceGroupName <String>] [-SubscriptionId <String>]
 [-BackupFrequencyInHours <Int32>] [-BackupRetentionPeriodInDays <Int32>] [-BlobStorageKey <String>]
 [-BlobStorageUrl <String>] [-EncryptionCertPath <String>] [-IsBackupSchedulerEnabled] [-Tag <Hashtable>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateBlobViaIdentityExpanded
```
Update-AzsBackupConfiguration [-InputObject <IBackupAdminIdentity>] [-Location <String>]
 [-BackupFrequencyInHours <Int32>] [-BackupRetentionPeriodInDays <Int32>] [-BlobStorageKey <String>]
 [-BlobStorageUrl <String>] [-EncryptionCertPath <String>] [-IsBackupSchedulerEnabled] [-Tag <Hashtable>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateFileshareExpanded
```
Update-AzsBackupConfiguration [-Location <String>] [-ResourceGroupName <String>] [-SubscriptionId <String>]
 [-BackupFrequencyInHours <Int32>] [-BackupRetentionPeriodInDays <Int32>] [-EncryptionCertPath <String>]
 [-IsBackupSchedulerEnabled] [-Password <SecureString>] [-Path <String>] [-Tag <Hashtable>]
 [-UserName <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-AzsBackupConfiguration -InputObject <IBackupAdminIdentity> -Backup <IBackupLocation>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Patch update a backup location.

## EXAMPLES

### Example 1: Update backup configuration which uses fileshare as backup location
```powershell
PS C:\> Update-AzsBackupConfiguration -Path "\\***.***.***.***\Share" -Username "asdomain1\azurestackadmin" -Password $password  -EncryptionCertPath $encryptionCertPath

```

Set Azure Stack backup configuration to use fileshare as backup location.

### Example 2: Update backup configuration which uses blob as backup location
```powershell
PS C:\> Update-AzsBackupConfiguration -BlobStorageUrl $blobStorageUrl -BlobStorageKey $blobStorageKey -EncryptionCertPath $encryptionCertPath

```

Set Azure Stack backup configuration to use blob storage as backup location.

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Backup
Information about the backup location.
To construct, see NOTES section for BACKUP properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20210901.IBackupLocation
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BackupFrequencyInHours
The interval, in hours, for the frequency that the scheduler takes a backup.

```yaml
Type: System.Int32
Parameter Sets: UpdateBlobExpanded, UpdateBlobViaIdentityExpanded, UpdateFileshareExpanded, UpdateFileshareViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BackupRetentionPeriodInDays
The retention period, in days, for backs in the storage location.

```yaml
Type: System.Int32
Parameter Sets: UpdateBlobExpanded, UpdateBlobViaIdentityExpanded, UpdateFileshareExpanded, UpdateFileshareViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlobStorageKey
Key to access the blob location.

```yaml
Type: System.String
Parameter Sets: UpdateBlobExpanded, UpdateBlobViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlobStorageUrl
Url to the update blob location

```yaml
Type: System.String
Parameter Sets: UpdateBlobExpanded, UpdateBlobViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EncryptionCertPath
Path to the encryption cert file with public key (.cer).

```yaml
Type: System.String
Parameter Sets: UpdateBlobExpanded, UpdateBlobViaIdentityExpanded, UpdateFileshareExpanded, UpdateFileshareViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.IBackupAdminIdentity
Parameter Sets: UpdateBlobViaIdentityExpanded, UpdateFileshareViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsBackupSchedulerEnabled
True if the backup scheduler is enabled.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateBlobExpanded, UpdateBlobViaIdentityExpanded, UpdateFileshareExpanded, UpdateFileshareViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
Name of the backup location.

```yaml
Type: System.String
Parameter Sets: Update, UpdateBlobExpanded, UpdateBlobViaIdentityExpanded, UpdateFileshareExpanded, UpdateFileshareViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzLocation)[0].Location
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Password
Password to access the fileshare location.

```yaml
Type: System.Security.SecureString
Parameter Sets: UpdateFileshareExpanded, UpdateFileshareViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Path
Path to the update fileshare location

```yaml
Type: System.String
Parameter Sets: UpdateFileshareExpanded, UpdateFileshareViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
Name of the resource group.

```yaml
Type: System.String
Parameter Sets: Update, UpdateBlobExpanded, UpdateFileshareExpanded
Aliases:

Required: False
Position: Named
Default value: "system.$((Get-AzLocation)[0].Location)"
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
Subscription credentials that uniquely identify Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: Update, UpdateBlobExpanded, UpdateFileshareExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
List of key value pairs.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateBlobExpanded, UpdateBlobViaIdentityExpanded, UpdateFileshareExpanded, UpdateFileshareViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserName
Username to access the fileshare location.

```yaml
Type: System.String
Parameter Sets: UpdateFileshareExpanded, UpdateFileshareViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20210901.IBackupLocation

### Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.IBackupAdminIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20210901.IBackupLocation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BACKUP <IBackupLocation>: Information about the backup location.
  - `[Location <String>]`: Location of the resource.
  - `[Tag <IResourceTags>]`: List of key value pairs.
    - `[(Any) <String>]`: This indicates any property can be added to this object.
  - `[BackupFrequencyInHours <Int32?>]`: The interval, in hours, for the frequency that the scheduler takes a backup.
  - `[BackupRetentionPeriodInDays <Int32?>]`: The retention period, in days, for backs in the storage location.
  - `[BlobStorageKey <String>]`: Key to access the blob location.
  - `[BlobStorageUrl <String>]`: Url to the update blob location
  - `[EncryptionCertBase64 <String>]`: The base64 raw data for the backup encryption certificate.
  - `[IsBackupSchedulerEnabled <Boolean?>]`: True if the backup scheduler is enabled.
  - `[Password <String>]`: Password to access the fileshare location.
  - `[Path <String>]`: Path to the update fileshare location
  - `[UserName <String>]`: Username to access the fileshare location.

INPUTOBJECT <IBackupAdminIdentity>: Identity Parameter
  - `[Backup <String>]`: Name of the backup.
  - `[Id <String>]`: Resource identity path
  - `[Location <String>]`: Name of the backup location.
  - `[ResourceGroupName <String>]`: Name of the resource group.
  - `[SubscriptionId <String>]`: Subscription credentials that uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.

## RELATED LINKS

