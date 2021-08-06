namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.PowerShell;

    /// <summary>Properties for aggregate usage.</summary>
    [System.ComponentModel.TypeConverter(typeof(DownloadedProductTypeConverter))]
    public partial class DownloadedProduct
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.DownloadedProduct"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProduct" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProduct DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DownloadedProduct(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.DownloadedProduct"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProduct" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProduct DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DownloadedProduct(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.DownloadedProduct"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DownloadedProduct(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailsProperty = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedProductProperties) content.GetValueForProperty("ProductDetailsProperty",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailsProperty, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ExtendedProductPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).VMExtensionType = (string) content.GetValueForProperty("VMExtensionType",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).VMExtensionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).Link = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink[]) content.GetValueForProperty("Link",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).Link, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink>(__y, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductLinkTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).LegalTerm = (string) content.GetValueForProperty("LegalTerm",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).LegalTerm, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).PrivacyPolicy = (string) content.GetValueForProperty("PrivacyPolicy",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).PrivacyPolicy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).GalleryPackageBlobSasUri = (string) content.GetValueForProperty("GalleryPackageBlobSasUri",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).GalleryPackageBlobSasUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PropertyVersion = (string) content.GetValueForProperty("PropertyVersion",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PropertyVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityMessage = (string) content.GetValueForProperty("CompatibilityMessage",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityDescription = (string) content.GetValueForProperty("CompatibilityDescription",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityIssue = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[]) content.GetValueForProperty("CompatibilityIssue",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityIssue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue>(__y, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriHero = (string) content.GetValueForProperty("IconUriHero",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriHero, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriLarge = (string) content.GetValueForProperty("IconUriLarge",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriLarge, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriWide = (string) content.GetValueForProperty("IconUriWide",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriWide, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriMedium = (string) content.GetValueForProperty("IconUriMedium",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriMedium, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriSmall = (string) content.GetValueForProperty("IconUriSmall",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriSmall, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityIsCompatible = (bool?) content.GetValueForProperty("CompatibilityIsCompatible",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityIsCompatible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUri = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIcons) content.GetValueForProperty("IconUri",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUri, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.GalleryIconsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Compatibility = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility) content.GetValueForProperty("Compatibility",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Compatibility, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.CompatibilityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PublisherDisplayName = (string) content.GetValueForProperty("PublisherDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PublisherDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PublisherIdentifier = (string) content.GetValueForProperty("PublisherIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PublisherIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Offer = (string) content.GetValueForProperty("Offer",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Offer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).OfferVersion = (string) content.GetValueForProperty("OfferVersion",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).OfferVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Sku = (string) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Sku, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).BillingPartNumber = (string) content.GetValueForProperty("BillingPartNumber",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).BillingPartNumber, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).GalleryItemIdentity = (string) content.GetValueForProperty("GalleryItemIdentity",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).GalleryItemIdentity, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PayloadLength = (long?) content.GetValueForProperty("PayloadLength",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PayloadLength, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Kind, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyComputeRole = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole?) content.GetValueForProperty("ProductDetailPropertyComputeRole",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyComputeRole, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertySourceBlobUri = (string) content.GetValueForProperty("ProductDetailPropertySourceBlobUri",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertySourceBlobUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertySourceBlob = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUri) content.GetValueForProperty("ProductDetailPropertySourceBlob",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertySourceBlob, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.UriTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyIsSystemExtension = (bool?) content.GetValueForProperty("ProductDetailPropertyIsSystemExtension",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyIsSystemExtension, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertySupportMultipleExtension = (bool?) content.GetValueForProperty("ProductDetailPropertySupportMultipleExtension",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertySupportMultipleExtension, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyVersion = (string) content.GetValueForProperty("ProductDetailPropertyVersion",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyVmosType = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem?) content.GetValueForProperty("ProductDetailPropertyVmosType",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyVmosType, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyVMScaleSetEnabled = (bool?) content.GetValueForProperty("ProductDetailPropertyVMScaleSetEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyVMScaleSetEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyOSDiskImageOperatingSystem = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem?) content.GetValueForProperty("ProductDetailPropertyOSDiskImageOperatingSystem",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyOSDiskImageOperatingSystem, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyOSDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImage) content.GetValueForProperty("ProductDetailPropertyOSDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyOSDiskImage, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.OSDiskImageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyDataDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[]) content.GetValueForProperty("ProductDetailPropertyDataDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyDataDiskImage, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage>(__y, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.DataDiskImageTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyOSDiskImageSourceBlobSasUri = (string) content.GetValueForProperty("ProductDetailPropertyOSDiskImageSourceBlobSasUri",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyOSDiskImageSourceBlobSasUri, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.DownloadedProduct"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DownloadedProduct(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailsProperty = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedProductProperties) content.GetValueForProperty("ProductDetailsProperty",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailsProperty, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ExtendedProductPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).VMExtensionType = (string) content.GetValueForProperty("VMExtensionType",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).VMExtensionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).Link = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink[]) content.GetValueForProperty("Link",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).Link, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink>(__y, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductLinkTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).LegalTerm = (string) content.GetValueForProperty("LegalTerm",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).LegalTerm, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).PrivacyPolicy = (string) content.GetValueForProperty("PrivacyPolicy",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).PrivacyPolicy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).GalleryPackageBlobSasUri = (string) content.GetValueForProperty("GalleryPackageBlobSasUri",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).GalleryPackageBlobSasUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PropertyVersion = (string) content.GetValueForProperty("PropertyVersion",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PropertyVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityMessage = (string) content.GetValueForProperty("CompatibilityMessage",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityDescription = (string) content.GetValueForProperty("CompatibilityDescription",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityIssue = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[]) content.GetValueForProperty("CompatibilityIssue",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityIssue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue>(__y, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriHero = (string) content.GetValueForProperty("IconUriHero",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriHero, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriLarge = (string) content.GetValueForProperty("IconUriLarge",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriLarge, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriWide = (string) content.GetValueForProperty("IconUriWide",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriWide, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriMedium = (string) content.GetValueForProperty("IconUriMedium",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriMedium, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriSmall = (string) content.GetValueForProperty("IconUriSmall",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUriSmall, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityIsCompatible = (bool?) content.GetValueForProperty("CompatibilityIsCompatible",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).CompatibilityIsCompatible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUri = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIcons) content.GetValueForProperty("IconUri",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).IconUri, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.GalleryIconsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Compatibility = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility) content.GetValueForProperty("Compatibility",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Compatibility, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.CompatibilityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PublisherDisplayName = (string) content.GetValueForProperty("PublisherDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PublisherDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PublisherIdentifier = (string) content.GetValueForProperty("PublisherIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PublisherIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Offer = (string) content.GetValueForProperty("Offer",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Offer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).OfferVersion = (string) content.GetValueForProperty("OfferVersion",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).OfferVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Sku = (string) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Sku, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).BillingPartNumber = (string) content.GetValueForProperty("BillingPartNumber",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).BillingPartNumber, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).GalleryItemIdentity = (string) content.GetValueForProperty("GalleryItemIdentity",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).GalleryItemIdentity, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PayloadLength = (long?) content.GetValueForProperty("PayloadLength",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).PayloadLength, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductBaseInternal)this).Kind, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyComputeRole = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole?) content.GetValueForProperty("ProductDetailPropertyComputeRole",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyComputeRole, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertySourceBlobUri = (string) content.GetValueForProperty("ProductDetailPropertySourceBlobUri",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertySourceBlobUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertySourceBlob = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUri) content.GetValueForProperty("ProductDetailPropertySourceBlob",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertySourceBlob, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.UriTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyIsSystemExtension = (bool?) content.GetValueForProperty("ProductDetailPropertyIsSystemExtension",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyIsSystemExtension, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertySupportMultipleExtension = (bool?) content.GetValueForProperty("ProductDetailPropertySupportMultipleExtension",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertySupportMultipleExtension, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyVersion = (string) content.GetValueForProperty("ProductDetailPropertyVersion",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyVmosType = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem?) content.GetValueForProperty("ProductDetailPropertyVmosType",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyVmosType, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyVMScaleSetEnabled = (bool?) content.GetValueForProperty("ProductDetailPropertyVMScaleSetEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyVMScaleSetEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyOSDiskImageOperatingSystem = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem?) content.GetValueForProperty("ProductDetailPropertyOSDiskImageOperatingSystem",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyOSDiskImageOperatingSystem, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyOSDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImage) content.GetValueForProperty("ProductDetailPropertyOSDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyOSDiskImage, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.OSDiskImageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyDataDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[]) content.GetValueForProperty("ProductDetailPropertyDataDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyDataDiskImage, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage>(__y, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.DataDiskImageTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyOSDiskImageSourceBlobSasUri = (string) content.GetValueForProperty("ProductDetailPropertyOSDiskImageSourceBlobSasUri",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductInternal)this).ProductDetailPropertyOSDiskImageSourceBlobSasUri, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DownloadedProduct" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProduct FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties for aggregate usage.
    [System.ComponentModel.TypeConverter(typeof(DownloadedProductTypeConverter))]
    public partial interface IDownloadedProduct

    {

    }
}