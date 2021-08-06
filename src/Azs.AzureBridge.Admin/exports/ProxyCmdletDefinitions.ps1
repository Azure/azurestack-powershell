
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
Returns activation name.
.Description
Returns activation name.
.Example
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
.Example
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

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.IBridgeAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IActivationResource
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
https://docs.microsoft.com/en-us/powershell/module/azs.azurebridge.admin/get-azsazurebridgeactivation
#>
function Get-AzsAzureBridgeActivation {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IActivationResource])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('ActivationName')]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [System.String]
    # Name of the activation.
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
            Get = 'Azs.Azurebridge.Admin.private\Get-AzsAzureBridgeActivation_Get';
            GetViaIdentity = 'Azs.Azurebridge.Admin.private\Get-AzsAzureBridgeActivation_GetViaIdentity';
            List = 'Azs.Azurebridge.Admin.private\Get-AzsAzureBridgeActivation_List';
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
Get a downloaded product.
.Description
Get a downloaded product.
.Example
Get-AzsAzureBridgeDownloadedProduct -ActivationName "default" -ResourceGroupName "azurestack-activation" | Select -First 1


BillingPartNumber                                : 
CompatibilityDescription                         : 
CompatibilityIsCompatible                        : 
CompatibilityIssue                               : 
CompatibilityMessage                             : 
Description                                      : <p>Ghost is a publishing platform suitable for everything from personal blogs to major news websites. 
                                                   </p><p></p><p>For developers, its modern technology stack is flexible enough to integrate with other applications 
                                                   and tools. For content authors, content creation and management is extremely easy thanks to its simplified Ghost 
                                                   editor dashboard that lets authors use easy-to-learn markdown while simultaneously seeing the real-time output in a 
                                                   preview pane. </p><p></p><p>This image includes SSL auto-configuration with Let's Encrypt 
                                                   certificates.</p><p></p><p>This open source solution is packaged by Bitnami. Learn how to install, configure, and 
                                                   manage it at docs.bitnami.com. For deployment issues, reach out our support team at 
                                                   community.bitnami.com.</p><p></p><p>Why use Bitnami Certified Apps? </p><p></p><p>Bitnami certified images are 
                                                   always up-to-date, secure, and built to work right out of the box. </p><p></p><p>Bitnami packages applications 
                                                   following industry standards, and continuously monitors all components and libraries for vulnerabilities and 
                                                   application updates. When any security threat or update is identified, Bitnami automatically repackages the 
                                                   applications and pushes the latest versions to the cloud marketplaces.</p><br>Ghost 3.37.1-0 (Debian 10)
DisplayName                                      : Ghost Certified by Bitnami
GalleryItemIdentity                              : bitnami.ghostdefault.1.0.158
GalleryPackageBlobSasUri                         : 
IconUriHero                                      : 
IconUriLarge                                     : https://azstmktprodwcu001.blob.core.windows.net/icons/18d250d22e84486b8d68e196c0638e92/Large.png
IconUriMedium                                    : https://azstmktprodwcu001.blob.core.windows.net/icons/18d250d22e84486b8d68e196c0638e92/Medium.png
IconUriSmall                                     : https://azstmktprodwcu001.blob.core.windows.net/icons/18d250d22e84486b8d68e196c0638e92/Small.png
IconUriWide                                      : https://azstmktprodwcu001.blob.core.windows.net/icons/18d250d22e84486b8d68e196c0638e92/Wide.png
Id                                               : /subscriptions/4d6112db-c97e-47d6-abd9-97ce61f62f2e/resourceGroups/azurestack-activation/providers/Microsoft.AzureBri
                                                   dge.Admin/activations/default/downloadedProducts/bitnami.ghostdefault-3.37.2011041158
LegalTerm                                        : Bitnami Terms of Use can be found at <a 
                                                   href="https://www.vmware.com/help/legal.html">https://www.vmware.com/help/legal.html</a>
Link                                             : {Learn More, Documentation, License Agreement, Bitnami Support}
Location                                         : 
Name                                             : default/bitnami.ghostdefault-3.37.2011041158
Offer                                            : ghost
OfferVersion                                     : 1038
PayloadLength                                    : 32212300322
PrivacyPolicy                                    : https://www.vmware.com/help/privacy.html
ProductDetailPropertyComputeRole                 : 
ProductDetailPropertyDataDiskImage               : 
ProductDetailPropertyIsSystemExtension           : 
ProductDetailPropertyOSDiskImageOperatingSystem  : 
ProductDetailPropertyOSDiskImageSourceBlobSasUri : 
ProductDetailPropertySourceBlobUri               : 
ProductDetailPropertySupportMultipleExtension    : 
ProductDetailPropertyVMScaleSetEnabled           : 
ProductDetailPropertyVersion                     : 
ProductDetailPropertyVmosType                    : 
ProductKind                                      : virtualMachine
ProductProperties                                : 3.37.2011041158
ProvisioningState                                : Succeeded
PublisherDisplayName                             : Bitnami
PublisherIdentifier                              : Bitnami
Sku                                              : default
Tag                                              : Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ResourceTags
Type                                             : Microsoft.AzureBridge.Admin/activations/downloadedProducts
VMExtensionType                                  : 
.Example
Get-AzsAzureBridgeDownloadedProduct -Name 'microsoft.windowsserver2016-datacenter-payg-14393.3986.2010070045' -ActivationName 'default' -ResourceGroupName 'azurestack-activation'


BillingPartNumber                                : 
CompatibilityDescription                         : 
CompatibilityIsCompatible                        : 
CompatibilityIssue                               : 
CompatibilityMessage                             : 
Description                                      : Windows Server 2016 is a comprehensive server operating system designed to run the applications and infrastructure 
                                                   that power your business. It includes built-in layers of security and innovation to help you run traditional and 
                                                   cloud-native applications with confidence.<p><h3 class='msportalfx-text-header'>Legal Terms</h3></p><p>By clicking 
                                                   the Create button, I acknowledge that I am getting this software from Microsoft and that the <a 
                                                   href='https://go.microsoft.com/fwlink/?linkid=2014360' target='_blank'>legal terms</a> of Microsoft apply to it. 
                                                   Microsoft does not provide rights for third-party software. Also see the <a 
                                                   href='https://go.microsoft.com/fwlink/?LinkId=521839' target='_blank'>privacy statement</a> from Microsoft.</p>
DisplayName                                      : Windows Server 2016 Datacenter-Pay as you go
GalleryItemIdentity                              : Microsoft.WindowsServer2016Datacenter-ARM.14393.3986.2010070045
GalleryPackageBlobSasUri                         : 
IconUriHero                                      : 
IconUriLarge                                     : https://azstmktprodwcu001.blob.core.windows.net/icons/e3a0aa9e4c4f49e1ad94f10524499a39/Large.png
IconUriMedium                                    : https://azstmktprodwcu001.blob.core.windows.net/icons/e3a0aa9e4c4f49e1ad94f10524499a39/Medium.png
IconUriSmall                                     : https://azstmktprodwcu001.blob.core.windows.net/icons/e3a0aa9e4c4f49e1ad94f10524499a39/Small.png
IconUriWide                                      : https://azstmktprodwcu001.blob.core.windows.net/icons/e3a0aa9e4c4f49e1ad94f10524499a39/Wide.png
Id                                               : /subscriptions/4d6112db-c97e-47d6-abd9-97ce61f62f2e/resourceGroups/azurestack-activation/providers/Microsoft.AzureBri
                                                   dge.Admin/activations/default/downloadedProducts/microsoft.windowsserver2016-datacenter-payg-14393.3986.2010070045
LegalTerm                                        : https://go.microsoft.com/fwlink/?linkid=2014360
Link                                             : 
Location                                         : 
Name                                             : default/microsoft.windowsserver2016-datacenter-payg-14393.3986.2010070045
Offer                                            : windowsserver
OfferVersion                                     : 14393.3986.2010070045
PayloadLength                                    : 136367658454
PrivacyPolicy                                    : https://go.microsoft.com/fwlink/?LinkId=521839
ProductDetailPropertyComputeRole                 : 
ProductDetailPropertyDataDiskImage               : 
ProductDetailPropertyIsSystemExtension           : 
ProductDetailPropertyOSDiskImageOperatingSystem  : 
ProductDetailPropertyOSDiskImageSourceBlobSasUri : 
ProductDetailPropertySourceBlobUri               : 
ProductDetailPropertySupportMultipleExtension    : 
ProductDetailPropertyVMScaleSetEnabled           : 
ProductDetailPropertyVersion                     : 
ProductDetailPropertyVmosType                    : 
ProductKind                                      : virtualMachine
ProductProperties                                : 14393.3986.2010070045
ProvisioningState                                : Succeeded
PublisherDisplayName                             : Microsoft
PublisherIdentifier                              : MicrosoftWindowsServer
Sku                                              : 2016-Datacenter
Tag                                              : Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ResourceTags
Type                                             : Microsoft.AzureBridge.Admin/activations/downloadedProducts
VMExtensionType                                  : 

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.IBridgeAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductResource
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
https://docs.microsoft.com/en-us/powershell/module/azs.azurebridge.admin/get-azsazurebridgedownloadedproduct
#>
function Get-AzsAzureBridgeDownloadedProduct {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductResource])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [System.String]
    # Name of the activation.
    ${ActivationName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('Name')]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [System.String]
    # Name of the product.
    ${ProductName},

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
            Get = 'Azs.Azurebridge.Admin.private\Get-AzsAzureBridgeDownloadedProduct_Get';
            GetViaIdentity = 'Azs.Azurebridge.Admin.private\Get-AzsAzureBridgeDownloadedProduct_GetViaIdentity';
            List = 'Azs.Azurebridge.Admin.private\Get-AzsAzureBridgeDownloadedProduct_List';
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
Downloads a product from azure marketplace.
.Description
Downloads a product from azure marketplace.
.Example
Invoke-AzsAzureBridgeProductDownload -ActivationName 'default' -ResourceGroupName 'azurestack-activation' -Name 'microsoft.sqliaasextension-1.3.20590'

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.IBridgeAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductResource
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
https://docs.microsoft.com/en-us/powershell/module/azs.azurebridge.admin/invoke-azsazurebridgeproductdownload
#>
function Invoke-AzsAzureBridgeProductDownload {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductResource])]
[CmdletBinding(DefaultParameterSetName='Download', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Download', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [System.String]
    # Name of the activation.
    ${ActivationName},

    [Parameter(ParameterSetName='Download', Mandatory)]
    [Alias('Name')]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [System.String]
    # Name of the product.
    ${ProductName},

    [Parameter(ParameterSetName='Download', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [System.String]
    # The resource group the resource is located under.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Download')]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DownloadViaIdentity', Mandatory, ValueFromPipeline)]
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

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

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

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

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
            Download = 'Azs.Azurebridge.Admin.private\Invoke-AzsAzureBridgeProductDownload_Download';
            DownloadViaIdentity = 'Azs.Azurebridge.Admin.private\Invoke-AzsAzureBridgeProductDownload_DownloadViaIdentity';
        }
        if (('Download') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
Delete a downloaded product.
.Description
Delete a downloaded product.
.Example
Remove-AzsAzureBridgeDownloadedProduct -ActivationName 'default' -ResourceGroupName 'azurestack-activation' -ProductName 'microsoft.sqliaasextension-1.3.20590'

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.IBridgeAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductResource
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
https://docs.microsoft.com/en-us/powershell/module/azs.azurebridge.admin/remove-azsazurebridgedownloadedproduct
#>
function Remove-AzsAzureBridgeDownloadedProduct {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductResource])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [System.String]
    # Name of the activation.
    ${ActivationName},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('Name')]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [System.String]
    # Name of the product.
    ${ProductName},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [System.String]
    # The resource group the resource is located under.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
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

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

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

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

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
            Delete = 'Azs.Azurebridge.Admin.custom\Remove-AzsAzureBridgeDownloadedProduct';
            DeleteViaIdentity = 'Azs.Azurebridge.Admin.custom\Remove-AzsAzureBridgeDownloadedProduct';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
