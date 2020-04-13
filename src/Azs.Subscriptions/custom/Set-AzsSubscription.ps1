<#
.Synopsis
Create or updates a subscription.
.Description
Create or updates a subscription.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/azs.subscription/set-azssubscription
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

SUBSCRIPTIONDEFINITION <ISubscription>: List of supported operations.
  [DisplayName <String>]: Subscription name.
  [Id <String>]: Fully qualified identifier.
  [OfferId <String>]: Identifier of the offer under the scope of a delegated provider.
  [State <SubscriptionState?>]: Subscription state.
  [SubscriptionId <String>]: Subscription identifier.
  [TenantId <String>]: Directory tenant identifier.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.subscription/set-azssubscription
#>
function Set-AzsSubscription {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Path')]
    [System.String]
    # Id of the subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Update', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription]
    # List of supported operations.
    # To construct, see NOTES section for SUBSCRIPTIONDEFINITION properties and create a hash table.
    ${SubscriptionDefinition},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Body')]
    [System.String]
    # Subscription name.
    ${DisplayName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Body')]
    [System.String]
    # Fully qualified identifier.
    ${Id},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Body')]
    [System.String]
    # Identifier of the offer under the scope of a delegated provider.
    ${OfferId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState])]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState]
    # Subscription state.
    ${State},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Body')]
    [System.String]
    # Directory tenant identifier.
    ${TenantId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

    process {
        # Pipeline feature broken in autorest generated cmdlet 
        # TargetSubscriptionId is a mandatory parameters along with the pipeline object
        # Getting TargetSubscriptionId parameter from the pipeline object
        if ( $PSCmdlet.ParameterSetName -eq 'Update' ) {
            if ($null -ne $PSBoundParameters['SubscriptionDefinition'].SubscriptionId) {
                $PSBoundParameters['SubscriptionId'] = $PSBoundParameters['SubscriptionDefinition'].SubscriptionId
            }
        } 
        else {
            # SubscriptionId and SubscriptionId1 are duplicate parameters generated by autorest. 
            # Set SubscriptionId1 = SubscriptionId
            if ($null -ne $PSBoundParameters['SubscriptionId']) {
                $PSBoundParameters['SubscriptionId1'] = $PSBoundParameters['SubscriptionId']
            }
        }
        Azs.Subscriptions.internal\Set-AzsSubscription @PSBoundParameters
    }

}
