
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Return product name.
.Description
Return product name.
.Example
Get-AzsAzureBridgeProduct -ActivationName 'default' -ResourceGroupName 'azurestack-activation' | Select -First 5 | ft *

BillingPartNumber CompatibilityDescription CompatibilityIsCompatible CompatibilityIssue CompatibilityMessage Description DisplayName                                    
----------------- ------------------------ ------------------------- ------------------ -------------------- ----------- -----------                                    
                  None                                          True {}                 None                             Acronis Backup for Linux (preview)             
                  None                                          True {}                 None                             CoreOS Linux (Stable)                          
                  None                                          True {}                 None                             Custom Script Extension                        
                  None                                          True {}                 None                             BGInfo                                         
                  None                                          True {}                 None                             Free License: SQL Server 2016 SP2 Express on...

.Example
Get-AzsAzureBridgeProduct -ActivationName 'default' -ResourceGroupName 'azurestack-activation' -Name 'microsoft.sqliaasextension-1.3.20590'


BillingPartNumber         : 
CompatibilityDescription  : None
CompatibilityIsCompatible : True
CompatibilityIssue        : {}
CompatibilityMessage      : None
Description               : This extension is required for deploying SQL Server Windows-based VMs on Azure Stack
DisplayName               : SqlIaaSExtension
GalleryItemIdentity       : Microsoft.SqlIaaSExtension.1.3.20590
IconUriHero               : 
IconUriLarge              : https://azstmktprodwcu001.blob.core.windows.net/icons/dbf187f0c64c467f931482ee778e5a04/Large.png
IconUriMedium             : https://azstmktprodwcu001.blob.core.windows.net/icons/dbf187f0c64c467f931482ee778e5a04/Medium.png
IconUriSmall              : https://azstmktprodwcu001.blob.core.windows.net/icons/dbf187f0c64c467f931482ee778e5a04/Small.png
IconUriWide               : https://azstmktprodwcu001.blob.core.windows.net/icons/dbf187f0c64c467f931482ee778e5a04/Wide.png
Id                        : /subscriptions/4d6112db-c97e-47d6-abd9-97ce61f62f2e/resourceGroups/azurestack-activation/providers/Microsoft.AzureBridge.Admin/activations/d
                            efault/products/microsoft.sqliaasextension-1.3.20590
LegalTerm                 : 
Link                      : {}
Location                  : 
Name                      : default/microsoft.sqliaasextension-1.3.20590
Offer                     : 
OfferVersion              : 
PayloadLength             : 7419601
PrivacyPolicy             : 
ProductKind               : virtualMachineExtension
ProductProperties         : 1.3.20590
ProvisioningState         : Succeeded
PublisherDisplayName      : Microsoft
PublisherIdentifier       : Microsoft.SqlServer.Management
Sku                       : 
Tag                       : Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ResourceTags
Type                      : Microsoft.AzureBridge.Admin/activations/products
VMExtensionType           : 

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.IBridgeAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResource
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IBridgeAdminIdentity>: Identity Parameter
  [ActivationName <String>]: Name of the activation.
  [Id <String>]: Resource identity path
  [ProductName <String>]: Name of the product.
  [ResourceGroupName <String>]: The resource group the resource is located under.
  [SubscriptionId <String>]: Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI for every service call.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.azurebridge.admin/get-azsazurebridgeproduct
#>
function Get-AzsAzureBridgeProduct {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResource])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [System.String]
    # Name of the activation.
    ${ActivationName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('ProductName')]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [System.String]
    # Name of the product.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [System.String]
    # The resource group the resource is located under.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.IBridgeAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Azs.Azurebridge.Admin.private\Get-AzsAzureBridgeProduct_Get';
            GetViaIdentity = 'Azs.Azurebridge.Admin.private\Get-AzsAzureBridgeProduct_GetViaIdentity';
            List = 'Azs.Azurebridge.Admin.private\Get-AzsAzureBridgeProduct_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
