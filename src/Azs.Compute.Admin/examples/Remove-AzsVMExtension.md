### Example 1: Remove a VM Extension that Exists 
```powershell
PS C:\> Remove-AzsVMExtension -Location local -Publisher Microsoft -Type MicroExtension -Version 0.1.0
```

A successful call to remove a compute quota will not return any output

### Example 2: Remove a VM Extension that Does Not Exist
```powershell
PS C:\> Remove-AzsVMExtension -Location local -Publisher Microsoft -Type DoesntExist -Version 9.8.7
```

A successful call to remove a platform image that doesn't exist will not return any output

