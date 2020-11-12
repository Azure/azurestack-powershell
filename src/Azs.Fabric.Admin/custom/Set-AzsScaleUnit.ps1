<#
.Synopsis
Set GPU partition size.
.Description
Set GPU partition size.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/azs.fabric.admin/set-azsscaleunit
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.IFabricAdminIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

GPUPARTITIONSIZEPARAMETER [NumberOfGPUPartition <Int32?>]: Number of GPU partitions
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.fabric.admin/set-azsscaleunit
#>
function Set-AzsScaleUnit {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='SetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Path')]
    [System.String]
    # Name of the scale units.
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

    [Parameter(ParameterSetName='SetExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Body')]
    [ValidateSet('1','2','4','8')]
    [System.Int32]
    # Number of GPU partitions
    ${NumberOfGPUPartition},

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

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

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
    ${ProxyUseDefaultCredentials},
	
	[Parameter(Mandatory = $false)]
    [switch]
    $Force
)

process {
        # Generated cmdlet does not support {prefix}/{name} for Gateway name, so extract the {name} part here
        if ($PSBoundParameters.ContainsKey(('Name')))
        {
            if ($null -ne $Name -and $Name.Contains('/'))
            {
                $PSBoundParameters['Name'] = $Name.Split("/")[-1]
            }
        }

        if ($PSCmdlet.ShouldProcess("$Name" , "Set ScaleUnit")) {
            if ($Force.IsPresent -or $PSCmdlet.ShouldContinue("Set GPU partitions for scale unit '$Name'?", "Performing operation Set GPU partitions for $Name")) {

                if ($PSBoundParameters.ContainsKey(('Force'))){
                    $null = $PSBoundParameters.Remove('Force')
                }

                
                $scaleUnit = Get-AzsScaleUnit -Name $Name
                if(-not $scaleUnit)
                {
                    throw "Couldn't find scale unit '$Name'"
                }

                if($scaleUnit.GpuType -ne "GPUP")
                {
                    throw "This operation is not supported for GPU type: " + $scaleUnit.GpuType
                }


                if($scaleUnit.GpuPartitionSize -eq $NumberOfGPUPartition)
                {
                    Write-Host "Number of GPU partitions on '$Name' is already set to $NumberOfGPUPartition."
                    return
                }

                Azs.Fabric.Admin.internal\Set-AzsScaleUnit @PSBoundParameters

            }
        }
    }
}
