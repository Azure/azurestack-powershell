
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
Links a plan to an offer.
.Description
Links a plan to an offer.
.Example
PS C:\> Add-AzsPlanToOffer -PlanName "addonplan" -PlanLinkType Addon -OfferName "testoffer" -ResourceGroupName "testrg" -MaxAcquisitionCount 18

AddonPlans                 : {/subscriptions/d77ed1d7-cb62-4658-a777-386a8ae523dd/resourceGroups/testrg/providers/Microsoft.Subscriptions.Admin/plans/addonplan}
BasePlanIds                : {/subscriptions/d77ed1d7-cb62-4658-a777-386a8ae523dd/resourceGroups/testrg/providers/Microsoft.Subscriptions.Admin/plans/testplan}
Description                : 
DisplayName                : testoffer
ExternalReferenceId        : 
Id                         : /subscriptions/d77ed1d7-cb62-4658-a777-386a8ae523dd/resourceGroups/testrg/providers/Microsoft.Subscriptions.Admin/offers/testoffer
Location                   : redmond
MaxSubscriptionsPerAccount : 0
Name                       : testoffer
PropertiesName             : testoffer
State                      : Private
SubscriptionCount          : 0
Tags                       : Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ResourceTags
Type                       : Microsoft.Subscriptions.Admin/offers

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanLinkDefinition
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.ISubscriptionsAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOffer
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

PLANLINK <IPlanLinkDefinition>: Definition for linking and unlinking plans to offers.
  [MaxAcquisitionCount <Int32?>]: The maximum acquisition count by subscribers
  [PlanLinkType <PlanLinkType?>]: Type of the plan link.
  [PlanName <String>]: Name of the plan.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.subscriptions.admin/add-azsplantooffer
#>
function Add-AzsPlanToOffer {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOffer])]
[CmdletBinding(DefaultParameterSetName='LinkExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Link', Mandatory)]
    [Parameter(ParameterSetName='LinkExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [System.String]
    # Name of an offer.
    ${OfferName},

    [Parameter(ParameterSetName='Link', Mandatory)]
    [Parameter(ParameterSetName='LinkExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [System.String]
    # The resource group the resource is located under.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Link')]
    [Parameter(ParameterSetName='LinkExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='LinkViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='LinkViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.ISubscriptionsAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Link', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='LinkViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanLinkDefinition]
    # Definition for linking and unlinking plans to offers.
    # To construct, see NOTES section for PLANLINK properties and create a hash table.
    ${PlanLink},

    [Parameter(ParameterSetName='LinkExpanded')]
    [Parameter(ParameterSetName='LinkViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.Int32]
    # The maximum acquisition count by subscribers
    ${MaxAcquisitionCount},

    [Parameter(ParameterSetName='LinkExpanded')]
    [Parameter(ParameterSetName='LinkViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType])]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType]
    # Type of the plan link.
    ${PlanLinkType},

    [Parameter(ParameterSetName='LinkExpanded')]
    [Parameter(ParameterSetName='LinkViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # Name of the plan.
    ${PlanName},

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
            Link = 'Azs.Subscriptions.Admin.private\Add-AzsPlanToOffer_Link';
            LinkExpanded = 'Azs.Subscriptions.Admin.private\Add-AzsPlanToOffer_LinkExpanded';
            LinkViaIdentity = 'Azs.Subscriptions.Admin.private\Add-AzsPlanToOffer_LinkViaIdentity';
            LinkViaIdentityExpanded = 'Azs.Subscriptions.Admin.private\Add-AzsPlanToOffer_LinkViaIdentityExpanded';
        }
        if (('Link', 'LinkExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
