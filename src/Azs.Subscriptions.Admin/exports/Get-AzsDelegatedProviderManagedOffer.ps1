
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
Get the specified delegated provider offer.
.Description
Get the specified delegated provider offer.
.Example
PS C:\> Get-AzsDelegatedProviderManagedOffer -DelegatedProviderSubscriptionId "c90173b1-de7a-4b1d-8600-b832b0e65946"

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.ISubscriptionsAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDelegatedProviderOffer
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <ISubscriptionsAdminIdentity>: Identity Parameter
  [DelegatedProvider <String>]: DelegatedProvider identifier.
  [DelegatedProviderSubscriptionId <String>]: Delegated provider subscription identifier.
  [Id <String>]: Resource identity path
  [Location <String>]: The AzureStack location.
  [ManifestName <String>]: The manifest name.
  [Offer <String>]: Name of an offer.
  [OfferDelegationName <String>]: Name of a offer delegation.
  [OperationsStatusName <String>]: The operation status name.
  [Plan <String>]: Name of the plan.
  [PlanAcquisitionId <String>]: The plan acquisition Identifier
  [Quota <String>]: Name of the quota.
  [ResourceGroupName <String>]: The resource group the resource is located under.
  [SubscriptionId <String>]: Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI for every service call.
  [TargetSubscriptionId <String>]: The target subscription ID.
  [Tenant <String>]: Directory tenant name.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.subscriptions.admin/get-azsdelegatedprovidermanagedoffer
#>
function Get-AzsDelegatedProviderManagedOffer {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDelegatedProviderOffer])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Alias('DelegatedProviderId')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [System.String]
    # Delegated provider subscription identifier.
    ${DelegatedProviderSubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [System.String]
    # Name of an offer.
    ${Name},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.ISubscriptionsAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Runtime')]
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
            Get = 'Azs.Subscriptions.Admin.private\Get-AzsDelegatedProviderManagedOffer_Get';
            GetViaIdentity = 'Azs.Subscriptions.Admin.private\Get-AzsDelegatedProviderManagedOffer_GetViaIdentity';
            List = 'Azs.Subscriptions.Admin.private\Get-AzsDelegatedProviderManagedOffer_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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