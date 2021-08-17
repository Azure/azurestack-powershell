
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
Create or updates a subscription.
.Description
Create or updates a subscription.
.Example
PS C:\> New-AzsSubscription -OfferId '/delegatedProviders/default/offers/testoffer' -DisplayName 'testsubscription' | fl *

DisplayName    : testsubscription
Id             : /subscriptions/7b9d25c5-52ea-4940-8c6a-fe6749ab2e97
OfferId        : /delegatedProviders/default/offers/testoffer
State          : Enabled
SubscriptionId : 7b9d25c5-52ea-4940-8c6a-fe6749ab2e97
TenantId       : 6ca57aaf-0074-498a-9c96-2b097515e8cb

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.subscriptions/new-azssubscription
#>
function New-AzsSubscription {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.DefaultInfo(Script='$([Guid]::NewGuid().ToString())')]
    [System.String]
    # Id of the subscription.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Body')]
    [System.String]
    # Subscription name.
    ${DisplayName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Body')]
    [System.String]
    # Fully qualified identifier.
    ${Id},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Body')]
    [System.String]
    # Identifier of the offer under the scope of a delegated provider.
    ${OfferId},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState])]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.DefaultInfo(Script='Write-Output "Enabled"')]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState]
    # Subscription state.
    ${State},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Category('Body')]
    [System.String]
    # Subscription identifier.
    ${SubscriptionId1},

    [Parameter()]
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

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Azs.Subscriptions.private\New-AzsSubscription_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = $([Guid]::NewGuid().ToString())
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('State')) {
            $PSBoundParameters['State'] = Write-Output "Enabled"
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
