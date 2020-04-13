<#
.Synopsis
Create or update the offer.
.Description
Create or update the offer.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/azs.subscriptions.admin/set-azsoffer
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
https://docs.microsoft.com/en-us/powershell/module/azs.subscriptions.admin/set-azsoffer
#>
function Set-AzsOffer {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOffer])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory, ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [System.String]
    # Name of an offer.
    ${Name},

    [Parameter(Mandatory, ParameterSetName='UpdateExpanded')]
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

    [Parameter(ParameterSetName='Update', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOffer]
    # Represents an offering of services against which a subscription can be created.
    # To construct, see NOTES section for OFFERDEFINITION properties and create a hash table.
    ${OfferDefinition},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAddonPlanDefinition[]]
    # References to add-on plans that a tenant can optionally acquire as a part of the offer.
    # To construct, see NOTES section for ADDONPLANDEFINITION properties and create a hash table.
    ${AddonPlanDefinition},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String[]]
    # Identifiers of the base plans that become available to the tenant immediately when a tenant subscribes to the offer.
    ${BasePlanIds},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # Description of offer.
    ${Description},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # Display name of offer.
    ${DisplayName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # External reference identifier.
    ${ExternalReferenceId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Location of the resource
    ${Location},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.Int32]
    # Maximum subscriptions per account.
    ${MaxSubscriptionsPerAccount},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # Name of the Offer.
    ${PropertiesName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState]
    # Offer accessibility state.
    ${State},

    [Parameter(ParameterSetName='UpdateExpanded')]
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

    process {
        # Pipeline feature broken in autorest generated cmdlet 
        # Name and ResourceGroupName are mandatory parameters along with the pipeline object
        # Getting these parameters from the pipeline object
        if ( $PSCmdlet.ParameterSetName -eq 'Update' )
        {
            if ($null -ne $PSBoundParameters['OfferDefinition'].PropertiesName)
            {
                $PSBoundParameters['Name'] = $PSBoundParameters['OfferDefinition'].PropertiesName
            }
            if ($null -ne $PSBoundParameters['OfferDefinition'].Id)
            {
                $OfferProps = $PSBoundParameters['OfferDefinition'].Id.split('/')
                $PSBoundParameters['ResourceGroupName'] = $OfferProps[$OfferProps.indexof('resourceGroups')+1]
            }
        }
        Azs.Subscriptions.Admin.internal\Set-AzsOffer @PSBoundParameters
    }

}
