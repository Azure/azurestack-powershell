
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
Creates or Updates a Compute Quota with the provided quota parameters.
.Description
Creates or Updates a Compute Quota with the provided quota parameters.
.Example
PS C:\> New-AzsComputeQuota -Name ExampleComputeQuotaWithDefaultParameters

AvailabilitySetCount               : 10
CoresLimit                         : 100
Id                                 : /subscriptions/3ae476e5-83d3-429d-a450-2f4f2fc67c5e/providers/Microsoft.Compute.Ad
                                     min/locations/local/quotas/ExampleComputeQuotaWithDefaultParameters
Location                           : local
Name                               : ExampleComputeQuotaWithDefaultParameters
PremiumManagedDiskAndSnapshotSize  : 2048
StandardManagedDiskAndSnapshotSize : 2048
Type                               : Microsoft.Compute.Admin/quotas
VMScaleSetCount                    : 0
VirtualMachineCount                : 100
.Example
PS C:\>  New-AzsComputeQuota -Name ExampleComputeQuotaWithCustomParameters -Location local -AvailabilitySetCount 9 -CoresCount 99 -PremiumManagedDiskAndSnapshotSize 1024 -StandardManagedDiskAndSnapshotSize 1024 -VirtualMachineCount 99 -VMScaleSetCount 2

AvailabilitySetCount               : 9
CoresLimit                         : 99
Id                                 : /subscriptions/3ae476e5-83d3-429d-a450-2f4f2fc67c5e/providers/Microsoft.Compute.Admin/locat
                                     ions/local/quotas/ExampleComputeQuotaWithCustomParameters
Location                           : local
Name                               : ExampleComputeQuotaWithCustomParameters
PremiumManagedDiskAndSnapshotSize  : 1024
StandardManagedDiskAndSnapshotSize : 1024
Type                               : Microsoft.Compute.Admin/quotas
VMScaleSetCount                    : 2
VirtualMachineCount                : 99

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuota
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuota
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

NEWQUOTA <IQuota>: Holds Compute quota information used to control resource allocation.
  [Location <String>]: Location of the resource.
  [AvailabilitySetCount <Int32?>]: Maximum number of availability sets allowed.
  [CoresLimit <Int32?>]: Maximum number of cores allowed.
  [DdagpuCount <Int32?>]: Maximum number of dda gpus allowed.
  [PartitionedGpuCount <Int32?>]: Maximum number of partitioned gpus allowed.
  [PremiumManagedDiskAndSnapshotSize <Int32?>]: Maximum number of managed disks and snapshots of type premium allowed.
  [StandardManagedDiskAndSnapshotSize <Int32?>]: Maximum number of managed disks and snapshots of type standard allowed.
  [VMScaleSetCount <Int32?>]: Maximum number of scale sets allowed.
  [VirtualMachineCount <Int32?>]: Maximum number of virtual machines allowed.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.compute.admin/new-azscomputequota
#>
function New-AzsComputeQuota {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuota])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('QuotaName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Path')]
    [System.String]
    # Name of the quota.
    ${Name},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Location of the resource.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.DefaultInfo(Script='10')]
    [System.Int32]
    # Maximum number of availability sets allowed.
    ${AvailabilitySetCount},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Alias('CoresLimit')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.DefaultInfo(Script='100')]
    [System.Int32]
    # Maximum number of cores allowed.
    ${CoresCount},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Body')]
    [System.String]
    # Location of the resource.
    ${Location1},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.DefaultInfo(Script='2048')]
    [System.Int32]
    # Maximum number of managed disks and snapshots of type premium allowed.
    ${PremiumManagedDiskAndSnapshotSize},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.DefaultInfo(Script='2048')]
    [System.Int32]
    # Maximum number of managed disks and snapshots of type standard allowed.
    ${StandardManagedDiskAndSnapshotSize},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Body')]
    [System.Int32]
    # Maximum number of scale sets allowed.
    ${VMScaleSetCount},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.DefaultInfo(Script='100')]
    [System.Int32]
    # Maximum number of virtual machines allowed.
    ${VirtualMachineCount},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuota]
    # Holds Compute quota information used to control resource allocation.
    # To construct, see NOTES section for NEWQUOTA properties and create a hash table.
    ${NewQuota},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Runtime')]
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
            CreateExpanded = 'Azs.Compute.Admin.custom\New-AzsComputeQuota';
            Create = 'Azs.Compute.Admin.custom\New-AzsComputeQuota';
        }
        if (('CreateExpanded', 'Create') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('CreateExpanded', 'Create') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('AvailabilitySetCount')) {
            $PSBoundParameters['AvailabilitySetCount'] = 10
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('CoresCount')) {
            $PSBoundParameters['CoresCount'] = 100
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('PremiumManagedDiskAndSnapshotSize')) {
            $PSBoundParameters['PremiumManagedDiskAndSnapshotSize'] = 2048
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('StandardManagedDiskAndSnapshotSize')) {
            $PSBoundParameters['StandardManagedDiskAndSnapshotSize'] = 2048
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('VirtualMachineCount')) {
            $PSBoundParameters['VirtualMachineCount'] = 100
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
