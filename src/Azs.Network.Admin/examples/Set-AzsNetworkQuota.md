### Example 1: Set value for MaxNicsPerSubscription using Quota parameter
```powershell
PS C:\> $quota = Get-AzsNetworkQuota -Name MyQuota

PS C:\> $quota.MaxNicsPerSubscription = 30

PS C:\> Set-AzsNetworkQuota -Quota $quota

Id                                                 : /subscriptions/39c82aed-b2b7-4a66-abdb-611de00bf11e/providers/Microsoft.Network.Admin/locations/northwest/quotas/MyQuota
Location                                           : northwest
MaxLoadBalancersPerSubscription                    : 50
MaxNicsPerSubscription                             : 30
MaxPublicIpsPerSubscription                        : 50
MaxSecurityGroupsPerSubscription                   : 50
MaxVirtualNetworkGatewayConnectionsPerSubscription : 2
MaxVirtualNetworkGatewaysPerSubscription           : 1
MaxVnetsPerSubscription                            : 50
MigrationPhase                                     : None
Name                                               : northwest/MyQuota
ProvisioningState                                  : Succeeded
Tag                                                : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
Type                                               : Microsoft.Network.Admin/quotas
```

Returns MyQuota with the MaxNicsPerSubscription changed to 30.

### Example 2: Set value for MaxNicsPerSubscription using a pipeline
```powershell
PS C:\> $quota = Get-AzsNetworkQuota -Name MyQuota

PS C:\> $quota.MaxNicsPerSubscription = 50

PS C:\> $quota | Set-AzsNetworkQuota

Id                                                 : /subscriptions/39c82aed-b2b7-4a66-abdb-611de00bf11e/providers/Microsoft.Network.Admin/locations/northwest/quotas/MyQuota
Location                                           : northwest
MaxLoadBalancersPerSubscription                    : 50
MaxNicsPerSubscription                             : 50
MaxPublicIpsPerSubscription                        : 50
MaxSecurityGroupsPerSubscription                   : 50
MaxVirtualNetworkGatewayConnectionsPerSubscription : 2
MaxVirtualNetworkGatewaysPerSubscription           : 1
MaxVnetsPerSubscription                            : 50
MigrationPhase                                     : None
Name                                               : northwest/MyQuota
ProvisioningState                                  : Succeeded
Tag                                                : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
Type                                               : Microsoft.Network.Admin/quotas
```

Pipelines the quota variable to change the MaxNicsPerSubscription to 50.
