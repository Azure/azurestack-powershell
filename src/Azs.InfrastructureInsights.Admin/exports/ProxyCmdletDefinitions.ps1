
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
Returns the requested an alert.
.Description
Returns the requested an alert.
.Example
PS C:\> Get-AzsAlert -Name 7f58eb8b-e39f-45d0-8ae7-9920b8f22f5f
.Example
PS C:\> Get-AzsAlert | Where State -EQ 'active' | select FaultTypeId, Title

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.IInfrastructureInsightsAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlert
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

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
https://docs.microsoft.com/en-us/powershell/module/azs.infrastructureinsights.admin/get-azsalert
#>
function Get-AzsAlert {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlert])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Name of the region
    ${Location},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('AlertName')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [System.String]
    # Name of the alert.
    ${Name},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='-join("System.",(Get-AzLocation)[0].Location)')]
    [System.String]
    # The name of the resource group.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.IInfrastructureInsightsAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Query')]
    [System.String]
    # OData filter parameter.
    ${Filter},

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

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Azs.Infrastructureinsights.Admin.private\Get-AzsAlert_Get';
            GetViaIdentity = 'Azs.Infrastructureinsights.Admin.private\Get-AzsAlert_GetViaIdentity';
            List = 'Azs.Infrastructureinsights.Admin.private\Get-AzsAlert_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('ResourceGroupName')) {
            $PSBoundParameters['ResourceGroupName'] = -join("System.",(Get-AzLocation)[0].Location)
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
Returns the requested health status of a region.
.Description
Returns the requested health status of a region.
.Example
PS C:\> Get-AzsRegionHealth

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.IInfrastructureInsightsAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IRegionHealth
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

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
https://docs.microsoft.com/en-us/powershell/module/azs.infrastructureinsights.admin/get-azsregionhealth
#>
function Get-AzsRegionHealth {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IRegionHealth])]
[CmdletBinding(DefaultParameterSetName='Get', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Name of the region
    ${Location},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='-join("System.",(Get-AzLocation)[0].Location)')]
    [System.String]
    # The name of the resource group.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.IInfrastructureInsightsAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Query')]
    [System.String]
    # OData filter parameter.
    ${Filter},

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

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Azs.Infrastructureinsights.Admin.private\Get-AzsRegionHealth_Get';
            GetViaIdentity = 'Azs.Infrastructureinsights.Admin.private\Get-AzsRegionHealth_GetViaIdentity';
            List = 'Azs.Infrastructureinsights.Admin.private\Get-AzsRegionHealth_List';
        }
        if (('Get') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('ResourceGroupName')) {
            $PSBoundParameters['ResourceGroupName'] = -join("System.",(Get-AzLocation)[0].Location)
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
Returns the requested health information about a resource.
.Description
Returns the requested health information about a resource.
.Example
PS C:\> Get-AzsRegistrationHealth -ServiceRegistrationName e56bc7b8-c8b5-4e25-b00c-4f951effb22c
.Example
PS C:\> Get-AzsRPHealth | Where {$_.NamespaceProperty -eq 'Microsoft.Fabric.Admin'} | % { Get-AzsRegistrationHealth -ServiceRegistrationName $_.RegistrationId } | select ResourceName, HealthState

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.IInfrastructureInsightsAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceHealth
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

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
https://docs.microsoft.com/en-us/powershell/module/azs.infrastructureinsights.admin/get-azsregistrationhealth
#>
function Get-AzsRegistrationHealth {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceHealth])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Name of the region
    ${Location},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='-join("System.",(Get-AzLocation)[0].Location)')]
    [System.String]
    # The name of the resource group.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [System.String]
    # Resource registration ID.
    ${ResourceRegistrationId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [System.String]
    # Service registration ID.
    ${ServiceRegistrationId},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.IInfrastructureInsightsAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Query')]
    [System.String]
    # OData filter parameter.
    ${Filter},

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

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Azs.Infrastructureinsights.Admin.private\Get-AzsRegistrationHealth_Get';
            GetViaIdentity = 'Azs.Infrastructureinsights.Admin.private\Get-AzsRegistrationHealth_GetViaIdentity';
            List = 'Azs.Infrastructureinsights.Admin.private\Get-AzsRegistrationHealth_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('ResourceGroupName')) {
            $PSBoundParameters['ResourceGroupName'] = -join("System.",(Get-AzLocation)[0].Location)
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
Returns the requested service health object.
.Description
Returns the requested service health object.
.Example
PS C:\> Get-AzsRPHealth
.Example
PS C:\> Get-AzsRPHealth -Name "e56bc7b8-c8b5-4e25-b00c-4f951effb22c"

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.IInfrastructureInsightsAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IServiceHealth
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

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
https://docs.microsoft.com/en-us/powershell/module/azs.infrastructureinsights.admin/get-azsrphealth
#>
function Get-AzsRPHealth {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IServiceHealth])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Name of the region
    ${Location},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='-join("System.",(Get-AzLocation)[0].Location)')]
    [System.String]
    # The name of the resource group.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [System.String]
    # Service Health name.
    ${ServiceHealth},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.IInfrastructureInsightsAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Query')]
    [System.String]
    # OData filter parameter.
    ${Filter},

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

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Azs.Infrastructureinsights.Admin.private\Get-AzsRPHealth_Get';
            GetViaIdentity = 'Azs.Infrastructureinsights.Admin.private\Get-AzsRPHealth_GetViaIdentity';
            List = 'Azs.Infrastructureinsights.Admin.private\Get-AzsRPHealth_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('ResourceGroupName')) {
            $PSBoundParameters['ResourceGroupName'] = -join("System.",(Get-AzLocation)[0].Location)
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
Repairs an alert.
.Description
Repairs an alert.
.Example
PS C:\> Repair-AzsAlert -Name f2147f3d-42ac-4316-8cbc-f0f9c18888b0
.Example
PS C:\> Get-AzsAlert -Name f2147f3d-42ac-4316-8cbc-f0f9c18888b0 | Repair-AzsAlert

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.IInfrastructureInsightsAdminIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

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
https://docs.microsoft.com/en-us/powershell/module/azs.infrastructureinsights.admin/repair-azsalert
#>
function Repair-AzsAlert {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Repair', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Repair')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Name of the region
    ${Location},

    [Parameter(ParameterSetName='Repair', Mandatory)]
    [Alias('AlertName')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [System.String]
    # Name of the alert.
    ${Name},

    [Parameter(ParameterSetName='Repair')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='-join("System.",(Get-AzLocation)[0].Location)')]
    [System.String]
    # The name of the resource group.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Repair')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='RepairViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.IInfrastructureInsightsAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

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

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

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

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Repair = 'Azs.Infrastructureinsights.Admin.private\Repair-AzsAlert_Repair';
            RepairViaIdentity = 'Azs.Infrastructureinsights.Admin.private\Repair-AzsAlert_RepairViaIdentity';
        }
        if (('Repair') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Repair') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('ResourceGroupName')) {
            $PSBoundParameters['ResourceGroupName'] = -join("System.",(Get-AzLocation)[0].Location)
        }
        if (('Repair') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
PS C:\> $alert | Close-AzsAlert -Name $alert.AlertId -user "adminuser@microsoft.com"
.Example
PS C:\> Close-AzsAlert -Name 7f58eb8b-e39f-45d0-8ae7-9920b8f22f5f -user "adminuser@microsoft.com" -AlertProperty @{"Name"="7f58eb8b-e39f-45d0-8ae7-9920b8f22f5f"}

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
    [Parameter(ParameterSetName='CloseExpanded', Mandatory)]
    [Parameter(ParameterSetName='Close', Mandatory)]
    [Alias('AlertName')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [System.String]
    # Name of the alert.
    ${Name},

    [Parameter(ParameterSetName='CloseExpanded')]
    [Parameter(ParameterSetName='CloseViaIdentityExpanded')]
    [Parameter(ParameterSetName='Close')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Name of the region
    ${Location},

    [Parameter(ParameterSetName='CloseExpanded')]
    [Parameter(ParameterSetName='Close')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='-join("System.",(Get-AzLocation)[0].Location)')]
    [System.String]
    # The name of the resource group.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='CloseExpanded')]
    [Parameter(ParameterSetName='Close')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='CloseViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CloseViaIdentity', Mandatory, ValueFromPipeline)]
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

    [Parameter(ParameterSetName='CloseExpanded', Mandatory)]
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
    # Gets or sets the ID of the alert.
    ${AlertId},

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

    [Parameter(ParameterSetName='Close', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CloseViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlert]
    # This object represents an alert resource.
    # To construct, see NOTES section for ALERT properties and create a hash table.
    ${Alert},

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

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CloseExpanded = 'Azs.Infrastructureinsights.Admin.custom\Close-AzsAlert';
            CloseViaIdentityExpanded = 'Azs.Infrastructureinsights.Admin.custom\Close-AzsAlert';
            Close = 'Azs.Infrastructureinsights.Admin.custom\Close-AzsAlert';
            CloseViaIdentity = 'Azs.Infrastructureinsights.Admin.custom\Close-AzsAlert';
        }
        if (('CloseExpanded', 'CloseViaIdentityExpanded', 'Close') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('CloseExpanded', 'Close') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('ResourceGroupName')) {
            $PSBoundParameters['ResourceGroupName'] = -join("System.",(Get-AzLocation)[0].Location)
        }
        if (('CloseExpanded', 'Close') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
