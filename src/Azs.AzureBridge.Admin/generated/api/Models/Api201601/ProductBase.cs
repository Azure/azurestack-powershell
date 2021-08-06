namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Base object for all product classes.</summary>
    public partial class ProductBase :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBase,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal
    {

        /// <summary>Backing field for <see cref="BillingPartNumber" /> property.</summary>
        private string _billingPartNumber;

        /// <summary>Billing part number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string BillingPartNumber { get => this._billingPartNumber; set => this._billingPartNumber = value; }

        /// <summary>Backing field for <see cref="Compatibility" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility _compatibility;

        /// <summary>Product compatibility with current device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility Compatibility { get => (this._compatibility = this._compatibility ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.Compatibility()); set => this._compatibility = value; }

        /// <summary>Full error message if any compatibility issues are found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string CompatibilityDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)Compatibility).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)Compatibility).Description = value ?? null; }

        /// <summary>Tells if product is compatible with current device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public bool? CompatibilityIsCompatible { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)Compatibility).IsCompatible; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)Compatibility).IsCompatible = value ?? default(bool); }

        /// <summary>List of all issues found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[] CompatibilityIssue { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)Compatibility).Issue; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)Compatibility).Issue = value ?? null /* arrayOf */; }

        /// <summary>Short error message if any compatibility issues are found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string CompatibilityMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)Compatibility).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)Compatibility).Message = value ?? null; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Name displayed for the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="GalleryItemIdentity" /> property.</summary>
        private string _galleryItemIdentity;

        /// <summary>Gallery item identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string GalleryItemIdentity { get => this._galleryItemIdentity; set => this._galleryItemIdentity = value; }

        /// <summary>Backing field for <see cref="IconUri" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIcons _iconUri;

        /// <summary>Information about gallery icons.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIcons IconUri { get => (this._iconUri = this._iconUri ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.GalleryIcons()); set => this._iconUri = value; }

        /// <summary>The hero (815x290) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string IconUriHero { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIconsInternal)IconUri).Hero; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIconsInternal)IconUri).Hero = value ?? null; }

        /// <summary>The large (115x115) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string IconUriLarge { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIconsInternal)IconUri).Large; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIconsInternal)IconUri).Large = value ?? null; }

        /// <summary>The medium (90x90) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string IconUriMedium { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIconsInternal)IconUri).Medium; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIconsInternal)IconUri).Medium = value ?? null; }

        /// <summary>The small (40x40) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string IconUriSmall { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIconsInternal)IconUri).Small; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIconsInternal)IconUri).Small = value ?? null; }

        /// <summary>The wide (255x115) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string IconUriWide { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIconsInternal)IconUri).Wide; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIconsInternal)IconUri).Wide = value ?? null; }

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind;

        /// <summary>
        /// The kind. E.g. VirtualMachineProductProperties.ProductKind or WebApp, SolutionTemplate.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Internal Acessors for Compatibility</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal.Compatibility { get => (this._compatibility = this._compatibility ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.Compatibility()); set { {_compatibility = value;} } }

        /// <summary>Internal Acessors for IconUri</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIcons Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal.IconUri { get => (this._iconUri = this._iconUri ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.GalleryIcons()); set { {_iconUri = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductProperties Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Offer" /> property.</summary>
        private string _offer;

        /// <summary>Offer name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string Offer { get => this._offer; set => this._offer = value; }

        /// <summary>Backing field for <see cref="OfferVersion" /> property.</summary>
        private string _offerVersion;

        /// <summary>Offer version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string OfferVersion { get => this._offerVersion; set => this._offerVersion = value; }

        /// <summary>Backing field for <see cref="PayloadLength" /> property.</summary>
        private long? _payloadLength;

        /// <summary>Size in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public long? PayloadLength { get => this._payloadLength; set => this._payloadLength = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductProperties _property;

        /// <summary>
        /// the product properties. At the moment only VirtualMachineProductProperties is allowed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductProperties()); set => this._property = value; }

        /// <summary>The version of the product</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string PropertyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductPropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductPropertiesInternal)Property).Version = value ?? null; }

        /// <summary>Backing field for <see cref="PublisherDisplayName" /> property.</summary>
        private string _publisherDisplayName;

        /// <summary>Name of publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string PublisherDisplayName { get => this._publisherDisplayName; set => this._publisherDisplayName = value; }

        /// <summary>Backing field for <see cref="PublisherIdentifier" /> property.</summary>
        private string _publisherIdentifier;

        /// <summary>Publisher identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string PublisherIdentifier { get => this._publisherIdentifier; set => this._publisherIdentifier = value; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private string _sku;

        /// <summary>Product SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string Sku { get => this._sku; set => this._sku = value; }

        /// <summary>Creates an new <see cref="ProductBase" /> instance.</summary>
        public ProductBase()
        {

        }
    }
    /// Base object for all product classes.
    public partial interface IProductBase :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Billing part number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Billing part number.",
        SerializedName = @"billingPartNumber",
        PossibleTypes = new [] { typeof(string) })]
        string BillingPartNumber { get; set; }
        /// <summary>Full error message if any compatibility issues are found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Full error message if any compatibility issues are found",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string CompatibilityDescription { get; set; }
        /// <summary>Tells if product is compatible with current device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tells if product is compatible with current device",
        SerializedName = @"isCompatible",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CompatibilityIsCompatible { get; set; }
        /// <summary>List of all issues found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of all issues found",
        SerializedName = @"issues",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[] CompatibilityIssue { get; set; }
        /// <summary>Short error message if any compatibility issues are found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Short error message if any compatibility issues are found",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string CompatibilityMessage { get; set; }
        /// <summary>Description of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the product.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Name displayed for the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name displayed for the product.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Gallery item identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gallery item identity.",
        SerializedName = @"galleryItemIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string GalleryItemIdentity { get; set; }
        /// <summary>The hero (815x290) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The hero (815x290) icon relative path.",
        SerializedName = @"hero",
        PossibleTypes = new [] { typeof(string) })]
        string IconUriHero { get; set; }
        /// <summary>The large (115x115) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The large (115x115) icon relative path.",
        SerializedName = @"large",
        PossibleTypes = new [] { typeof(string) })]
        string IconUriLarge { get; set; }
        /// <summary>The medium (90x90) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The medium (90x90) icon relative path.",
        SerializedName = @"medium",
        PossibleTypes = new [] { typeof(string) })]
        string IconUriMedium { get; set; }
        /// <summary>The small (40x40) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The small (40x40) icon relative path.",
        SerializedName = @"small",
        PossibleTypes = new [] { typeof(string) })]
        string IconUriSmall { get; set; }
        /// <summary>The wide (255x115) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The wide (255x115) icon relative path.",
        SerializedName = @"wide",
        PossibleTypes = new [] { typeof(string) })]
        string IconUriWide { get; set; }
        /// <summary>
        /// The kind. E.g. VirtualMachineProductProperties.ProductKind or WebApp, SolutionTemplate.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The kind. E.g. VirtualMachineProductProperties.ProductKind or WebApp, SolutionTemplate.",
        SerializedName = @"productKind",
        PossibleTypes = new [] { typeof(string) })]
        string Kind { get; set; }
        /// <summary>Offer name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Offer name.",
        SerializedName = @"offer",
        PossibleTypes = new [] { typeof(string) })]
        string Offer { get; set; }
        /// <summary>Offer version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Offer version.",
        SerializedName = @"offerVersion",
        PossibleTypes = new [] { typeof(string) })]
        string OfferVersion { get; set; }
        /// <summary>Size in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Size in bytes.",
        SerializedName = @"payloadLength",
        PossibleTypes = new [] { typeof(long) })]
        long? PayloadLength { get; set; }
        /// <summary>The version of the product</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the product",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyVersion { get; set; }
        /// <summary>Name of publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of publisher.",
        SerializedName = @"publisherDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string PublisherDisplayName { get; set; }
        /// <summary>Publisher identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Publisher identifier.",
        SerializedName = @"publisherIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string PublisherIdentifier { get; set; }
        /// <summary>Product SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Product SKU.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string Sku { get; set; }

    }
    /// Base object for all product classes.
    internal partial interface IProductBaseInternal

    {
        /// <summary>Billing part number.</summary>
        string BillingPartNumber { get; set; }
        /// <summary>Product compatibility with current device.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility Compatibility { get; set; }
        /// <summary>Full error message if any compatibility issues are found</summary>
        string CompatibilityDescription { get; set; }
        /// <summary>Tells if product is compatible with current device</summary>
        bool? CompatibilityIsCompatible { get; set; }
        /// <summary>List of all issues found</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[] CompatibilityIssue { get; set; }
        /// <summary>Short error message if any compatibility issues are found</summary>
        string CompatibilityMessage { get; set; }
        /// <summary>Description of the product.</summary>
        string Description { get; set; }
        /// <summary>Name displayed for the product.</summary>
        string DisplayName { get; set; }
        /// <summary>Gallery item identity.</summary>
        string GalleryItemIdentity { get; set; }
        /// <summary>Information about gallery icons.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIcons IconUri { get; set; }
        /// <summary>The hero (815x290) icon relative path.</summary>
        string IconUriHero { get; set; }
        /// <summary>The large (115x115) icon relative path.</summary>
        string IconUriLarge { get; set; }
        /// <summary>The medium (90x90) icon relative path.</summary>
        string IconUriMedium { get; set; }
        /// <summary>The small (40x40) icon relative path.</summary>
        string IconUriSmall { get; set; }
        /// <summary>The wide (255x115) icon relative path.</summary>
        string IconUriWide { get; set; }
        /// <summary>
        /// The kind. E.g. VirtualMachineProductProperties.ProductKind or WebApp, SolutionTemplate.
        /// </summary>
        string Kind { get; set; }
        /// <summary>Offer name.</summary>
        string Offer { get; set; }
        /// <summary>Offer version.</summary>
        string OfferVersion { get; set; }
        /// <summary>Size in bytes.</summary>
        long? PayloadLength { get; set; }
        /// <summary>
        /// the product properties. At the moment only VirtualMachineProductProperties is allowed.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductProperties Property { get; set; }
        /// <summary>The version of the product</summary>
        string PropertyVersion { get; set; }
        /// <summary>Name of publisher.</summary>
        string PublisherDisplayName { get; set; }
        /// <summary>Publisher identifier.</summary>
        string PublisherIdentifier { get; set; }
        /// <summary>Product SKU.</summary>
        string Sku { get; set; }

    }
}