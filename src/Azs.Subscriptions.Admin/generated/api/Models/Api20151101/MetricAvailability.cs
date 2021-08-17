namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Metric Definition</summary>
    public partial class MetricAvailability :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricAvailability,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricAvailabilityInternal
    {

        /// <summary>Backing field for <see cref="Retention" /> property.</summary>
        private string _retention;

        /// <summary>the retention. Metrics may be queried for this interval.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Retention { get => this._retention; set => this._retention = value; }

        /// <summary>Backing field for <see cref="TimeGrain" /> property.</summary>
        private string _timeGrain;

        /// <summary>The time grain. Metrics will be available for this time grain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string TimeGrain { get => this._timeGrain; set => this._timeGrain = value; }

        /// <summary>Creates an new <see cref="MetricAvailability" /> instance.</summary>
        public MetricAvailability()
        {

        }
    }
    /// Metric Definition
    public partial interface IMetricAvailability :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>the retention. Metrics may be queried for this interval.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the retention. Metrics may be queried for this interval.",
        SerializedName = @"retention",
        PossibleTypes = new [] { typeof(string) })]
        string Retention { get; set; }
        /// <summary>The time grain. Metrics will be available for this time grain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time grain. Metrics will be available for this time grain.",
        SerializedName = @"timeGrain",
        PossibleTypes = new [] { typeof(string) })]
        string TimeGrain { get; set; }

    }
    /// Metric Definition
    internal partial interface IMetricAvailabilityInternal

    {
        /// <summary>the retention. Metrics may be queried for this interval.</summary>
        string Retention { get; set; }
        /// <summary>The time grain. Metrics will be available for this time grain.</summary>
        string TimeGrain { get; set; }

    }
}