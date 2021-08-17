namespace Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Extensions;

    /// <summary>Properties of an update.</summary>
    public partial class UpdateModel
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModel.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModel.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModel FromJson(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject json ? new UpdateModel(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="UpdateModel" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UpdateModel" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._installedDate ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._installedDate?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "installedDate" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            AddIf( null != (((object)this._kbLink)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._kbLink.ToString()) : null, "kbLink" ,container.Add );
            AddIf( null != (((object)this._minVersionRequired)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._minVersionRequired.ToString()) : null, "minVersionRequired" ,container.Add );
            AddIf( null != (((object)this._minOemVersionRequired)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._minOemVersionRequired.ToString()) : null, "minOemVersionRequired" ,container.Add );
            AddIf( null != (((object)this._packagePath)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._packagePath.ToString()) : null, "packagePath" ,container.Add );
            AddIf( null != this._packageSizeInMb ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNumber((long)this._packageSizeInMb) : null, "packageSizeInMb" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._version)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._version.ToString()) : null, "version" ,container.Add );
            AddIf( null != (((object)this._oemVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._oemVersion.ToString()) : null, "oemVersion" ,container.Add );
            AddIf( null != (((object)this._publisher)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._publisher.ToString()) : null, "publisher" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject into a new instance of <see cref="UpdateModel" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal UpdateModel(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_installedDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("installedDate"), out var __jsonInstalledDate) ? global::System.DateTime.TryParse((string)__jsonInstalledDate, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonInstalledDateValue) ? __jsonInstalledDateValue : InstalledDate : InstalledDate;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            {_kbLink = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("kbLink"), out var __jsonKbLink) ? (string)__jsonKbLink : (string)KbLink;}
            {_minVersionRequired = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("minVersionRequired"), out var __jsonMinVersionRequired) ? (string)__jsonMinVersionRequired : (string)MinVersionRequired;}
            {_minOemVersionRequired = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("minOemVersionRequired"), out var __jsonMinOemVersionRequired) ? (string)__jsonMinOemVersionRequired : (string)MinOemVersionRequired;}
            {_packagePath = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("packagePath"), out var __jsonPackagePath) ? (string)__jsonPackagePath : (string)PackagePath;}
            {_packageSizeInMb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNumber>("packageSizeInMb"), out var __jsonPackageSizeInMb) ? (long?)__jsonPackageSizeInMb : PackageSizeInMb;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_version = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;}
            {_oemVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("oemVersion"), out var __jsonOemVersion) ? (string)__jsonOemVersion : (string)OemVersion;}
            {_publisher = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("publisher"), out var __jsonPublisher) ? (string)__jsonPublisher : (string)Publisher;}
            AfterFromJson(json);
        }
    }
}