### Example 1:
```powershell
PS C:\> Get-AzsStorageAccount -Summary
```

Get a list of storage accounts (summary).

### Example 2:
```powershell
PS C:\> $storageAccount = Get-AzsStorageAccount
PS C:\> $storageAccount | Select Location,Name,AccountStatus,HealthState,Kind | ft
```

Get a list of storage account with details and print the status.

### Example 3:
```powershell
PS C:\> Get-AzsStorageAccount -Name 32cbc1173bde4e5fad04e11cc4cb2e00 | fl *
```

Get details of the specified storage account.
