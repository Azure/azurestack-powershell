namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>A report of the health status of an OAuth2PermissionGrant.</summary>
    public partial class OAuth2PermissionGrantHealthReport :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReport,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReportInternal
    {

        /// <summary>Internal Acessors for OAuth2PermissionGrant</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantDefinition Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReportInternal.OAuth2PermissionGrant { get => (this._oAuth2PermissionGrant = this._oAuth2PermissionGrant ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.OAuth2PermissionGrantDefinition()); set { {_oAuth2PermissionGrant = value;} } }

        /// <summary>Backing field for <see cref="OAuth2PermissionGrant" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantDefinition _oAuth2PermissionGrant;

        /// <summary>The permission description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantDefinition OAuth2PermissionGrant { get => (this._oAuth2PermissionGrant = this._oAuth2PermissionGrant ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.OAuth2PermissionGrantDefinition()); set => this._oAuth2PermissionGrant = value; }

        /// <summary>
        /// The client identifier. This should be the application identifier of the client application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string OAuth2PermissionGrantClient { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantDefinitionInternal)OAuth2PermissionGrant).Client; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantDefinitionInternal)OAuth2PermissionGrant).Client = value ?? null; }

        /// <summary>
        /// The resource identifier. This should be the application identifier of the resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string OAuth2PermissionGrantResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantDefinitionInternal)OAuth2PermissionGrant).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantDefinitionInternal)OAuth2PermissionGrant).Resource = value ?? null; }

        /// <summary>
        /// The scope identifier. This should be the scope value of the OAUTH2PERMISSION exposed by the resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string OAuth2PermissionGrantScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantDefinitionInternal)OAuth2PermissionGrant).Scope; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantDefinitionInternal)OAuth2PermissionGrant).Scope = value ?? null; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? _status;

        /// <summary>The health status for the permission.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="OAuth2PermissionGrantHealthReport" /> instance.</summary>
        public OAuth2PermissionGrantHealthReport()
        {

        }
    }
    /// A report of the health status of an OAuth2PermissionGrant.
    public partial interface IOAuth2PermissionGrantHealthReport :
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
        string OAuth2PermissionGrantClient { get; set; }
        /// <summary>
        /// The resource identifier. This should be the application identifier of the resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource identifier. This should be the application identifier of the resource application.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string OAuth2PermissionGrantResource { get; set; }
        /// <summary>
        /// The scope identifier. This should be the scope value of the OAUTH2PERMISSION exposed by the resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scope identifier. This should be the scope value of the OAUTH2PERMISSION exposed by the resource application.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string OAuth2PermissionGrantScope { get; set; }
        /// <summary>The health status for the permission.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The health status for the permission.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get; set; }

    }
    /// A report of the health status of an OAuth2PermissionGrant.
    internal partial interface IOAuth2PermissionGrantHealthReportInternal

    {
        /// <summary>The permission description.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantDefinition OAuth2PermissionGrant { get; set; }
        /// <summary>
        /// The client identifier. This should be the application identifier of the client application.
        /// </summary>
        string OAuth2PermissionGrantClient { get; set; }
        /// <summary>
        /// The resource identifier. This should be the application identifier of the resource application.
        /// </summary>
        string OAuth2PermissionGrantResource { get; set; }
        /// <summary>
        /// The scope identifier. This should be the scope value of the OAUTH2PERMISSION exposed by the resource application.
        /// </summary>
        string OAuth2PermissionGrantScope { get; set; }
        /// <summary>The health status for the permission.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get; set; }

    }
}