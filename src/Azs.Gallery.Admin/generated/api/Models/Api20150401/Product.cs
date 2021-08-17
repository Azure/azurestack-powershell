namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Represents a product item read from the gallery item package.</summary>
    public partial class Product :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProduct,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProductInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="LegalTerm" /> property.</summary>
        private string _legalTerm;

        /// <summary>Legal terms of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string LegalTerm { get => this._legalTerm; set => this._legalTerm = value; }

        /// <summary>Backing field for <see cref="LegalTermsUri" /> property.</summary>
        private string _legalTermsUri;

        /// <summary>URI to the legal terms of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string LegalTermsUri { get => this._legalTermsUri; set => this._legalTermsUri = value; }

        /// <summary>Internal Acessors for OfferDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetails Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProductInternal.OfferDetail { get => (this._offerDetail = this._offerDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.OfferDetails()); set { {_offerDetail = value;} } }

        /// <summary>Internal Acessors for OfferDetailPlan</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProductInternal.OfferDetailPlan { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetailsInternal)OfferDetail).Plan; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetailsInternal)OfferDetail).Plan = value; }

        /// <summary>Backing field for <see cref="OfferDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetails _offerDetail;

        /// <summary>Offer details of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetails OfferDetail { get => (this._offerDetail = this._offerDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.OfferDetails()); set => this._offerDetail = value; }

        /// <summary>Offer identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string OfferDetailOfferId { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetailsInternal)OfferDetail).OfferId; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetailsInternal)OfferDetail).OfferId = value ?? null; }

        /// <summary>List of plans available for the offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan[] OfferDetailPlan { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetailsInternal)OfferDetail).Plan; }

        /// <summary>Publisher identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string OfferDetailPublisherId { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetailsInternal)OfferDetail).PublisherId; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetailsInternal)OfferDetail).PublisherId = value ?? null; }

        /// <summary>Backing field for <see cref="PricingDetailsUri" /> property.</summary>
        private string _pricingDetailsUri;

        /// <summary>URI to the pricing details of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string PricingDetailsUri { get => this._pricingDetailsUri; set => this._pricingDetailsUri = value; }

        /// <summary>Backing field for <see cref="PrivacyPolicy" /> property.</summary>
        private string _privacyPolicy;

        /// <summary>Privacy policy of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string PrivacyPolicy { get => this._privacyPolicy; set => this._privacyPolicy = value; }

        /// <summary>Backing field for <see cref="PrivacyPolicyUri" /> property.</summary>
        private string _privacyPolicyUri;

        /// <summary>URI to the privacy policy of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string PrivacyPolicyUri { get => this._privacyPolicyUri; set => this._privacyPolicyUri = value; }

        /// <summary>Backing field for <see cref="PublisherDisplayName" /> property.</summary>
        private string _publisherDisplayName;

        /// <summary>Publisher display name of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string PublisherDisplayName { get => this._publisherDisplayName; set => this._publisherDisplayName = value; }

        /// <summary>Creates an new <see cref="Product" /> instance.</summary>
        public Product()
        {

        }
    }
    /// Represents a product item read from the gallery item package.
    public partial interface IProduct :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Display name of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the product.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Legal terms of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Legal terms of the product.",
        SerializedName = @"legalTerms",
        PossibleTypes = new [] { typeof(string) })]
        string LegalTerm { get; set; }
        /// <summary>URI to the legal terms of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the legal terms of the product.",
        SerializedName = @"legalTermsUri",
        PossibleTypes = new [] { typeof(string) })]
        string LegalTermsUri { get; set; }
        /// <summary>Offer identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Offer identifier.",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailOfferId { get; set; }
        /// <summary>List of plans available for the offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of plans available for the offer.",
        SerializedName = @"plans",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan[] OfferDetailPlan { get;  }
        /// <summary>Publisher identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Publisher identifier.",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferDetailPublisherId { get; set; }
        /// <summary>URI to the pricing details of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the pricing details of the product.",
        SerializedName = @"pricingDetailsUri",
        PossibleTypes = new [] { typeof(string) })]
        string PricingDetailsUri { get; set; }
        /// <summary>Privacy policy of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Privacy policy of the product.",
        SerializedName = @"privacyPolicy",
        PossibleTypes = new [] { typeof(string) })]
        string PrivacyPolicy { get; set; }
        /// <summary>URI to the privacy policy of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the privacy policy of the product.",
        SerializedName = @"privacyPolicyUri",
        PossibleTypes = new [] { typeof(string) })]
        string PrivacyPolicyUri { get; set; }
        /// <summary>Publisher display name of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Publisher display name of the product.",
        SerializedName = @"publisherDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string PublisherDisplayName { get; set; }

    }
    /// Represents a product item read from the gallery item package.
    internal partial interface IProductInternal

    {
        /// <summary>Display name of the product.</summary>
        string DisplayName { get; set; }
        /// <summary>Legal terms of the product.</summary>
        string LegalTerm { get; set; }
        /// <summary>URI to the legal terms of the product.</summary>
        string LegalTermsUri { get; set; }
        /// <summary>Offer details of the product.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOfferDetails OfferDetail { get; set; }
        /// <summary>Offer identifier.</summary>
        string OfferDetailOfferId { get; set; }
        /// <summary>List of plans available for the offer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IPlan[] OfferDetailPlan { get; set; }
        /// <summary>Publisher identifier.</summary>
        string OfferDetailPublisherId { get; set; }
        /// <summary>URI to the pricing details of the product.</summary>
        string PricingDetailsUri { get; set; }
        /// <summary>Privacy policy of the product.</summary>
        string PrivacyPolicy { get; set; }
        /// <summary>URI to the privacy policy of the product.</summary>
        string PrivacyPolicyUri { get; set; }
        /// <summary>Publisher display name of the product.</summary>
        string PublisherDisplayName { get; set; }

    }
}