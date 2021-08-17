namespace Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Extensions;

    /// <summary>List of public offers.</summary>
    public partial class OfferList :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IOfferList,
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IOfferListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IOffer[] _value;

        /// <summary>List of public offers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IOffer[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OfferList" /> instance.</summary>
        public OfferList()
        {

        }
    }
    /// List of public offers.
    public partial interface IOfferList :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.IJsonSerializable
    {
        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of public offers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of public offers.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IOffer) })]
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IOffer[] Value { get; set; }

    }
    /// List of public offers.
    internal partial interface IOfferListInternal

    {
        /// <summary>URI to next page.</summary>
        string NextLink { get; set; }
        /// <summary>List of public offers.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IOffer[] Value { get; set; }

    }
}