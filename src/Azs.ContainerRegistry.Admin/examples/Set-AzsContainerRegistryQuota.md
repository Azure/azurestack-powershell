### Example 1: Set Azs ContainerRegistry Quota
```powershell
PS C:\> Set-AzsContainerRegistryQuota -QuotaName testquota -CapacityPerRegistryInGib 30 -NumberOfRegistries 30 | ConvertTo-Json

{
    "CapacityPerRegistryInGiB":  30,
    "Id":  "/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Admin/locations/redmond/quotas/testquota",
    "Name":  "redmond/testquota",
    "NumberOfRegistries":  30,
    "Type":  "Microsoft.ContainerRegistry.Admin/locations/quotas"
}
```

Update an existing container registry quota.

