
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
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/azs.storage.admin/set-azsstoragequota
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

QUOTAOBJECT <IStorageQuota>: Storage quota.
  [CapacityInGb <Int32?>]: Maximum capacity (GB).
  [NumberOfStorageAccount <Int32?>]: Total number of storage accounts.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.storage.admin/set-azsstoragequota
#>
function Set-AzsStorageQuota {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota])]
[CmdletBinding(DefaultParameterSetName='Name', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Name', Mandatory)]
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

    [Parameter(ParameterSetName='QuotaObject', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota]
    # Storage quota.
    # To construct, see NOTES section for QUOTAOBJECT properties and create a hash table.
    ${QuotaObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Category('Body')]
    [System.Int32]
    # Maximum capacity (GB).
    ${CapacityInGb},

    [Parameter()]
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

process {
    $quotaName = $Name

    if ('QuotaObject' -eq $PsCmdlet.ParameterSetName)
    {
        $quotaName = $QuotaObject.Name
    }

    if ($null -ne $quotaName -and $quotaName.Contains('/'))
    {
        $quotaName = $quotaName.Split("/")[-1]
    }

    if ('QuotaObject' -eq $PsCmdlet.ParameterSetName)
    {
        if ($PSBoundParameters.ContainsKey('CapacityInGb'))
        {
            $QuotaObject.CapacityInGb = $CapacityInGb
            $null = $PSBoundParameters.Remove('CapacityInGb')
        }

        if ($PSBoundParameters.ContainsKey('NumberOfStorageAccounts'))
        {
            $QuotaObject.NumberOfStorageAccounts = $NumberOfStorageAccounts
            $null = $PSBoundParameters.Remove('NumberOfStorageAccounts')
        }

        $PSBoundParameters['QuotaObject'] = $QuotaObject
    }
    else
    {
        $params = @{}

        if ($PSBoundParameters.ContainsKey('Location')){
            $params.Add('Location', $Location)
        }
        if ($PSBoundParameters.ContainsKey('SubscriptionId')){
            $params.Add('SubscriptionId', $SubscriptionId)
        }
        
        $quota = Azs.Storage.Admin.internal\Get-AzsStorageQuota -Name $quotaName @params
        
        if (-not $PSBoundParameters.ContainsKey('CapacityInGb'))
        {
            $PSBoundParameters['CapacityInGb'] = $quota.CapacityInGb
        }

        if (-not $PSBoundParameters.ContainsKey('NumberOfStorageAccounts'))
        {
            $PSBoundParameters['NumberOfStorageAccounts'] = $quota.NumberOfStorageAccounts
        }
    }

    $PSBoundParameters['Name'] = $quotaName

    Azs.Storage.Admin.internal\Set-AzsStorageQuota @PSBoundParameters
}
}
