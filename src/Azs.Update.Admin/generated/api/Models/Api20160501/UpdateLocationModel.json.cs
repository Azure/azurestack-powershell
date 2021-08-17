namespace Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Extensions;

    /// <summary>Model which holds information related to update location.</summary>
    public partial class UpdateLocationModel
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModel.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModel.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModel FromJson(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject json ? new UpdateLocationModel(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="UpdateLocationModel" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UpdateLocationModel" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._currentVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._currentVersion.ToString()) : null, "currentVersion" ,container.Add );
            AddIf( null != (((object)this._currentOemVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._currentOemVersion.ToString()) : null, "currentOemVersion" ,container.Add );
            AddIf( null != this._lastUpdated ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._lastUpdated?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastUpdated" ,container.Add );
            AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject into a new instance of <see cref="UpdateLocationModel" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal UpdateLocationModel(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_currentVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("currentVersion"), out var __jsonCurrentVersion) ? (string)__jsonCurrentVersion : (string)CurrentVersion;}
            {_currentOemVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("currentOemVersion"), out var __jsonCurrentOemVersion) ? (string)__jsonCurrentOemVersion : (string)CurrentOemVersion;}
            {_lastUpdated = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("lastUpdated"), out var __jsonLastUpdated) ? global::System.DateTime.TryParse((string)__jsonLastUpdated, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastUpdatedValue) ? __jsonLastUpdatedValue : LastUpdated : LastUpdated;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            AfterFromJson(json);
        }
    }
}