
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
Delete an existing quota
.Description
Delete an existing quota
.Example
PS C:\> Remove-AzsStorageQuota -Name 'TestQuota'
.Example
PS C:\> Get-AzsStorageQuota -Name 'TestQuota' | Remove-AzsStorageQuota

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.IStorageAdminIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IStorageAdminIdentity>: Identity Parameter
  [AccountId <String>]: Internal storage account ID, which is not visible to tenant.
  [AsyncOperationId <String>]: Async Operation Id.
  [Id <String>]: Resource identity path
  [Location <String>]: Resource location.
  [QuotaName <String>]: The name of the storage quota.
  [ResourceGroup <String>]: Resource group name.
  [ServiceName <String>]: Storage service name.
  [SubscriptionId <String>]: Subscription Id.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.storage.admin/remove-azsstoragequota
#>
function Remove-AzsStorageQuota {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Resource location.
    ${Location},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('QuotaName')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Path')]
    [System.String]
    # The name of the storage quota.
    ${Name},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription Id.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.IStorageAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Runtime')]
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
            Delete = 'Azs.Storage.Admin.private\Remove-AzsStorageQuota_Delete';
            DeleteViaIdentity = 'Azs.Storage.Admin.private\Remove-AzsStorageQuota_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
