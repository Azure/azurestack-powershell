namespace Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Extensions;

    /// <summary>Metrics for a source.</summary>
    public partial class Metrics :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IMetrics,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IMetricsInternal
    {

        /// <summary>Backing field for <see cref="MaCounterName" /> property.</summary>
        private string _maCounterName;

        /// <summary>Name of the counter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string MaCounterName { get => this._maCounterName; set => this._maCounterName = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the usage metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ObservedTimestamp" /> property.</summary>
        private global::System.DateTime? _observedTimestamp;

        /// <summary>Time counter was observed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? ObservedTimestamp { get => this._observedTimestamp; set => this._observedTimestamp = value; }

        /// <summary>Backing field for <see cref="SourceName" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Support.MetricsSourceType? _sourceName;

        /// <summary>Name of the source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Support.MetricsSourceType? SourceName { get => this._sourceName; set => this._sourceName = value; }

        /// <summary>Backing field for <see cref="SourceType" /> property.</summary>
        private string _sourceType;

        /// <summary>Type of the source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string SourceType { get => this._sourceType; set => this._sourceType = value; }

        /// <summary>Backing field for <see cref="Unit" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Support.MetricsUnit? _unit;

        /// <summary>Unit for the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Support.MetricsUnit? Unit { get => this._unit; set => this._unit = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private double? _value;

        /// <summary>Name of the usage metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public double? Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="Metrics" /> instance.</summary>
        public Metrics()
        {

        }
    }
    /// Metrics for a source.
    public partial interface IMetrics :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Name of the counter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the counter.",
        SerializedName = @"maCounterName",
        PossibleTypes = new [] { typeof(string) })]
        string MaCounterName { get; set; }
        /// <summary>Name of the usage metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the usage metric.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Time counter was observed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time counter was observed.",
        SerializedName = @"observedTimestamp",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ObservedTimestamp { get; set; }
        /// <summary>Name of the source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the source.",
        SerializedName = @"sourceName",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Support.MetricsSourceType) })]
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Support.MetricsSourceType? SourceName { get; set; }
        /// <summary>Type of the source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the source.",
        SerializedName = @"sourceType",
        PossibleTypes = new [] { typeof(string) })]
        string SourceType { get; set; }
        /// <summary>Unit for the metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unit for the metric.",
        SerializedName = @"unit",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Support.MetricsUnit) })]
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Support.MetricsUnit? Unit { get; set; }
        /// <summary>Name of the usage metric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the usage metric.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(double) })]
        double? Value { get; set; }

    }
    /// Metrics for a source.
    internal partial interface IMetricsInternal

    {
        /// <summary>Name of the counter.</summary>
        string MaCounterName { get; set; }
        /// <summary>Name of the usage metric.</summary>
        string Name { get; set; }
        /// <summary>Time counter was observed.</summary>
        global::System.DateTime? ObservedTimestamp { get; set; }
        /// <summary>Name of the source.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Support.MetricsSourceType? SourceName { get; set; }
        /// <summary>Type of the source.</summary>
        string SourceType { get; set; }
        /// <summary>Unit for the metric.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Support.MetricsUnit? Unit { get; set; }
        /// <summary>Name of the usage metric.</summary>
        double? Value { get; set; }

    }
}