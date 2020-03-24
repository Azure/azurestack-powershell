### Example 1: Set Properties on an Existing Compute Quota
```powershell
PS C:\> $myComputeQuota = @{ `
Name = "MyComputeQuota"; `
Location = "northwest"; `
AvailabilitySetCount = 9; `
CoresLimit = 99; `
PremiumManagedDiskAndSnapshotSize = 4096; `
StandardManagedDiskAndSnapshotSize = 4096; `
VMScaleSetCount = 0; `
VirtualMachineCount = 99; `
}

PS C:\> Set-AzsComputeQuota -NewQuota $myComputeQuota

AvailabilitySetCount               : 9
CoresLimit                         : 99
Id                                 : /subscriptions/74c72bdc-d917-431c-a377-8ca80f4238a0/providers/Microsoft.Compute.Admin/locations/northwest/quotas/MyComputeQuota
Location                           : northwest
Name                               : MyComputeQuota
PremiumManagedDiskAndSnapshotSize  : 4096
StandardManagedDiskAndSnapshotSize : 4096
Type                               : Microsoft.Compute.Admin/quotas
VMScaleSetCount                    : 0
VirtualMachineCount                : 99
```
```

Set the parameters specified in the NewQuota hash set. Any parameters not set will default to 0