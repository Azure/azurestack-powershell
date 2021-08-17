
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
Add a new scale unit.
.Description
Add a new scale unit.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersList
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

CREATIONDATA <ICreateFromJsonScaleUnitParametersList>: A list of input data that allows for creating the new scale unit.
  [ClusterName <String>]: Cluster name for the new scale unit.
  [InfrastructureNetworkSubnet <String[]>]: The subnet IP mask in the example format 10.0.0.0/25.
  [InfrastructureNetworkVlanId <String[]>]: The Vlan ID of the subnet.
  [NetQosPriority <Int32?>]: The network QOS priority setting.
  [PhysicalNode <IDeploymentJsonPhysicalNodeParameters[]>]: List of nodes in the scale unit.
    [BmcipAddress <String>]: BMC address of the physical machine.
    [Name <String>]: Computer name of the physical machine.
  [SoftwareBgpAsn <String>]: The software ASN for the cluster's rack.
  [StorageNetworkSubnet <String[]>]: The subnet IP mask in the example format 10.0.0.0/25.
  [StorageNetworkVlanId <String[]>]: The Vlan ID of the subnet.
  [TorSwitchBgpAsn <String>]: The ASN for the cluster's rack TOR.
  [TorSwitchBgpPeerIP <String[]>]: The list of IP addresses used for TOR communication.

PHYSICALNODE <IDeploymentJsonPhysicalNodeParameters[]>: List of nodes in the scale unit.
  [BmcipAddress <String>]: BMC address of the physical machine.
  [Name <String>]: Computer name of the physical machine.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.fabric.admin/new-azsscaleunitfromjson
#>
function New-AzsScaleUnitFromJson {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [System.String]
    # Name of the scale units.
    ${ScaleUnit},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Location of the resource.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(Script='-join("System.",(Get-AzLocation)[0].Location)')]
    [System.String]
    # Name of the resource group.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersList]
    # A list of input data that allows for creating the new scale unit.
    # To construct, see NOTES section for CREATIONDATA properties and create a hash table.
    ${CreationData},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # Cluster name for the new scale unit.
    ${ClusterName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String[]]
    # The subnet IP mask in the example format 10.0.0.0/25.
    ${InfrastructureNetworkSubnet},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String[]]
    # The Vlan ID of the subnet.
    ${InfrastructureNetworkVlanId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.Int32]
    # The network QOS priority setting.
    ${NetQosPriority},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IDeploymentJsonPhysicalNodeParameters[]]
    # List of nodes in the scale unit.
    # To construct, see NOTES section for PHYSICALNODE properties and create a hash table.
    ${PhysicalNode},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # The software ASN for the cluster's rack.
    ${SoftwareBgpAsn},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String[]]
    # The subnet IP mask in the example format 10.0.0.0/25.
    ${StorageNetworkSubnet},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String[]]
    # The Vlan ID of the subnet.
    ${StorageNetworkVlanId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # The ASN for the cluster's rack TOR.
    ${TorSwitchBgpAsn},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String[]]
    # The list of IP addresses used for TOR communication.
    ${TorSwitchBgpPeerIP},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
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
            Create = 'Azs.Fabric.Admin.private\New-AzsScaleUnitFromJson_Create';
            CreateExpanded = 'Azs.Fabric.Admin.private\New-AzsScaleUnitFromJson_CreateExpanded';
        }
        if (('Create', 'CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Create', 'CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('ResourceGroupName')) {
            $PSBoundParameters['ResourceGroupName'] = -join("System.",(Get-AzLocation)[0].Location)
        }
        if (('Create', 'CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }

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
