### Example 1: Set Properties on an Existing Compute Quota
```powershell
PS C:\> Set-AzsComputeQuota -Name AComputeQuota -AvailabilitySetCount 9 -CoresCount 99 -PremiumManagedDiskAndSnapshotSize 4096 -StandardManagedDiskAndSnapshotSize 4096


AvailabilitySetCount               : 9
CoresLimit                         : 99
Id                                 : /subscriptions/74c72bdc-d917-431c-a377-8ca80f4238a0/providers/Microsoft.Compute.Ad
                                     min/locations/northwest/quotas/AComputeQuota
Location                           : northwest
Name                               : AComputeQuota
PremiumManagedDiskAndSnapshotSize  : 4096
StandardManagedDiskAndSnapshotSize : 4096
Type                               : Microsoft.Compute.Admin/quotas
VMScaleSetCount                    : 0
VirtualMachineCount                : 0
```

Set the parameters specified on the command line. Any parameters not set will default to 0

### Example 2: Set Properties on a Compute Quota that Does Not Exist
```powershell
PS C:\> Set-AzsComputeQuota -Name AComputeQuotaThatDoesNotExist2 -AvailabilitySetCount 9 -CoresCount 99 -PremiumManagedDiskAndSnapshotSize 4096 -StandardManagedDiskAndSnapshotSize 4096


AvailabilitySetCount               : 9
CoresLimit                         : 99
Id                                 : /subscriptions/74c72bdc-d917-431c-a377-8ca80f4238a0/providers/Microsoft.Compute.Ad
                                     min/locations/northwest/quotas/AComputeQuotaThatDoesNotExist2
Location                           : northwest
Name                               : AComputeQuotaThatDoesNotExist2
PremiumManagedDiskAndSnapshotSize  : 4096
StandardManagedDiskAndSnapshotSize : 4096
Type                               : Microsoft.Compute.Admin/quotas
VMScaleSetCount                    : 0
VirtualMachineCount                : 0
```

Calling `Set-AzsComputeQuota` on a compute Quota that does not exist creates a new Compute Quota with the specified parameters. Any parameters that are not given a value will default to 0. 

