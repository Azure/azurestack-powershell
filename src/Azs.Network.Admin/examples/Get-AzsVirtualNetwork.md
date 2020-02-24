### Example 1: Default Get
```powershell
PS C:\> Get-AzsVirtualNetwork

ConfigurationStateHostError                    : {}
ConfigurationStateLastUpdatedTime              : 2/10/2020 11:44:06 PM
ConfigurationStateStatus                       : Success
ConfigurationStateVirtualNetworkInterfaceError : {}
Id                                             : /subscriptions/074e4440-77f1-422a-8622-0d146946698c/resourceGroups/vaasrg468c/providers/Microsoft.Network/virtualNetwork
                                                 s/vnetc4b363rprjk3q
Location                                       : 
Name                                           : vnetc4b363rprjk3q
ProvisioningState                              : Succeeded
SubscriptionId                                 : 074e4440-77f1-422a-8622-0d146946698c
Tag                                            : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri                              : /subscriptions/074e4440-77f1-422a-8622-0d146946698c/resourceGroups/vaasrg468c/providers/Microsoft.Network/virtualNetwork
                                                 s/vnetc4b363rprjk3q
Type                                           : Microsoft.Network.Admin/adminVirtualNetworks

ConfigurationStateHostError                    : {}
ConfigurationStateLastUpdatedTime              : 2/10/2020 11:44:07 PM
ConfigurationStateStatus                       : Success
ConfigurationStateVirtualNetworkInterfaceError : {}
Id                                             : /subscriptions/0c4ca7ea-4314-4940-a5dc-29886cfe7c42/resourceGroups/microsoft.iothubstaging/providers/Microsoft.Network/v
                                                 irtualNetworks/4wxzf2ukegiemvnet
Location                                       : 
Name                                           : 4wxzf2ukegiemvnet
ProvisioningState                              : Succeeded
SubscriptionId                                 : 0c4ca7ea-4314-4940-a5dc-29886cfe7c42
Tag                                            : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri                              : /subscriptions/0c4ca7ea-4314-4940-a5dc-29886cfe7c42/resourceGroups/microsoft.iothubstaging/providers/Microsoft.Network/v
                                                 irtualNetworks/4wxzf2ukegiemvnet
Type                                           : Microsoft.Network.Admin/adminVirtualNetworks
```

Returns all of the virtual networks.

### Example 2: Get by filtering
```powershell
PS C:\> Get-AzsVirtualNetwork -Filter "Name eq '4wxzf2ukegiemvnet'"

ConfigurationStateHostError                    : {}
ConfigurationStateLastUpdatedTime              : 2/10/2020 11:49:20 PM
ConfigurationStateStatus                       : Success
ConfigurationStateVirtualNetworkInterfaceError : {}
Id                                             : /subscriptions/0c4ca7ea-4314-4940-a5dc-29886cfe7c42/resourceGroups/microsoft.iothubstaging/providers/Microsoft.Network/v
                                                 irtualNetworks/4wxzf2ukegiemvnet
Location                                       : 
Name                                           : 4wxzf2ukegiemvnet
ProvisioningState                              : Succeeded
SubscriptionId                                 : 0c4ca7ea-4314-4940-a5dc-29886cfe7c42
Tag                                            : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri                              : /subscriptions/0c4ca7ea-4314-4940-a5dc-29886cfe7c42/resourceGroups/microsoft.iothubstaging/providers/Microsoft.Network/v
                                                 irtualNetworks/4wxzf2ukegiemvnet
Type                                           : Microsoft.Network.Admin/adminVirtualNetworks
```

Returns virtual networks that are named 4wxzf2ukegiemvnet.
