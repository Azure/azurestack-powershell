
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
Get a list of all load balancers.
.Description
Get a list of all load balancers.
.Example
PS C:\> Get-AzsLoadBalancer

Id                : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/resourceGroups/AppServiceLH01/providers/Microsoft.Network/loadBalancers/aps-sql-lb
Location          : 
Name              : aps-sql-lb
ProvisioningState : Succeeded
PublicIPAddress   : {}
SubscriptionId    : 3ff3b1de-e7f5-43ad-b057-ace4767e7d01
Tag               : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/resourceGroups/AppServiceLH01/providers/Microsoft.Network/loadBalancers/aps-sql-lb
Type              : Microsoft.Network.Admin/adminLoadBalancers

Id                : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/resourceGroups/AppServiceLH01/providers/Microsoft.Network/loadBalancers/FrontEndServersLoadBalanc
                    er
Location          : 
Name              : FrontEndServersLoadBalancer
ProvisioningState : Succeeded
PublicIPAddress   : {100.81.128.40}
SubscriptionId    : 3ff3b1de-e7f5-43ad-b057-ace4767e7d01
Tag               : Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTags
TenantResourceUri : /subscriptions/3ff3b1de-e7f5-43ad-b057-ace4767e7d01/resourceGroups/AppServiceLH01/providers/Microsoft.Network/loadBalancers/FrontEndServersLoadBalanc
                    er
Type              : Microsoft.Network.Admin/adminLoadBalancers

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILoadBalancer
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.network.admin/get-azsloadbalancer
#>
function Get-AzsLoadBalancer {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILoadBalancer])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Query')]
    [System.String]
    # OData filter parameter.
    ${Filter},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Query')]
    [System.String]
    # OData inline count parameter.
    ${InlineCount},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Query')]
    [System.String]
    # OData orderBy parameter.
    ${OrderBy},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Query')]
    [System.String]
    # OData skip parameter.
    ${Skip},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Query')]
    [System.String]
    # OData top parameter.
    ${Top},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Runtime')]
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
            List = 'Azs.Network.Admin.private\Get-AzsLoadBalancer_List';
        }
        if (('List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
