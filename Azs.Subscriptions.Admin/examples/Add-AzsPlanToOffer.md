### Example 1
```powershell
PS C:\> Add-AzsPlanToOffer -OfferName ascantenantoffer65 -ResourceGroupName ascansubscrrg65 -PlanLinkType Base -MaxAcquisitionCount 22 -PlanName ascantenantplan65

AddonPlans                 : {}
BasePlanIds                : {/subscriptions/e5c36693-ebfd-4860-b227-7763ebebbc27/resourceGroups/ascansubscrrg65/provid
                             ers/Microsoft.Subscriptions.Admin/plans/ascantenantplan65}
Description                :
DisplayName                : ascantenantoffer65
ExternalReferenceId        :
Id                         : /subscriptions/e5c36693-ebfd-4860-b227-7763ebebbc27/resourceGroups/ascansubscrrg65/provide
                             rs/Microsoft.Subscriptions.Admin/offers/ascantenantoffer65
Location                   : local
MaxSubscriptionsPerAccount : 0
Name                       : ascantenantoffer65
PropertiesName             : ascantenantoffer65
State                      : Public
SubscriptionCount          : 0
Tags                       : Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ResourceTags
Type                       : Microsoft.Subscriptions.Admin/offers
```

Links a plan to an offer.