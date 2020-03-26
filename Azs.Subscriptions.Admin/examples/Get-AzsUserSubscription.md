### Example 1
```powershell
PS C:\> Get-AzsUserSubscription | Select-Object -First 1 | fl *

DelegatedProviderSubscriptionId : d77ed1d7-cb62-4658-a777-386a8ae523dd
DisplayName                     : DRPTestffbffbe5-test-test-test-test-test-test
ExternalReferenceId             : 
Id                              : /subscriptions/d77ed1d7-cb62-4658-a777-386a8ae523dd/providers/Microsoft.Subscriptions.Admin/subscriptions/ffbffbe5-8905-4f51-b2ed-4717049de782
OfferId                         : /subscriptions/d77ed1d7-cb62-4658-a777-386a8ae523dd/resourceGroups/DRPTestResourceGroup5056/providers/Microsoft.Subscriptions.Admin/offers/DRPTestOffer5056
Owner                           : user@microsoft.com
RoutingResourceManagerType      : Default
State                           : Enabled
SubscriptionId                  : ffbffbe5-8905-4f51-b2ed-4717049de782
TenantId                        : 76440dfb-c97c-4fee-8f6c-dff8ddbe816f
```

Get the list of user subscriptions as operator.