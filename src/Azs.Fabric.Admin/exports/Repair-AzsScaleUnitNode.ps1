
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
Repairs a node of the cluster.
.Description
Repairs a node of the cluster.
.Example
PS C:\> Repair-AzsScaleUnitNode -Name "AZS-ERCO03" -BMCIPv4Address ***.***.***.***


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IBareMetalNodeDescription
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BAREMETALNODE <IBareMetalNodeDescription>: Description of a bare metal node used for ScaleOut operation on a cluster.
  [BiosVersion <String>]: Bios version of the physical machine.
  [BmciPv4Address <String>]: BMC address of the physical machine.
  [ClusterName <String>]: Name of the cluster.
  [ComputerName <String>]: Name of the computer.
  [MacAddress <String>]: Name of the MAC address of the bare metal node.
  [Model <String>]: Model of the physical machine.
  [SerialNumber <String>]: Serial number of the physical machine.
  [Vendor <String>]: Vendor of the physical machine.

INPUTOBJECT <IFabricAdminIdentity>: Identity Parameter
  [Drive <String>]: Name of the storage drive.
  [EdgeGateway <String>]: Name of the edge gateway.
  [EdgeGatewayPool <String>]: Name of the edge gateway pool.
  [FabricLocation <String>]: Fabric location.
  [FileShare <String>]: Fabric file share name.
  [IPPool <String>]: IP pool name.
  [Id <String>]: Resource identity path
  [InfraRole <String>]: Infrastructure role name.
  [InfraRoleInstance <String>]: Name of an infrastructure role instance.
  [Location <String>]: Location of the resource.
  [LogicalNetwork <String>]: Name of the logical network.
  [LogicalSubnet <String>]: Name of the logical subnet.
  [MacAddressPool <String>]: Name of the MAC address pool.
  [Operation <String>]: Operation identifier.
  [ResourceGroupName <String>]: Name of the resource group.
  [ScaleUnit <String>]: Name of the scale units.
  [ScaleUnitNode <String>]: Name of the scale unit node.
  [SlbMuxInstance <String>]: Name of a SLB MUX instance.
  [StorageSubSystem <String>]: Name of the storage system.
  [SubscriptionId <String>]: Subscription credentials that uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
  [Volume <String>]: Name of the storage volume.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.fabric.admin/repair-azsscaleunitnode
#>
function Repair-AzsScaleUnitNode {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='RepairExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='RepairExpanded', Mandatory)]
    [Parameter(ParameterSetName='Repair', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [System.String]
    # Name of the scale unit node.
    ${Name},

    [Parameter(ParameterSetName='RepairExpanded')]
    [Parameter(ParameterSetName='Repair')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Location of the resource.
    ${Location},

    [Parameter(ParameterSetName='RepairExpanded')]
    [Parameter(ParameterSetName='Repair')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(Script='-join("System.",(Get-AzLocation)[0].Location)')]
    [System.String]
    # Name of the resource group.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='RepairExpanded')]
    [Parameter(ParameterSetName='Repair')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='RepairViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='RepairViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='RepairExpanded')]
    [Parameter(ParameterSetName='RepairViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # Bios version of the physical machine.
    ${BiosVersion},

    [Parameter(ParameterSetName='RepairExpanded')]
    [Parameter(ParameterSetName='RepairViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # BMC address of the physical machine.
    ${BmciPv4Address},

    [Parameter(ParameterSetName='RepairExpanded')]
    [Parameter(ParameterSetName='RepairViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # Name of the cluster.
    ${ClusterName},

    [Parameter(ParameterSetName='RepairExpanded')]
    [Parameter(ParameterSetName='RepairViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # Name of the computer.
    ${ComputerName},

    [Parameter(ParameterSetName='RepairExpanded')]
    [Parameter(ParameterSetName='RepairViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # Name of the MAC address of the bare metal node.
    ${MacAddress},

    [Parameter(ParameterSetName='RepairExpanded')]
    [Parameter(ParameterSetName='RepairViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # Model of the physical machine.
    ${Model},

    [Parameter(ParameterSetName='RepairExpanded')]
    [Parameter(ParameterSetName='RepairViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # Serial number of the physical machine.
    ${SerialNumber},

    [Parameter(ParameterSetName='RepairExpanded')]
    [Parameter(ParameterSetName='RepairViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # Vendor of the physical machine.
    ${Vendor},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    ${Force},

    [Parameter(ParameterSetName='Repair', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='RepairViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IBareMetalNodeDescription]
    # Description of a bare metal node used for ScaleOut operation on a cluster.
    # To construct, see NOTES section for BAREMETALNODE properties and create a hash table.
    ${BareMetalNode},

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
            RepairExpanded = 'Azs.Fabric.Admin.custom\Repair-AzsScaleUnitNode';
            Repair = 'Azs.Fabric.Admin.custom\Repair-AzsScaleUnitNode';
            RepairViaIdentityExpanded = 'Azs.Fabric.Admin.custom\Repair-AzsScaleUnitNode';
            RepairViaIdentity = 'Azs.Fabric.Admin.custom\Repair-AzsScaleUnitNode';
        }
        if (('RepairExpanded', 'Repair') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('RepairExpanded', 'Repair') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('ResourceGroupName')) {
            $PSBoundParameters['ResourceGroupName'] = -join("System.",(Get-AzLocation)[0].Location)
        }
        if (('RepairExpanded', 'Repair') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
