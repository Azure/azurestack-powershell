namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Properties for a product.</summary>
    public partial class Product :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProduct,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductInternal,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBase __productBase = new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductBase();

        /// <summary>Billing part number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string BillingPartNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).BillingPartNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).BillingPartNumber = value ?? null; }

        /// <summary>Product compatibility with current device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility Compatibility { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).Compatibility; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).Compatibility = value ?? null /* model class */; }

        /// <summary>Full error message if any compatibility issues are found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string CompatibilityDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).CompatibilityDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).CompatibilityDescription = value ?? null; }

        /// <summary>Tells if product is compatible with current device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public bool? CompatibilityIsCompatible { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).CompatibilityIsCompatible; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).CompatibilityIsCompatible = value ?? default(bool); }

        /// <summary>List of all issues found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[] CompatibilityIssue { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).CompatibilityIssue; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).CompatibilityIssue = value ?? null /* arrayOf */; }

        /// <summary>Short error message if any compatibility issues are found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string CompatibilityMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).CompatibilityMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).CompatibilityMessage = value ?? null; }

        /// <summary>Description of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).Description = value ?? null; }

        /// <summary>Name displayed for the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).DisplayName = value ?? null; }

        /// <summary>Gallery item identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string GalleryItemIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).GalleryItemIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).GalleryItemIdentity = value ?? null; }

        /// <summary>Information about gallery icons.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIcons IconUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).IconUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).IconUri = value ?? null /* model class */; }

        /// <summary>The hero (815x290) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string IconUriHero { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).IconUriHero; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).IconUriHero = value ?? null; }

        /// <summary>The large (115x115) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string IconUriLarge { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).IconUriLarge; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).IconUriLarge = value ?? null; }

        /// <summary>The medium (90x90) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string IconUriMedium { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).IconUriMedium; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).IconUriMedium = value ?? null; }

        /// <summary>The small (40x40) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string IconUriSmall { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).IconUriSmall; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).IconUriSmall = value ?? null; }

        /// <summary>The wide (255x115) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string IconUriWide { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).IconUriWide; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).IconUriWide = value ?? null; }

        /// <summary>
        /// The kind. E.g. VirtualMachineProductProperties.ProductKind or WebApp, SolutionTemplate.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).Kind = value ?? null; }

        /// <summary>Backing field for <see cref="LegalTerm" /> property.</summary>
        private string _legalTerm;

        /// <summary>Legal terms for the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string LegalTerm { get => this._legalTerm; set => this._legalTerm = value; }

        /// <summary>Backing field for <see cref="Link" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink[] _link;

        /// <summary>Gallery item identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink[] Link { get => this._link; set => this._link = value; }

        /// <summary>Offer name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string Offer { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).Offer; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).Offer = value ?? null; }

        /// <summary>Offer version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string OfferVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).OfferVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).OfferVersion = value ?? null; }

        /// <summary>Size in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public long? PayloadLength { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).PayloadLength; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).PayloadLength = value ?? default(long); }

        /// <summary>Backing field for <see cref="PrivacyPolicy" /> property.</summary>
        private string _privacyPolicy;

        /// <summary>Privacy policy of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string PrivacyPolicy { get => this._privacyPolicy; set => this._privacyPolicy = value; }

        /// <summary>
        /// the product properties. At the moment only VirtualMachineProductProperties is allowed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductProperties Property { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).Property = value ?? null /* model class */; }

        /// <summary>The version of the product</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string PropertyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).PropertyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).PropertyVersion = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Name of publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string PublisherDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).PublisherDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).PublisherDisplayName = value ?? null; }

        /// <summary>Publisher identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string PublisherIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).PublisherIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).PublisherIdentifier = value ?? null; }

        /// <summary>Product SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)__productBase).Sku = value ?? null; }

        /// <summary>Backing field for <see cref="VMExtensionType" /> property.</summary>
        private string _vMExtensionType;

        /// <summary>Extension type of the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string VMExtensionType { get => this._vMExtensionType; set => this._vMExtensionType = value; }

        /// <summary>Creates an new <see cref="Product" /> instance.</summary>
        public Product()
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
            await eventListener.AssertNotNull(nameof(__productBase), __productBase);
            await eventListener.AssertObjectIsValid(nameof(__productBase), __productBase);
        }
    }
    /// Properties for a product.
    public partial interface IProduct :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBase
    {
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
        /// <summary>Privacy policy of the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Privacy policy of the product.",
        SerializedName = @"privacyPolicy",
        PossibleTypes = new [] { typeof(string) })]
        string PrivacyPolicy { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Extension type of the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Extension type of the VM.",
        SerializedName = @"vmExtensionType",
        PossibleTypes = new [] { typeof(string) })]
        string VMExtensionType { get; set; }

    }
    /// Properties for a product.
    internal partial interface IProductInternal :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal
    {
        /// <summary>Legal terms for the product.</summary>
        string LegalTerm { get; set; }
        /// <summary>Gallery item identity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink[] Link { get; set; }
        /// <summary>Privacy policy of the product.</summary>
        string PrivacyPolicy { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Extension type of the VM.</summary>
        string VMExtensionType { get; set; }

    }
}