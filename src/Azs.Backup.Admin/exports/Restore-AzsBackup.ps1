
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
Restore a backup.
.Description
Restore a backup.
.Example
PS C:\> Restore-AzsBackup -Name $backupResourceName -DecryptionCertPath $decryptionCertPath -DecryptionCertPassword $decryptionCertPassword


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.IBackupAdminIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IBackupAdminIdentity>: Identity Parameter
  [Backup <String>]: Name of the backup.
  [Id <String>]: Resource identity path
  [Location <String>]: Name of the backup location.
  [ResourceGroupName <String>]: Name of the resource group.
  [SubscriptionId <String>]: Subscription credentials that uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.

RESTOREOPTION <IRestoreOptions>: Properties for restore options.
  [DecryptionCertBase64 <String>]: The certificate file raw data in Base64 string. This should be the .pfx file with the private key.
  [DecryptionCertPassword <String>]: The password for the decryption certificate.
  [RoleName <String>]: The Azure Stack role name for restore, set it to empty for all infrastructure role
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.backup.admin/restore-azsbackup
#>
function Restore-AzsBackup {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='RestoreExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='RestoreExpanded', Mandatory)]
    [Parameter(ParameterSetName='Restore', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [System.String]
    # Name of the backup.
    ${Name},

    [Parameter(ParameterSetName='RestoreExpanded')]
    [Parameter(ParameterSetName='Restore')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Name of the backup location.
    ${Location},

    [Parameter(ParameterSetName='RestoreExpanded')]
    [Parameter(ParameterSetName='Restore')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.DefaultInfo(Script='"system.$((Get-AzLocation)[0].Location)"')]
    [System.String]
    # Name of the resource group.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='RestoreExpanded')]
    [Parameter(ParameterSetName='Restore')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='RestoreViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='RestoreViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.IBackupAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='RestoreExpanded')]
    [Parameter(ParameterSetName='RestoreViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.String]
    # Path to the decryption cert file with private key (.pfx).
    ${DecryptionCertPath},

    [Parameter(ParameterSetName='RestoreExpanded')]
    [Parameter(ParameterSetName='RestoreViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.Security.SecureString]
    # The password for the decryption certificate.
    ${DecryptionCertPassword},

    [Parameter(ParameterSetName='RestoreExpanded')]
    [Parameter(ParameterSetName='RestoreViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.String]
    # The Azure Stack role name for restore, set it to empty for all infrastructure role
    ${RoleName},

    [Parameter(ParameterSetName='Restore', Mandatory)]
    [Parameter(ParameterSetName='RestoreViaIdentity', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRestoreOptions]
    # Properties for restore options.
    # To construct, see NOTES section for RESTOREOPTION properties and create a hash table.
    ${RestoreOption},

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
    ${ProxyUseDefaultCredentials},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Don't ask for confirmation
    ${Force}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            RestoreExpanded = 'Azs.Backup.Admin.custom\Restore-AzsBackup';
            Restore = 'Azs.Backup.Admin.custom\Restore-AzsBackup';
            RestoreViaIdentityExpanded = 'Azs.Backup.Admin.custom\Restore-AzsBackup';
            RestoreViaIdentity = 'Azs.Backup.Admin.custom\Restore-AzsBackup';
        }
        if (('RestoreExpanded', 'Restore') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('RestoreExpanded', 'Restore') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('ResourceGroupName')) {
            $PSBoundParameters['ResourceGroupName'] = "system.$((Get-AzLocation)[0].Location)"
        }
        if (('RestoreExpanded', 'Restore') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
