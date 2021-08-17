namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The identity health check report action definition.</summary>
    public partial class IdentityHealthCheckReportDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IIdentityHealthCheckReportDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IIdentityHealthCheckReportDefinitionInternal
    {

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string DirectoryTenantNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReportListInternal)DirectoryTenants).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReportListInternal)DirectoryTenants).NextLink = value ?? null; }

        /// <summary>Directory tenant health report.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReport[] DirectoryTenantValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReportListInternal)DirectoryTenants).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReportListInternal)DirectoryTenants).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="DirectoryTenants" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReportList _directoryTenants;

        /// <summary>List of directory tenant health reports.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReportList DirectoryTenants { get => (this._directoryTenants = this._directoryTenants ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.DirectoryTenantHealthReportList()); set => this._directoryTenants = value; }

        /// <summary>Internal Acessors for DirectoryTenants</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReportList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IIdentityHealthCheckReportDefinitionInternal.DirectoryTenants { get => (this._directoryTenants = this._directoryTenants ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.DirectoryTenantHealthReportList()); set { {_directoryTenants = value;} } }

        /// <summary>Backing field for <see cref="ReportEndTimeUtc" /> property.</summary>
        private global::System.DateTime? _reportEndTimeUtc;

        /// <summary>End time of the report.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? ReportEndTimeUtc { get => this._reportEndTimeUtc; set => this._reportEndTimeUtc = value; }

        /// <summary>Backing field for <see cref="ReportStartTimeUtc" /> property.</summary>
        private global::System.DateTime? _reportStartTimeUtc;

        /// <summary>Start time of the report.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? ReportStartTimeUtc { get => this._reportStartTimeUtc; set => this._reportStartTimeUtc = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? _status;

        /// <summary>The roll-up health status for the directory.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="IdentityHealthCheckReportDefinition" /> instance.</summary>
        public IdentityHealthCheckReportDefinition()
        {

        }
    }
    /// The identity health check report action definition.
    public partial interface IIdentityHealthCheckReportDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string DirectoryTenantNextLink { get; set; }
        /// <summary>Directory tenant health report.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Directory tenant health report.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReport) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReport[] DirectoryTenantValue { get; set; }
        /// <summary>End time of the report.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"End time of the report.",
        SerializedName = @"reportEndTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ReportEndTimeUtc { get; set; }
        /// <summary>Start time of the report.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Start time of the report.",
        SerializedName = @"reportStartTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ReportStartTimeUtc { get; set; }
        /// <summary>The roll-up health status for the directory.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The roll-up health status for the directory.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get; set; }

    }
    /// The identity health check report action definition.
    internal partial interface IIdentityHealthCheckReportDefinitionInternal

    {
        /// <summary>URI to the next page.</summary>
        string DirectoryTenantNextLink { get; set; }
        /// <summary>Directory tenant health report.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReport[] DirectoryTenantValue { get; set; }
        /// <summary>List of directory tenant health reports.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReportList DirectoryTenants { get; set; }
        /// <summary>End time of the report.</summary>
        global::System.DateTime? ReportEndTimeUtc { get; set; }
        /// <summary>Start time of the report.</summary>
        global::System.DateTime? ReportStartTimeUtc { get; set; }
        /// <summary>The roll-up health status for the directory.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get; set; }

    }
}