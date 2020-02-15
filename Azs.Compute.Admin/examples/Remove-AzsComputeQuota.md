### Example 1: Remove a Compute Quota
```powershell
PS C:\> Remove-AzsComputeQuota -Name "AComputeQuota"
```

A successful call to remove a compute quota will not return any output

### Example 2: Remove a Compute Quota That Does Not Exist
```powershell
PS C:\> Remove-AzsComputeQuota -Name "AComputeQuotaThatDoesNotExist"

NullReferenceException/Object reference not set to an instance of an object./   at Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.RestException..ctor(HttpResponseMessage response) in C:\repos\azure-powershell\src\StackAdmin\Azs.Compute.Admin\generated\runtime\UndeclaredResponseException.cs:line 40
Remove-AzsComputeQuota : The server responded with a Request Error, Status: NotFound
At line:1 char:1
+ Remove-AzsComputeQuota -Name "AComputeQuotaThatDoesNotExist"
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
+ CategoryInfo          : InvalidOperation: ({ SubscriptionI...tDoesNotExist }:<>f__AnonymousType3`3) [Remove-AzsComputeQuota_Delete], UndeclaredResponseException
+ FullyQualifiedErrorId : NotFound,Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Cmdlets.RemoveAzsComputeQuota_Delete
```

Removing a Compute Quota that doesn't exist will throw a `NotFound` Error
