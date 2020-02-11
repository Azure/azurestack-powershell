### Example 1: Default Get
```powershell
PS C:\> Get-AzsNetworkQuota -Location northwest

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
