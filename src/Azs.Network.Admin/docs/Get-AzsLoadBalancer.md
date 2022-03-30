---
external help file:
Module Name: Azs.Network.Admin
online version: https://docs.microsoft.com/en-us/powershell/module/azs.network.admin/get-azsloadbalancer
schema: 2.0.0
---

# Get-AzsLoadBalancer

## SYNOPSIS
Get a list of all load balancers.

## SYNTAX

```
Get-AzsLoadBalancer [-SubscriptionId <String[]>] [-Filter <String>] [-InlineCount <String>]
 [-OrderBy <String>] [-Skip <String>] [-Top <String>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Get a list of all load balancers.

## EXAMPLES

### Example 1: Default Get
```powershell
PS C:\> Get-AzsLoadBalancer

Id                : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/resourceGroups/AppServiceLH01/providers/Microsoft.Network/loadBalancers/aps-sql-lb
Location          : 
Name              : aps-sql-lb
ProvisioningState : Succeeded
PublicIPAddress   : {}
SubscriptionId    : 3ff3b1de-e7f5-43ad-b057-ace4767e7d01
Tag               : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/resourceGroups/AppServiceLH01/providers/Microsoft.Network/loadBalancers/aps-sql-lb
Type              : Microsoft.Network.Admin/adminLoadBalancers

Id                : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/resourceGroups/AppServiceLH01/providers/Microsoft.Network/loadBalancers/FrontEndServersLoadBalanc
                    er
Location          : 
Name              : FrontEndServersLoadBalancer
ProvisioningState : Succeeded
PublicIPAddress   : {100.81.128.40}
SubscriptionId    : 3ff3b1de-e7f5-43ad-b057-ace4767e7d01
Tag               : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/resourceGroups/AppServiceLH01/providers/Microsoft.Network/loadBalancers/FrontEndServersLoadBalanc
                    er
Type              : Microsoft.Network.Admin/adminLoadBalancers
```

Returns all of the virtual networks.

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

### Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILoadBalancer

## NOTES

ALIASES

## RELATED LINKS

