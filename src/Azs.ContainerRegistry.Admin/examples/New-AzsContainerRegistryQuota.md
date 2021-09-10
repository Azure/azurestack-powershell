### Example 1: New Azs ContainerRegistry Quota
```powershell
PS C:\> New-AzsContainerRegistryQuota -QuotaName testquota -CapacityPerRegistryInGib 20 -NumberOfRegistry 20 | ConvertTo-Json

{
    "CapacityPerRegistryInGiB":  20,
    "Id":  "/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Admin/locations/redmond/quotas/testquota",
    "Name":  "redmond/testquota",
    "NumberOfRegistry":  20,
    "Type":  "Microsoft.ContainerRegistry.Admin/locations/quotas"
}
```

Create or update an existing container registry quota.

