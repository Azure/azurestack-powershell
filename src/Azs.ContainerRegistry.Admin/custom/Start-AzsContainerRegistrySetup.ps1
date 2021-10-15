
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
Invokes container registry certificate uploading and service deployment.
.Description
Invokes container registry certificate uploading and service deployment.
.Example
PS C:\> Start-AzsContainerRegistrySetup -Password $password -CertificateInputFile $pfx_cert_path | ConvertTo-Json

{
    "Id":  "/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Setup/locations/redmond/setup/value",
    "Name":  "redmond/value",
    "StatusUri":  "https://containerregistrysetup.ascu.azs:4335/providers/Microsoft.ContainerRegistry.Setup/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Setup/locations/redmond/setup?api-version=2019-11-01-preview",
    "Type":  "Microsoft.ContainerRegistry.Setup/locations/setup"
}
.Example
PS C:\> Start-AzsContainerRegistrySetup -Password $password -CertificateInputFile $pfx_cert_path | ConvertTo-Json

Start-AzsContainerRegistrySetup : Container registry deployment is still running. It is not allowed to repeat deployment at this stage.
At line:1 char:1
+ Start-AzsContainerRegistrySetup -Password $password -CertificateInputFile ...
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : InvalidOperation: ({ SubscriptionI...SetupProperty }:<>f__AnonymousType7`3) [Start-AzsContai...p_StartExpanded], Exception
    + FullyQualifiedErrorId : AcrDeploymentStillRunning,Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Cmdlets.StartAzsContainerRegistrySetup_StartExpanded

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.Api20191101Preview.IContainerRegistrySetupProperty
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.IContainerRegistryAdminIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.Api20191101Preview.IContainerRegistrySetup
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IContainerRegistryAdminIdentity>: Identity Parameter
  [CapacityName <String>]: The name of the capacity parameter.
  [ConfigurationName <String>]: The name of the configuration.
  [Id <String>]: Resource identity path
  [Location <String>]: The name of Azure region.
  [QuotaName <String>]: The name of the container registry quota.
  [SubscriptionId <String>]: The ID of the target subscription.

STARTSETUPREQUEST <IContainerRegistrySetupProperty>: Container registry setup properties.
  [Password <SecureString>]: Ssl certificate password.
  [SslCertBase64 <Byte[]>]: Ssl certificate in base64 format.
.Link
https://docs.microsoft.com/en-us/powershell/module/azs.containerregistry.admin/start-azscontainerregistrysetup
#>
function Start-AzsContainerRegistrySetup {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.Api20191101Preview.IContainerRegistrySetup])]
[CmdletBinding(DefaultParameterSetName='StartExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Start')]
    [Parameter(ParameterSetName='StartExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Runtime.DefaultInfo(Script='(Get-AzLocation)[0].Location')]
    [System.String]
    # The name of Azure region.
    ${Location},

    [Parameter(ParameterSetName='Start')]
    [Parameter(ParameterSetName='StartExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='StartViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='StartViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.IContainerRegistryAdminIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Start', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='StartViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.Api20191101Preview.IContainerRegistrySetupProperty]
    # Container registry setup properties.
    # To construct, see NOTES section for STARTSETUPREQUEST properties and create a hash table.
    ${StartSetupRequest},

    [Parameter(ParameterSetName='StartExpanded')]
    [Parameter(ParameterSetName='StartViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Body')]
    [System.String]
    # Input File for Certificate (Ssl certificate in base64 format.)
    ${CertificateInputFile},

    [Parameter(ParameterSetName='StartExpanded')]
    [Parameter(ParameterSetName='StartViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Category('Body')]
    [System.Security.SecureString]
    # Ssl certificate password.
    ${Password},

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
            Start = 'Azs.ContainerRegistry.Admin.private\Start-AzsContainerRegistrySetup_Start';
            StartExpanded = 'Azs.ContainerRegistry.Admin.private\Start-AzsContainerRegistrySetup_StartExpanded';
            StartViaIdentity = 'Azs.ContainerRegistry.Admin.private\Start-AzsContainerRegistrySetup_StartViaIdentity';
            StartViaIdentityExpanded = 'Azs.ContainerRegistry.Admin.private\Start-AzsContainerRegistrySetup_StartViaIdentityExpanded';
        }
        if (('Start', 'StartExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Location')) {
            $PSBoundParameters['Location'] = (Get-AzLocation)[0].Location
        }
        if (('Start', 'StartExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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

    # Basic validation should be present in powershell for PFX file
    if ($PSBoundParameters.ContainsKey(('CertificateInputFile')))
    {
        if (!(Test-Path -Path $CertificateInputFile -PathType Leaf))
        {
            throw "The specified ssl cert $CertificateInputFile does not exist."
        }

        if ([IO.Path]::GetExtension($CertificateInputFile) -ne ".pfx" )
        {
            throw "The specified file $CertificateInputFile is not cert with private key."
        }
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
