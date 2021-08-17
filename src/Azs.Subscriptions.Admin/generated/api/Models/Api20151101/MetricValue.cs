namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Metric value</summary>
    public partial class MetricValue :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricValue,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricValueInternal
    {

        /// <summary>Backing field for <see cref="Average" /> property.</summary>
        private double? _average;

        /// <summary>Average value for metric sample period.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public double? Average { get => this._average; set => this._average = value; }

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private int? _count;

        /// <summary>Number of measurements for metric sample period.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public int? Count { get => this._count; set => this._count = value; }

        /// <summary>Backing field for <see cref="ExtendedProperties" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricValueProperties _extendedProperties;

        /// <summary>Extended properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricValueProperties ExtendedProperties { get => (this._extendedProperties = this._extendedProperties ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.MetricValueProperties()); set => this._extendedProperties = value; }

        /// <summary>Backing field for <see cref="Maximum" /> property.</summary>
        private double? _maximum;

        /// <summary>Maximum value for metric sample period.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public double? Maximum { get => this._maximum; set => this._maximum = value; }

        /// <summary>Backing field for <see cref="Minimum" /> property.</summary>
        private double? _minimum;

        /// <summary>Minimum value for metric sample period.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public double? Minimum { get => this._minimum; set => this._minimum = value; }

        /// <summary>Backing field for <see cref="TimeStamp" /> property.</summary>
        private global::System.DateTime? _timeStamp;

        /// <summary>Timestamp of when the metric value was collected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? TimeStamp { get => this._timeStamp; set => this._timeStamp = value; }

        /// <summary>Backing field for <see cref="Total" /> property.</summary>
        private double? _total;

        /// <summary>Total value for metric sample period.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public double? Total { get => this._total; set => this._total = value; }

        /// <summary>Creates an new <see cref="MetricValue" /> instance.</summary>
        public MetricValue()
        {

        }
    }
    /// Metric value
    public partial interface IMetricValue :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Average value for metric sample period.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Average value for metric sample period.",
        SerializedName = @"average",
        PossibleTypes = new [] { typeof(double) })]
        double? Average { get; set; }
        /// <summary>Number of measurements for metric sample period.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of measurements for metric sample period.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(int) })]
        int? Count { get; set; }
        /// <summary>Extended properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Extended properties.",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricValueProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricValueProperties ExtendedProperties { get; set; }
        /// <summary>Maximum value for metric sample period.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum value for metric sample period.",
        SerializedName = @"maximum",
        PossibleTypes = new [] { typeof(double) })]
        double? Maximum { get; set; }
        /// <summary>Minimum value for metric sample period.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Minimum value for metric sample period.",
        SerializedName = @"minimum",
        PossibleTypes = new [] { typeof(double) })]
        double? Minimum { get; set; }
        /// <summary>Timestamp of when the metric value was collected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Timestamp of when the metric value was collected.",
        SerializedName = @"timeStamp",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TimeStamp { get; set; }
        /// <summary>Total value for metric sample period.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Total value for metric sample period.",
        SerializedName = @"total",
        PossibleTypes = new [] { typeof(double) })]
        double? Total { get; set; }

    }
    /// Metric value
    internal partial interface IMetricValueInternal

    {
        /// <summary>Average value for metric sample period.</summary>
        double? Average { get; set; }
        /// <summary>Number of measurements for metric sample period.</summary>
        int? Count { get; set; }
        /// <summary>Extended properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricValueProperties ExtendedProperties { get; set; }
        /// <summary>Maximum value for metric sample period.</summary>
        double? Maximum { get; set; }
        /// <summary>Minimum value for metric sample period.</summary>
        double? Minimum { get; set; }
        /// <summary>Timestamp of when the metric value was collected.</summary>
        global::System.DateTime? TimeStamp { get; set; }
        /// <summary>Total value for metric sample period.</summary>
        double? Total { get; set; }

    }
}