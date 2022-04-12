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

Returns a list of all Virtual Network Gateway Connections on the stamp. To expand all properties, pipe the output into Format-List.

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

Returns a list of all Virtual Network Gateway Connections that match the filter. To expand all properties, pipe the output into Format-List.

### Example 2: Get a specific property
```powershell
PS C:\> (Get-AzSVirtualNetworkGatewayConnection -Filter "Name eq 'Tokyo-Hub-Conn'").ConnectionErrorDetailedInfo | Format-List

Code    : 13801
Message : IKE authentication credentials are unacceptable.
Source  : Network Controller
```

Returns the specified property.

