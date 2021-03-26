## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-AzsAzureBridgeActivation -ResourceGroupName "azurestack-activation"

AzureRegistrationResourceIdentifier : /subscriptions/5c17413c-1135-479b-a046-847e1ef9fbeb/resourceGroups/AzureStack-s31r21/providers/Microsoft.AzureStack/registrations/AzureStackCIRegistration-s31r2104
DisplayName                         : Azure Stack Activation
Expiration                          : 2022-03-22T02:56:11.024982Z
Id                                  : /subscriptions/4d6112db-c97e-47d6-abd9-97ce61f62f2e/resourceGroups/azurestack-activation/providers/Microsoft.AzureBridge.Admin/activations/default
Location                            : redmond
MarketplaceSyndicationEnabled       : True
Name                                : default
ProvisioningState                   : Succeeded
Tag                                 : Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ResourceTags
Type                                : Microsoft.AzureBridge.Admin/activations
UsageReportingEnabled               : True
```

Get a list of Azure Bridge Activations under the resource group "activationRG"

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Get-AzsAzureBridgeActivation -ResourceGroupName "azurestack-activation" -Name "default"

AzureRegistrationResourceIdentifier : /subscriptions/5c17413c-1135-479b-a046-847e1ef9fbeb/resourceGroups/AzureStack-s31r21/providers/Microsoft.AzureStack/registrations/AzureStackCIRegistration-s31r2104
DisplayName                         : Azure Stack Activation
Expiration                          : 2022-03-22T02:56:11.024982Z
Id                                  : /subscriptions/4d6112db-c97e-47d6-abd9-97ce61f62f2e/resourceGroups/azurestack-activation/providers/Microsoft.AzureBridge.Admin/activations/default
Location                            : redmond
MarketplaceSyndicationEnabled       : True
Name                                : default
ProvisioningState                   : Succeeded
Tag                                 : Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ResourceTags
Type                                : Microsoft.AzureBridge.Admin/activations
UsageReportingEnabled               : True
```

Get an Azure Bridge Activation by name 'myActivation' situated under 'activationRG'
