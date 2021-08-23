### Example 1: Get AzsContainerRegistry Configuration
```powershell
PS C:\> Get-AzsContainerRegistryConfiguration

{{
    "Id":  "/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Admin/locations/redmond/configurations/Default",
    "MaximumCapacityInGiB":  2000,
    "Name":  "redmond/Default",
    "Type":  "Microsoft.ContainerRegistry.Admin/locations/configurations"
}
```

Returns the specified configuration details.


