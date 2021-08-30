### Example 1: Disable a Tenant Subscription Feature
```powershell
PS C:\> Disable-AzsComputeUserSubscriptionFeature -TenantSubscriptionId 4d105157-d6b2-42db-a3a3-56da6674183a -FeatureName Microsoft.Compute.EmergencyVMAccess -Location local
```

A successful call to disable a feature for a tenant's subscription will not return any output

