namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Properties of a gallery item.</summary>
    public partial class GalleryItemProperties1
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1 FromJson(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject json ? new GalleryItemProperties1(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject into a new instance of <see cref="GalleryItemProperties1" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal GalleryItemProperties1(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_marketingMaterial = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject>("marketingMaterial"), out var __jsonMarketingMaterial) ? Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.MarketingMaterial.FromJson(__jsonMarketingMaterial) : MarketingMaterial;}
            {_iconFileUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject>("iconFileUris"), out var __jsonIconFileUris) ? Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.GalleryItemPropertiesIconFileUris.FromJson(__jsonIconFileUris) : IconFileUri;}
            {_metadata = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject>("metadata"), out var __jsonMetadata) ? Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.OpenProperty.FromJson(__jsonMetadata) : Metadata;}
            {_definitionTemplate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject>("definitionTemplates"), out var __jsonDefinitionTemplates) ? Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplates.FromJson(__jsonDefinitionTemplates) : DefinitionTemplate;}
            {_identity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("identity"), out var __jsonIdentity) ? (string)__jsonIdentity : (string)Identity;}
            {_publisher = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("publisher"), out var __jsonPublisher) ? (string)__jsonPublisher : (string)Publisher;}
            {_publisherDisplayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("publisherDisplayName"), out var __jsonPublisherDisplayName) ? (string)__jsonPublisherDisplayName : (string)PublisherDisplayName;}
            {_itemName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("itemName"), out var __jsonItemName) ? (string)__jsonItemName : (string)ItemName;}
            {_itemDisplayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("itemDisplayName"), out var __jsonItemDisplayName) ? (string)__jsonItemDisplayName : (string)ItemDisplayName;}
            {_version = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;}
            {_summary = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("summary"), out var __jsonSummary) ? (string)__jsonSummary : (string)Summary;}
            {_longSummary = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("longSummary"), out var __jsonLongSummary) ? (string)__jsonLongSummary : (string)LongSummary;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_uiDefinitionUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("uiDefinitionUri"), out var __jsonUiDefinitionUri) ? (string)__jsonUiDefinitionUri : (string)UiDefinitionUri;}
            {_createdTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("createdTime"), out var __jsonCreatedTime) ? global::System.DateTime.TryParse((string)__jsonCreatedTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreatedTimeValue) ? __jsonCreatedTimeValue : CreatedTime : CreatedTime;}
            {_changedTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("changedTime"), out var __jsonChangedTime) ? global::System.DateTime.TryParse((string)__jsonChangedTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonChangedTimeValue) ? __jsonChangedTimeValue : ChangedTime : ChangedTime;}
            {_itemType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("itemType"), out var __jsonItemType) ? (string)__jsonItemType : (string)ItemType;}
            {_categoryId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray>("categoryIds"), out var __jsonCategoryIds) ? If( __jsonCategoryIds as Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : CategoryId;}
            {_screenshotUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray>("screenshotUris"), out var __jsonScreenshotUris) ? If( __jsonScreenshotUris as Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : ScreenshotUri;}
            {_link = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray>("links"), out var __jsonLinks) ? If( __jsonLinks as Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.ILinkProperties[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.ILinkProperties) (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.LinkProperties.FromJson(__k) )) ))() : null : Link;}
            {_filter = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray>("filters"), out var __jsonFilters) ? If( __jsonFilters as Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IFilter[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IFilter) (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.Filter.FromJson(__f) )) ))() : null : Filter;}
            {_artifact = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray>("artifacts"), out var __jsonArtifacts) ? If( __jsonArtifacts as Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IArtifact[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__b, (__a)=>(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IArtifact) (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.Artifact.FromJson(__a) )) ))() : null : Artifact;}
            {_property = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject>("properties"), out var __jsonProperties) ? Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.GalleryItemProperties.FromJson(__jsonProperties) : Property;}
            {_image = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray>("images"), out var __jsonImages) ? If( __jsonImages as Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray, out var ___w) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImageGroup[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___w, (___v)=>(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImageGroup) (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.ImageGroup.FromJson(___v) )) ))() : null : Image;}
            {_product = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray>("products"), out var __jsonProducts) ? If( __jsonProducts as Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonArray, out var ___r) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProduct[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___r, (___q)=>(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProduct) (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.Product.FromJson(___q) )) ))() : null : Product;}
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)ResourceGroupName;}
            {_additionalProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject>("additionalProperties"), out var __jsonAdditionalProperties) ? Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.GalleryItemPropertiesAdditionalProperties.FromJson(__jsonAdditionalProperties) : AdditionalProperty;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="GalleryItemProperties1" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="GalleryItemProperties1" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._marketingMaterial ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) this._marketingMaterial.ToJson(null,serializationMode) : null, "marketingMaterial" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._iconFileUri ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) this._iconFileUri.ToJson(null,serializationMode) : null, "iconFileUris" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._metadata ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) this._metadata.ToJson(null,serializationMode) : null, "metadata" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._definitionTemplate ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) this._definitionTemplate.ToJson(null,serializationMode) : null, "definitionTemplates" ,container.Add );
            }
            AddIf( null != (((object)this._identity)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._identity.ToString()) : null, "identity" ,container.Add );
            AddIf( null != (((object)this._publisher)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._publisher.ToString()) : null, "publisher" ,container.Add );
            AddIf( null != (((object)this._publisherDisplayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._publisherDisplayName.ToString()) : null, "publisherDisplayName" ,container.Add );
            AddIf( null != (((object)this._itemName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._itemName.ToString()) : null, "itemName" ,container.Add );
            AddIf( null != (((object)this._itemDisplayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._itemDisplayName.ToString()) : null, "itemDisplayName" ,container.Add );
            AddIf( null != (((object)this._version)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._version.ToString()) : null, "version" ,container.Add );
            AddIf( null != (((object)this._summary)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._summary.ToString()) : null, "summary" ,container.Add );
            AddIf( null != (((object)this._longSummary)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._longSummary.ToString()) : null, "longSummary" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._uiDefinitionUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._uiDefinitionUri.ToString()) : null, "uiDefinitionUri" ,container.Add );
            AddIf( null != this._createdTime ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._createdTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "createdTime" ,container.Add );
            AddIf( null != this._changedTime ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._changedTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "changedTime" ,container.Add );
            AddIf( null != (((object)this._itemType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._itemType.ToString()) : null, "itemType" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._categoryId)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.XNodeArray();
                    foreach( var __x in this._categoryId )
                    {
                        AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                    }
                    container.Add("categoryIds",__w);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._screenshotUri)
                {
                    var __r = new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.XNodeArray();
                    foreach( var __s in this._screenshotUri )
                    {
                        AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                    }
                    container.Add("screenshotUris",__r);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._link)
                {
                    var __m = new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.XNodeArray();
                    foreach( var __n in this._link )
                    {
                        AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                    }
                    container.Add("links",__m);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._filter)
                {
                    var __h = new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.XNodeArray();
                    foreach( var __i in this._filter )
                    {
                        AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                    }
                    container.Add("filters",__h);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._artifact)
                {
                    var __c = new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.XNodeArray();
                    foreach( var __d in this._artifact )
                    {
                        AddIf(__d?.ToJson(null, serializationMode) ,__c.Add);
                    }
                    container.Add("artifacts",__c);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._property ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) this._property.ToJson(null,serializationMode) : null, "properties" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._image)
                {
                    var ___x = new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.XNodeArray();
                    foreach( var ___y in this._image )
                    {
                        AddIf(___y?.ToJson(null, serializationMode) ,___x.Add);
                    }
                    container.Add("images",___x);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._product)
                {
                    var ___s = new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.XNodeArray();
                    foreach( var ___t in this._product )
                    {
                        AddIf(___t?.ToJson(null, serializationMode) ,___s.Add);
                    }
                    container.Add("products",___s);
                }
            }
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._additionalProperty ? (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode) this._additionalProperty.ToJson(null,serializationMode) : null, "additionalProperties" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}