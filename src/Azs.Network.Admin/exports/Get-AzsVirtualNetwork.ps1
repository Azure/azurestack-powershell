
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
Get a list of all virtual networks.
.Description
Get a list of all virtual networks.
.Example
PS C:\> Get-AzsVirtualNetwork

ConfigurationStateHostError                    : {}
ConfigurationStateLastUpdatedTime              : 2/10/2020 11:44:06 PM
ConfigurationStateStatus                       : Success
ConfigurationStateVirtualNetworkInterfaceError : {}
Id                                             : /subscriptions/074e4440-77f1-422a-8622-0d146946698c/resourceGroups/vaasrg468c/providers/Microsoft.Network/virtualNetwork
                                                 s/vnetc4b363rprjk3q
Location                                       : 
Name                                           : vnetc4b363rprjk3q
ProvisioningState                              : Succeeded
SubscriptionId                                 : 074e4440-77f1-422a-8622-0d146946698c
Tag                                            : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri                              : /subscriptions/074e4440-77f1-422a-8622-0d146946698c/resourceGroups/vaasrg468c/providers/Microsoft.Network/virtualNetwork
                                                 s/vnetc4b363rprjk3q
Type                                           : Microsoft.Network.Admin/adminVirtualNetworks

ConfigurationStateHostError                    : {}
ConfigurationStateLastUpdatedTime              : 2/10/2020 11:44:07 PM
ConfigurationStateStatus                       : Success
ConfigurationStateVirtualNetworkInterfaceError : {}
Id                                             : /subscriptions/0c4ca7ea-4314-4940-a5dc-29886cfe7c42/resourceGroups/microsoft.iothubstaging/providers/Microsoft.Network/v
                                                 irtualNetworks/4wxzf2ukegiemvnet
Location                                       : 
Name                                           : 4wxzf2ukegiemvnet
ProvisioningState                              : Succeeded
SubscriptionId                                 : 0c4ca7ea-4314-4940-a5dc-29886cfe7c42
Tag                                            : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri                              : /subscriptions/0c4ca7ea-4314-4940-a5dc-29886cfe7c42/resourceGroups/microsoft.iothubstaging/providers/Microsoft.Network/v
                                                 irtualNetworks/4wxzf2ukegiemvnet
Type                                           : Microsoft.Network.Admin/adminVirtualNetworks
.Example
PS C:\> Get-AzsVirtualNetwork -Filter "Name eq '4wxzf2ukegiemvnet'"

ConfigurationStateHostError                    : {}
ConfigurationStateLastUpdatedTime              : 2/10/2020 11:49:20 PM
ConfigurationStateStatus                       : Success
ConfigurationStateVirtualNetworkInterfaceError : {}
Id                                             : /subscriptions/0c4ca7ea-4314-4940-a5dc-29886cfe7c42/resourceGroups/microsoft.iothubstaging/providers/Microsoft.Network/v
                                                 irtualNetworks/4wxzf2ukegiemvnet
Location                                       : 
Name                                           : 4wxzf2ukegiemvnet
ProvisioningState                              : Succeeded
SubscriptionId                                 : 0c4ca7ea-4314-4940-a5dc-29886cfe7c42
Tag                                            : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri                              : /subscriptions/0c4ca7ea-4314-4940-a5dc-29886cfe7c42/resourceGroups/microsoft.iothubstaging/providers/Microsoft.Network/v
                                                 irtualNetworks/4wxzf2ukegiemvnet
Type                                           : Microsoft.Network.Admin/adminVirtualNetworks

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetwork
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.network.admin/get-azsvirtualnetwork
#>
function Get-AzsVirtualNetwork {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetwork])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Query')]
    [System.String]
    # OData filter parameter.
    ${Filter},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Query')]
    [System.String]
    # OData inline count parameter.
    ${InlineCount},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Query')]
    [System.String]
    # OData orderBy parameter.
    ${OrderBy},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Query')]
    [System.String]
    # OData skip parameter.
    ${Skip},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Query')]
    [System.String]
    # OData top parameter.
    ${Top},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Runtime')]
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
            List = 'Azs.Network.Admin.private\Get-AzsVirtualNetwork_List';
        }
        if (('List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
