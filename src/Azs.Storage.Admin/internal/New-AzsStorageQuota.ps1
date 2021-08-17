
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
Create or update an existing storage quota.
.Description
Create or update an existing storage quota.
.Example
PS C:\> New-AzsStorageQuota -Name TestQuota -CapacityInGb 123 -NumberOfStorageAccounts 456

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

QUOTAOBJECT <IStorageQuota>: Storage quota.
  [CapacityInGb <Int32?>]: Maximum capacity (GB).
  [NumberOfStorageAccounts <Int32?>]: Total number of storage accounts.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.storage.admin/new-azsstoragequota
#>
function New-AzsStorageQuota {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('QuotaName')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Path')]
    [System.String]
    # The name of the storage quota.
    ${Name},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Resource location.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription Id.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota]
    # Storage quota.
    # To construct, see NOTES section for QUOTAOBJECT properties and create a hash table.
    ${QuotaObject},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.DefaultInfo(Script='500')]
    [System.Int32]
    # Maximum capacity (GB).
    ${CapacityInGb},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.DefaultInfo(Script='20')]
    [System.Int32]
    # Total number of storage accounts.
    ${NumberOfStorageAccounts},

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
            Create = 'Azs.Storage.Admin.private\New-AzsStorageQuota_Create';
            CreateExpanded = 'Azs.Storage.Admin.private\New-AzsStorageQuota_CreateExpanded';
        }
        if (('Create', 'CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Create', 'CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('CapacityInGb')) {
            $PSBoundParameters['CapacityInGb'] = 500
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('NumberOfStorageAccounts')) {
            $PSBoundParameters['NumberOfStorageAccounts'] = 20
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
