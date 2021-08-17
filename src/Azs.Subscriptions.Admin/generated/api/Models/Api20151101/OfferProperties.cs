namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Represents an offering of services against which a subscription can be created.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
    public partial class OfferProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOfferProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOfferPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AddonPlans" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAddonPlanDefinition[] _addonPlans;

        /// <summary>
        /// References to add-on plans that a tenant can optionally acquire as a part of the offer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAddonPlanDefinition[] AddonPlans { get => this._addonPlans; set => this._addonPlans = value; }

        /// <summary>Backing field for <see cref="BasePlanIds" /> property.</summary>
        private string[] _basePlanIds;

        /// <summary>
        /// Identifiers of the base plans that become available to the tenant immediately when a tenant subscribes to the offer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string[] BasePlanIds { get => this._basePlanIds; set => this._basePlanIds = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="ExternalReferenceId" /> property.</summary>
        private string _externalReferenceId;

        /// <summary>External reference identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string ExternalReferenceId { get => this._externalReferenceId; set => this._externalReferenceId = value; }

        /// <summary>Backing field for <see cref="MaxSubscriptionsPerAccount" /> property.</summary>
        private int? _maxSubscriptionsPerAccount;

        /// <summary>Maximum subscriptions per account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public int? MaxSubscriptionsPerAccount { get => this._maxSubscriptionsPerAccount; set => this._maxSubscriptionsPerAccount = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the Offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState? _state;

        /// <summary>Offer accessibility state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState? State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="SubscriptionCount" /> property.</summary>
        private int? _subscriptionCount;

        /// <summary>Current subscription count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public int? SubscriptionCount { get => this._subscriptionCount; set => this._subscriptionCount = value; }

        /// <summary>Creates an new <see cref="OfferProperties" /> instance.</summary>
        public OfferProperties()
        {

        }
    }
    /// Represents an offering of services against which a subscription can be created.
    public partial interface IOfferProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>
        /// References to add-on plans that a tenant can optionally acquire as a part of the offer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"References to add-on plans that a tenant can optionally acquire as a part of the offer.",
        SerializedName = @"addonPlans",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAddonPlanDefinition) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAddonPlanDefinition[] AddonPlans { get; set; }
        /// <summary>
        /// Identifiers of the base plans that become available to the tenant immediately when a tenant subscribes to the offer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identifiers of the base plans that become available to the tenant immediately when a tenant subscribes to the offer.",
        SerializedName = @"basePlanIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] BasePlanIds { get; set; }
        /// <summary>Description of offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of offer.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Display name of offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of offer.",
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
        /// <summary>Maximum subscriptions per account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum subscriptions per account.",
        SerializedName = @"maxSubscriptionsPerAccount",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxSubscriptionsPerAccount { get; set; }
        /// <summary>Name of the Offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the Offer.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Offer accessibility state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Offer accessibility state.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState? State { get; set; }
        /// <summary>Current subscription count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current subscription count.",
        SerializedName = @"subscriptionCount",
        PossibleTypes = new [] { typeof(int) })]
        int? SubscriptionCount { get; set; }

    }
    /// Represents an offering of services against which a subscription can be created.
    internal partial interface IOfferPropertiesInternal

    {
        /// <summary>
        /// References to add-on plans that a tenant can optionally acquire as a part of the offer.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAddonPlanDefinition[] AddonPlans { get; set; }
        /// <summary>
        /// Identifiers of the base plans that become available to the tenant immediately when a tenant subscribes to the offer.
        /// </summary>
        string[] BasePlanIds { get; set; }
        /// <summary>Description of offer.</summary>
        string Description { get; set; }
        /// <summary>Display name of offer.</summary>
        string DisplayName { get; set; }
        /// <summary>External reference identifier.</summary>
        string ExternalReferenceId { get; set; }
        /// <summary>Maximum subscriptions per account.</summary>
        int? MaxSubscriptionsPerAccount { get; set; }
        /// <summary>Name of the Offer.</summary>
        string Name { get; set; }
        /// <summary>Offer accessibility state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState? State { get; set; }
        /// <summary>Current subscription count.</summary>
        int? SubscriptionCount { get; set; }

    }
}