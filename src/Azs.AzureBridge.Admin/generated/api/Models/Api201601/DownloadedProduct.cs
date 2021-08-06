namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Properties for aggregate usage.</summary>
    public partial class DownloadedProduct :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProduct,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal,
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

        /// <summary>Backing field for <see cref="GalleryPackageBlobSasUri" /> property.</summary>
        private string _galleryPackageBlobSasUri;

        /// <summary>
        /// The URI to the .azpkg file that provides information required for showing product in the gallery.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string GalleryPackageBlobSasUri { get => this._galleryPackageBlobSasUri; set => this._galleryPackageBlobSasUri = value; }

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

        /// <summary>Internal Acessors for ProductDetailPropertyComputeRole</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole? Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal.ProductDetailPropertyComputeRole { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).ComputeRole; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).ComputeRole = value; }

        /// <summary>Internal Acessors for ProductDetailPropertyDataDiskImage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[] Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal.ProductDetailPropertyDataDiskImage { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)ProductDetailsProperty).DataDiskImage; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)ProductDetailsProperty).DataDiskImage = value; }

        /// <summary>Internal Acessors for ProductDetailPropertyOSDiskImage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImage Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal.ProductDetailPropertyOSDiskImage { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)ProductDetailsProperty).OSDiskImage; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)ProductDetailsProperty).OSDiskImage = value; }

        /// <summary>Internal Acessors for ProductDetailPropertyOSDiskImageOperatingSystem</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal.ProductDetailPropertyOSDiskImageOperatingSystem { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)ProductDetailsProperty).OSDiskImageOperatingSystem; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)ProductDetailsProperty).OSDiskImageOperatingSystem = value; }

        /// <summary>Internal Acessors for ProductDetailPropertyOSDiskImageSourceBlobSasUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal.ProductDetailPropertyOSDiskImageSourceBlobSasUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)ProductDetailsProperty).OSDiskImageSourceBlobSasUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)ProductDetailsProperty).OSDiskImageSourceBlobSasUri = value; }

        /// <summary>Internal Acessors for ProductDetailPropertySourceBlob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUri Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal.ProductDetailPropertySourceBlob { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).SourceBlob; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).SourceBlob = value; }

        /// <summary>Internal Acessors for ProductDetailPropertyVmosType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal.ProductDetailPropertyVmosType { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).VmosType; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).VmosType = value; }

        /// <summary>Internal Acessors for ProductDetailsProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedProductProperties Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal.ProductDetailsProperty { get => (this._productDetailsProperty = this._productDetailsProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ExtendedProductProperties()); set { {_productDetailsProperty = value;} } }

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

        /// <summary>Specifies kind of compute role included in the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole? ProductDetailPropertyComputeRole { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).ComputeRole; }

        /// <summary>List of attached data disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[] ProductDetailPropertyDataDiskImage { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)ProductDetailsProperty).DataDiskImage; }

        /// <summary>Specifies if product is a Virtual Machine Extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public bool? ProductDetailPropertyIsSystemExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).IsSystemExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).IsSystemExtension = value ?? default(bool); }

        /// <summary>OS operating system type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? ProductDetailPropertyOSDiskImageOperatingSystem { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)ProductDetailsProperty).OSDiskImageOperatingSystem; }

        /// <summary>SAS key for source blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string ProductDetailPropertyOSDiskImageSourceBlobSasUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)ProductDetailsProperty).OSDiskImageSourceBlobSasUri; }

        /// <summary>The URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string ProductDetailPropertySourceBlobUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).SourceBlobUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).SourceBlobUri = value ?? null; }

        /// <summary>Indicates if specified product supports multiple extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public bool? ProductDetailPropertySupportMultipleExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).SupportMultipleExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).SupportMultipleExtension = value ?? default(bool); }

        /// <summary>Indicates if virtual machine Scale Set is enabled in the specified product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public bool? ProductDetailPropertyVMScaleSetEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).VMScaleSetEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).VMScaleSetEnabled = value ?? default(bool); }

        /// <summary>Specifies product version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string ProductDetailPropertyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).Version = value ?? null; }

        /// <summary>Specifies operating system used by the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? ProductDetailPropertyVmosType { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)ProductDetailsProperty).VmosType; }

        /// <summary>Backing field for <see cref="ProductDetailsProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedProductProperties _productDetailsProperty;

        /// <summary>Specifies additional properties describing the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedProductProperties ProductDetailsProperty { get => (this._productDetailsProperty = this._productDetailsProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ExtendedProductProperties()); }

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

        /// <summary>Creates an new <see cref="DownloadedProduct" /> instance.</summary>
        public DownloadedProduct()
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
    /// Properties for aggregate usage.
    public partial interface IDownloadedProduct :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBase
    {
        /// <summary>
        /// The URI to the .azpkg file that provides information required for showing product in the gallery.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI to the .azpkg file that provides information required for showing product in the gallery.",
        SerializedName = @"galleryPackageBlobSasUri",
        PossibleTypes = new [] { typeof(string) })]
        string GalleryPackageBlobSasUri { get; set; }
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
        /// <summary>Specifies kind of compute role included in the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies kind of compute role included in the package.",
        SerializedName = @"computeRole",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole? ProductDetailPropertyComputeRole { get;  }
        /// <summary>List of attached data disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of attached data disks.",
        SerializedName = @"dataDiskImages",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[] ProductDetailPropertyDataDiskImage { get;  }
        /// <summary>Specifies if product is a Virtual Machine Extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies if product is a Virtual Machine Extension.",
        SerializedName = @"isSystemExtension",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ProductDetailPropertyIsSystemExtension { get; set; }
        /// <summary>OS operating system type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"OS operating system type.",
        SerializedName = @"operatingSystem",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? ProductDetailPropertyOSDiskImageOperatingSystem { get;  }
        /// <summary>SAS key for source blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"SAS key for source blob.",
        SerializedName = @"sourceBlobSasUri",
        PossibleTypes = new [] { typeof(string) })]
        string ProductDetailPropertyOSDiskImageSourceBlobSasUri { get;  }
        /// <summary>The URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string ProductDetailPropertySourceBlobUri { get; set; }
        /// <summary>Indicates if specified product supports multiple extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if specified product supports multiple extensions.",
        SerializedName = @"supportMultipleExtensions",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ProductDetailPropertySupportMultipleExtension { get; set; }
        /// <summary>Indicates if virtual machine Scale Set is enabled in the specified product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if virtual machine Scale Set is enabled in the specified product.",
        SerializedName = @"vmScaleSetEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ProductDetailPropertyVMScaleSetEnabled { get; set; }
        /// <summary>Specifies product version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies product version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string ProductDetailPropertyVersion { get; set; }
        /// <summary>Specifies operating system used by the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies operating system used by the product.",
        SerializedName = @"vmOsType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? ProductDetailPropertyVmosType { get;  }
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
    /// Properties for aggregate usage.
    internal partial interface IDownloadedProductInternal :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal
    {
        /// <summary>
        /// The URI to the .azpkg file that provides information required for showing product in the gallery.
        /// </summary>
        string GalleryPackageBlobSasUri { get; set; }
        /// <summary>Legal terms for the product.</summary>
        string LegalTerm { get; set; }
        /// <summary>Gallery item identity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink[] Link { get; set; }
        /// <summary>Privacy policy of the product.</summary>
        string PrivacyPolicy { get; set; }
        /// <summary>Specifies kind of compute role included in the package.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole? ProductDetailPropertyComputeRole { get; set; }
        /// <summary>List of attached data disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[] ProductDetailPropertyDataDiskImage { get; set; }
        /// <summary>Specifies if product is a Virtual Machine Extension.</summary>
        bool? ProductDetailPropertyIsSystemExtension { get; set; }
        /// <summary>OS disk image used by product.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImage ProductDetailPropertyOSDiskImage { get; set; }
        /// <summary>OS operating system type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? ProductDetailPropertyOSDiskImageOperatingSystem { get; set; }
        /// <summary>SAS key for source blob.</summary>
        string ProductDetailPropertyOSDiskImageSourceBlobSasUri { get; set; }
        /// <summary>Specifies a download location where content can be downloaded from.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUri ProductDetailPropertySourceBlob { get; set; }
        /// <summary>The URI.</summary>
        string ProductDetailPropertySourceBlobUri { get; set; }
        /// <summary>Indicates if specified product supports multiple extensions.</summary>
        bool? ProductDetailPropertySupportMultipleExtension { get; set; }
        /// <summary>Indicates if virtual machine Scale Set is enabled in the specified product.</summary>
        bool? ProductDetailPropertyVMScaleSetEnabled { get; set; }
        /// <summary>Specifies product version.</summary>
        string ProductDetailPropertyVersion { get; set; }
        /// <summary>Specifies operating system used by the product.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? ProductDetailPropertyVmosType { get; set; }
        /// <summary>Specifies additional properties describing the product.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedProductProperties ProductDetailsProperty { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Extension type of the VM.</summary>
        string VMExtensionType { get; set; }

    }
}