# Copyright (c) Microsoft Corporation. All rights reserved.

<#
.SYNOPSIS
    Initializes the Azure PowerShell environment for use with an Azure Stack Environment.
#>
[CmdletBinding(DefaultParameterSetName='UserCredential')]
param
(
    [Parameter(Mandatory=$false)]
    [ValidateNotNullOrEmpty()]
    [string] $Name = 'AzureStack',

    [Parameter(Mandatory=$true)]
    [ValidateNotNull()]
    [ValidateScript({ $_.Scheme -eq [System.Uri]::UriSchemeHttps })]
    [System.Uri] $ResourceManagerEndpoint,

    [Parameter(Mandatory=$true)]
    [ValidateNotNullOrEmpty()]
    [string] $DirectoryTenantId,

    [Parameter(Mandatory=$true, ParameterSetName='UserCredential')]
    [ValidateNotNull()]
    [PSCredential] $Credential,

    [Parameter(Mandatory=$true, ParameterSetName='ServicePrincipal')]
    [ValidateNotNullOrEmpty()]
    [string] $ApplicationId,

    [Parameter(Mandatory=$true, ParameterSetName='ServicePrincipal')]
    [ValidateNotNullOrEmpty()]
    [ValidatePattern('^([0-9A-Fa-f]{2})*$')]
    [string] $CertificateThumbprint,

    # Optional subscription to select as the active / default subscription.
    [Parameter(Mandatory=$false)]
    [ValidateNotNullOrEmpty()]
    [string] $SubscriptionId
)

if (($azureEnvironment = Get-AzEnvironment | Where Name -EQ $Name))
{
    Write-Verbose -Message "Azure Environment '$Name' already initialized" -Verbose
}
else
{
    $azureEnvironment = Add-AzEnvironment -Name $Name -ARMEndpoint $ResourceManagerEndpoint -ErrorAction Stop
    $azureEnvironment = Get-AzEnvironment $Name -ErrorAction Stop
    write-Verbose -Message "Added Azure Environment: $($azureEnvironment | out-string)" -Verbose
}

$azureAccountParams = @{
    Environment = $Name
    TenantId    = $DirectoryTenantId
    ServicePrincipal = $true
}

if ($Credential)
{
    $azureAccountParams += @{ 
        Credential = $Credential 
    }
}
else
{
    $azureAccountParams += @{
        ApplicationId         = $ApplicationId
        CertificateThumbprint = $CertificateThumbprint
    }
}

Login-AzAccount @azureAccountParams -Verbose -ErrorAction Stop | Out-Null

if ($SubscriptionId)
{
    $subscription = Select-AzSubscription -SubscriptionId $SubscriptionId -TenantId $DirectoryTenantId -Verbose -ErrorAction Stop
    Write-Verbose "Using account: $($subscription | out-string)" -Verbose
}
else
{
    Write-Verbose "Using account: $(Get-AzContext | out-string)" -Verbose
}
