namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>
    /// A report of the health status of a tag on an identity application service principal.
    /// </summary>
    public partial class ServicePrincipalTagHealthReport :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReport,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReportInternal
    {

        /// <summary>Backing field for <see cref="ServicePrincipalTag" /> property.</summary>
        private string _servicePrincipalTag;

        /// <summary>The tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string ServicePrincipalTag { get => this._servicePrincipalTag; set => this._servicePrincipalTag = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? _status;

        /// <summary>The health status for the tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="ServicePrincipalTagHealthReport" /> instance.</summary>
        public ServicePrincipalTagHealthReport()
        {

        }
    }
    /// A report of the health status of a tag on an identity application service principal.
    public partial interface IServicePrincipalTagHealthReport :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tag.",
        SerializedName = @"servicePrincipalTag",
        PossibleTypes = new [] { typeof(string) })]
        string ServicePrincipalTag { get; set; }
        /// <summary>The health status for the tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The health status for the tag.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get; set; }

    }
    /// A report of the health status of a tag on an identity application service principal.
    internal partial interface IServicePrincipalTagHealthReportInternal

    {
        /// <summary>The tag.</summary>
        string ServicePrincipalTag { get; set; }
        /// <summary>The health status for the tag.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus? Status { get; set; }

    }
}