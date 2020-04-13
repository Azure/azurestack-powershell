### Example 1: Default Get
```powershell
PS C:\> Get-AzsNetworkAdminOverview

BackendIPUsageInUseResourceCount          : 40
BackendIPUsageTotalResourceCount          : 282
Id                                        : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/providers/Microsoft.Network.Admin/adminOverview/
LoadBalancerMuxHealthErrorResourceCount   : 0
LoadBalancerMuxHealthHealthyResourceCount : 2
LoadBalancerMuxHealthTotalResourceCount   : 2
LoadBalancerMuxHealthUnknownCount         : 0
LoadBalancerMuxHealthWarningResourceCount : 0
Location                                  : 
MacAddressUsageInUseResourceCount         : 95
MacAddressUsageTotalResourceCount         : 4063232
Name                                      : 
ProvisioningState                         : Succeeded
PublicIPAddressUsageInUseResourceCount    : 65
PublicIPAddressUsageTotalResourceCount    : 1023
Tag                                       : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
Type                                      : Microsoft.Network.Admin/adminOverview
VirtualGatewayHealthErrorResourceCount    : 0
VirtualGatewayHealthHealthyResourceCount  : 2
VirtualGatewayHealthTotalResourceCount    : 3
VirtualGatewayHealthUnknownCount          : 1
VirtualGatewayHealthWarningResourceCount  : 0
VirtualNetworkHealthErrorResourceCount    : 0
VirtualNetworkHealthHealthyResourceCount  : 0
VirtualNetworkHealthTotalResourceCount    : 31
VirtualNetworkHealthUnknownCount          : 31
VirtualNetworkHealthWarningResourceCount  : 0
```

Returns an overview of Network Admin.

### Example 2: Get a specific value
```powershell
PS C:\> (Get-AzsNetworkAdminOverview).BackendIPUsageTotalResourceCount

282
```

Returns the total resource count of the backend IPs.

