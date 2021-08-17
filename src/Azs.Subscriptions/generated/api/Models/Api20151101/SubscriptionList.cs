namespace Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Extensions;

    /// <summary>List of subscriptions.</summary>
    public partial class SubscriptionList :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionList,
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription[] _value;

        /// <summary>Subscription definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="SubscriptionList" /> instance.</summary>
        public SubscriptionList()
        {

        }
    }
    /// List of subscriptions.
    public partial interface ISubscriptionList :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Subscription definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription definition.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription) })]
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription[] Value { get; set; }

    }
    /// List of subscriptions.
    internal partial interface ISubscriptionListInternal

    {
        /// <summary>URI to the next page.</summary>
        string NextLink { get; set; }
        /// <summary>Subscription definition.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription[] Value { get; set; }

    }
}