### Example 1: Default Delete
```powershell
PS C:\> Remove-AzsNetworkQuota -Name NetworkQuota1


```

Remove a network quota by name.

### Example 2: Create new Quota with parameters
```powershell
PS C:\> Get-AzsNetworkQuota -Name NetworkQuota1 | Remove-AzsNetworkQuota


```

Remove a network quota using a pipe.
