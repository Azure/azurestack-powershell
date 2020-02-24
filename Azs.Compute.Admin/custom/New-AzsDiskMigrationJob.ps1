
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
Create a disk migration job.
.Description
Create a disk migration job.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/azs.compute.admin/new-azsdiskmigrationjob
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20180730Preview.IDisk[]
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20180730Preview.IDiskMigrationJob
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

DISKS <IDisk[]>: .
  [Location <String>]: Location of the resource.
  [DiskId <String>]: The disk id.
  [SharePath <String>]: The disk share path.
  [Status <DiskState?>]: The disk status.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.compute.admin/new-azsdiskmigrationjob
#>
function New-AzsDiskMigrationJob {
[Alias('Start-AzsDiskMigrationJob')]
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20180730Preview.IDiskMigrationJob])]
[CmdletBinding(DefaultParameterSetName='Volume', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('MigrationId')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Path')]
    [System.String]
    # The migration job guid name.
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

    [Parameter(ParameterSetName='Volume', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Query')]
    [System.String]
    # The target scale unit name.
    ${TargetScaleUnit},

    [Parameter(ParameterSetName='Share', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Query')]
    [System.String]
    # The target share name.
    ${TargetShare},

    [Parameter(ParameterSetName='Volume', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Query')]
    [System.String]
    # The target volume label.
    ${TargetVolumeLabel},

    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20180730Preview.IDisk[]]
    # .
    # To construct, see NOTES section for DISKS properties and create a hash table.
    ${Disks},

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

process {
    if ('Share' -eq $PsCmdlet.ParameterSetName)
    {
        Write-Warning "TargetShare parameter will be deprecated in a future release, please use Volume instead."
    }

    Azs.Compute.Admin.internal\New-AzsDiskMigrationJob @PSBoundParameters
}
}
