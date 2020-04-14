
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
Delete the specified subscription.
.Description
Delete the specified subscription.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/azs.subscriptions/remove-azssubscription
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISubscriptionIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <ISubscriptionIdentity>: Identity Parameter
  [DelegatedProviderId <String>]: Id of the delegated provider.
  [Id <String>]: Resource identity path
  [OfferName <String>]: Name of the offer.
  [SubscriptionId <String>]: Id of the subscription.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.subscriptions/remove-azssubscription
#>
function Remove-AzsSubscription {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Path')]
    [System.String]
    # Id of the subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISubscriptionIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

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

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

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
    ${ProxyUseDefaultCredentials},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Don't ask for confirmation
    $Force
)

    process {
        if ($PSCmdlet.ShouldProcess("$SubscriptionId" , "Delete the subscription")) {
            if (($Force.IsPresent -or $PSCmdlet.ShouldContinue("Delete the subscription?", "Performing operation delete on $SubscriptionId."))) {
                if ($PSBoundParameters.ContainsKey(('Force'))) { $null = $PSBoundParameters.Remove('Force') }
                Azs.Subscriptions.internal\Remove-AzsSubscription @PSBoundParameters
            }
        }
    }

}