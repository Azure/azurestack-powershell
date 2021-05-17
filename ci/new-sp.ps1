# WARNING: Don't run this script if the service principal named "Azs-SDK-agents-SP" already exists and works.
# Otherwise you will need to set the new service principal client Id in the Azure Devops pipeline variables.
# Run this script to create a service principal named "Azs-SDK-agents-SP".

. $PSScriptRoot/common.ps1

New-AzsSPSecret -ServicePrincipalName "Azs-SDK-agents-SP"