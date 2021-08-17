namespace Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Extensions;

    /// <summary>Aggregate usage values for resource.</summary>
    public partial class UsageAggregate :
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregate,
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.Resource();

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Id; }

        /// <summary>Key-value pairs of instance details represented as a string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inlined)]
        public string InstanceData { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModelInternal)Property).InstanceData; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModelInternal)Property).InstanceData = value ?? null; }

        /// <summary>Location where resource is location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Location; }

        /// <summary>Unique ID for the resource that was consumed, for example, the Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inlined)]
        public string MeterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModelInternal)Property).MeterId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModelInternal)Property).MeterId = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal.Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Location = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Tag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceTags Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal.Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Tag = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModel Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.UsageAggregateModel()); set { {_property = value;} } }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModel _property;

        /// <summary>Properties for aggregate usage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.UsageAggregateModel()); set => this._property = value; }

        /// <summary>The amount of the resource consumption that occurred in this time frame.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inlined)]
        public double? Quantity { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModelInternal)Property).Quantity; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModelInternal)Property).Quantity = value ?? default(double); }

        /// <summary>Subscription ID of tenant using plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inlined)]
        public string SubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModelInternal)Property).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModelInternal)Property).SubscriptionId = value ?? null; }

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Tag; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal)__resource).Type; }

        /// <summary>UTC end time for the usage category to which this usage aggregate belongs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? UsageEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModelInternal)Property).UsageEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModelInternal)Property).UsageEndTime = value ?? default(global::System.DateTime); }

        /// <summary>UTC start time for the usage category to which this usage aggregate belongs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? UsageStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModelInternal)Property).UsageStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModelInternal)Property).UsageStartTime = value ?? default(global::System.DateTime); }

        /// <summary>Creates an new <see cref="UsageAggregate" /> instance.</summary>
        public UsageAggregate()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Aggregate usage values for resource.
    public partial interface IUsageAggregate :
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResource
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
    /// Aggregate usage values for resource.
    internal partial interface IUsageAggregateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal
    {
        /// <summary>Key-value pairs of instance details represented as a string.</summary>
        string InstanceData { get; set; }
        /// <summary>Unique ID for the resource that was consumed, for example, the Resource ID.</summary>
        string MeterId { get; set; }
        /// <summary>Properties for aggregate usage.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModel Property { get; set; }
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