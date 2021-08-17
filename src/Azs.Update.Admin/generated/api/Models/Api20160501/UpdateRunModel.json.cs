namespace Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Extensions;

    /// <summary>Properties of an update run.</summary>
    public partial class UpdateRunModel
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModel.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModel.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModel FromJson(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject json ? new UpdateRunModel(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="UpdateRunModel" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UpdateRunModel" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._progress ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) this._progress.ToJson(null,serializationMode) : null, "progress" ,container.Add );
            AddIf( null != this._timeStarted ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._timeStarted?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "timeStarted" ,container.Add );
            AddIf( null != (((object)this._duration)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._duration.ToString()) : null, "duration" ,container.Add );
            AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject into a new instance of <see cref="UpdateRunModel" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal UpdateRunModel(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_progress = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonObject>("progress"), out var __jsonProgress) ? Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.Step.FromJson(__jsonProgress) : Progress;}
            {_timeStarted = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("timeStarted"), out var __jsonTimeStarted) ? global::System.DateTime.TryParse((string)__jsonTimeStarted, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonTimeStartedValue) ? __jsonTimeStartedValue : TimeStarted : TimeStarted;}
            {_duration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("duration"), out var __jsonDuration) ? (string)__jsonDuration : (string)Duration;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            AfterFromJson(json);
        }
    }
}