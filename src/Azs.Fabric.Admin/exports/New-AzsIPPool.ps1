
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
Create an IP pool.
Once created an IP pool cannot be deleted.
.Description
Create an IP pool.
Once created an IP pool cannot be deleted.
.Example
PS C:\> New-AzsIpPool -Name IpPool4 -StartIpAddress ***.***.***.*** -EndIpAddress ***.***.***.*** -AddressPrefix ***.***.***.***/24


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

POOL <IIPPool>: This resource defines the range of IP addresses from which addresses are allocated for nodes within a subnet.
  [Location <String>]: The region where the resource is located.
  [Tag <IResourceTags>]: List of key-value pairs.
    [(Any) <String>]: This indicates any property can be added to this object.
  [AddressPrefix <String>]: The address prefix.
  [EndIPAddress <String>]: The ending IP address.
  [NumberOfAllocatedIPAddresses <Int64?>]: The number of currently allocated IP addresses.
  [NumberOfIPAddresses <Int64?>]: The total number of IP addresses.
  [NumberOfIPAddressesInTransition <Int64?>]: The current number of IP addresses in transition.
  [StartIPAddress <String>]: The starting IP address.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.fabric.admin/new-azsippool
#>
function New-AzsIPPool {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [System.String]
    # IP pool name.
    ${Name},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # Location of the resource.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(Script='-join("System.",(Get-AzLocation)[0].Location)')]
    [System.String]
    # Name of the resource group.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPool]
    # This resource defines the range of IP addresses from which addresses are allocated for nodes within a subnet.
    # To construct, see NOTES section for POOL properties and create a hash table.
    ${Pool},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # The address prefix.
    ${AddressPrefix},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # The ending IP address.
    ${EndIPAddress},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # The region where the resource is located.
    ${Location1},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.Int64]
    # The number of currently allocated IP addresses.
    ${NumberOfAllocatedIPAddress},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.Int64]
    # The total number of IP addresses.
    ${NumberOfIPAddress},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.Int64]
    # The current number of IP addresses in transition.
    ${NumberOfIPAddressesInTransition},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [System.String]
    # The starting IP address.
    ${StartIPAddress},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags]))]
    [System.Collections.Hashtable]
    # List of key-value pairs.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
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
            Create = 'Azs.Fabric.Admin.private\New-AzsIPPool_Create';
            CreateExpanded = 'Azs.Fabric.Admin.private\New-AzsIPPool_CreateExpanded';
        }
        if (('Create', 'CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Create', 'CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('ResourceGroupName')) {
            $PSBoundParameters['ResourceGroupName'] = -join("System.",(Get-AzLocation)[0].Location)
        }
        if (('Create', 'CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
