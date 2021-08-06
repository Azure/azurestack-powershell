namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Properties for a product.</summary>
    public partial class Product
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProduct.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProduct.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProduct FromJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject json ? new Product(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject into a new instance of <see cref="Product" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Product(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __productBase = new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductBase(json);
            {_vMExtensionType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString>("vmExtensionType"), out var __jsonVMExtensionType) ? (string)__jsonVMExtensionType : (string)VMExtensionType;}
            {_link = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonArray>("links"), out var __jsonLinks) ? If( __jsonLinks as Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IProductLink) (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ProductLink.FromJson(__u) )) ))() : null : Link;}
            {_legalTerm = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString>("legalTerms"), out var __jsonLegalTerms) ? (string)__jsonLegalTerms : (string)LegalTerm;}
            {_privacyPolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString>("privacyPolicy"), out var __jsonPrivacyPolicy) ? (string)__jsonPrivacyPolicy : (string)PrivacyPolicy;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Product" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Product" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __productBase?.ToJson(container, serializationMode);
            AddIf( null != (((object)this._vMExtensionType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString(this._vMExtensionType.ToString()) : null, "vmExtensionType" ,container.Add );
            if (null != this._link)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.XNodeArray();
                foreach( var __x in this._link )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("links",__w);
            }
            AddIf( null != (((object)this._legalTerm)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString(this._legalTerm.ToString()) : null, "legalTerms" ,container.Add );
            AddIf( null != (((object)this._privacyPolicy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString(this._privacyPolicy.ToString()) : null, "privacyPolicy" ,container.Add );
            AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}