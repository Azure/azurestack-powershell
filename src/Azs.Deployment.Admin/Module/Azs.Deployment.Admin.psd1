#-----------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
#-----------------------------------------------------------------------

# How to Write a PowerShell Module Manifest
# https://docs.microsoft.com/en-us/powershell/developer/module/how-to-write-a-powershell-module-manifest

@{

# Script module or binary module file associated with this manifest.
RootModule = 'Azs.Deployment.Admin.psm1'

# Version number of this module.
ModuleVersion = '0.9.0'

# ID used to uniquely identify this module
GUID = 'a50d2cce-63a7-4c7b-980f-c4cead941544'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft AzureStack Hub PowerShell: Deployment Admin cmdlets'

# Minimum version of the Windows PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the Windows PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the Windows PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Compatible Powershell Editions
CompatiblePSEditions = 'Core', 'Desktop'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.0.1'; }, @{ModuleName = 'Az.Resources'; RequiredVersion = '0.10.0'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = '*'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = '*'

# Variables to export from this module
VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{      
    Prerelease = preview
    Tags = 'AzureStack', 'ResourceManager', 'ARM', 'PSModule', 'DeploymentResourceProvider'
    LicenseUri = 'https://aka.ms/azps-license'
    ProjectUri = 'https://github.com/Azure/azurestack-powershell'
    ReleaseNotes = 'AzureStack Hub Admin module - see https://aka.ms/azpshmigration for breaking changes'
}

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}
