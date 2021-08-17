namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>A report of the health status of an AppRoleAssignment.</summary>
    public partial class AppRoleAssignmentHealthReport :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReport,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReportInternal
    {

        /// <summary>Backing field for <see cref="AppRoleAssignment" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentDefinition _appRoleAssignment;

        /// <summary>The permission description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentDefinition AppRoleAssignment { get => (this._appRoleAssignment = this._appRoleAssignment ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.AppRoleAssignmentDefinition()); set => this._appRoleAssignment = value; }

        /// <summary>
        /// The client identifier. This should be the application identifier of the client application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string AppRoleAssignmentClient { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentDefinitionInternal)AppRoleAssignment).Client; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentDefinitionInternal)AppRoleAssignment).Client = value ?? null; }

        /// <summary>
        /// The resource identifier. This should be the application identifier of the resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string AppRoleAssignmentResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentDefinitionInternal)AppRoleAssignment).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentDefinitionInternal)AppRoleAssignment).Resource = value ?? null; }

        /// <summary>
        /// The role identifier. This should be the ID of the AppRole exposed by the resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string AppRoleAssignmentRoleId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentDefinitionInternal)AppRoleAssignment).RoleId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentDefinitionInternal)AppRoleAssignment).RoleId = value ?? null; }

        /// <summary>Internal Acessors for AppRoleAssignment</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentDefinition Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReportInternal.AppRoleAssignment { get => (this._appRoleAssignment = this._appRoleAssignment ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.AppRoleAssignmentDefinition()); set { {_appRoleAssignment = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? _status;

        /// <summary>The health status for the permission.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="AppRoleAssignmentHealthReport" /> instance.</summary>
        public AppRoleAssignmentHealthReport()
        {

        }
    }
    /// A report of the health status of an AppRoleAssignment.
    public partial interface IAppRoleAssignmentHealthReport :
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
        string AppRoleAssignmentClient { get; set; }
        /// <summary>
        /// The resource identifier. This should be the application identifier of the resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource identifier. This should be the application identifier of the resource application.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string AppRoleAssignmentResource { get; set; }
        /// <summary>
        /// The role identifier. This should be the ID of the AppRole exposed by the resource application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The role identifier. This should be the ID of the AppRole exposed by the resource application.",
        SerializedName = @"roleId",
        PossibleTypes = new [] { typeof(string) })]
        string AppRoleAssignmentRoleId { get; set; }
        /// <summary>The health status for the permission.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The health status for the permission.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get; set; }

    }
    /// A report of the health status of an AppRoleAssignment.
    internal partial interface IAppRoleAssignmentHealthReportInternal

    {
        /// <summary>The permission description.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentDefinition AppRoleAssignment { get; set; }
        /// <summary>
        /// The client identifier. This should be the application identifier of the client application.
        /// </summary>
        string AppRoleAssignmentClient { get; set; }
        /// <summary>
        /// The resource identifier. This should be the application identifier of the resource application.
        /// </summary>
        string AppRoleAssignmentResource { get; set; }
        /// <summary>
        /// The role identifier. This should be the ID of the AppRole exposed by the resource application.
        /// </summary>
        string AppRoleAssignmentRoleId { get; set; }
        /// <summary>The health status for the permission.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get; set; }

    }
}