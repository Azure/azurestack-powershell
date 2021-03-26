### Example 1
```powershell
PS C:\> Set-AzsOfferDelegation -OfferName "testof" -ResourceGroupName "testrgp" -Name "testofd" -TargetSubscriptionId "a7aa1685-566a-4d85-8a74-1b9db1b321c1"


Id             : /subscriptions/209523fa-09a8-4642-93df-58496efe1ca2/resourceGroups/testrgp/providers/Microsoft.Subscriptions.Admin/offers/testof/offerDelegations/testo
                 fd
Location       : local
Name           : testof/testofd
SubscriptionId : a7aa1685-566a-4d85-8a74-1b9db1b321c1
Tags           : Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ResourceTags
Type           : Microsoft.Subscriptions.Admin/offers/offerDelegations
```

Updates the offer delegation.