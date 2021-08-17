namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Application role assignment definition.</summary>
    public partial class AppRoleAssignmentDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentDefinitionInternal
    {

        /// <summary>Backing field for <see cref="Client" /> property.</summary>
        private string _client;

        /// <summary>
        /// The client identifier. This should be the application identifier of the client application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Client { get => this._client; set => this._client = value; }

        /// <summary>Backing field for <see cref="Resource" /> property.</summary>
        private string _resource;

        /// <summary>
        /// The resource identifier. This should be the application identifier of the resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Resource { get => this._resource; set => this._resource = value; }

        /// <summary>Backing field for <see cref="RoleId" /> property.</summary>
        private string _roleId;

        /// <summary>
        /// The role identifier. This should be the ID of the AppRole exposed by the resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string RoleId { get => this._roleId; set => this._roleId = value; }

        /// <summary>Creates an new <see cref="AppRoleAssignmentDefinition" /> instance.</summary>
        public AppRoleAssignmentDefinition()
        {

        }
    }
    /// Application role assignment definition.
    public partial interface IAppRoleAssignmentDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The client identifier. This should be the application identifier of the client application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The client identifier. This should be the application identifier of the client application.",
        SerializedName = @"client",
        PossibleTypes = new [] { typeof(string) })]
        string Client { get; set; }
        /// <summary>
        /// The resource identifier. This should be the application identifier of the resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource identifier. This should be the application identifier of the resource application.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string Resource { get; set; }
        /// <summary>
        /// The role identifier. This should be the ID of the AppRole exposed by the resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The role identifier. This should be the ID of the AppRole exposed by the resource application.",
        SerializedName = @"roleId",
        PossibleTypes = new [] { typeof(string) })]
        string RoleId { get; set; }

    }
    /// Application role assignment definition.
    internal partial interface IAppRoleAssignmentDefinitionInternal

    {
        /// <summary>
        /// The client identifier. This should be the application identifier of the client application.
        /// </summary>
        string Client { get; set; }
        /// <summary>
        /// The resource identifier. This should be the application identifier of the resource application.
        /// </summary>
        string Resource { get; set; }
        /// <summary>
        /// The role identifier. This should be the ID of the AppRole exposed by the resource application.
        /// </summary>
        string RoleId { get; set; }

    }
}