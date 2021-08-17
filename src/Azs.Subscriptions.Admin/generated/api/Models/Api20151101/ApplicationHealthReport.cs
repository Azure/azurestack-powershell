namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>A report of the health status of an identity applications.</summary>
    public partial class ApplicationHealthReport :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReport,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal
    {

        /// <summary>Backing field for <see cref="AppId" /> property.</summary>
        private string _appId;

        /// <summary>The application identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string AppId { get => this._appId; set => this._appId = value; }

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string AppRoleAssignmentNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReportListInternal)AppRoleAssignments).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReportListInternal)AppRoleAssignments).NextLink = value ?? null; }

        /// <summary>A report of the health status of an AppRoleAssignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReport[] AppRoleAssignmentValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReportListInternal)AppRoleAssignments).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReportListInternal)AppRoleAssignments).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="AppRoleAssignments" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReportList _appRoleAssignments;

        /// <summary>List of AppRoleAssignment health reports for the application.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReportList AppRoleAssignments { get => (this._appRoleAssignments = this._appRoleAssignments ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.AppRoleAssignmentHealthReportList()); set => this._appRoleAssignments = value; }

        /// <summary>Internal Acessors for AppRoleAssignments</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReportList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal.AppRoleAssignments { get => (this._appRoleAssignments = this._appRoleAssignments ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.AppRoleAssignmentHealthReportList()); set { {_appRoleAssignments = value;} } }

        /// <summary>Internal Acessors for OAuth2PermissionGrants</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReportList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal.OAuth2PermissionGrants { get => (this._oAuth2PermissionGrants = this._oAuth2PermissionGrants ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.OAuth2PermissionGrantHealthReportList()); set { {_oAuth2PermissionGrants = value;} } }

        /// <summary>Internal Acessors for ServicePrincipalTags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReportList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal.ServicePrincipalTags { get => (this._servicePrincipalTags = this._servicePrincipalTags ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ServicePrincipalTagHealthReportList()); set { {_servicePrincipalTags = value;} } }

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string OAuth2PermissionGrantNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReportListInternal)OAuth2PermissionGrants).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReportListInternal)OAuth2PermissionGrants).NextLink = value ?? null; }

        /// <summary>A report of the health status of an OAuth2PermissionGrant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReport[] OAuth2PermissionGrantValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReportListInternal)OAuth2PermissionGrants).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReportListInternal)OAuth2PermissionGrants).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="OAuth2PermissionGrants" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReportList _oAuth2PermissionGrants;

        /// <summary>List of OAuth2PermissionGrant health reports for the application.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReportList OAuth2PermissionGrants { get => (this._oAuth2PermissionGrants = this._oAuth2PermissionGrants ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.OAuth2PermissionGrantHealthReportList()); set => this._oAuth2PermissionGrants = value; }

        /// <summary>Backing field for <see cref="ServicePrincipalObjectId" /> property.</summary>
        private string _servicePrincipalObjectId;

        /// <summary>The service principal identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string ServicePrincipalObjectId { get => this._servicePrincipalObjectId; set => this._servicePrincipalObjectId = value; }

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string ServicePrincipalTagNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReportListInternal)ServicePrincipalTags).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReportListInternal)ServicePrincipalTags).NextLink = value ?? null; }

        /// <summary>
        /// A report of the health status of a tag on an identity application service principal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReport[] ServicePrincipalTagValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReportListInternal)ServicePrincipalTags).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReportListInternal)ServicePrincipalTags).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ServicePrincipalTags" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReportList _servicePrincipalTags;

        /// <summary>List of ServicePrincipalTag health reports for the application.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReportList ServicePrincipalTags { get => (this._servicePrincipalTags = this._servicePrincipalTags ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ServicePrincipalTagHealthReportList()); set => this._servicePrincipalTags = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? _status;

        /// <summary>The roll-up health status for the application</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="ApplicationHealthReport" /> instance.</summary>
        public ApplicationHealthReport()
        {

        }
    }
    /// A report of the health status of an identity applications.
    public partial interface IApplicationHealthReport :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The application identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The application identifier.",
        SerializedName = @"appId",
        PossibleTypes = new [] { typeof(string) })]
        string AppId { get; set; }
        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string AppRoleAssignmentNextLink { get; set; }
        /// <summary>A report of the health status of an AppRoleAssignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A report of the health status of an AppRoleAssignment.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReport) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReport[] AppRoleAssignmentValue { get; set; }
        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string OAuth2PermissionGrantNextLink { get; set; }
        /// <summary>A report of the health status of an OAuth2PermissionGrant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A report of the health status of an OAuth2PermissionGrant.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReport) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReport[] OAuth2PermissionGrantValue { get; set; }
        /// <summary>The service principal identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The service principal identifier.",
        SerializedName = @"servicePrincipalObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string ServicePrincipalObjectId { get; set; }
        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string ServicePrincipalTagNextLink { get; set; }
        /// <summary>
        /// A report of the health status of a tag on an identity application service principal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A report of the health status of a tag on an identity application service principal.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReport) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReport[] ServicePrincipalTagValue { get; set; }
        /// <summary>The roll-up health status for the application</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The roll-up health status for the application",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get; set; }

    }
    /// A report of the health status of an identity applications.
    internal partial interface IApplicationHealthReportInternal

    {
        /// <summary>The application identifier.</summary>
        string AppId { get; set; }
        /// <summary>URI to the next page.</summary>
        string AppRoleAssignmentNextLink { get; set; }
        /// <summary>A report of the health status of an AppRoleAssignment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReport[] AppRoleAssignmentValue { get; set; }
        /// <summary>List of AppRoleAssignment health reports for the application.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReportList AppRoleAssignments { get; set; }
        /// <summary>URI to the next page.</summary>
        string OAuth2PermissionGrantNextLink { get; set; }
        /// <summary>A report of the health status of an OAuth2PermissionGrant.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReport[] OAuth2PermissionGrantValue { get; set; }
        /// <summary>List of OAuth2PermissionGrant health reports for the application.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReportList OAuth2PermissionGrants { get; set; }
        /// <summary>The service principal identifier.</summary>
        string ServicePrincipalObjectId { get; set; }
        /// <summary>URI to the next page.</summary>
        string ServicePrincipalTagNextLink { get; set; }
        /// <summary>
        /// A report of the health status of a tag on an identity application service principal.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReport[] ServicePrincipalTagValue { get; set; }
        /// <summary>List of ServicePrincipalTag health reports for the application.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReportList ServicePrincipalTags { get; set; }
        /// <summary>The roll-up health status for the application</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get; set; }

    }
}