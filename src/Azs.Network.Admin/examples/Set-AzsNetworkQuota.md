### Example 1: Default Set
```powershell
PS C:\> Set-AzsNetworkQuota -Name MyQuota

Id                                                 : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/providers/Microsoft.Network.Admin/location
                                                     s/northwest/quotas/MyQuota
Location                                           : northwest
MaxLoadBalancersPerSubscription                    : 0
MaxNicsPerSubscription                             : 0
MaxPublicIpsPerSubscription                        : 0
MaxSecurityGroupsPerSubscription                   : 0
MaxVirtualNetworkGatewayConnectionsPerSubscription : 0
MaxVirtualNetworkGatewaysPerSubscription           : 0
MaxVnetsPerSubscription                            : 0
MigrationPhase                                     : None
Name                                               : northwest/MyQuota
ProvisioningState                                  : Succeeded
Tag                                                : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
Type                                               : Microsoft.Network.Admin/quotas
```

Returns MyQuota with default values of 0.

### Example 2: Set default value for MaxLoadBalancersPerSubscription
```powershell
PS C:\> Set-AzsNetworkQuota -Name MyQuota -MaxLoadBalancersPerSubscription 20

Id                                                 : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/providers/Microsoft.Network.Admin/location
                                                     s/northwest/quotas/MyQuota
Location                                           : northwest
MaxLoadBalancersPerSubscription                    : 20
MaxNicsPerSubscription                             : 0
MaxPublicIpsPerSubscription                        : 0
MaxSecurityGroupsPerSubscription                   : 0
MaxVirtualNetworkGatewayConnectionsPerSubscription : 0
MaxVirtualNetworkGatewaysPerSubscription           : 0
MaxVnetsPerSubscription                            : 0
MigrationPhase                                     : None
Name                                               : northwest/MyQuota
ProvisioningState                                  : Succeeded
Tag                                                : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
Type                                               : Microsoft.Network.Admin/quotas
```

Returns MyQuota with the values specified in the parameters.
