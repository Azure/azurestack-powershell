### Example 1: Get List Azs ContainerRegistry Quotas
```powershell
PS C:\> Get-AzsContainerRegistryQuota | ConvertTo-Json

[
    {
        "CapacityPerRegistryInGiB":  20,
        "Id":  "/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Admin/locations/redmond/quotas/Default quota",
        "Name":  "redmond/Default quota",
        "NumberOfRegistry":  20,
        "Type":  "Microsoft.ContainerRegistry.Admin/locations/quotas"
    },
    {
        "CapacityPerRegistryInGiB":  30,
        "Id":  "/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Admin/locations/redmond/quotas/testquota",
        "Name":  "redmond/testquota",
        "NumberOfRegistry":  30,
        "Type":  "Microsoft.ContainerRegistry.Admin/locations/quotas"
    }
]
```

Returns a list of container registry quotas at the given location.

### Example 2: Get Azs ContainerRegistry Quota by Name
```powershell
PS C:\> Get-AzsContainerRegistryQuota -Name "Default quota" | ConvertTo-Json

{
    "CapacityPerRegistryInGiB":  20,
    "Id":  "/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Admin/locations/redmond/quotas/Default quota",
    "Name":  "redmond/Default quota",
    "NumberOfRegistry":  20,
    "Type":  "Microsoft.ContainerRegistry.Admin/locations/quotas"
}
```

Returns the specified container registry quota.

