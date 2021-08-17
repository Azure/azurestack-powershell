namespace Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Extensions;

    /// <summary>Summary of the alerts.</summary>
    public partial class AlertSummary :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertSummary,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertSummaryInternal
    {

        /// <summary>Backing field for <see cref="CriticalAlertCount" /> property.</summary>
        private int? _criticalAlertCount;

        /// <summary>The number of critical alerts for the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public int? CriticalAlertCount { get => this._criticalAlertCount; set => this._criticalAlertCount = value; }

        /// <summary>Backing field for <see cref="WarningAlertCount" /> property.</summary>
        private int? _warningAlertCount;

        /// <summary>The number of warning alerts for the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public int? WarningAlertCount { get => this._warningAlertCount; set => this._warningAlertCount = value; }

        /// <summary>Creates an new <see cref="AlertSummary" /> instance.</summary>
        public AlertSummary()
        {

        }
    }
    /// Summary of the alerts.
    public partial interface IAlertSummary :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The number of critical alerts for the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of critical alerts for the service.",
        SerializedName = @"criticalAlertCount",
        PossibleTypes = new [] { typeof(int) })]
        int? CriticalAlertCount { get; set; }
        /// <summary>The number of warning alerts for the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of warning alerts for the service.",
        SerializedName = @"warningAlertCount",
        PossibleTypes = new [] { typeof(int) })]
        int? WarningAlertCount { get; set; }

    }
    /// Summary of the alerts.
    internal partial interface IAlertSummaryInternal

    {
        /// <summary>The number of critical alerts for the service.</summary>
        int? CriticalAlertCount { get; set; }
        /// <summary>The number of warning alerts for the service.</summary>
        int? WarningAlertCount { get; set; }

    }
}