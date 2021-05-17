# Azure Stack SDK Pipeline
This repository is for files used in running Azure Stack SDK tests in an Azure Devops pipeline.

# Configure the Pipeline
## Agent Pools and Service Connection
This step requires a machine or VM with access to a self-hosted Azure Stack environment.
1. In your VM, run the `setup-test.ps1` script.
1. In Azure Devops, click on your organization and then your project. The link should look like this:
    ```
    https://dev.azure.com/{ORGANIZATION}/{PROJECT}/
    ```
1. Go to `Project Settings` on the bottom of the left navigator and then `Service Connection` under `Pipelines` section. You should be at the following location:
    ```
    https://dev.azure.com/{ORGANIZATION}/{PROJECT}/_settings/adminservices
    ```
1. Click on `Agent pools` > `Add pool`. For `Pool type`, select `Self-hosted`, then enter a name for the pool and then click `create`.
1. Click on your new agent pool, then select `New agent`.
1. Follow the pop-up screen to complete the set-up of your new agent.
1. Click on `New Service Connection` > Select `Azure Resource Manager` > `Service principal (manual)`.
1. Enter the following for the values:
    - Environment: Select `Azure Stack` from drop-down list.
    - Server Url: Enter the Resource Manager Url for your Azure Stack environment.
    - Scope Level: Select `Subscription`.
    - Subscription Id: Select a subscription Id from your Azure Stack environment.
    - Subscription Name: Select a subscription name from your Azure Stack environment.
    - Service Principal Id: Enter the Application Id associated with your service principal.
    - Credential: Select either `Service Principal Key` or `Certificate` and then enter either one of them in the following field.
    - Tenant Id: Enter the tenant Id for the Azure Stack environment.
    - Service Connection Name: Enter a service connection name.
1. You can try verifying the connection by clicking the `Verify` button, but it may fail since Azure Stack is not well supported. If it shows an error, the service connection might still work regardless of the error. Instead of clicking `Verify and save`, click the drop-down arrow and click `Save without verification`.

## Environment Setup
1. To install software required for the environment, run the `tool\setup-environment.ps1` script manually on the agent. 

## Running Tests
1. To run the test, simply run the script `run-test.ps1` with the following parameters:
    ```powershell
    .\run-test.ps1 -Type <# Allowed test types: "cli", "dotnet", "golang", "java", "javascript", "powershell", "python" #> `
        -EnvironmentName "{Azure Stack environment name}" `
        -TenantName "{Azure Stack environment tenant name}" `
        -ResourceManagerUrl "{Azure Stack environment resource manager url}" `
        -ServicePrincipalClientId "{Id for service principal with owner role}" `
        -ServicePrincipalClientSecret (ConvertTo-SecureString -String "{Secret for service principal with owner role}" -AsPlainText -Force) `
        -SubscriptionName "{Subscription name or 'Default Provider Subscription' for the default subscription}"
    ```