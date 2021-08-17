
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
Returns the specified storage quota.
.Description
Returns the specified storage quota.
.Example
PS C:\> Get-AzsStorageQuota
.Example
PS C:\> Get-AzsStorageQuota -Name 'Default Quota'

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.IStorageAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota
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
https://docs.microsoft.com/en-us/powershell/module/azs.storage.admin/get-azsstoragequota
#>
function Get-AzsStorageQuota {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Resource location.
    ${Location},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('QuotaName')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Path')]
    [System.String]
    # The name of the storage quota.
    ${Name},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Subscription Id.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
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
            Get = 'Azs.Storage.Admin.private\Get-AzsStorageQuota_Get';
            GetViaIdentity = 'Azs.Storage.Admin.private\Get-AzsStorageQuota_GetViaIdentity';
            List = 'Azs.Storage.Admin.private\Get-AzsStorageQuota_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
Undelete a deleted storage account with new account name if the a new name is provided.
.Description
Undelete a deleted storage account with new account name if the a new name is provided.
.Example
PS C:\> Restore-AzsStorageAccount -Name 32cbc1173bde4e5fad04e11cc4cb2e00 

.Outputs
System.Boolean
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.storage.admin/restore-azsstorageaccount
#>
function Restore-AzsStorageAccount {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Undelete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('AccountId')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Path')]
    [System.String]
    # Internal storage account ID, which is not visible to tenant.
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

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Query')]
    [System.String]
    # New storage account name when doing undelete storage account operation.
    ${NewAccountName},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

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
    # Run the command asynchronously
    ${NoWait},

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
            Undelete = 'Azs.Storage.Admin.private\Restore-AzsStorageAccount_Undelete';
        }
        if (('Undelete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Undelete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
PS C:\> Set-AzsStorageQuota -Name 'TestUpdateStorageQuota' -NumberOfStorageAccounts 11 -CapacityInGb 22
.Example
PS C:\> Get-AzsStorageQuota -Name 'TestUpdateStorageQuota' | Set-AzsStorageQuota -NumberOfStorageAccounts 22 -CapacityInGb 33

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
https://docs.microsoft.com/en-us/powershell/module/azs.storage.admin/set-azsstoragequota
#>
function Set-AzsStorageQuota {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
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

    [Parameter(ParameterSetName='Update', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota]
    # Storage quota.
    # To construct, see NOTES section for QUOTAOBJECT properties and create a hash table.
    ${QuotaObject},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Body')]
    [System.Int32]
    # Maximum capacity (GB).
    ${CapacityInGb},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Body')]
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
            Update = 'Azs.Storage.Admin.private\Set-AzsStorageQuota_Update';
            UpdateExpanded = 'Azs.Storage.Admin.private\Set-AzsStorageQuota_UpdateExpanded';
        }
        if (('Update', 'UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Update', 'UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
Update storage resource provider settings.
.Description
Update storage resource provider settings.
.Example
PS C:\> Set-AzsStorageSettings -RetentionPeriodForDeletedStorageAccountsInDays 1

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.ISettings
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.storage.admin/set-azsstoragesettings
#>
function Set-AzsStorageSettings {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.ISettings])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
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

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Body')]
    [System.Int32]
    # The number of days a deleted storage account is kept before being permanently deleted.
    ${RetentionPeriodForDeletedStorageAccountsInDays},

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
            UpdateExpanded = 'Azs.Storage.Admin.private\Set-AzsStorageSettings_UpdateExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
Start reclaim storage capacity on deleted storage objects.
.Description
Start reclaim storage capacity on deleted storage objects.
.Example
PS C:\> Start-AzsReclaimStorageCapacity

.Outputs
System.Boolean
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.storage.admin/start-azsreclaimstoragecapacity
#>
function Start-AzsReclaimStorageCapacity {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Reclaim', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
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

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

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
    # Run the command asynchronously
    ${NoWait},

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
            Reclaim = 'Azs.Storage.Admin.private\Start-AzsReclaimStorageCapacity_Reclaim';
        }
        if (('Reclaim') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Reclaim') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
