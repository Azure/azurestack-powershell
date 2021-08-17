namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The resource provider authorization information.</summary>
    public partial class ResourceProviderAuthorization :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderAuthorization,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderAuthorizationInternal
    {

        /// <summary>Backing field for <see cref="ApplicationId" /> property.</summary>
        private string _applicationId;

        /// <summary>The application id of resource provider in AAD.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string ApplicationId { get => this._applicationId; set => this._applicationId = value; }

        /// <summary>Backing field for <see cref="RoleDefinitionId" /> property.</summary>
        private string _roleDefinitionId;

        /// <summary>The role definition identifier against which a role assignment is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string RoleDefinitionId { get => this._roleDefinitionId; set => this._roleDefinitionId = value; }

        /// <summary>Creates an new <see cref="ResourceProviderAuthorization" /> instance.</summary>
        public ResourceProviderAuthorization()
        {

        }
    }
    /// The resource provider authorization information.
    public partial interface IResourceProviderAuthorization :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The application id of resource provider in AAD.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The application id of resource provider in AAD.",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationId { get; set; }
        /// <summary>The role definition identifier against which a role assignment is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The role definition identifier against which a role assignment is created.",
        SerializedName = @"roleDefinitionId",
        PossibleTypes = new [] { typeof(string) })]
        string RoleDefinitionId { get; set; }

    }
    /// The resource provider authorization information.
    internal partial interface IResourceProviderAuthorizationInternal

    {
        /// <summary>The application id of resource provider in AAD.</summary>
        string ApplicationId { get; set; }
        /// <summary>The role definition identifier against which a role assignment is created.</summary>
        string RoleDefinitionId { get; set; }

    }
}