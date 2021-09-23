
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
Create or update an existing container registry quota.
.Description
Create or update an existing container registry quota.
.Example
PS C:\> Set-AzsContainerRegistryQuota -QuotaName testquota -CapacityPerRegistryInGib 30 -NumberOfRegistries 30 | ConvertTo-Json

{
    "CapacityPerRegistryInGiB":  30,
    "Id":  "/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Admin/locations/redmond/quotas/testquota",
    "Name":  "redmond/testquota",
    "NumberOfRegistries":  30,
    "Type":  "Microsoft.ContainerRegistry.Admin/locations/quotas"
}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.Api20191101Preview.IContainerRegistryQuota
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.Api20191101Preview.IContainerRegistryQuota
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

QUOTAOBJECT <IContainerRegistryQuota>: Container registry quota.
  [CapacityPerRegistryInGiB <Int32?>]: Storage capacity (GiB) of each registry.
  [NumberOfRegistries <Int32?>]: Total number of container registry accounts.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.containerregistry.admin/set-azscontainerregistryquota
#>
function Set-AzsContainerRegistryQuota {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.Api20191101Preview.IContainerRegistryQuota])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('QuotaName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Path')]
    [System.String]
    # The name of the container registry quota.
    ${Name},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # The name of Azure region.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Update', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.Api20191101Preview.IContainerRegistryQuota]
    # Container registry quota.
    # To construct, see NOTES section for QUOTAOBJECT properties and create a hash table.
    ${QuotaObject},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Body')]
    [System.Int32]
    # Storage capacity (GiB) of each registry.
    ${CapacityPerRegistryInGiB},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Body')]
    [System.Int32]
    # Total number of container registry accounts.
    ${NumberOfRegistries},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Runtime')]
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
            Update = 'Azs.ContainerRegistry.Admin.private\Set-AzsContainerRegistryQuota_Update';
            UpdateExpanded = 'Azs.ContainerRegistry.Admin.private\Set-AzsContainerRegistryQuota_UpdateExpanded';
        }
        if (('Update', 'UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Update', 'UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
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
        $quotaName = $Name
    
        if ('QuotaObject' -eq $PsCmdlet.ParameterSetName) {
            $quotaName = $QuotaObject.Name
        }
    
        if ($null -ne $quotaName -and $quotaName.Contains('/')) {
            $quotaName = $quotaName.Split("/")[-1]
        }
    
        if ('QuotaObject' -eq $PsCmdlet.ParameterSetName) {
            if ($PSBoundParameters.ContainsKey('CapacityPerRegistryInGiB')) {
                $QuotaObject.CapacityPerRegistryInGiB = $CapacityPerRegistryInGiB
                $null = $PSBoundParameters.Remove('CapacityPerRegistryInGiB')
            }
    
            if ($PSBoundParameters.ContainsKey('NumberOfRegistries')) {
                $QuotaObject.NumberOfRegistries = $NumberOfRegistries
                $null = $PSBoundParameters.Remove('NumberOfRegistries')
            }
    
            $PSBoundParameters['QuotaObject'] = $QuotaObject
        }
        else {
            $params = @{}

            if ($PSBoundParameters.ContainsKey('Location')) {
                $params.Add('Location', $Location)
            }
            if ($PSBoundParameters.ContainsKey('SubscriptionId')) {
                $params.Add('SubscriptionId', $SubscriptionId)
            }
            
            $quota = Get-AzsContainerRegistryQuota -Name $quotaName -ErrorAction SilentlyContinue @params
            
            if (-not $PSBoundParameters.ContainsKey('CapacityPerRegistryInGiB')) {
                $PSBoundParameters['CapacityPerRegistryInGiB'] = $quota.CapacityPerRegistryInGiB
            }
    
            if (-not $PSBoundParameters.ContainsKey('NumberOfRegistries')) {
                $PSBoundParameters['NumberOfRegistries'] = $quota.NumberOfRegistries
            }
        }
    
        $PSBoundParameters['Name'] = $quotaName
    
        Azs.ContainerRegistry.Admin.internal\Set-AzsContainerRegistryQuota @PSBoundParameters
    }
}
