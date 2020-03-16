
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
Resume a failed update.
.Description
Resume a failed update.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/azs.update.admin/resume-azsupdaterun
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.IUpdateAdminIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IUpdateAdminIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [ResourceGroupName <String>]: Resource group name.
  [RunName <String>]: Update run identifier.
  [SubscriptionId <String>]: Subscription credentials which uniquely identify Microsoft Azure subscription.  The subscription ID forms part of the URI for every service call.
  [UpdateLocation <String>]: The name of the update location.
  [UpdateName <String>]: Name of the update.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.update.admin/resume-azsupdaterun
#>
function Resume-AzsUpdateRun {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Rerun', PositionalBinding=$false, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Rerun')]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # The name of the update location.
    ${Location},

    [Parameter(ParameterSetName='Rerun', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Path')]
    [System.String]
    # Update run identifier.
    ${Name},

    [Parameter(ParameterSetName='Rerun')]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.DefaultInfo(Script='-join("System.",(Get-AzLocation)[0].Location)')]
    [System.String]
    # Resource group name.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Rerun')]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Rerun', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Path')]
    [System.String]
    # Name of the update.
    ${UpdateName},

    [Parameter(ParameterSetName='RerunViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.IUpdateAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    [Parameter(Mandatory = $false)]
    [switch]
    ${Force},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

process 
{
    $UpdateName = $null
    $Name = $null

    # If it is applied via identity
    $parameterSet = $PSCmdlet.ParameterSetName
    if(('RerunViaIdentity') -contains $parameterSet)
    {
        $Name = $InputObject.Id.Split("/")[-1]
        $UpdateName = $InputObject.Id.Split("/")[-3]
    } 
    else 
    {
        # Generated SDK does not support {location}/{updateName} for nested resource updateName, so extract the {updateName} part here
        if ($PSBoundParameters.ContainsKey(('UpdateName')))
        {
            $UpdateName = $PSBoundParameters['UpdateName']
            if ($null -ne $UpdateName -and $UpdateName.Contains('/'))
            {
                $PSBoundParameters['UpdateName'] = $UpdateName.Split("/")[-1]
                $UpdateName = $PSBoundParameters['UpdateName']
            }
        }

        # Generated SDK does not support {location}/{updateName}/{name} for nested resource name, so extract the {name} part here
        if ($PSBoundParameters.ContainsKey(('Name')))
        {
            $Name = $PSBoundParameters['Name']
            if ($null -ne $Name -and $Name.Contains('/'))
            {
                $PSBoundParameters['Name'] = $Name.Split("/")[-1]
                $Name = $PSBoundParameters['Name']
            }
        }
    }

    if ($Force.IsPresent -or $PsCmdlet.ShouldContinue("Are you sure you want to install update $UpdateName ?", "Resuming Update: $UpdateName Run: $Name")) {
        $PSBoundParameters.Remove('Force') | Out-Null
        Azs.Update.Admin.internal\Resume-AzsUpdateRun @PSBoundParameters
    }
}
}