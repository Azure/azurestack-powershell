namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20181001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>All properties of a storage subsystem.</summary>
    public partial class StorageSubSystemModel
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20181001.IStorageSubSystemModel.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20181001.IStorageSubSystemModel.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20181001.IStorageSubSystemModel FromJson(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject json ? new StorageSubSystemModel(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject into a new instance of <see cref="StorageSubSystemModel" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal StorageSubSystemModel(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_totalCapacityGb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNumber>("totalCapacityGB"), out var __jsonTotalCapacityGb) ? (int?)__jsonTotalCapacityGb : TotalCapacityGb;}
            {_remainingCapacityGb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNumber>("remainingCapacityGB"), out var __jsonRemainingCapacityGb) ? (int?)__jsonRemainingCapacityGb : RemainingCapacityGb;}
            {_healthStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString>("healthStatus"), out var __jsonHealthStatus) ? (string)__jsonHealthStatus : (string)HealthStatus;}
            {_operationalStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString>("operationalStatus"), out var __jsonOperationalStatus) ? (string)__jsonOperationalStatus : (string)OperationalStatus;}
            {_rebalanceStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString>("rebalanceStatus"), out var __jsonRebalanceStatus) ? (string)__jsonRebalanceStatus : (string)RebalanceStatus;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="StorageSubSystemModel" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="StorageSubSystemModel" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._totalCapacityGb ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNumber((int)this._totalCapacityGb) : null, "totalCapacityGB" ,container.Add );
            AddIf( null != this._remainingCapacityGb ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNumber((int)this._remainingCapacityGb) : null, "remainingCapacityGB" ,container.Add );
            AddIf( null != (((object)this._healthStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString(this._healthStatus.ToString()) : null, "healthStatus" ,container.Add );
            AddIf( null != (((object)this._operationalStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString(this._operationalStatus.ToString()) : null, "operationalStatus" ,container.Add );
            AddIf( null != (((object)this._rebalanceStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString(this._rebalanceStatus.ToString()) : null, "rebalanceStatus" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}