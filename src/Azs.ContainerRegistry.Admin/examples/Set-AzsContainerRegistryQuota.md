### Example 1: Set Azs ContainerRegistry Quota
```powershell
PS C:\> Set-AzsContainerRegistryQuota -QuotaName testquota -CapacityPerRegistryInGib 30 -NumberOfRegistry 30

{
    "CapacityPerRegistryInGiB":  30,
    "Id":  "/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Admin/locations/redmond/quotas/testquota",
    "Name":  "redmond/testquota",
    "NumberOfRegistry":  30,
    "Type":  "Microsoft.ContainerRegistry.Admin/locations/quotas"
}
```

Update an existing container registry quota.

