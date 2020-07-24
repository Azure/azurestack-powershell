<#
.Synopsis
Apply a specific update at an update location.
.Description
Apply a specific update at an update location.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/azs.update.admin/install-azsupdate
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.IUpdateAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRun
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
https://docs.microsoft.com/en-us/powershell/module/azs.update.admin/install-azsupdate
#>
function Install-AzsUpdate {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRun])]
    [CmdletBinding(DefaultParameterSetName='Apply', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(ParameterSetName='Apply')]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
        [System.String]
        # The name of the update location.
        ${Location},
    
        [Parameter(ParameterSetName='Apply', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Path')]
        [System.String]
        # Name of the update.
        ${Name},
    
        [Parameter(ParameterSetName='Apply')]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.DefaultInfo(Script='-join("System.",(Get-AzLocation)[0].Location)')]
        [System.String]
        # Resource group name.
        ${ResourceGroupName},
    
        [Parameter(ParameterSetName='Apply')]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # Subscription credentials which uniquely identify Microsoft Azure subscription.
        # The subscription ID forms part of the URI for every service call.
        ${SubscriptionId},
    
        [Parameter(ParameterSetName='ApplyViaIdentity', Mandatory, ValueFromPipeline)]
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
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command as a job
        ${AsJob},
        
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        [Parameter(Mandatory = $false)]
        [switch]
        ${Force},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},
    
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
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command asynchronously
        ${NoWait},
    
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
        # Generated SDK does not support {location}/{name} for nested resource name, so extract the {name} part here
        $Name = $null
        # If it is applied via identity
        $parameterSet = $PSCmdlet.ParameterSetName
        if(('ApplyViaIdentity') -contains $parameterSet)
        {
            $Name = $InputObject.Id.Split("/")[-1]
        }
        elseif ($PSBoundParameters.ContainsKey(('Name')))
        {
            $Name = $PSBoundParameters['Name']
            if ($null -ne $Name -and $Name.Contains('/'))
            {
                $PSBoundParameters['Name'] = $Name.Split("/")[-1]
                $Name = $PSBoundParameters['Name']
            }
        }

        if ($Force.IsPresent -or 
        $PsCmdlet.ShouldContinue(
            "Run Test-AzureStack -Group UpdateReadiness to validate the status of your Azure Stack and resolve any operational issues found, including all warnings and failures. Are you sure you want to install update $Name ?",
            "Installing Update $Name"))
        {
            $PSBoundParameters.Remove('Force') | Out-Null
            Azs.Update.Admin.internal\Install-AzsUpdate @PSBoundParameters
        }
    }

}
    