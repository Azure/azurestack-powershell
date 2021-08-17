
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
Update a backup location.
.Description
Update a backup location.
.Example
PS C:\> Set-AzsBackupConfiguration -Path "\\***.***.***.***\Share" -Username "asdomain1\azurestackadmin" -Password $password  -EncryptionCertPath $encryptionCertPath


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocation
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocation
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BACKUP <IBackupLocation>: Information about the backup location.
  [Location <String>]: Location of the resource.
  [Tag <IResourceTags>]: List of key value pairs.
    [(Any) <String>]: This indicates any property can be added to this object.
  [BackupFrequencyInHours <Int32?>]: The interval, in hours, for the frequency that the scheduler takes a backup.
  [BackupRetentionPeriodInDays <Int32?>]: The retention period, in days, for backs in the storage location.
  [EncryptionCertBase64 <String>]: The base64 raw data for the backup encryption certificate.
  [IsBackupSchedulerEnabled <Boolean?>]: True if the backup scheduler is enabled.
  [Password <String>]: Password to access the location.
  [Path <String>]: Path to the update location
  [UserName <String>]: Username to access the location.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.backup.admin/set-azsbackupconfiguration
#>
function Set-AzsBackupConfiguration {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocation])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Name of the backup location.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.DefaultInfo(Script='"system.$((Get-AzLocation)[0].Location)"')]
    [System.String]
    # Name of the resource group.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.Int32]
    # The interval, in hours, for the frequency that the scheduler takes a backup.
    ${BackupFrequencyInHours},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.Int32]
    # The retention period, in days, for backs in the storage location.
    ${BackupRetentionPeriodInDays},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.String]
    # Path to the encryption cert file with public key (.cer).
    ${EncryptionCertPath},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if the backup scheduler is enabled.
    ${IsBackupSchedulerEnabled},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.Security.SecureString]
    # Password to access the location.
    ${Password},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.String]
    # Path to the update location
    ${Path},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceTags]))]
    [System.Collections.Hashtable]
    # List of key value pairs.
    ${Tag},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.String]
    # Username to access the location.
    ${UserName},

    [Parameter(ParameterSetName='Update', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocation]
    # Information about the backup location.
    # To construct, see NOTES section for BACKUP properties and create a hash table.
    ${Backup},

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
            UpdateExpanded = 'Azs.Backup.Admin.custom\Set-AzsBackupConfiguration';
            Update = 'Azs.Backup.Admin.custom\Set-AzsBackupConfiguration';
        }
        if (('UpdateExpanded', 'Update') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('UpdateExpanded', 'Update') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('ResourceGroupName')) {
            $PSBoundParameters['ResourceGroupName'] = "system.$((Get-AzLocation)[0].Location)"
        }
        if (('UpdateExpanded', 'Update') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
