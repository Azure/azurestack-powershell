---
external help file:
Module Name: Azs.Network.Admin
online version: https://docs.microsoft.com/en-us/powershell/module/azs.network.admin/get-azsvirtualnetwork
schema: 2.0.0
---

# Get-AzsVirtualNetwork

## SYNOPSIS
Get a list of all virtual networks.

## SYNTAX

```
Get-AzsVirtualNetwork [-SubscriptionId <String[]>] [-Filter <String>] [-InlineCount <String>]
 [-OrderBy <String>] [-Skip <String>] [-Top <String>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Get a list of all virtual networks.

## EXAMPLES

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

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
OData filter parameter.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InlineCount
OData inline count parameter.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OrderBy
OData orderBy parameter.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
OData skip parameter.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
Subscription credentials which uniquely identify Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
OData top parameter.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetwork

## NOTES

ALIASES

## RELATED LINKS

