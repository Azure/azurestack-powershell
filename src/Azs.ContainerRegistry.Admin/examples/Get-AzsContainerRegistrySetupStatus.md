### Example 1: Get Azs ContainerRegistry Setup Status
```powershell
PS C:\> (Get-AzsContainerRegistrySetupStatus).ToJsonString() 

{
  "id": "/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Setup/locations/redmond/setup/value",
  "name": "redmond/value",
  "type": "Microsoft.ContainerRegistry.Setup/locations/setup",
  "properties": {
    "status": "Completed"
  }
}
```

Returns the status of the container registry setup.

