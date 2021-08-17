namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Properties for an delegated provider.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
    public partial class DelegatedProviderOfferProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDelegatedProviderOfferProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IDelegatedProviderOfferPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AccessibilityState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState? _accessibilityState;

        /// <summary>Offer accessibility state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState? AccessibilityState { get => this._accessibilityState; set => this._accessibilityState = value; }

        /// <summary>Backing field for <see cref="DelegatedOfferId" /> property.</summary>
        private string _delegatedOfferId;

        /// <summary>The delegated offer identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string DelegatedOfferId { get => this._delegatedOfferId; set => this._delegatedOfferId = value; }

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

        /// <summary>Backing field for <see cref="SubscriptionCount" /> property.</summary>
        private int? _subscriptionCount;

        /// <summary>Current subscription count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public int? SubscriptionCount { get => this._subscriptionCount; set => this._subscriptionCount = value; }

        /// <summary>Creates an new <see cref="DelegatedProviderOfferProperties" /> instance.</summary>
        public DelegatedProviderOfferProperties()
        {

        }
    }
    /// Properties for an delegated provider.
    public partial interface IDelegatedProviderOfferProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Offer accessibility state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Offer accessibility state.",
        SerializedName = @"accessibilityState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState? AccessibilityState { get; set; }
        /// <summary>The delegated offer identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The delegated offer identifier.",
        SerializedName = @"delegatedOfferId",
        PossibleTypes = new [] { typeof(string) })]
        string DelegatedOfferId { get; set; }
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
        /// <summary>Current subscription count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current subscription count.",
        SerializedName = @"subscriptionCount",
        PossibleTypes = new [] { typeof(int) })]
        int? SubscriptionCount { get; set; }

    }
    /// Properties for an delegated provider.
    internal partial interface IDelegatedProviderOfferPropertiesInternal

    {
        /// <summary>Offer accessibility state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.AccessibilityState? AccessibilityState { get; set; }
        /// <summary>The delegated offer identifier.</summary>
        string DelegatedOfferId { get; set; }
        /// <summary>Description of offer.</summary>
        string Description { get; set; }
        /// <summary>Display name of offer.</summary>
        string DisplayName { get; set; }
        /// <summary>External reference identifier.</summary>
        string ExternalReferenceId { get; set; }
        /// <summary>Current subscription count.</summary>
        int? SubscriptionCount { get; set; }

    }
}