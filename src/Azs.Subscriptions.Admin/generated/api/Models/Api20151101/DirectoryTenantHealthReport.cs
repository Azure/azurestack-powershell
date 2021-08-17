namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>
    /// A report of the health status of a directory tenant and identity applications within.
    /// </summary>
    public partial class DirectoryTenantHealthReport :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReport,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReportInternal
    {

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string ApplicationNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportListInternal)Applications).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportListInternal)Applications).NextLink = value ?? null; }

        /// <summary>A report of the health status of an identity applications.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReport[] ApplicationValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportListInternal)Applications).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportListInternal)Applications).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Applications" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportList _applications;

        /// <summary>List of the application health reports.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportList Applications { get => (this._applications = this._applications ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ApplicationHealthReportList()); set => this._applications = value; }

        /// <summary>Internal Acessors for Applications</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReportInternal.Applications { get => (this._applications = this._applications ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ApplicationHealthReportList()); set { {_applications = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? _status;

        /// <summary>The roll-up health status for the directory.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>The tenant unique identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; set => this._tenantId = value; }

        /// <summary>Backing field for <see cref="TenantName" /> property.</summary>
        private string _tenantName;

        /// <summary>The directory tenant resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string TenantName { get => this._tenantName; set => this._tenantName = value; }

        /// <summary>Creates an new <see cref="DirectoryTenantHealthReport" /> instance.</summary>
        public DirectoryTenantHealthReport()
        {

        }
    }
    /// A report of the health status of a directory tenant and identity applications within.
    public partial interface IDirectoryTenantHealthReport :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationNextLink { get; set; }
        /// <summary>A report of the health status of an identity applications.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A report of the health status of an identity applications.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReport) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReport[] ApplicationValue { get; set; }
        /// <summary>The roll-up health status for the directory.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The roll-up health status for the directory.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get; set; }
        /// <summary>The tenant unique identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tenant unique identifier.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }
        /// <summary>The directory tenant resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The directory tenant resource name.",
        SerializedName = @"tenantName",
        PossibleTypes = new [] { typeof(string) })]
        string TenantName { get; set; }

    }
    /// A report of the health status of a directory tenant and identity applications within.
    internal partial interface IDirectoryTenantHealthReportInternal

    {
        /// <summary>URI to the next page.</summary>
        string ApplicationNextLink { get; set; }
        /// <summary>A report of the health status of an identity applications.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReport[] ApplicationValue { get; set; }
        /// <summary>List of the application health reports.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportList Applications { get; set; }
        /// <summary>The roll-up health status for the directory.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get; set; }
        /// <summary>The tenant unique identifier.</summary>
        string TenantId { get; set; }
        /// <summary>The directory tenant resource name.</summary>
        string TenantName { get; set; }

    }
}