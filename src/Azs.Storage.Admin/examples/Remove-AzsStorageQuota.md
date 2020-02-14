### Example 1:
```powershell
PS C:\> Remove-AzsStorageQuota -Name 'TestQuota' -Force
```

Remove a storage quota by name.

### Example 2:
```powershell
PS C:\> Get-AzsStorageQuota -Name 'TestQuota' | Remove-AzsStorageQuota
```

Remove a storage quota by piping.
