# Azure PowerShell AutoRest Configuration

> Values
``` yaml
azure: true
powershell: true
branch: stackadmin
repo: https://github.com/Azure/azure-rest-api-specs/tree/$(branch)
metadata:
  authors: Microsoft Corporation
  owners: Microsoft Corporation
  copyright: Microsoft Corporation. All rights reserved.
  tags: AzureStack ResourceManager ARM PSModule
  companyName: Microsoft Corporation
  requireLicenseAcceptance: true
  licenseUri: https://aka.ms/azps-license
  projectUri: https://github.com/Azure/azurestack-powershell
```

> Names
``` yaml
prefix: Azs
namespace: Microsoft.Azure.PowerShell.Cmdlets.$(service-name)
identity-correction-for-post: true
```

> Folders
``` yaml
clear-output-folder: true
output-folder: .
```

> Directives
``` yaml
# PSD1 Changes for preview module
  - from: source-file-csharp
    where: $
    transform: $ = $.replace('sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}Prerelease = \{previewVersion\}\"\);', 'sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}Prerelease = \'\{previewVersion\}\'\"\);' );

```