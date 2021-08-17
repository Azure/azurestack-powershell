
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
Create or update the offer.
.Description
Create or update the offer.
.Example
PS C:\> New-AzsOffer -Name "testoffer" -ResourceGroupName "testrg" -BasePlanIds "/subscriptions/d77ed1d7-cb62-4658-a777-386a8ae523dd/resourceGroups/testrg/providers/Microsoft.Subscriptions.Admin/plans/testplan"

AddonPlans                 : {}
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
Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOffer
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOffer
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ADDONPLANDEFINITION <IAddonPlanDefinition[]>: References to add-on plans that a tenant can optionally acquire as a part of the offer.
  [MaxAcquisitionCount <Int32?>]: Maximum number of instances that can be acquired by a single subscription. If not specified, the assumed value is 1.
  [PlanId <String>]: Plan identifier.

OFFERDEFINITION <IOffer>: Represents an offering of services against which a subscription can be created.
  [Location <String>]: Location of the resource
  [AddonPlans <IAddonPlanDefinition[]>]: References to add-on plans that a tenant can optionally acquire as a part of the offer.
    [MaxAcquisitionCount <Int32?>]: Maximum number of instances that can be acquired by a single subscription. If not specified, the assumed value is 1.
    [PlanId <String>]: Plan identifier.
  [BasePlanIds <String[]>]: Identifiers of the base plans that become available to the tenant immediately when a tenant subscribes to the offer.
  [Description <String>]: Description of offer.
  [DisplayName <String>]: Display name of offer.
  [ExternalReferenceId <String>]: External reference identifier.
  [MaxSubscriptionsPerAccount <Int32?>]: Maximum subscriptions per account.
  [PropertiesName <String>]: Name of the Offer.
  [State <AccessibilityState?>]: Offer accessibility state.
  [SubscriptionCount <Int32?>]: Current subscription count.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.subscriptions.admin/new-azsoffer
#>
function New-AzsOffer {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOffer])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [System.String]
    # Name of an offer.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [System.String]
    # The resource group the resource is located under.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOffer]
    # Represents an offering of services against which a subscription can be created.
    # To construct, see NOTES section for OFFERDEFINITION properties and create a hash table.
    ${OfferDefinition},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAddonPlanDefinition[]]
    # References to add-on plans that a tenant can optionally acquire as a part of the offer.
    # To construct, see NOTES section for ADDONPLANDEFINITION properties and create a hash table.
    ${AddonPlanDefinition},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String[]]
    # Identifiers of the base plans that become available to the tenant immediately when a tenant subscribes to the offer.
    ${BasePlanIds},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # Description of offer.
    ${Description},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # Display name of offer.
    ${DisplayName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # External reference identifier.
    ${ExternalReferenceId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Location of the resource
    ${Location},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.Int32]
    # Maximum subscriptions per account.
    ${MaxSubscriptionsPerAccount},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # Name of the Offer.
    ${PropertiesName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.DefaultInfo(Script='Write-Output "Private"')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState]
    # Offer accessibility state.
    ${State},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.Int32]
    # Current subscription count.
    ${SubscriptionCount},

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
            Create = 'Azs.Subscriptions.Admin.private\New-AzsOffer_Create';
            CreateExpanded = 'Azs.Subscriptions.Admin.private\New-AzsOffer_CreateExpanded';
        }
        if (('Create', 'CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('State')) {
            $PSBoundParameters['State'] = Write-Output "Private"
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
