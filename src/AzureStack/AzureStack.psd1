#
# Module manifest for module 'AzureStack'
#
# Generated by: Microsoft Corporation
#
# Generated on: 3/22/2018
#

@{

    # Root Module
    # RootModule = ''

    # Version number of this module.
    ModuleVersion          = '2.1.1'

    # Supported PSEditions
    # CompatiblePSEditions = @()

    # ID used to uniquely identify this module
    GUID                   = '65f1e943-5e22-4b21-8350-82c798c958d2'

    # Author of this module
    Author                 = 'Microsoft Corporation'

    # Company or vendor of this module
    CompanyName            = 'Microsoft Corporation'

    # Copyright statement for this module
    Copyright              = 'Microsoft Corporation. All rights reserved.'

    # Description of the functionality provided by this module
    Description            = 'Azure Stack Adminisitration Module'

    # Minimum version of the Windows PowerShell engine required by this module
    PowerShellVersion      = '5.1'

    # Name of the Windows PowerShell host required by this module
    # PowerShellHostName = ''

    # Minimum version of the Windows PowerShell host required by this module
    # PowerShellHostVersion = ''

    # Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
    DotNetFrameworkVersion = '4.7.2'

    # Compatible Powershell Editions
    CompatiblePSEditions = 'Core', 'Desktop'

    # Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
    # CLRVersion             = '4.0'

    # Processor architecture (None, X86, Amd64) required by this module
    # ProcessorArchitecture = ''

    # Modules that must be imported into the global environment prior to importing this module
    ### IMPORTANT - Note that the module names are case sensitive ###
    RequiredModules        = @(@{ModuleName = 'Az.Accounts'; RequiredVersion = '2.2.8'; },
        @{ModuleName = 'Az.Resources'; RequiredVersion = '0.11.0'; },
        @{ModuleName = 'Azs.Azurebridge.Admin'; RequiredVersion = '1.0.1'; },
        @{ModuleName = 'Azs.Backup.Admin'; RequiredVersion = '1.0.1'; },
        @{ModuleName = 'Azs.Commerce.Admin'; RequiredVersion = '1.0.1'; },
        @{ModuleName = 'Azs.Compute.Admin'; RequiredVersion = '1.0.1'; },
        @{ModuleName = 'Azs.Deployment.Admin'; RequiredVersion = '1.0.0'; },
        @{ModuleName = 'Azs.Fabric.Admin'; RequiredVersion = '1.0.1'; },
        @{ModuleName = 'Azs.Gallery.Admin'; RequiredVersion = '1.0.1'; },
        @{ModuleName = 'Azs.Infrastructureinsights.Admin'; RequiredVersion = '1.0.1'; },
        @{ModuleName = 'Azs.Keyvault.Admin'; RequiredVersion = '1.0.1'; },
        @{ModuleName = 'Azs.Network.Admin'; RequiredVersion = '1.0.1'; },
        @{ModuleName = 'Azs.Storage.Admin'; RequiredVersion = '1.0.1'; },
        @{ModuleName = 'Azs.Subscriptions'; RequiredVersion = '1.0.1'; },
        @{ModuleName = 'Azs.Subscriptions.Admin'; RequiredVersion = '1.0.1'; },
        @{ModuleName = 'Azs.Update.Admin'; RequiredVersion = '1.0.1'; },
        @{ModuleName = 'Azs.Syndication.Admin'; RequiredVersion = '0.1.157'; })

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
    FunctionsToExport      = @()

    # Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
    CmdletsToExport        = @()

    # Variables to export from this module
    # VariablesToExport = @()

    # Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
    AliasesToExport        = @()

    # DSC resources to export from this module
    # DscResourcesToExport = @()

    # List of all modules packaged with this module
    # ModuleList = @()

    # List of all files packaged with this module
    # FileList = @()

    # Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
    PrivateData            = @{

        PSData = @{

            # Tags applied to this module. These help with module discovery in online galleries.
            # Tags = @()

            # A URL to the license for this module.
            LicenseUri   = 'https://aka.ms/azsps-license'

            # A URL to the main website for this project.
            ProjectUri   = 'https://github.com/Azure/azurestack-powershell'

            # A URL to an icon representing this module.
            # IconUri = ''

            # ReleaseNotes of this module
            ReleaseNotes = '* Bug fix - Add signing for a file under utils folder in each of the module'

        } # End of PSData hashtable

    } # End of PrivateData hashtable

    # HelpInfo URI of this module
    # HelpInfoURI = ''

    # Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
    # DefaultCommandPrefix = ''

}