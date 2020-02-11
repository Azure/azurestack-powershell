### Example 1: Get by location
```powershell
PS C:\> Get-AzsNetworkQuota -Location northwest

Id                                                 : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/providers/Microsoft.Network.Admin/locations/northwest/quotas/Def
                                                     ault Quota
Location                                           : northwest
MaxLoadBalancersPerSubscription                    : 50
MaxNicsPerSubscription                             : 100
MaxPublicIpsPerSubscription                        : 50
MaxSecurityGroupsPerSubscription                   : 50
MaxVirtualNetworkGatewayConnectionsPerSubscription : 2
MaxVirtualNetworkGatewaysPerSubscription           : 1
MaxVnetsPerSubscription                            : 50
MigrationPhase                                     : None
Name                                               : northwest/Default Quota
ProvisioningState                                  : Succeeded
Tag                                                : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
Type                                               : Microsoft.Network.Admin/quotas

Id                                                 : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/providers/Microsoft.Network.Admin/locations/northwest/quotas/Vaa
                                                     SSDKTestNetworkQuota
Location                                           : northwest
MaxLoadBalancersPerSubscription                    : 50
MaxNicsPerSubscription                             : 100
MaxPublicIpsPerSubscription                        : 50
MaxSecurityGroupsPerSubscription                   : 50
MaxVirtualNetworkGatewayConnectionsPerSubscription : 2
MaxVirtualNetworkGatewaysPerSubscription           : 1
MaxVnetsPerSubscription                            : 50
MigrationPhase                                     : None
Name                                               : northwest/VaaSSDKTestNetworkQuota
ProvisioningState                                  : Succeeded
Tag                                                : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
Type                                               : Microsoft.Network.Admin/quotas
```

Returns all of the network quotas in northwest.

### Example 2: Get by location and name
```powershell
PS C:\> Get-AzsNetworkQuota -Location northwest -Name VaaSSDKTestNetworkQuota

Id                                                 : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/providers/Microsoft.Network.Admin/locations/northwest/quotas/Vaa
                                                     SSDKTestNetworkQuota
Location                                           : northwest
MaxLoadBalancersPerSubscription                    : 50
MaxNicsPerSubscription                             : 100
MaxPublicIpsPerSubscription                        : 50
MaxSecurityGroupsPerSubscription                   : 50
MaxVirtualNetworkGatewayConnectionsPerSubscription : 2
MaxVirtualNetworkGatewaysPerSubscription           : 1
MaxVnetsPerSubscription                            : 50
MigrationPhase                                     : None
Name                                               : northwest/VaaSSDKTestNetworkQuota
ProvisioningState                                  : Succeeded
Tag                                                : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
Type                                               : Microsoft.Network.Admin/quotas
```

Returns network quotas in the northwest that are named VaaSSDKTestNetworkQuota.
