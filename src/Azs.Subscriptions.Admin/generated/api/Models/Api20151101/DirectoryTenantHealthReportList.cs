namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>List of directory tenant health reports.</summary>
    public partial class DirectoryTenantHealthReportList :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReportList,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReportListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReport[] _value;

        /// <summary>Directory tenant health report.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReport[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DirectoryTenantHealthReportList" /> instance.</summary>
        public DirectoryTenantHealthReportList()
        {

        }
    }
    /// List of directory tenant health reports.
    public partial interface IDirectoryTenantHealthReportList :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Directory tenant health report.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Directory tenant health report.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReport) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReport[] Value { get; set; }

    }
    /// List of directory tenant health reports.
    internal partial interface IDirectoryTenantHealthReportListInternal

    {
        /// <summary>URI to the next page.</summary>
        string NextLink { get; set; }
        /// <summary>Directory tenant health report.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDirectoryTenantHealthReport[] Value { get; set; }

    }
}