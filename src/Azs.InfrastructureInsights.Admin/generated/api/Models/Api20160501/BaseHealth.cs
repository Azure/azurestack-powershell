namespace Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Extensions;

    /// <summary>Models the base properties for health resource.</summary>
    public partial class BaseHealth :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealth,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal
    {

        /// <summary>Backing field for <see cref="AlertSummary" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertSummary _alertSummary;

        /// <summary>Alert summary.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertSummary AlertSummary { get => (this._alertSummary = this._alertSummary ?? new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.AlertSummary()); set => this._alertSummary = value; }

        /// <summary>The number of critical alerts for the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        public int? AlertSummaryCriticalAlertCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertSummaryInternal)AlertSummary).CriticalAlertCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertSummaryInternal)AlertSummary).CriticalAlertCount = value ?? default(int); }

        /// <summary>The number of warning alerts for the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        public int? AlertSummaryWarningAlertCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertSummaryInternal)AlertSummary).WarningAlertCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertSummaryInternal)AlertSummary).WarningAlertCount = value ?? default(int); }

        /// <summary>Backing field for <see cref="HealthState" /> property.</summary>
        private string _healthState;

        /// <summary>Health state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string HealthState { get => this._healthState; set => this._healthState = value; }

        /// <summary>Internal Acessors for AlertSummary</summary>
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertSummary Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal.AlertSummary { get => (this._alertSummary = this._alertSummary ?? new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.AlertSummary()); set { {_alertSummary = value;} } }

        /// <summary>Backing field for <see cref="Namespace" /> property.</summary>
        private string _namespace;

        /// <summary>Namespace of the health resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string Namespace { get => this._namespace; set => this._namespace = value; }

        /// <summary>Backing field for <see cref="RegistrationId" /> property.</summary>
        private string _registrationId;

        /// <summary>Registration ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string RegistrationId { get => this._registrationId; set => this._registrationId = value; }

        /// <summary>Backing field for <see cref="RoutePrefix" /> property.</summary>
        private string _routePrefix;

        /// <summary>Route prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string RoutePrefix { get => this._routePrefix; set => this._routePrefix = value; }

        /// <summary>Creates an new <see cref="BaseHealth" /> instance.</summary>
        public BaseHealth()
        {

        }
    }
    /// Models the base properties for health resource.
    public partial interface IBaseHealth :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The number of critical alerts for the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of critical alerts for the service.",
        SerializedName = @"criticalAlertCount",
        PossibleTypes = new [] { typeof(int) })]
        int? AlertSummaryCriticalAlertCount { get; set; }
        /// <summary>The number of warning alerts for the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of warning alerts for the service.",
        SerializedName = @"warningAlertCount",
        PossibleTypes = new [] { typeof(int) })]
        int? AlertSummaryWarningAlertCount { get; set; }
        /// <summary>Health state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Health state.",
        SerializedName = @"healthState",
        PossibleTypes = new [] { typeof(string) })]
        string HealthState { get; set; }
        /// <summary>Namespace of the health resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Namespace of the health resource.",
        SerializedName = @"namespace",
        PossibleTypes = new [] { typeof(string) })]
        string Namespace { get; set; }
        /// <summary>Registration ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Registration ID.",
        SerializedName = @"registrationId",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationId { get; set; }
        /// <summary>Route prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Route prefix.",
        SerializedName = @"routePrefix",
        PossibleTypes = new [] { typeof(string) })]
        string RoutePrefix { get; set; }

    }
    /// Models the base properties for health resource.
    internal partial interface IBaseHealthInternal

    {
        /// <summary>Alert summary.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertSummary AlertSummary { get; set; }
        /// <summary>The number of critical alerts for the service.</summary>
        int? AlertSummaryCriticalAlertCount { get; set; }
        /// <summary>The number of warning alerts for the service.</summary>
        int? AlertSummaryWarningAlertCount { get; set; }
        /// <summary>Health state.</summary>
        string HealthState { get; set; }
        /// <summary>Namespace of the health resource.</summary>
        string Namespace { get; set; }
        /// <summary>Registration ID.</summary>
        string RegistrationId { get; set; }
        /// <summary>Route prefix.</summary>
        string RoutePrefix { get; set; }

    }
}