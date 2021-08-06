namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.PowerShell;

    /// <summary>Product resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(ProductResourceTypeConverter))]
    public partial class ProductResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ProductResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ProductResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProductResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ProductResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProduct) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProductProperty = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductProperties) content.GetValueForProperty("ProductProperty",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProductProperty, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Compatibility = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility) content.GetValueForProperty("Compatibility",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Compatibility, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.CompatibilityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProductProperties = (string) content.GetValueForProperty("ProductProperties",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProductProperties, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityMessage = (string) content.GetValueForProperty("CompatibilityMessage",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityDescription = (string) content.GetValueForProperty("CompatibilityDescription",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityIssue = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[]) content.GetValueForProperty("CompatibilityIssue",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityIssue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue>(__y, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUri = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIcons) content.GetValueForProperty("IconUri",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUri, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.GalleryIconsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PublisherDisplayName = (string) content.GetValueForProperty("PublisherDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PublisherDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PublisherIdentifier = (string) content.GetValueForProperty("PublisherIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PublisherIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Offer = (string) content.GetValueForProperty("Offer",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Offer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).OfferVersion = (string) content.GetValueForProperty("OfferVersion",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).OfferVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Sku = (string) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Sku, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).BillingPartNumber = (string) content.GetValueForProperty("BillingPartNumber",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).BillingPartNumber, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).GalleryItemIdentity = (string) content.GetValueForProperty("GalleryItemIdentity",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).GalleryItemIdentity, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PayloadLength = (long?) content.GetValueForProperty("PayloadLength",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PayloadLength, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProductKind = (string) content.GetValueForProperty("ProductKind",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProductKind, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).VMExtensionType = (string) content.GetValueForProperty("VMExtensionType",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).VMExtensionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Link = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink[]) content.GetValueForProperty("Link",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Link, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink>(__y, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductLinkTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).LegalTerm = (string) content.GetValueForProperty("LegalTerm",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).LegalTerm, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PrivacyPolicy = (string) content.GetValueForProperty("PrivacyPolicy",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PrivacyPolicy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriHero = (string) content.GetValueForProperty("IconUriHero",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriHero, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriLarge = (string) content.GetValueForProperty("IconUriLarge",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriLarge, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriWide = (string) content.GetValueForProperty("IconUriWide",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriWide, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriMedium = (string) content.GetValueForProperty("IconUriMedium",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriMedium, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriSmall = (string) content.GetValueForProperty("IconUriSmall",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriSmall, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityIsCompatible = (bool?) content.GetValueForProperty("CompatibilityIsCompatible",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityIsCompatible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ProductResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProduct) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProductProperty = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductProperties) content.GetValueForProperty("ProductProperty",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProductProperty, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Compatibility = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility) content.GetValueForProperty("Compatibility",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Compatibility, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.CompatibilityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProductProperties = (string) content.GetValueForProperty("ProductProperties",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProductProperties, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityMessage = (string) content.GetValueForProperty("CompatibilityMessage",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityDescription = (string) content.GetValueForProperty("CompatibilityDescription",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityIssue = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[]) content.GetValueForProperty("CompatibilityIssue",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityIssue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue>(__y, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUri = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIcons) content.GetValueForProperty("IconUri",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUri, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.GalleryIconsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PublisherDisplayName = (string) content.GetValueForProperty("PublisherDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PublisherDisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PublisherIdentifier = (string) content.GetValueForProperty("PublisherIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PublisherIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Offer = (string) content.GetValueForProperty("Offer",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Offer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).OfferVersion = (string) content.GetValueForProperty("OfferVersion",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).OfferVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Sku = (string) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Sku, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).BillingPartNumber = (string) content.GetValueForProperty("BillingPartNumber",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).BillingPartNumber, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).GalleryItemIdentity = (string) content.GetValueForProperty("GalleryItemIdentity",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).GalleryItemIdentity, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PayloadLength = (long?) content.GetValueForProperty("PayloadLength",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PayloadLength, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProductKind = (string) content.GetValueForProperty("ProductKind",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).ProductKind, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).VMExtensionType = (string) content.GetValueForProperty("VMExtensionType",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).VMExtensionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Link = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink[]) content.GetValueForProperty("Link",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).Link, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink>(__y, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductLinkTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).LegalTerm = (string) content.GetValueForProperty("LegalTerm",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).LegalTerm, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PrivacyPolicy = (string) content.GetValueForProperty("PrivacyPolicy",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).PrivacyPolicy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriHero = (string) content.GetValueForProperty("IconUriHero",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriHero, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriLarge = (string) content.GetValueForProperty("IconUriLarge",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriLarge, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriWide = (string) content.GetValueForProperty("IconUriWide",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriWide, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriMedium = (string) content.GetValueForProperty("IconUriMedium",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriMedium, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriSmall = (string) content.GetValueForProperty("IconUriSmall",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).IconUriSmall, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityIsCompatible = (bool?) content.GetValueForProperty("CompatibilityIsCompatible",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductResourceInternal)this).CompatibilityIsCompatible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Product resource.
    [System.ComponentModel.TypeConverter(typeof(ProductResourceTypeConverter))]
    public partial interface IProductResource

    {

    }
}