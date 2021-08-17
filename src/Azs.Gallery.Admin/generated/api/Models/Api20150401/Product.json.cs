namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Represents a product item read from the gallery item package.</summary>
    public partial class Product
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProduct.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProduct.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProduct FromJson(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject json ? new Product(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject into a new instance of <see cref="Product" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Product(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_offerDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject>("offerDetails"), out var __jsonOfferDetails) ? Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.OfferDetails.FromJson(__jsonOfferDetails) : OfferDetail;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_publisherDisplayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("publisherDisplayName"), out var __jsonPublisherDisplayName) ? (string)__jsonPublisherDisplayName : (string)PublisherDisplayName;}
            {_pricingDetailsUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("pricingDetailsUri"), out var __jsonPricingDetailsUri) ? (string)__jsonPricingDetailsUri : (string)PricingDetailsUri;}
            {_legalTerm = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("legalTerms"), out var __jsonLegalTerms) ? (string)__jsonLegalTerms : (string)LegalTerm;}
            {_privacyPolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("privacyPolicy"), out var __jsonPrivacyPolicy) ? (string)__jsonPrivacyPolicy : (string)PrivacyPolicy;}
            {_legalTermsUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("legalTermsUri"), out var __jsonLegalTermsUri) ? (string)__jsonLegalTermsUri : (string)LegalTermsUri;}
            {_privacyPolicyUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("privacyPolicyUri"), out var __jsonPrivacyPolicyUri) ? (string)__jsonPrivacyPolicyUri : (string)PrivacyPolicyUri;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Product" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Product" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._offerDetail ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) this._offerDetail.ToJson(null,serializationMode) : null, "offerDetails" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._publisherDisplayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._publisherDisplayName.ToString()) : null, "publisherDisplayName" ,container.Add );
            AddIf( null != (((object)this._pricingDetailsUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._pricingDetailsUri.ToString()) : null, "pricingDetailsUri" ,container.Add );
            AddIf( null != (((object)this._legalTerm)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._legalTerm.ToString()) : null, "legalTerms" ,container.Add );
            AddIf( null != (((object)this._privacyPolicy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._privacyPolicy.ToString()) : null, "privacyPolicy" ,container.Add );
            AddIf( null != (((object)this._legalTermsUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._legalTermsUri.ToString()) : null, "legalTermsUri" ,container.Add );
            AddIf( null != (((object)this._privacyPolicyUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._privacyPolicyUri.ToString()) : null, "privacyPolicyUri" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}