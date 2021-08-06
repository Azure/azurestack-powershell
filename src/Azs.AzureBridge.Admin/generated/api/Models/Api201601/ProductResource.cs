namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Product resource.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.DoNotFormat]
    public partial class ProductResource :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResource,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.Resource();

        /// <summary>Billing part number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string BillingPartNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).BillingPartNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).BillingPartNumber = value ?? null; }

        /// <summary>Full error message if any compatibility issues are found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string CompatibilityDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).CompatibilityDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).CompatibilityDescription = value ?? null; }

        /// <summary>Tells if product is compatible with current device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public bool? CompatibilityIsCompatible { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).CompatibilityIsCompatible; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).CompatibilityIsCompatible = value ?? default(bool); }

        /// <summary>List of all issues found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[] CompatibilityIssue { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).CompatibilityIssue; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).CompatibilityIssue = value ?? null /* arrayOf */; }

        /// <summary>Short error message if any compatibility issues are found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string CompatibilityMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).CompatibilityMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).CompatibilityMessage = value ?? null; }

        /// <summary>Description of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).Description = value ?? null; }

        /// <summary>Name displayed for the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).DisplayName = value ?? null; }

        /// <summary>Gallery item identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string GalleryItemIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).GalleryItemIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).GalleryItemIdentity = value ?? null; }

        /// <summary>The hero (815x290) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string IconUriHero { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).IconUriHero; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).IconUriHero = value ?? null; }

        /// <summary>The large (115x115) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string IconUriLarge { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).IconUriLarge; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).IconUriLarge = value ?? null; }

        /// <summary>The medium (90x90) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string IconUriMedium { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).IconUriMedium; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).IconUriMedium = value ?? null; }

        /// <summary>The small (40x40) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string IconUriSmall { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).IconUriSmall; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).IconUriSmall = value ?? null; }

        /// <summary>The wide (255x115) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string IconUriWide { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).IconUriWide; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).IconUriWide = value ?? null; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)__resource).Id = value ?? null; }

        /// <summary>Legal terms for the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string LegalTerm { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductInternal)Property).LegalTerm; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductInternal)Property).LegalTerm = value ?? null; }

        /// <summary>Gallery item identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink[] Link { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductInternal)Property).Link; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductInternal)Property).Link = value ?? null /* arrayOf */; }

        /// <summary>Location of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)__resource).Location; }

        /// <summary>Internal Acessors for Compatibility</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal.Compatibility { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).Compatibility; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).Compatibility = value; }

        /// <summary>Internal Acessors for IconUri</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIcons Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal.IconUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).IconUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).IconUri = value; }

        /// <summary>Internal Acessors for ProductProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductProperties Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal.ProductProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).Property = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProduct Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.Product()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal.Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)__resource).Location = value; }

        /// <summary>Internal Acessors for Tag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceTags Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal.Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)__resource).Tag = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)__resource).Name = value ?? null; }

        /// <summary>Offer name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string Offer { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).Offer; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).Offer = value ?? null; }

        /// <summary>Offer version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string OfferVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).OfferVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).OfferVersion = value ?? null; }

        /// <summary>Size in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public long? PayloadLength { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).PayloadLength; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).PayloadLength = value ?? default(long); }

        /// <summary>Privacy policy of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string PrivacyPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductInternal)Property).PrivacyPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductInternal)Property).PrivacyPolicy = value ?? null; }

        /// <summary>
        /// The kind. E.g. VirtualMachineProductProperties.ProductKind or WebApp, SolutionTemplate.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string ProductKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).Kind = value ?? null; }

        /// <summary>The version of the product</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string ProductProperties { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).PropertyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).PropertyVersion = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProduct _property;

        /// <summary>Properties of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProduct Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.Product()); set => this._property = value; }

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductInternal)Property).ProvisioningState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState)""); }

        /// <summary>Name of publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string PublisherDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).PublisherDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).PublisherDisplayName = value ?? null; }

        /// <summary>Publisher identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string PublisherIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).PublisherIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).PublisherIdentifier = value ?? null; }

        /// <summary>Product SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)Property).Sku = value ?? null; }

        /// <summary>List of key value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)__resource).Tag; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)__resource).Type = value ?? null; }

        /// <summary>Extension type of the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string VMExtensionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductInternal)Property).VMExtensionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductInternal)Property).VMExtensionType = value ?? null; }

        /// <summary>Creates an new <see cref="ProductResource" /> instance.</summary>
        public ProductResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Product resource.
    public partial interface IProductResource :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResource
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
        /// <summary>Legal terms for the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Legal terms for the product.",
        SerializedName = @"legalTerms",
        PossibleTypes = new [] { typeof(string) })]
        string LegalTerm { get; set; }
        /// <summary>Gallery item identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gallery item identity.",
        SerializedName = @"links",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink[] Link { get; set; }
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
        /// <summary>Privacy policy of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Privacy policy of the product.",
        SerializedName = @"privacyPolicy",
        PossibleTypes = new [] { typeof(string) })]
        string PrivacyPolicy { get; set; }
        /// <summary>
        /// The kind. E.g. VirtualMachineProductProperties.ProductKind or WebApp, SolutionTemplate.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The kind. E.g. VirtualMachineProductProperties.ProductKind or WebApp, SolutionTemplate.",
        SerializedName = @"productKind",
        PossibleTypes = new [] { typeof(string) })]
        string ProductKind { get; set; }
        /// <summary>The version of the product</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the product",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string ProductProperties { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState? ProvisioningState { get; set; }
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
        /// <summary>Extension type of the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Extension type of the VM.",
        SerializedName = @"vmExtensionType",
        PossibleTypes = new [] { typeof(string) })]
        string VMExtensionType { get; set; }

    }
    /// Product resource.
    internal partial interface IProductResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal
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
        /// <summary>Legal terms for the product.</summary>
        string LegalTerm { get; set; }
        /// <summary>Gallery item identity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink[] Link { get; set; }
        /// <summary>Offer name.</summary>
        string Offer { get; set; }
        /// <summary>Offer version.</summary>
        string OfferVersion { get; set; }
        /// <summary>Size in bytes.</summary>
        long? PayloadLength { get; set; }
        /// <summary>Privacy policy of the product.</summary>
        string PrivacyPolicy { get; set; }
        /// <summary>
        /// The kind. E.g. VirtualMachineProductProperties.ProductKind or WebApp, SolutionTemplate.
        /// </summary>
        string ProductKind { get; set; }
        /// <summary>The version of the product</summary>
        string ProductProperties { get; set; }
        /// <summary>
        /// the product properties. At the moment only VirtualMachineProductProperties is allowed.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductProperties ProductProperty { get; set; }
        /// <summary>Properties of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProduct Property { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Name of publisher.</summary>
        string PublisherDisplayName { get; set; }
        /// <summary>Publisher identifier.</summary>
        string PublisherIdentifier { get; set; }
        /// <summary>Product SKU.</summary>
        string Sku { get; set; }
        /// <summary>Extension type of the VM.</summary>
        string VMExtensionType { get; set; }

    }
}