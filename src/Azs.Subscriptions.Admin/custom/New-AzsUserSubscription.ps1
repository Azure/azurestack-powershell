<#
.Synopsis
Creates or updates the specified subscription.
.Description
Creates or updates the specified subscription.
.Example
PS C:\> New-AzsUserSubscription -Owner "user@contoso.com" -OfferId "/subscriptions/d77ed1d7-cb62-4658-a777-386a8ae523dd/resourceGroups/TenantResourceGroup/providers/Microsoft.Subscriptions.Admin/offers/TenantOffer" | fl *

DelegatedProviderSubscriptionId : d77ed1d7-cb62-4658-a777-386a8ae523dd
DisplayName                     : 
ExternalReferenceId             : 
Id                              : /subscriptions/d77ed1d7-cb62-4658-a777-386a8ae523dd/providers/Microsoft.Subscriptions.Admin/subscriptions/398466a8-7d43-455a-b842-772d356d119e
OfferId                         : /subscriptions/d77ed1d7-cb62-4658-a777-386a8ae523dd/resourceGroups/TenantResourceGroup/providers/Microsoft.Subscriptions.Admin/offers/TenantOff
                                  er
Owner                           : user@contoso.com
RoutingResourceManagerType      : Default
State                           : Enabled
SubscriptionId                  : 398466a8-7d43-455a-b842-772d356d119e
TenantId                        : 6ca57aaf-0074-498a-9c96-2b097515e8cb

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ISubscriptionDefinition
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ISubscriptionDefinition
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

SUBSCRIPTIONDEFINITION <ISubscriptionDefinition>: Subscription object properties.
  [DelegatedProviderSubscriptionId <String>]: Parent DelegatedProvider subscription identifier.
  [DisplayName <String>]: Subscription name.
  [ExternalReferenceId <String>]: External reference identifier.
  [Id <String>]: Fully qualified identifier.
  [OfferId <String>]: Identifier of the offer under the scope of a delegated provider.
  [Owner <String>]: Subscription owner.
  [RoutingResourceManagerType <ResourceManagerType?>]: Routing resource manager type.
  [State <SubscriptionState?>]: Subscription state.
  [SubscriptionId <String>]: Subscription identifier.
  [TenantId <String>]: Directory tenant identifier.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.subscriptions.admin/new-azsusersubscription
#>
function New-AzsUserSubscription {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ISubscriptionDefinition])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.DefaultInfo(Script='$([Guid]::NewGuid().ToString())')]
    [System.String]
    # The target subscription ID.
    ${TargetSubscriptionId},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ISubscriptionDefinition]
    # Subscription object properties.
    # To construct, see NOTES section for SUBSCRIPTIONDEFINITION properties and create a hash table.
    ${SubscriptionDefinition},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Parent DelegatedProvider subscription identifier.
    ${DelegatedProviderSubscriptionId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # Subscription name.
    ${DisplayName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # External reference identifier.
    ${ExternalReferenceId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # Fully qualified identifier.
    ${Id},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # Identifier of the offer under the scope of a delegated provider.
    ${OfferId},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # Subscription owner.
    ${Owner},

    [Parameter(ParameterSetName='CreateExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType])]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.DefaultInfo(Script='Write-Output "Default"')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType]
    # Routing resource manager type.
    ${RoutingResourceManagerType},

    [Parameter(ParameterSetName='CreateExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.DefaultInfo(Script='Write-Output "Enabled"')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState]
    # Subscription state.
    ${State},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # Directory tenant identifier.
    ${TenantId},

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
    if ( $PSCmdlet.ParameterSetName -eq 'CreateExpanded' ) {
        # Autorest generated code doesn't throw error in case resource already exists
        $params = @{}
        $relevantParams = @('SubscriptionId', 'TargetSubscriptionId', 'DefaultProfile', 'Break', 
                            'HttpPipelineAppend', 'HttpPipelinePrepend', 'Proxy', 'ProxyCredential', 
                            'ProxyUseDefaultCredentials')
        foreach ($p in $relevantParams) {
            if ($PSBoundParameters.ContainsKey($p)) { $params[$p] = $PSBoundParameters[$p] }
        }
        $resource = Get-AzsUserSubscription @params -ErrorAction SilentlyContinue
        if ($null -ne $resource) { throw "$($MyInvocation.MyCommand): A target subscription with id $TargetSubscriptionId already exists" }
        # SubscriptionId1 and TargetSubscriptionId are duplicate parameters generated by autorest. 
        # Set SubscriptionId1 as TargetSubscriptionId
        $PSBoundParameters['SubscriptionId1'] = $TargetSubscriptionId
    }
    Azs.Subscriptions.Admin.internal\New-AzsUserSubscription @PSBoundParameters
} 
}
