### Example 1: Get Azs ContainerRegistry Capacity
```powershell
PS C:\> Get-AzsContainerRegistryCapacity | ConvertTo-Json

{
    "AllowPush":  true,
    "Id":  "/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Admin/locations/redmond/capacities/Default",
    "MaximumCapacityInGiB":  2000,
    "Name":  "redmond/Default",
    "RegistriesConsumptionInGiB":  0,
    "Type":  "Microsoft.ContainerRegistry.Admin/locations/capacities"
}
```

Returns container registry capacity property.

