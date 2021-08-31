### Example 1: Get Quota for Container Service
```powershell
PS C:\> Get-AzsContainerServiceQuota -Location "redmond" | ConvertTo-Json
{
  "Id": "/subscriptions/f9712d12-aa4d-4d37-8f46-fabf3c07c836/providers/Microsoft.ContainerService.Admin/locations/redmond/quotas/Unlimited",
  "Name": "redmond/Unlimited",
  "PropertiesName": "Unlimited",
  "Type": "Microsoft.ContainerService.Admin/locations/quotas"
}
