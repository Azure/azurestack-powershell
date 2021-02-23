# Docker


## Overview
These Dockerfiles create containers suitable for running github actions agents against AzureStack

## Configuration
This image requires Docker 17.05 or newer.

It is also expected that you are able to run Docker without `sudo`.
Please follow [Docker's official instructions][install] to install `docker` correctly.
[install]: https://docs.docker.com/engine/installation/


## Release
The release containers derive from the [Powershell image][powershell image], and then install the current Az package.
[powershell image]: https://hub.docker.com/_/microsoft-powershell

## Build
```
# go one directory up and run the below cmd from docker folder
docker build -f .\githubactions\Dockerfile-gha-ubuntu-18.04 --build-arg VERSION=0.2002.0 --build-arg AZURESTACK_VERSION=2.0.2-preview .
```

## Configuring github actions agent in AzureStack
```
# create a vm, add DockerExtension
az vm create --resource-group "test" --name "testVM" --image "UbuntuLTS" --admin-username "demouser" --admin-password "demouser@111" --location "local"
az vm extension set -n DockerExtension --publisher Microsoft.Azure.Extensions --vm-name testVM -g test
# ssh to created vm and pull docker image
docker pull mcr.microsoft.com/azurestack/powershell:<tag>
docker run -it mcr.microsoft.com/azurestack/powershell:0.1.0-ubuntu-18.04
# configure github actions agent (get token from the github repo settings)
cd ./root/actions-runner
./config.cmd --url https://github.com/azure/azurestack-powershell --token <REDACTED>
./run.sh
```