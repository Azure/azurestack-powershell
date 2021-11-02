
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
Patch update a backup location.
.Description
Patch update a backup location.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20210901.IBackupLocation
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.IBackupAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20210901.IBackupLocation
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BACKUP <IBackupLocation>: Information about the backup location.
  [Location <String>]: Location of the resource.
  [Tag <IResourceTags>]: List of key value pairs.
    [(Any) <String>]: This indicates any property can be added to this object.
  [BackupFrequencyInHours <Int32?>]: The interval, in hours, for the frequency that the scheduler takes a backup.
  [BackupRetentionPeriodInDays <Int32?>]: The retention period, in days, for backs in the storage location.
  [BlobStorageKey <String>]: Key to access the blob location.
  [BlobStorageUrl <String>]: Url to the update blob location
  [EncryptionCertBase64 <String>]: The base64 raw data for the backup encryption certificate.
  [IsBackupSchedulerEnabled <Boolean?>]: True if the backup scheduler is enabled.
  [Password <String>]: Password to access the fileshare location.
  [Path <String>]: Path to the update fileshare location
  [UserName <String>]: Username to access the fileshare location.

INPUTOBJECT <IBackupAdminIdentity>: Identity Parameter
  [Backup <String>]: Name of the backup.
  [Id <String>]: Resource identity path
  [Location <String>]: Name of the backup location.
  [ResourceGroupName <String>]: Name of the resource group.
  [SubscriptionId <String>]: Subscription credentials that uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.backup.admin/update-azsbackupconfiguration
#>
function Update-AzsBackupConfiguration {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20210901.IBackupLocation])]
[CmdletBinding(PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Update')]
    [Parameter(ParameterSetName='UpdateBlobExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareExpanded')]
    [Parameter(ParameterSetName='UpdateBlobViaIdentityExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Name of the backup location.
    ${Location},

    [Parameter(ParameterSetName='Update')]
    [Parameter(ParameterSetName='UpdateBlobExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.DefaultInfo(Script='"system.$((Get-AzLocation)[0].Location)"')]
    [System.String]
    # Name of the resource group.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Update')]
    [Parameter(ParameterSetName='UpdateBlobExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateBlobViaIdentityExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.IBackupAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Update', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20210901.IBackupLocation]
    # Information about the backup location.
    # To construct, see NOTES section for BACKUP properties and create a hash table.
    ${Backup},

    [Parameter(ParameterSetName='UpdateBlobExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareExpanded')]
    [Parameter(ParameterSetName='UpdateBlobViaIdentityExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.Int32]
    # The interval, in hours, for the frequency that the scheduler takes a backup.
    ${BackupFrequencyInHours},

    [Parameter(ParameterSetName='UpdateBlobExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareExpanded')]
    [Parameter(ParameterSetName='UpdateBlobViaIdentityExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.Int32]
    # The retention period, in days, for backs in the storage location.
    ${BackupRetentionPeriodInDays},

    [Parameter(ParameterSetName='UpdateBlobExpanded')]
    [Parameter(ParameterSetName='UpdateBlobViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.String]
    # Key to access the blob location.
    ${BlobStorageKey},

    [Parameter(ParameterSetName='UpdateBlobExpanded')]
    [Parameter(ParameterSetName='UpdateBlobViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.String]
    # Url to the update blob location
    ${BlobStorageUrl},

    [Parameter(ParameterSetName='UpdateBlobExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareExpanded')]
    [Parameter(ParameterSetName='UpdateBlobViaIdentityExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.String]
    # Path to the encryption cert file with public key (.cer).
    ${EncryptionCertPath},

    [Parameter(ParameterSetName='UpdateBlobExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareExpanded')]
    [Parameter(ParameterSetName='UpdateBlobViaIdentityExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if the backup scheduler is enabled.
    ${IsBackupSchedulerEnabled},

    [Parameter(ParameterSetName='UpdateFileshareExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [SecureString]
    # Password to access the fileshare location.
    ${Password},

    [Parameter(ParameterSetName='UpdateFileshareExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.String]
    # Path to the update fileshare location
    ${Path},

    [Parameter(ParameterSetName='UpdateBlobExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareExpanded')]
    [Parameter(ParameterSetName='UpdateBlobViaIdentityExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceTags]))]
    [System.Collections.Hashtable]
    # List of key value pairs.
    ${Tag},

    [Parameter(ParameterSetName='UpdateFileshareExpanded')]
    [Parameter(ParameterSetName='UpdateFileshareViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Category('Body')]
    [System.String]
    # Username to access the fileshare location.
    ${UserName},

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

process {
    if ($PSCmdlet.ParameterSetName -eq 'UpdateBlobExpanded' -or $PSCmdlet.ParameterSetName -eq 'UpdateFileshareExpanded')
    {
        $PSBoundParameters.Add('Location1', $PSBoundParameters['Location'])
    }
    
    if ($PSBoundParameters.ContainsKey(('Password')))
    {
        $Ptr = [System.Runtime.InteropServices.Marshal]::SecureStringToCoTaskMemUnicode($Password)
        $PasswordString = [System.Runtime.InteropServices.Marshal]::PtrToStringUni($Ptr)
        [System.Runtime.InteropServices.Marshal]::ZeroFreeCoTaskMemUnicode($Ptr)
        $PSBoundParameters['Password'] = $PasswordString
    }

    if ($PSBoundParameters.ContainsKey(('EncryptionCertPath')))
    {
        if (!(Test-Path -Path $EncryptionCertPath -PathType Leaf))
        {
            throw "The specified encryption cert $EncryptionCertPath does not exist"
        }

        $EncryptionCertBytes = [System.IO.File]::ReadAllBytes($EncryptionCertPath)
        $EncryptionCertBase64 = [System.Convert]::ToBase64String($EncryptionCertBytes)
        $null = $PSBoundParameters.Remove('EncryptionCertPath')
        $PSBoundParameters.Add('EncryptionCertBase64', $EncryptionCertBase64)
    }

    Azs.Backup.Admin.internal\Update-AzsBackupConfiguration @PSBoundParameters
}
}
