
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
Closes the given alert.
.Description
Closes the given alert.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/azs.infrastructureinsights.admin/close-azsalert
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlert
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.IInfrastructureInsightsAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlert
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ALERT <IAlert>: This object represents an alert resource.
  [Location <String>]: The Azure Region where the resource lives
  [Tag <ITrackedResourceTags>]: Resource tags.
    [(Any) <String>]: This indicates any property can be added to this object.
  [AlertId <String>]: Gets or sets the ID of the alert.
  [AlertProperty <IAlertModelAlertProperties>]: Properties of the alert.
    [(Any) <String>]: This indicates any property can be added to this object.
  [ClosedByUserAlias <String>]: User alias who closed the alert.
  [ClosedTimestamp <String>]: Timestamp when the alert was closed.
  [CreatedTimestamp <String>]: Timestamp when the alert was created.
  [Description <IDictionary[]>]: Description of the alert.
  [FaultId <String>]: Gets or sets the fault ID of the alert.
  [FaultTypeId <String>]: Gets or sets the fault type ID of the alert.
  [HasValidRemediationAction <Boolean?>]: Indicates if the alert can be remediated.
  [ImpactedResourceDisplayName <String>]: Display name for the impacted item.
  [ImpactedResourceId <String>]: Gets or sets the Resource ID for the impacted item.
  [LastUpdatedTimestamp <String>]: Timestamp when the alert was last updated.
  [Remediation <IDictionary[]>]: Gets or sets the admin friendly remediation instructions for the alert.
  [ResourceProviderRegistrationId <String>]: Gets or sets the registration ID of the service the alert belongs to.
  [ResourceRegistrationId <String>]: Gets or sets the registration ID of the resource associated with the alert. If the alert is not associated with a resource, the resource registration ID is null.
  [Severity <String>]: Severity of the alert.
  [State <String>]: State of the alert.
  [Title <String>]: Gets or sets the Resource ID for the impacted item.

INPUTOBJECT <IInfrastructureInsightsAdminIdentity>: Identity Parameter
  [AlertName <String>]: Name of the alert.
  [Id <String>]: Resource identity path
  [Location <String>]: Name of the region
  [ResourceGroupName <String>]: The name of the resource group.
  [ResourceRegistrationId <String>]: Resource registration ID.
  [ServiceHealth <String>]: Service Health name.
  [ServiceRegistrationId <String>]: Service registration ID.
  [SubscriptionId <String>]: Subscription credentials that uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.InfrastructureInsightsAdmin.admin/close-azsalert
#>
function Close-AzsAlert {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlert])]
    [CmdletBinding(DefaultParameterSetName='CloseExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(ParameterSetName='Close')]
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
        [System.String]
        # Name of the region
        ${Location},
    
        [Parameter(ParameterSetName='Close', Mandatory)]
        [Parameter(ParameterSetName='CloseExpanded', Mandatory)]
        [Alias('AlertName')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
        [System.String]
        # Name of the alert.
        ${Name},
    
        [Parameter(ParameterSetName='Close')]
        [Parameter(ParameterSetName='CloseExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='-join("System.",(Get-AzLocation)[0].Location)')]
        [System.String]
        # The name of the resource group.
        ${ResourceGroupName},
    
        [Parameter(ParameterSetName='Close')]
        [Parameter(ParameterSetName='CloseExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # Subscription credentials that uniquely identify Microsoft Azure subscription.
        # The subscription ID forms part of the URI for every service call.
        ${SubscriptionId},
    
        [Parameter(ParameterSetName='CloseViaIdentity', Mandatory, ValueFromPipeline)]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded', Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.IInfrastructureInsightsAdminIdentity]
        # Identity Parameter
        # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
        ${InputObject},
    
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Query')]
        [System.String]
        # The username used to perform the operation.
        ${User},
    
        [Parameter(ParameterSetName='Close', Mandatory, ValueFromPipeline)]
        [Parameter(ParameterSetName='CloseViaIdentity', Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlert]
        # This object represents an alert resource.
        # To construct, see NOTES section for ALERT properties and create a hash table.
        ${Alert},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # Gets or sets the ID of the alert.
        ${AlertId},
    
        [Parameter(ParameterSetName='CloseExpanded',Mandatory)]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelAlertProperties]))]
        [System.Collections.Hashtable]
        # Properties of the alert.
        ${AlertProperty},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # User alias who closed the alert.
        ${ClosedByUserAlias},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # Timestamp when the alert was closed.
        ${ClosedTimestamp},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # Timestamp when the alert was created.
        ${CreatedTimestamp},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary[]]
        # Description of the alert.
        ${Description},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # Gets or sets the fault ID of the alert.
        ${FaultId},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # Gets or sets the fault type ID of the alert.
        ${FaultTypeId},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Indicates if the alert can be remediated.
        ${HasValidRemediationAction},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # Display name for the impacted item.
        ${ImpactedResourceDisplayName},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # Gets or sets the Resource ID for the impacted item.
        ${ImpactedResourceId},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # Timestamp when the alert was last updated.
        ${LastUpdatedTimestamp},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # The Azure Region where the resource lives
        ${Location1},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary[]]
        # Gets or sets the admin friendly remediation instructions for the alert.
        ${Remediation},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # Gets or sets the registration ID of the service the alert belongs to.
        ${ResourceProviderRegistrationId},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # Gets or sets the registration ID of the resource associated with the alert.
        # If the alert is not associated with a resource, the resource registration ID is null.
        ${ResourceRegistrationId},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # Severity of the alert.
        ${Severity},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # State of the alert.
        ${State},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.ITrackedResourceTags]))]
        [System.Collections.Hashtable]
        # Resource tags.
        ${Tag},
    
        [Parameter(ParameterSetName='CloseExpanded')]
        [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
        [System.String]
        # Gets or sets the Resource ID for the impacted item.
        ${Title},
    
        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The credentials, account, tenant, and subscription used for communication with Azure.
        ${DefaultProfile},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )
    
    process {
        Azs.InfrastructureInsights.Admin.internal\Close-AzsAlert @PSBoundParameters
    }
    
    }
    