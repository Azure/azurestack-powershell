---
external help file:
Module Name: Azs.Network.Admin
online version: https://docs.microsoft.com/en-us/powershell/module/azs.network.admin/get-azspublicipaddress
schema: 2.0.0
---

# Get-AzsPublicIPAddress

## SYNOPSIS
List of public IP addresses.

## SYNTAX

```
Get-AzsPublicIPAddress [-SubscriptionId <String[]>] [-Filter <String>] [-InlineCount <String>]
 [-OrderBy <String>] [-Skip <String>] [-Top <String>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
List of public IP addresses.

## EXAMPLES

### Example 1: Default Get
```powershell
PS C:\> Get-AzsPublicIPAddress

AllocationMethod  : Dynamic
IPAddress         : 100.81.128.46
IPPool            : 731fb401-ff66-4626-95f4-bd5d1e812c1c
Id                : /subscriptions/0c4ca7ea-4314-4940-a5dc-29886cfe7c42/resourceGroups/microsoft.iothubstaging/providers/Microsoft.Network/publicIPAddresses/sqlvmpubip
Location          : 
Name              : sqlvmpubip
ProvisioningState : Succeeded
SubscriptionId    : 0c4ca7ea-4314-4940-a5dc-29886cfe7c42
Tag               : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri : /subscriptions/0c4ca7ea-4314-4940-a5dc-29886cfe7c42/resourceGroups/microsoft.iothubstaging/providers/Microsoft.Network/publicIPAddresses/sqlvmpubip
Type              : Microsoft.Network.Admin/adminPublicIPAddresses

AllocationMethod  : Dynamic
IPAddress         : 
IPPool            : 
Id                : /subscriptions/26f17619-330c-4db7-8699-9b012e94cb6d/resourceGroups/cloudinittest1/providers/Microsoft.Network/publicIPAddresses/cloudinittest-ip
Location          : 
Name              : cloudinittest-ip
ProvisioningState : Succeeded
SubscriptionId    : 26f17619-330c-4db7-8699-9b012e94cb6d
Tag               : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri : /subscriptions/26f17619-330c-4db7-8699-9b012e94cb6d/resourceGroups/cloudinittest1/providers/Microsoft.Network/publicIPAddresses/cloudinittest-ip
Type              : Microsoft.Network.Admin/adminPublicIPAddresses

AllocationMethod  : Static
IPAddress         : 100.81.128.48
IPPool            : 731fb401-ff66-4626-95f4-bd5d1e812c1c
Id                : /subscriptions/26f17619-330c-4db7-8699-9b012e94cb6d/resourceGroups/kub/providers/Microsoft.Network/publicIPAddresses/vmd-publicIPtf7yd2q2ruluu
Location          : 
Name              : vmd-publicIPtf7yd2q2ruluu
ProvisioningState : Succeeded
SubscriptionId    : 26f17619-330c-4db7-8699-9b012e94cb6d
Tag               : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri : /subscriptions/26f17619-330c-4db7-8699-9b012e94cb6d/resourceGroups/kub/providers/Microsoft.Network/publicIPAddresses/vmd-publicIPtf7yd2q2ruluu
Type              : Microsoft.Network.Admin/adminPublicIPAddresses
```

Returns all of the public IP addresses.

### Example 2: Get by filtering
```powershell
PS C:\> Get-AzsPublicIPAddress -Filter "Name eq 'sqlvmpubip'"

AllocationMethod  : Dynamic
IPAddress         : 100.81.128.46
IPPool            : 731fb401-ff66-4626-95f4-bd5d1e812c1c
Id                : /subscriptions/0c4ca7ea-4314-4940-a5dc-29886cfe7c42/resourceGroups/microsoft.iothubstaging/providers/Microsoft.Network/publicIPAddresses/sqlvmpubip
Location          : 
Name              : sqlvmpubip
ProvisioningState : Succeeded
SubscriptionId    : 0c4ca7ea-4314-4940-a5dc-29886cfe7c42
Tag               : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri : /subscriptions/0c4ca7ea-4314-4940-a5dc-29886cfe7c42/resourceGroups/microsoft.iothubstaging/providers/Microsoft.Network/publicIPAddresses/sqlvmpubip
Type              : Microsoft.Network.Admin/adminPublicIPAddresses
```

Returns public IP addresses that are named sqlvmpubip.

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

### Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddress

## NOTES

ALIASES

## RELATED LINKS

