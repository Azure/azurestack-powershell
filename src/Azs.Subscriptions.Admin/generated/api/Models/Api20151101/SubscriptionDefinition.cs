namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Subscription object properties.</summary>
    public partial class SubscriptionDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ISubscriptionDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ISubscriptionDefinitionInternal
    {

        /// <summary>Backing field for <see cref="DelegatedProviderSubscriptionId" /> property.</summary>
        private string _delegatedProviderSubscriptionId;

        /// <summary>Parent DelegatedProvider subscription identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string DelegatedProviderSubscriptionId { get => this._delegatedProviderSubscriptionId; set => this._delegatedProviderSubscriptionId = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Subscription name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="ExternalReferenceId" /> property.</summary>
        private string _externalReferenceId;

        /// <summary>External reference identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string ExternalReferenceId { get => this._externalReferenceId; set => this._externalReferenceId = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Fully qualified identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="OfferId" /> property.</summary>
        private string _offerId;

        /// <summary>Identifier of the offer under the scope of a delegated provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string OfferId { get => this._offerId; set => this._offerId = value; }

        /// <summary>Backing field for <see cref="Owner" /> property.</summary>
        private string _owner;

        /// <summary>Subscription owner.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Owner { get => this._owner; set => this._owner = value; }

        /// <summary>Backing field for <see cref="RoutingResourceManagerType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType? _routingResourceManagerType;

        /// <summary>Routing resource manager type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType? RoutingResourceManagerType { get => this._routingResourceManagerType; set => this._routingResourceManagerType = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState? _state;

        /// <summary>Subscription state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState? State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>Subscription identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Directory tenant identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; set => this._tenantId = value; }

        /// <summary>Creates an new <see cref="SubscriptionDefinition" /> instance.</summary>
        public SubscriptionDefinition()
        {

        }
    }
    /// Subscription object properties.
    public partial interface ISubscriptionDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Parent DelegatedProvider subscription identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Parent DelegatedProvider subscription identifier.",
        SerializedName = @"delegatedProviderSubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string DelegatedProviderSubscriptionId { get; set; }
        /// <summary>Subscription name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>External reference identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"External reference identifier.",
        SerializedName = @"externalReferenceId",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalReferenceId { get; set; }
        /// <summary>Fully qualified identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Identifier of the offer under the scope of a delegated provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identifier of the offer under the scope of a delegated provider.",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferId { get; set; }
        /// <summary>Subscription owner.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription owner.",
        SerializedName = @"owner",
        PossibleTypes = new [] { typeof(string) })]
        string Owner { get; set; }
        /// <summary>Routing resource manager type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Routing resource manager type.",
        SerializedName = @"routingResourceManagerType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType? RoutingResourceManagerType { get; set; }
        /// <summary>Subscription state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription state.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState? State { get; set; }
        /// <summary>Subscription identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription identifier.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>Directory tenant identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Directory tenant identifier.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }

    }
    /// Subscription object properties.
    internal partial interface ISubscriptionDefinitionInternal

    {
        /// <summary>Parent DelegatedProvider subscription identifier.</summary>
        string DelegatedProviderSubscriptionId { get; set; }
        /// <summary>Subscription name.</summary>
        string DisplayName { get; set; }
        /// <summary>External reference identifier.</summary>
        string ExternalReferenceId { get; set; }
        /// <summary>Fully qualified identifier.</summary>
        string Id { get; set; }
        /// <summary>Identifier of the offer under the scope of a delegated provider.</summary>
        string OfferId { get; set; }
        /// <summary>Subscription owner.</summary>
        string Owner { get; set; }
        /// <summary>Routing resource manager type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType? RoutingResourceManagerType { get; set; }
        /// <summary>Subscription state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.SubscriptionState? State { get; set; }
        /// <summary>Subscription identifier.</summary>
        string SubscriptionId { get; set; }
        /// <summary>Directory tenant identifier.</summary>
        string TenantId { get; set; }

    }
}