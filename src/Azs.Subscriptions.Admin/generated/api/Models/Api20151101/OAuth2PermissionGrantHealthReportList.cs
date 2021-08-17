namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>List of OAuth2PermissionGrant health reports for the application.</summary>
    public partial class OAuth2PermissionGrantHealthReportList :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReportList,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReportListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReport[] _value;

        /// <summary>A report of the health status of an OAuth2PermissionGrant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReport[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OAuth2PermissionGrantHealthReportList" /> instance.</summary>
        public OAuth2PermissionGrantHealthReportList()
        {

        }
    }
    /// List of OAuth2PermissionGrant health reports for the application.
    public partial interface IOAuth2PermissionGrantHealthReportList :
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
        /// <summary>A report of the health status of an OAuth2PermissionGrant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A report of the health status of an OAuth2PermissionGrant.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReport) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReport[] Value { get; set; }

    }
    /// List of OAuth2PermissionGrant health reports for the application.
    internal partial interface IOAuth2PermissionGrantHealthReportListInternal

    {
        /// <summary>URI to the next page.</summary>
        string NextLink { get; set; }
        /// <summary>A report of the health status of an OAuth2PermissionGrant.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReport[] Value { get; set; }

    }
}