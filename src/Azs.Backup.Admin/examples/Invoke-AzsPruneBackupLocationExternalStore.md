### Example 1: Prune external store
```powershell
PS C:\> Invoke-AzsPruneBackupLocationExternalStore

masbackup/progressivebackup/garbage
```

Prune external store


### Example 2: Perform a dry run that does not actually remove the garbage
```powershell
PS C:\> Invoke-AzsPruneBackupLocationExternalStore -OperationType DryRun

masbackup/progressivebackup/garbage

```

Perform a dry run that does not actually remove the garbage