namespace Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Extensions;

    /// <summary>Properties for aggregate usage.</summary>
    public partial class UsageAggregateModel
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModel.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModel.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IUsageAggregateModel FromJson(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonObject json ? new UsageAggregateModel(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="UsageAggregateModel" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UsageAggregateModel" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != this._usageStartTime ? (Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonString(this._usageStartTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "usageStartTime" ,container.Add );
            AddIf( null != this._usageEndTime ? (Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonString(this._usageEndTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "usageEndTime" ,container.Add );
            AddIf( null != (((object)this._instanceData)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonString(this._instanceData.ToString()) : null, "instanceData" ,container.Add );
            AddIf( null != this._quantity ? (Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonNumber((double)this._quantity) : null, "quantity" ,container.Add );
            AddIf( null != (((object)this._meterId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonString(this._meterId.ToString()) : null, "meterId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonObject into a new instance of <see cref="UsageAggregateModel" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal UsageAggregateModel(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)SubscriptionId;}
            {_usageStartTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonString>("usageStartTime"), out var __jsonUsageStartTime) ? global::System.DateTime.TryParse((string)__jsonUsageStartTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonUsageStartTimeValue) ? __jsonUsageStartTimeValue : UsageStartTime : UsageStartTime;}
            {_usageEndTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonString>("usageEndTime"), out var __jsonUsageEndTime) ? global::System.DateTime.TryParse((string)__jsonUsageEndTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonUsageEndTimeValue) ? __jsonUsageEndTimeValue : UsageEndTime : UsageEndTime;}
            {_instanceData = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonString>("instanceData"), out var __jsonInstanceData) ? (string)__jsonInstanceData : (string)InstanceData;}
            {_quantity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonNumber>("quantity"), out var __jsonQuantity) ? (double?)__jsonQuantity : Quantity;}
            {_meterId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Json.JsonString>("meterId"), out var __jsonMeterId) ? (string)__jsonMeterId : (string)MeterId;}
            AfterFromJson(json);
        }
    }
}