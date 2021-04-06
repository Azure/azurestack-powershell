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

AzureStack PowerShell [release notes](https://aka.ms/azspsdocker)

## Building Dockerfiles

Using `Dockerfile-ubuntu-18.04` as an example, here is the command to build the docker file and at the same time tagging it `mcr.microsoft.com/powershell:ubuntu-18.04`:

```sh
docker build -f .\Dockerfile-ubuntu-18.04 -t mcr.microsoft.com/powershell:ubuntu-18.04 .
```

Tagging images is useful for organizing your images. It is currently not possible to tag docker images within a dockerfile, so you will have to tag your image manually after its creation:

```sh
docker tag <image id> mcr.microsoft.com/powershell:ubuntu-18.04
```

`WARNING`: docker builds seem to break very easily. If it fails at first, try building it several times from a clean state. The `--no-cache` option ensures a clean build that doesn't use cached steps:

```sh
docker build -f .\Dockerfile-debian-9 -t mcr.microsoft.com/powershell:ubuntu-18.04 . --no-cache
```

## Examples 

### Download/Update the AzureStack Powershell image

You may replace the tag part after the colon with the tag of the image OS you want, e.g., 0.1.0-ubuntu-18.04.

```sh
docker pull mcr.microsoft.com/azurestack/powershell:<tag>
```

### Run AzureStack Powershell container 

- To run a new container with AzureStack resources from a docker image with Powershell Core as the interactive command interface:

```sh
$ docker run -it mcr.microsoft.com/azurestack/powershell:0.1.0-ubuntu-18.04 pwsh 
```

- To start an existing container containing AzureStack resources with Powershell Core as the interactive command interface:

```sh
$ docker start -ia mcr.microsoft.com/azurestack/powershell:0.1.0-ubuntu-18.04 pwsh 
```

- To run a container containing AzureStack resources from a docker image in an interactive Powershell Core interface using host authentication: 

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
docker rmi <image id>
```

### Testing

1. Run Login-Environment.ps1 to create an environment and connect your AzureStack account to it.  

Note: The default value for parameters are set in the environment variables of the containers using a docker command when first running the container such as in the following docker command:
```
docker run 
-e "Location=<LOCATION>" 
-e "ClientObjectId=<CLIENT_OBJECT_ID>" 
-it <IMAGE_URL>:<IMAGE_TAG>
```
Login using credentials:  
```sh
./Login-Environment.ps1 
[-EnvironmentName <String>]  # Defaults to 'AzureStack'
-ResourceManagerEndpoint <System.Uri>  
-TenantId <String>  
-Credential <PSCredential>  
[-SubscriptionId <String>]
```
Login using certificates:  
```sh
./Login-Environment.ps1  
[-EnvironmentName <String>]  # Defaults to 'AzureStack'
-ResourceManagerEndpoint <System.Uri>  
-TenantId <String>  
-ApplicationId <String>  
-CertificateThumbprint <String>  
[-SubscriptionId <String>]
```

2. Run New-AzureStackTestResources.ps1 to create required resources for running the tests.  

```sh
./New-AzureStackTestResources.ps1  
[-Location <String>]  # Defaults to $ENV:Location
```
3. Run Test-AzsPowershell.ps1 to run the tests.  


```sh
./Test-AzsPowershell.ps1  
[-ClientObjectId <String>]  # Defaults to $ENV:ClientObjectId
[-Location <String>]  # Defaults to $ENV:Location
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
