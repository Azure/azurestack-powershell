### Example 1: Get list of managed clusters
```powershell
PS C:\> Get-AzsContainerService -Location "redmond" | ConvertTo-Json
[
  {
    "CreationDate": "2021-08-24T21:33:46Z",
    "Id": "/subscriptions/f9712d12-aa4d-4d37-8f46-fabf3c07c836/providers/Microsoft.ContainerService.Admin/locations/redmond/managedclusters/testaksux",
    "Location": "redmond",
    "Name": "redmond/testaksux",
    "OrchestratorVersion": "1.19.11",
    "PropertiesId": "/subscriptions/16661f04-6eca-4ccb-acef-3624fc128005/resourcegroups/testaksuxrg/providers/Microsoft.ContainerService/managedClusters/testaksux",
    "PropertiesName": "testaksux",
    "ProvisioningState": "Succeeded",
    "SubscriptionId": "16661f04-6eca-4ccb-acef-3624fc128005",
    "Type": "Microsoft.ContainerService.Admin/locations/managedclusters"
  },
  {
    "CreationDate": "2021-08-25T20:02:38Z",
    "Id": "/subscriptions/f9712d12-aa4d-4d37-8f46-fabf3c07c836/providers/Microsoft.ContainerService.Admin/locations/redmond/managedclusters/testaksaddon",
    "Location": "redmond",
    "Name": "redmond/testaksaddon",
    "OrchestratorVersion": "1.19.11",
    "PropertiesId": "/subscriptions/a174daa5-4b9c-4745-8d80-ca8a6c1e2279/resourcegroups/testaksaddonrg/providers/Microsoft.ContainerService/managedClusters/testaksaddon",
    "PropertiesName": "testaksaddon",
    "ProvisioningState": "Succeeded",
    "SubscriptionId": "a174daa5-4b9c-4745-8d80-ca8a6c1e2279",
    "Type": "Microsoft.ContainerService.Admin/locations/managedclusters"
  }
]
```

Returns a list of all tenant container service clusters
