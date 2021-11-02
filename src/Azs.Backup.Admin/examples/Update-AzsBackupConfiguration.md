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

