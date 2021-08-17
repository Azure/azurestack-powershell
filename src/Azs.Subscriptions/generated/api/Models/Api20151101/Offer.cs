namespace Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Extensions;

    /// <summary>Represents an offering of services against which a subscription can be created.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.Subscription.DoNotFormat]
    public partial class Offer :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IOffer,
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IOfferInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The offer ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="Offer" /> instance.</summary>
        public Offer()
        {

        }
    }
    /// Represents an offering of services against which a subscription can be created.
    public partial interface IOffer :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.IJsonSerializable
    {
        /// <summary>Description of offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of offer.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Display name of offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of offer.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The offer ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The offer ID",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the offer.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Represents an offering of services against which a subscription can be created.
    internal partial interface IOfferInternal

    {
        /// <summary>Description of offer.</summary>
        string Description { get; set; }
        /// <summary>Display name of offer.</summary>
        string DisplayName { get; set; }
        /// <summary>The offer ID</summary>
        string Id { get; set; }
        /// <summary>The name of the offer.</summary>
        string Name { get; set; }

    }
}