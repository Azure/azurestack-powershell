namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Metric Definition</summary>
    public partial class MetricDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricDefinitionInternal
    {

        /// <summary>Backing field for <see cref="MetricAvailabilities" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricAvailability[] _metricAvailabilities;

        /// <summary>Metric availabilities.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricAvailability[] MetricAvailabilities { get => this._metricAvailabilities; set => this._metricAvailabilities = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Metric definition name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="PrimaryAggregationType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType? _primaryAggregationType;

        /// <summary>Type of the primary aggregation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType? PrimaryAggregationType { get => this._primaryAggregationType; set => this._primaryAggregationType = value; }

        /// <summary>Backing field for <see cref="Unit" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit? _unit;

        /// <summary>Unit of metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit? Unit { get => this._unit; set => this._unit = value; }

        /// <summary>Creates an new <see cref="MetricDefinition" /> instance.</summary>
        public MetricDefinition()
        {

        }
    }
    /// Metric Definition
    public partial interface IMetricDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Metric availabilities.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metric availabilities.",
        SerializedName = @"metricAvailabilities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricAvailability) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricAvailability[] MetricAvailabilities { get; set; }
        /// <summary>Metric definition name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metric definition name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Type of the primary aggregation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the primary aggregation.",
        SerializedName = @"primaryAggregationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType? PrimaryAggregationType { get; set; }
        /// <summary>Unit of metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unit of metrics.",
        SerializedName = @"unit",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit? Unit { get; set; }

    }
    /// Metric Definition
    internal partial interface IMetricDefinitionInternal

    {
        /// <summary>Metric availabilities.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricAvailability[] MetricAvailabilities { get; set; }
        /// <summary>Metric definition name.</summary>
        string Name { get; set; }
        /// <summary>Type of the primary aggregation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType? PrimaryAggregationType { get; set; }
        /// <summary>Unit of metrics.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricUnit? Unit { get; set; }

    }
}