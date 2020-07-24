<#
.Synopsis
Create or update a quota.
.Description
Create or update a quota.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/azs.network.admin/set-azsnetworkquota
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

QUOTA <IQuota>: Network quota resource.
  [Tag <IResourceTags>]: List of key value pairs.
    [(Any) <String>]: This indicates any property can be added to this object.
  [MaxLoadBalancersPerSubscription <Int64?>]: Maximum number of load balancers a tenant subscription can provision.
  [MaxNicsPerSubscription <Int64?>]: Maximum number of NICs a tenant subscription can provision.
  [MaxPublicIpsPerSubscription <Int64?>]: Maximum number of public IP addresses a tenant subscription can provision.
  [MaxSecurityGroupsPerSubscription <Int64?>]: Maximum number of security groups a tenant subscription can provision.
  [MaxVirtualNetworkGatewayConnectionsPerSubscription <Int64?>]: Maximum number of virtual network gateway Connections a tenant subscription can provision.
  [MaxVirtualNetworkGatewaysPerSubscription <Int64?>]: Maximum number of virtual network gateways a tenant subscription can provision.
  [MaxVnetsPerSubscription <Int64?>]: Maximum number of virtual networks a tenant subscription can provision.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.network.admin/set-azsnetworkquota
#>
function Set-AzsNetworkQuota {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota])]
[CmdletBinding(DefaultParameterSetName='Update', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota]
    # Network quota resource.
    # To construct, see NOTES section for QUOTA properties and create a hash table.
    ${Quota},

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

    process {
        # Pipeline feature broken in autorest generated cmdlet 
        # Name is a mandatory parameter along with the pipeline object
        # Getting this parameter from the pipeline object
        if ($null -ne $Quota.Name)
        {
            $name = $Quota.Name
            if ($name.Contains('/')) { $name = $name.split('/')[-1] }
            $PSBoundParameters.Add('Name', $name)
        }
        if ($null -ne $Quota.Location)
        {
            $PSBoundParameters.Add('Location', $Quota.Location)
        }
        Azs.Network.Admin.internal\Set-AzsNetworkQuota @PSBoundParameters
    }

}
