namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>The GPU information on the physical machine.</summary>
    public partial class GpuModel
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel FromJson(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject json ? new GpuModel(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject into a new instance of <see cref="GpuModel" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal GpuModel(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_hostDriverVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString>("hostDriverVersion"), out var __jsonHostDriverVersion) ? (string)__jsonHostDriverVersion : (string)HostDriverVersion;}
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_partitionSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNumber>("partitionSize"), out var __jsonPartitionSize) ? (int?)__jsonPartitionSize : PartitionSize;}
            {_slotLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString>("slotLocation"), out var __jsonSlotLocation) ? (string)__jsonSlotLocation : (string)SlotLocation;}
            {_oem = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString>("oem"), out var __jsonOem) ? (string)__jsonOem : (string)Oem;}
            {_type = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="GpuModel" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="GpuModel" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._hostDriverVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString(this._hostDriverVersion.ToString()) : null, "hostDriverVersion" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != this._partitionSize ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNumber((int)this._partitionSize) : null, "partitionSize" ,container.Add );
            AddIf( null != (((object)this._slotLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString(this._slotLocation.ToString()) : null, "slotLocation" ,container.Add );
            AddIf( null != (((object)this._oem)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString(this._oem.ToString()) : null, "oem" ,container.Add );
            AddIf( null != (((object)this._type)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}