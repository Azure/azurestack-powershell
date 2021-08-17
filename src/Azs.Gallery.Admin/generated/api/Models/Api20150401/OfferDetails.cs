namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Represents a offer details item read from the gallery item package.</summary>
    public partial class OfferDetails :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetails,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetailsInternal
    {

        /// <summary>Internal Acessors for Plan</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetailsInternal.Plan { get => this._plan; set { {_plan = value;} } }

        /// <summary>Backing field for <see cref="OfferId" /> property.</summary>
        private string _offerId;

        /// <summary>Offer identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string OfferId { get => this._offerId; set => this._offerId = value; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan[] _plan;

        /// <summary>List of plans available for the offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan[] Plan { get => this._plan; }

        /// <summary>Backing field for <see cref="PublisherId" /> property.</summary>
        private string _publisherId;

        /// <summary>Publisher identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string PublisherId { get => this._publisherId; set => this._publisherId = value; }

        /// <summary>Creates an new <see cref="OfferDetails" /> instance.</summary>
        public OfferDetails()
        {

        }
    }
    /// Represents a offer details item read from the gallery item package.
    public partial interface IOfferDetails :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Offer identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Offer identifier.",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferId { get; set; }
        /// <summary>List of plans available for the offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of plans available for the offer.",
        SerializedName = @"plans",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan[] Plan { get;  }
        /// <summary>Publisher identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Publisher identifier.",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string PublisherId { get; set; }

    }
    /// Represents a offer details item read from the gallery item package.
    internal partial interface IOfferDetailsInternal

    {
        /// <summary>Offer identifier.</summary>
        string OfferId { get; set; }
        /// <summary>List of plans available for the offer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan[] Plan { get; set; }
        /// <summary>Publisher identifier.</summary>
        string PublisherId { get; set; }

    }
}