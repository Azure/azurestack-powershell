
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
Creates an acquired plan.
.Description
Creates an acquired plan.
.Example
PS C:\> New-AzsAcquiredPlan -PlanAcquisitionId $([Guid]::NewGuid()) -PlanId "/subscriptions/d77ed1d7-cb62-4658-a777-386a8ae523dd/resourceGroups/testrg/providers/Microsoft.Subscriptions.Admin/plans/testplan" -TargetSubscriptionId "d77ed1d7-cb62-4658-a777-386a8ae523dd"

AcquisitionId       : 718c7f7c-4868-479a-98ce-5caaa8f158c1
AcquisitionTime     : 3/12/2020 11:16:08 PM
ExternalReferenceId : 
Id                  : /subscriptions/d77ed1d7-cb62-4658-a777-386a8ae523dd/providers/Microsoft.Subscriptions.Admin/subscriptions/d77ed1d7-cb62-4658-a777-386a8ae523dd/acquiredPlan
                      s/718c7f7c-4868-479a-98ce-5caaa8f158c1
PlanId              : /subscriptions/d77ed1d7-cb62-4658-a777-386a8ae523dd/providers/Microsoft.Subscriptions.Admin/plans/testplan
ProvisioningState   : Succeeded

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanAcquisition
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanAcquisition
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ACQUIREDPLANDEFINITION <IPlanAcquisition>: Represents the acquisition of an add-on plan for a subscription.
  [AcquisitionId <String>]: Acquisition identifier.
  [AcquisitionTime <DateTime?>]: Acquisition time.
  [ExternalReferenceId <String>]: External reference identifier.
  [Id <String>]: Identifier in the tenant subscription context.
  [PlanId <String>]: Plan identifier in the tenant subscription context.
  [ProvisioningState <ProvisioningState?>]: State of the provisioning.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.subscriptions.admin/new-azsacquiredplan
#>
function New-AzsAcquiredPlan {
[Alias('New-AzsSubscriptionPlan')]
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanAcquisition])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [System.String]
    # The target subscription ID.
    ${TargetSubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.DefaultInfo(Script='$([Guid]::NewGuid().ToString())')]
    [System.String]
    # The plan acquisition Identifier
    ${PlanAcquisitionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.DateTime]
    # Acquisition time.
    ${AcquisitionTime},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # External reference identifier.
    ${ExternalReferenceId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # Identifier in the tenant subscription context.
    ${Id},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [System.String]
    # Plan identifier in the tenant subscription context.
    ${PlanId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ProvisioningState])]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ProvisioningState]
    # State of the provisioning.
    ${ProvisioningState},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanAcquisition]
    # Represents the acquisition of an add-on plan for a subscription.
    # To construct, see NOTES section for ACQUIREDPLANDEFINITION properties and create a hash table.
    ${AcquiredPlanDefinition},

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
            CreateExpanded = 'Azs.Subscriptions.Admin.custom\New-AzsAcquiredPlan';
            Create = 'Azs.Subscriptions.Admin.custom\New-AzsAcquiredPlan';
        }
        if (('CreateExpanded', 'Create') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('PlanAcquisitionId')) {
            $PSBoundParameters['PlanAcquisitionId'] = $([Guid]::NewGuid().ToString())
        }
        if (('CreateExpanded', 'Create') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
