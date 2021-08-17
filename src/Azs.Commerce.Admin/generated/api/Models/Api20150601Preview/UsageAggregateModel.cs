namespace Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Extensions;

    /// <summary>Properties for aggregate usage.</summary>
    public partial class UsageAggregateModel :
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModel,
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModelInternal
    {

        /// <summary>Backing field for <see cref="InstanceData" /> property.</summary>
        private string _instanceData;

        /// <summary>Key-value pairs of instance details represented as a string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Owned)]
        public string InstanceData { get => this._instanceData; set => this._instanceData = value; }

        /// <summary>Backing field for <see cref="MeterId" /> property.</summary>
        private string _meterId;

        /// <summary>Unique ID for the resource that was consumed, for example, the Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Owned)]
        public string MeterId { get => this._meterId; set => this._meterId = value; }

        /// <summary>Backing field for <see cref="Quantity" /> property.</summary>
        private double? _quantity;

        /// <summary>The amount of the resource consumption that occurred in this time frame.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Owned)]
        public double? Quantity { get => this._quantity; set => this._quantity = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>Subscription ID of tenant using plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="UsageEndTime" /> property.</summary>
        private global::System.DateTime? _usageEndTime;

        /// <summary>UTC end time for the usage category to which this usage aggregate belongs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? UsageEndTime { get => this._usageEndTime; set => this._usageEndTime = value; }

        /// <summary>Backing field for <see cref="UsageStartTime" /> property.</summary>
        private global::System.DateTime? _usageStartTime;

        /// <summary>UTC start time for the usage category to which this usage aggregate belongs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? UsageStartTime { get => this._usageStartTime; set => this._usageStartTime = value; }

        /// <summary>Creates an new <see cref="UsageAggregateModel" /> instance.</summary>
        public UsageAggregateModel()
        {

        }
    }
    /// Properties for aggregate usage.
    public partial interface IUsageAggregateModel :
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Key-value pairs of instance details represented as a string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Key-value pairs of instance details represented as a string.",
        SerializedName = @"instanceData",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceData { get; set; }
        /// <summary>Unique ID for the resource that was consumed, for example, the Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unique ID for the resource that was consumed, for example, the Resource ID.",
        SerializedName = @"meterId",
        PossibleTypes = new [] { typeof(string) })]
        string MeterId { get; set; }
        /// <summary>The amount of the resource consumption that occurred in this time frame.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of the resource consumption that occurred in this time frame.",
        SerializedName = @"quantity",
        PossibleTypes = new [] { typeof(double) })]
        double? Quantity { get; set; }
        /// <summary>Subscription ID of tenant using plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription ID of tenant using plan.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>UTC end time for the usage category to which this usage aggregate belongs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"UTC end time for the usage category to which this usage aggregate belongs.",
        SerializedName = @"usageEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? UsageEndTime { get; set; }
        /// <summary>UTC start time for the usage category to which this usage aggregate belongs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"UTC start time for the usage category to which this usage aggregate belongs.",
        SerializedName = @"usageStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? UsageStartTime { get; set; }

    }
    /// Properties for aggregate usage.
    internal partial interface IUsageAggregateModelInternal

    {
        /// <summary>Key-value pairs of instance details represented as a string.</summary>
        string InstanceData { get; set; }
        /// <summary>Unique ID for the resource that was consumed, for example, the Resource ID.</summary>
        string MeterId { get; set; }
        /// <summary>The amount of the resource consumption that occurred in this time frame.</summary>
        double? Quantity { get; set; }
        /// <summary>Subscription ID of tenant using plan.</summary>
        string SubscriptionId { get; set; }
        /// <summary>UTC end time for the usage category to which this usage aggregate belongs.</summary>
        global::System.DateTime? UsageEndTime { get; set; }
        /// <summary>UTC start time for the usage category to which this usage aggregate belongs.</summary>
        global::System.DateTime? UsageStartTime { get; set; }

    }
}