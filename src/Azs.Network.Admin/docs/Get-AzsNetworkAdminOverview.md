---
external help file:
Module Name: Azs.Network.Admin
online version: https://docs.microsoft.com/en-us/powershell/module/azs.network.admin/get-azsnetworkadminoverview
schema: 2.0.0
---

# Get-AzsNetworkAdminOverview

## SYNOPSIS
Get an overview of the state of the network resource provider.

## SYNTAX

### Get (Default)
```
Get-AzsNetworkAdminOverview [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzsNetworkAdminOverview -InputObject <INetworkAdminIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Get an overview of the state of the network resource provider.

## EXAMPLES

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.INetworkAdminIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SubscriptionId
Subscription credentials which uniquely identify Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String[]
Parameter Sets: Get
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.INetworkAdminIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverview

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <INetworkAdminIdentity>: Identity Parameter
  - `[Id <String>]`: Resource identity path
  - `[Location <String>]`: Location of the resource.
  - `[ResourceName <String>]`: Name of the resource.
  - `[SubscriptionId <String>]`: Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.

## RELATED LINKS

