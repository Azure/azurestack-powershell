<#
.Synopsis
Creates or Updates a Compute Quota with the provided quota parameters.
.Description
Creates or Updates a Compute Quota with the provided quota parameters.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/azs.compute.admin/set-azscomputequota
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuota
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuota
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

NEWQUOTA <IQuota>: Holds Compute quota information used to control resource allocation.
  [Location <String>]: Location of the resource.
  [AvailabilitySetCount <Int32?>]: Maximum number of availability sets allowed.
  [CoresLimit <Int32?>]: Maximum number of cores allowed.
  [PremiumManagedDiskAndSnapshotSize <Int32?>]: Maximum number of managed disks and snapshots of type premium allowed.
  [StandardManagedDiskAndSnapshotSize <Int32?>]: Maximum number of managed disks and snapshots of type standard allowed.
  [VMScaleSetCount <Int32?>]: Maximum number of scale sets allowed.
  [VirtualMachineCount <Int32?>]: Maximum number of virtual machines allowed.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.compute.admin/set-azscomputequota
#>
function Set-AzsComputeQuota {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuota])]
[CmdletBinding(DefaultParameterSetName='Update', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials that uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuota]
    # Holds Compute quota information used to control resource allocation.
    # To construct, see NOTES section for NEWQUOTA properties and create a hash table.
    ${NewQuota},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

    process {
        # Pipeline feature broken in autorest generated cmdlet 
        # Name is a mandatory parameter along with the pipeline object
        # Getting this parameter from the pipeline object
        if ($null -ne $NewQuota.Name)
        {
            $name = $NewQuota.Name
            if ($name.Contains('/')) { $name = $name.split('/')[-1] }
            $PSBoundParameters.Add('Name', $name)
        }
        if ($null -ne $NewQuota.Location)
        {
            $PSBoundParameters.Add('Location', $NewQuota.Location)
        }
        Azs.Compute.Admin.internal\Set-AzsComputeQuota @PSBoundParameters
    }

}
