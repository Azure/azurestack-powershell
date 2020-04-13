### Example 1: Default Get
```powershell
PS C:\> Get-AzsLoadBalancer

Id                : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/resourceGroups/AppServiceLH01/providers/Microsoft.Network/loadBalancers/aps-sql-lb
Location          : 
Name              : aps-sql-lb
ProvisioningState : Succeeded
PublicIPAddress   : {}
SubscriptionId    : 3ff3b1de-e7f5-43ad-b057-ace4767e7d01
Tag               : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/resourceGroups/AppServiceLH01/providers/Microsoft.Network/loadBalancers/aps-sql-lb
Type              : Microsoft.Network.Admin/adminLoadBalancers

Id                : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/resourceGroups/AppServiceLH01/providers/Microsoft.Network/loadBalancers/FrontEndServersLoadBalanc
                    er
Location          : 
Name              : FrontEndServersLoadBalancer
ProvisioningState : Succeeded
PublicIPAddress   : {100.81.128.40}
SubscriptionId    : 3ff3b1de-e7f5-43ad-b057-ace4767e7d01
Tag               : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/resourceGroups/AppServiceLH01/providers/Microsoft.Network/loadBalancers/FrontEndServersLoadBalanc
                    er
Type              : Microsoft.Network.Admin/adminLoadBalancers
```

Returns all of the virtual networks.
