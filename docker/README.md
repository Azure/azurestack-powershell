# Docker


## Overview
These Dockerfiles enable executing AzureStack PowerShell cmdlets in a container for the supported OS.  
The container images also include support for AzureStack release 2002+ by including AzureStack Admin Modules and AzureStack Tools.

## Configuration
This image requires Docker 17.05 or newer.

It is also expected that you are able to run Docker without `sudo`.
Please follow [Docker's official instructions][install] to install `docker` correctly.

[install]: https://docs.docker.com/engine/installation/


## Release

The release containers derive from the [Powershell image][powershell image], and then install the current Az package. Starting with Az 3.6.1 the images are using PowerShell 7, the previous versions are using PowerShell 6.2.4.

[powershell image]: https://hub.docker.com/_/microsoft-powershell

AzureStack PowerShell [release notes](https://aka.ms/azspsdockerreadme)

## Examples 

### Download/Update the AzureStack Powershell image

You may replace the tag part after the colon with the tag you want.

```sh
docker pull mcr.microsoft.com/azurestack/powershell
```

### Run AzureStack Powershell container 

- To run AzureStack Powershell in a container in an interactive mode:

```sh
$ docker run -it mcr.microsoft.com/azurestack/powershell:0.1.0-ubuntu-18.04 pwsh 
```

- To run AzureStack Powershell in a container:

```sh
$ docker start -ia mcr.microsoft.com/azurestack/powershell:0.1.0-ubuntu-18.04 pwsh 
```

- To run AzureStack Powershell from using a container in an interactive mode using host authentication: 

    1. Make sure that `$HOME/.Azure` is present on the host (default location).
    2. You may need to grant access this location for the docker process.

```sh
$ docker run -it -v ~/.Azure/AzureRmContext.json:/root/.Azure/AzureRmContext.json -v ~/.Azure/TokenCache.dat:/root/.Azure/TokenCache.dat mcr.microsoft.com/azurestack/powershell pwsh 
```

Verify the host authentication:

```sh
docker run -it --rm -v ~/.Azure/AzureRmContext.json:/root/.Azure/AzureRmContext.json -v ~/.Azure/TokenCache.dat:/root/.Azure/TokenCache.dat mcr.microsoft.com/azurestack/powershell pwsh -c Get-AzContext
```

### Remove image

```sh
docker rmi mcr.microsoft.com/azurestack/powershell
```

### Testing

1. Run Login-Environment.ps1 to create an environment and connect your AzureStack account to it.  

Login using credentials:  
```sh
./Login-Environment.ps1 
[-Name <String>]  
-ResourceManagerEndpoint <System.Uri>  
-DirectoryTenantId <String>  
-Credential <PSCredential>  
[-SubscriptionId <String>]
```
Login using certificates:  
```sh
./Login-Environment.ps1  
[-Name <String>]  
-ResourceManagerEndpoint <System.Uri>  
-DirectoryTenantId <String>  
-ApplicationId <String>  
-CertificateThumbprint <String>  
[-SubscriptionId <String>]
```

2. Run New-AzureStackTestResources.ps1 to create required resources for running the tests.  

If the $Location parameter is not passed, it will look use $ENV:Location.  
```sh
./New-AzureStackTestResources.ps1  
[-Location <String>]  
```
3. Run Test-AzureStack.ps1 to run the tests.  

If the $ClientObjectId parameter is not passed, it will use $ENV:ClientObjectId.  
```sh
./Test-AzureStack.ps1  
[-ClientObjectId <String>]  
```

## Developing and Contributing

Please see the [Contribution Guide][] for general information about how to develop and contribute.

If you have any problems, please consult the [GitHub issues][].
If you do not see your problem captured, please file a [new issue][] and follow the provided template.

[Contribution Guide]: https://github.com/Azure/azure-powershell/blob/master/CONTRIBUTING.md
[GitHub issues]: https://github.com/Azure/azure-powershell/issues
[new issue]:https://aka.ms/azpsissue


## Legal and Licensing

AzureStack PowerShell is licensed under the [Apache license][].

[Apache license]: https://github.com/Azure/azurestack-powershell/blob/master/LICENSE


PowerShell is licensed under the [MIT license][].

[MIT license]: https://github.com/Azure/azurestack-powershell/blob/master/LICENSE

## [Code of Conduct][conduct-md]

This project has adopted the [Microsoft Open Source Code of Conduct][conduct-code].
For more information see the [Code of Conduct FAQ][conduct-FAQ] or contact [opencode@microsoft.com][conduct-email] with any additional questions or comments.

[conduct-code]: http://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: http://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
