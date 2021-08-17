
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
Create or update a quota.
.Description
Create or update a quota.
.Example
PS C:\> New-AzsNetworkQuota -Name NetworkQuotaDefaultValues

Id                                                 : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/providers/Microsoft.Network.Admin/locations/northwest/quotas/Net
                                                     workQuotaDefaultValues
Location                                           : northwest
MaxLoadBalancersPerSubscription                    : 50
MaxNicsPerSubscription                             : 100
MaxPublicIpsPerSubscription                        : 50
MaxSecurityGroupsPerSubscription                   : 50
MaxVirtualNetworkGatewayConnectionsPerSubscription : 2
MaxVirtualNetworkGatewaysPerSubscription           : 1
MaxVnetsPerSubscription                            : 50
MigrationPhase                                     : None
Name                                               : northwest/NetworkQuotaDefaultValues
ProvisioningState                                  : Succeeded
Tag                                                : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
Type                                               : Microsoft.Network.Admin/quotas
.Example
PS C:\> New-AzsNetworkQuota -Name NetworkQuota1 -MaxNicsPerSubscription 150 -MaxPublicIpsPerSubscription 150

Id                                                 : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/providers/Microsoft.Network.Admin/locations/northwest/quotas/Net
                                                     workQuota1
Location                                           : northwest
MaxLoadBalancersPerSubscription                    : 50
MaxNicsPerSubscription                             : 150
MaxPublicIpsPerSubscription                        : 150
MaxSecurityGroupsPerSubscription                   : 50
MaxVirtualNetworkGatewayConnectionsPerSubscription : 2
MaxVirtualNetworkGatewaysPerSubscription           : 1
MaxVnetsPerSubscription                            : 50
MigrationPhase                                     : None
Name                                               : northwest/NetworkQuota1
ProvisioningState                                  : Succeeded
Tag                                                : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
Type                                               : Microsoft.Network.Admin/quotas

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

QUOTA <IQuota>: Network quota resource.
  [Tag <IResourceTags>]: List of key value pairs.
    [(Any) <String>]: This indicates any property can be added to this object.
  [MaxLoadBalancersPerSubscription <Int64?>]: Maximum number of load balancers a tenant subscription can provision.
  [MaxNicsPerSubscription <Int64?>]: Maximum number of NICs a tenant subscription can provision.
  [MaxPublicIpsPerSubscription <Int64?>]: Maximum number of public IP addresses a tenant subscription can provision.
  [MaxSecurityGroupsPerSubscription <Int64?>]: Maximum number of security groups a tenant subscription can provision.
  [MaxVirtualNetworkGatewayConnectionsPerSubscription <Int64?>]: Maximum number of virtual network gateway Connections a tenant subscription can provision.
  [MaxVirtualNetworkGatewaysPerSubscription <Int64?>]: Maximum number of virtual network gateways a tenant subscription can provision.
  [MaxVnetsPerSubscription <Int64?>]: Maximum number of virtual networks a tenant subscription can provision.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.network.admin/new-azsnetworkquota
#>
function New-AzsNetworkQuota {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Path')]
    [System.String]
    # Name of the resource.
    ${Name},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Location of the resource.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.DefaultInfo(Script='50')]
    [System.Int64]
    # Maximum number of load balancers a tenant subscription can provision.
    ${MaxLoadBalancersPerSubscription},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.DefaultInfo(Script='100')]
    [System.Int64]
    # Maximum number of NICs a tenant subscription can provision.
    ${MaxNicsPerSubscription},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.DefaultInfo(Script='50')]
    [System.Int64]
    # Maximum number of public IP addresses a tenant subscription can provision.
    ${MaxPublicIpsPerSubscription},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.DefaultInfo(Script='50')]
    [System.Int64]
    # Maximum number of security groups a tenant subscription can provision.
    ${MaxSecurityGroupsPerSubscription},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.DefaultInfo(Script='2')]
    [System.Int64]
    # Maximum number of virtual network gateway Connections a tenant subscription can provision.
    ${MaxVirtualNetworkGatewayConnectionsPerSubscription},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.DefaultInfo(Script='1')]
    [System.Int64]
    # Maximum number of virtual network gateways a tenant subscription can provision.
    ${MaxVirtualNetworkGatewaysPerSubscription},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.DefaultInfo(Script='50')]
    [System.Int64]
    # Maximum number of virtual networks a tenant subscription can provision.
    ${MaxVnetsPerSubscription},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceTags]))]
    [System.Collections.Hashtable]
    # List of key value pairs.
    ${Tag},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota]
    # Network quota resource.
    # To construct, see NOTES section for QUOTA properties and create a hash table.
    ${Quota},

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
            CreateExpanded = 'Azs.Network.Admin.custom\New-AzsNetworkQuota';
            Create = 'Azs.Network.Admin.custom\New-AzsNetworkQuota';
        }
        if (('CreateExpanded', 'Create') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('CreateExpanded', 'Create') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('MaxLoadBalancersPerSubscription')) {
            $PSBoundParameters['MaxLoadBalancersPerSubscription'] = 50
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('MaxNicsPerSubscription')) {
            $PSBoundParameters['MaxNicsPerSubscription'] = 100
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('MaxPublicIpsPerSubscription')) {
            $PSBoundParameters['MaxPublicIpsPerSubscription'] = 50
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('MaxSecurityGroupsPerSubscription')) {
            $PSBoundParameters['MaxSecurityGroupsPerSubscription'] = 50
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('MaxVirtualNetworkGatewayConnectionsPerSubscription')) {
            $PSBoundParameters['MaxVirtualNetworkGatewayConnectionsPerSubscription'] = 2
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('MaxVirtualNetworkGatewaysPerSubscription')) {
            $PSBoundParameters['MaxVirtualNetworkGatewaysPerSubscription'] = 1
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('MaxVnetsPerSubscription')) {
            $PSBoundParameters['MaxVnetsPerSubscription'] = 50
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
