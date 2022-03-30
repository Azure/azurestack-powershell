---
external help file:
Module Name: Azs.Network.Admin
online version: https://docs.microsoft.com/en-us/powershell/module/azs.network.admin/set-azsnetworkquota
schema: 2.0.0
---

# Set-AzsNetworkQuota

## SYNOPSIS
Create or update a quota.

## SYNTAX

```
Set-AzsNetworkQuota -Quota <IQuota> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create or update a quota.

## EXAMPLES

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

### -Quota
Network quota resource.
To construct, see NOTES section for QUOTA properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota
Parameter Sets: (All)
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
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


QUOTA <IQuota>: Network quota resource.
  - `[Tag <IResourceTags>]`: List of key value pairs.
    - `[(Any) <String>]`: This indicates any property can be added to this object.
  - `[MaxLoadBalancersPerSubscription <Int64?>]`: Maximum number of load balancers a tenant subscription can provision.
  - `[MaxNicsPerSubscription <Int64?>]`: Maximum number of NICs a tenant subscription can provision.
  - `[MaxPublicIpsPerSubscription <Int64?>]`: Maximum number of public IP addresses a tenant subscription can provision.
  - `[MaxSecurityGroupsPerSubscription <Int64?>]`: Maximum number of security groups a tenant subscription can provision.
  - `[MaxVirtualNetworkGatewayConnectionsPerSubscription <Int64?>]`: Maximum number of virtual network gateway Connections a tenant subscription can provision.
  - `[MaxVirtualNetworkGatewaysPerSubscription <Int64?>]`: Maximum number of virtual network gateways a tenant subscription can provision.
  - `[MaxVnetsPerSubscription <Int64?>]`: Maximum number of virtual networks a tenant subscription can provision.

## RELATED LINKS

