## Admin API Guidance
AzureStack Hub Admin APIs are only for Operators. These APIs are exposed only via Admin AzureStack Hub Resource Manager. For example 'List all the subscriptions in an AzureStack Hub Environment' is an admin API. 

### Developer flow
Here is a recommended flow for developing an Admin API
- Author Open API Spec and make a Pull Request
- Notify azsdevexp alias for review
- The PR is automatically reviewed by azure ARM team and SDK team for compliance
- While the PR is in review, start developing the API. The PR could take more than a month to get it merged.
- Start developing the Admin Powershell for the API from your fork. No need to wait until the Open API Spec PR is merged

Admin powershell is typically shipped within 2 weeks of the product update release.
### Open API spec Authoring

Please look at the [docs](https://github.com/Azure/azure-rest-api-specs/tree/master/documentation) at the azure-rest-api-spec for guidance on authoring Open API Specs

### Admin powershell generation

Please look at the docs [here](https://github.com/Azure/azurestack-powershell/blob/master/docs/getting-started.md) to get started on the powershell generation

### FAQ

1. How to author an ARM API?

Please refer to the ARM guidance [here](https://github.com/Azure/azure-resource-manager-rpc)

2. When does an API need a new api-version?

Any breaking changes needs a new api version. Please refer to the [Breaking Change Policy](http://aka.ms/bcforapi) for detailed instructions on what constitutes as a breaking change

3. Do we need a new api version for adding a new API?

Adding an api to the existing api version is considered as a breaking change and we definitely need a newer api version. All customer environments are not getting the azure stack updates at the same time. Having a new API in the exsting api version will mislead the customer to try the new API in an older stamp which has not been updated. This is a breaking change. Azure Rest API specs team catches the breaking changes in the PR process itself and it will not get merged. 


For any other queries, please reach out to azsdevexp alias or use the Teams [channel](https://aka.ms/azsdevexp)
