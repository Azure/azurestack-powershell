### Example 1: Get List Azs Container Registries
```powershell
PS C:\> Get-AzsContainerRegistry | ConvertTo-Json

{
    "CreationDate":  "\/Date(1629160842681)\/",
    "Id":  "/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Admin/locations/redmond/registries/testregistry01",
    "Location":  "redmond",
    "Name":  "redmond/testregistry01",
    "PropertiesName":  "testregistry01",
    "RegistryId":  "/subscriptions/72b77b1b-3e43-4d00-8b5b-be6beceb7f3a/resourceGroups/acrtenanttestrg/providers/Microsoft.ContainerRegistry/registries/testregistry01",
    "RegistrySizeInByte":  3011,
    "ResourceGroup":  "acrtenanttestrg",
    "SubscriptionId":  "72b77b1b-3e43-4d00-8b5b-be6beceb7f3a",
    "Type":  "Microsoft.ContainerRegistry.Admin/locations/registries"
}
```

Returns a list of container registries present in all tenant location.