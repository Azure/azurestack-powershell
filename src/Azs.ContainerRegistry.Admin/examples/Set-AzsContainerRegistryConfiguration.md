### Example 1: Set Azs ContainerRegistry Configuration
```powershell
PS C:\> Set-AzsContainerRegistryConfiguration -MaximumCapacityInGib 30 -ConfigurationName default | ConvertTo-Json

{
    "Id":  "/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Admin/locations/redmond/configurations/Default",
    "MaximumCapacityInGiB":  30,
    "Name":  "redmond/Default",
    "Type":  "Microsoft.ContainerRegistry.Admin/locations/configurations"
}
```

Configure container registry overall configuration properties.

