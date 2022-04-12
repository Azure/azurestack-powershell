---
external help file:
Module Name: Azs.Network.Admin
online version: https://docs.microsoft.com/en-us/powershell/module/azs.network.admin/get-azsvirtualnetworkgatewayconnection
schema: 2.0.0
---

# Get-AzsVirtualNetworkGatewayConnection

## SYNOPSIS
Returns a list of all Virtual Network Gateway Connections.

## SYNTAX

```
Get-AzsVirtualNetworkGatewayConnection [-SubscriptionId <String[]>] [-Filter <String>] [-OrderBy <String>]
 [-Top <String>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Returns a list of all Virtual Network Gateway Connections.

## EXAMPLES

### Example 1: Default Get
```powershell
PS C:\> Get-AzSVirtualNetworkGatewayConnection | Format-List *

CapacityReserved               : 400
ConnectionErrorDetailedInfo    : 
ConnectionErrorLastUpdatedTime : 
ConnectionErrorStatus          : 
ConnectionStateActiveGateway   : n22r1602-Gwy01
ConnectionStateStatus          : Connected
Id                             : /subscriptions/dc5ecb41-8865-454a-995c-8a5bb6f322d2/resourceGroups/ExampleRG/providers/Microsoft.Network/connections/Tokyo-Hub-Conn
LocalNetworkGatewayIPAddress   : 10.10.54.52
LocalNetworkGatewayName        : TokyoLNG
Location                       : 
Name                           : Tokyo-Hub-Conn
ProvisioningState              : Succeeded
ResourceGroup                  : ExampleRG
Sku                            : HighPerformance
SubscriptionId                 : dc5ecb41-8865-454a-995c-8a5bb6f322d2
Tag                            : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TotalStampCapacity             : 4000
Type                           : Microsoft.Network.Admin/adminVirtualNetworkGatewayConnections
VirtualNetworkGatewayIPAddress : 100.74.96.130
VirtualNetworkGatewayName      : HubVNG
```

Returns a list of all Virtual Network Gateway Connections on the stamp.
To expand all properties, pipe the output into Format-List.

### Example 2: Use filters to Get specific connections
```powershell
PS C:\> Get-AzSVirtualNetworkGatewayConnection -Filter "Name eq 'Tokyo-Hub-Conn'" | Format-List *

CapacityReserved               : 400
ConnectionErrorDetailedInfo    : {Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20220201.VirtualNetworkGatewayConnectionConfigurationStateInfo}
ConnectionErrorLastUpdatedTime : 3/30/2022 4:32:29 PM
ConnectionErrorStatus          : Failure
ConnectionStateActiveGateway   : n22r1602-Gwy01
ConnectionStateStatus          : Disconnected
Id                             : /subscriptions/dc5ecb41-8865-454a-995c-8a5bb6f322d2/resourceGroups/ExampleRG/providers/Microsoft.Network/connections/Tokyo-Hub-Conn
LocalNetworkGatewayIPAddress   : 10.10.54.52
LocalNetworkGatewayName        : TokyoLNG
Location                       : 
Name                           : Tokyo-Hub-Conn
ProvisioningState              : Succeeded
ResourceGroup                  : ExampleRG
Sku                            : HighPerformance
SubscriptionId                 : dc5ecb41-8865-454a-995c-8a5bb6f322d2
Tag                            : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TotalStampCapacity             : 4000
Type                           : Microsoft.Network.Admin/adminVirtualNetworkGatewayConnections
VirtualNetworkGatewayIPAddress : 100.74.96.130
VirtualNetworkGatewayName      : HubVNG
```

Returns a list of all Virtual Network Gateway Connections that match the filter.
To expand all properties, pipe the output into Format-List.

### Example 2: Get a specific property
```powershell
PS C:\> (Get-AzSVirtualNetworkGatewayConnection -Filter "Name eq 'Tokyo-Hub-Conn'").ConnectionErrorDetailedInfo | Format-List

Code    : 13801
Message : IKE authentication credentials are unacceptable.
Source  : Network Controller
```

Returns the specified property.

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

### Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20220201.IVirtualNetworkGatewayConnection

## NOTES

ALIASES

## RELATED LINKS

