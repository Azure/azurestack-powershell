
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
