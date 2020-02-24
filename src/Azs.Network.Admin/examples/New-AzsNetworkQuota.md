### Example 1: Default New
```powershell
PS C:\> New-AzsNetworkQuota -Name NetworkQuotaDefaultValues

Id                                                 : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/providers/Microsoft.Network.Admin/locations/northwest/quotas/Net
                                                     workQuotaDefaultValues
Location                                           : northwest
MaxLoadBalancersPerSubscription                    : 50
MaxNicsPerSubscription                             : 100
MaxPublicIpsPerSubscription                        : 50
MaxSecurityGroupsPerSubscription                   : 50
MaxVirtualNetworkGatewayConnectionsPerSubscription : 2
MaxVirtualNetworkGatewaysPerSubscription           : 1
MaxVnetsPerSubscription                            : 50
MigrationPhase                                     : None
Name                                               : northwest/NetworkQuotaDefaultValues
ProvisioningState                                  : Succeeded
Tag                                                : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
Type                                               : Microsoft.Network.Admin/quotas
```

Create a new network quota with all the default values. Returns the created object's values.

### Example 2: Create new Quota with parameters
```powershell
PS C:\> New-AzsNetworkQuota -Name NetworkQuota1 -MaxNicsPerSubscription 150 -MaxPublicIpsPerSubscription 150

Id                                                 : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/providers/Microsoft.Network.Admin/locations/northwest/quotas/Net
                                                     workQuota1
Location                                           : northwest
MaxLoadBalancersPerSubscription                    : 50
MaxNicsPerSubscription                             : 150
MaxPublicIpsPerSubscription                        : 150
MaxSecurityGroupsPerSubscription                   : 50
MaxVirtualNetworkGatewayConnectionsPerSubscription : 2
MaxVirtualNetworkGatewaysPerSubscription           : 1
MaxVnetsPerSubscription                            : 50
MigrationPhase                                     : None
Name                                               : northwest/NetworkQuota1
ProvisioningState                                  : Succeeded
Tag                                                : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
Type                                               : Microsoft.Network.Admin/quotas
```

Create a new network quota with non default values for quota.
