namespace Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Extensions;

    /// <summary>Metrics of resource usage.</summary>
    public partial class UsageMetrics :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IUsageMetrics,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IUsageMetricsInternal
    {

        /// <summary>Backing field for <see cref="MetricsValue" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IMetrics[] _metricsValue;

        /// <summary>List of usage metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.FormatTable(Index = 1, Label = @"Capacity Metrics")]
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IMetrics[] MetricsValue { get => this._metricsValue; set => this._metricsValue = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the usage metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.FormatTable(Index = 0, Width = 30)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="UsageMetrics" /> instance.</summary>
        public UsageMetrics()
        {

        }
    }
    /// Metrics of resource usage.
    public partial interface IUsageMetrics :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>List of usage metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of usage metrics.",
        SerializedName = @"metricsValue",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IMetrics) })]
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IMetrics[] MetricsValue { get; set; }
        /// <summary>Name of the usage metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the usage metric.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Metrics of resource usage.
    internal partial interface IUsageMetricsInternal

    {
        /// <summary>List of usage metrics.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IMetrics[] MetricsValue { get; set; }
        /// <summary>Name of the usage metric.</summary>
        string Name { get; set; }

    }
}