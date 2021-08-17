namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Application permission grant definition.</summary>
    public partial class OAuth2PermissionGrantDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantDefinitionInternal
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

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string _scope;

        /// <summary>
        /// The scope identifier. This should be the scope value of the OAUTH2PERMISSION exposed by the resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Scope { get => this._scope; set => this._scope = value; }

        /// <summary>Creates an new <see cref="OAuth2PermissionGrantDefinition" /> instance.</summary>
        public OAuth2PermissionGrantDefinition()
        {

        }
    }
    /// Application permission grant definition.
    public partial interface IOAuth2PermissionGrantDefinition :
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
        /// The scope identifier. This should be the scope value of the OAUTH2PERMISSION exposed by the resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scope identifier. This should be the scope value of the OAUTH2PERMISSION exposed by the resource application.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get; set; }

    }
    /// Application permission grant definition.
    internal partial interface IOAuth2PermissionGrantDefinitionInternal

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
        /// The scope identifier. This should be the scope value of the OAUTH2PERMISSION exposed by the resource application.
        /// </summary>
        string Scope { get; set; }

    }
}