
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
Prune the external backup store.
.Description
Prune the external backup store.
.Example
PS C:\> Invoke-AzsPruneBackupLocationExternalStore

masbackup/progressivebackup/garbage
.Example
PS C:\> Invoke-AzsPruneBackupLocationExternalStore -OperationType DryRun

masbackup/progressivebackup/garbage


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneBackupStoreOperationOptionModel
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.IBackupAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneModel
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IBackupAdminIdentity>: Identity Parameter
  [Backup <String>]: Name of the backup.
  [Id <String>]: Resource identity path
  [Location <String>]: Name of the backup location.
  [ResourceGroupName <String>]: Name of the resource group.
  [SubscriptionId <String>]: Subscription credentials that uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.

OPTION <IPruneBackupStoreOperationOptionModel>: Prune backup store operation model.
  [OperationType <PruneBackupStoreOperationType?>]: Operation type.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.backup.admin/invoke-azsprunebackuplocationexternalstore
#>
function Invoke-AzsPruneBackupLocationExternalStore {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneModel])]
[CmdletBinding(DefaultParameterSetName='PruneExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Prune')]
    [Parameter(ParameterSetName='PruneExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Name of the backup location.
    ${Location},

    [Parameter(ParameterSetName='Prune')]
    [Parameter(ParameterSetName='PruneExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.DefaultInfo(Script='"system.$((Get-AzLocation)[0].Location)"')]
    [System.String]
    # Name of the resource group.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Prune')]
    [Parameter(ParameterSetName='PruneExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='PruneViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PruneViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.IBackupAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Prune', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PruneViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneBackupStoreOperationOptionModel]
    # Prune backup store operation model.
    # To construct, see NOTES section for OPTION properties and create a hash table.
    ${Option},

    [Parameter(ParameterSetName='PruneExpanded')]
    [Parameter(ParameterSetName='PruneViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.PruneBackupStoreOperationType])]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.PruneBackupStoreOperationType]
    # Operation type.
    ${OperationType},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Runtime')]
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
            Prune = 'Azs.Backup.Admin.private\Invoke-AzsPruneBackupLocationExternalStore_Prune';
            PruneExpanded = 'Azs.Backup.Admin.private\Invoke-AzsPruneBackupLocationExternalStore_PruneExpanded';
            PruneViaIdentity = 'Azs.Backup.Admin.private\Invoke-AzsPruneBackupLocationExternalStore_PruneViaIdentity';
            PruneViaIdentityExpanded = 'Azs.Backup.Admin.private\Invoke-AzsPruneBackupLocationExternalStore_PruneViaIdentityExpanded';
        }
        if (('Prune', 'PruneExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Prune', 'PruneExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('ResourceGroupName')) {
            $PSBoundParameters['ResourceGroupName'] = "system.$((Get-AzLocation)[0].Location)"
        }
        if (('Prune', 'PruneExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
