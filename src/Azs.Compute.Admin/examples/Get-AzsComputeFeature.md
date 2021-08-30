### Example 1: Get a Feature
```powershell
PS C:\> Get-AzsComputeFeature -Location local -Name Microsoft.Compute.EmergencyVMAccess | ConvertTo-Json

{
    "EnabledTenantSubscriptionId":  [
                                        "e9f233f4-6251-441e-a8e4-5e0165a5ff84",
                                        "a6293671-ca91-4040-8edc-5a5bc8bb10f2",
                                        "77df6e8d-c86b-4184-a7da-35217afdb7e8",
                                        "078fcd45-e064-4f1b-a546-f2873757c7c0",
                                        "88e0ade6-f94a-4a75-8b32-b8f07daf2ad0",
                                        "22c12f96-7352-4165-a7e4-ccebd1257f15",
                                        "a40a4cdf-0054-4b41-8692-0c0de49958b5",
                                        "d23289dc-887a-4e68-8c84-8a0e4d8dec51",
                                        "3f843028-3d49-4ae9-8185-148745b4a231"
                                    ],
    "FeatureName":  "Microsoft.Compute.EmergencyVMAccess",
    "GlobalFeatureSettingGlobalFeatureState":  {

                                               },
    "Id":  "/subscriptions/52cc3943-24b0-45bc-8403-466ccf5775a3/providers/Microsoft.Compute.Admin/locations/local/features/Microsoft.Compute.EmergencyVMAccess",
    "Location":  "local",
    "Name":  "Microsoft.Compute.EmergencyVMAccess",
    "Type":  "Microsoft.Compute.Admin/locations/features"
}
```

Get a specific Feature.