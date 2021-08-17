namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Properties of a scale unit.</summary>
    public partial class ScaleUnitModel
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitModel.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitModel.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitModel FromJson(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject json ? new ScaleUnitModel(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject into a new instance of <see cref="ScaleUnitModel" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ScaleUnitModel(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_totalCapacity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject>("totalCapacity"), out var __jsonTotalCapacity) ? Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ScaleUnitCapacity.FromJson(__jsonTotalCapacity) : TotalCapacity;}
            {_scaleUnitType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString>("scaleUnitType"), out var __jsonScaleUnitType) ? (string)__jsonScaleUnitType : (string)ScaleUnitType;}
            {_logicalFaultDomain = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNumber>("logicalFaultDomain"), out var __jsonLogicalFaultDomain) ? (int?)__jsonLogicalFaultDomain : LogicalFaultDomain;}
            {_node = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonArray>("nodes"), out var __jsonNodes) ? If( __jsonNodes as Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : Node;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            {_model = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString>("model"), out var __jsonModel) ? (string)__jsonModel : (string)Model;}
            {_isMultiNode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonBoolean>("isMultiNode"), out var __jsonIsMultiNode) ? (bool?)__jsonIsMultiNode : IsMultiNode;}
            {_isGpuAvailable = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonBoolean>("isGpuAvailable"), out var __jsonIsGpuAvailable) ? (bool?)__jsonIsGpuAvailable : IsGpuAvailable;}
            {_gpuPartitionSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNumber>("gpuPartitionSize"), out var __jsonGpuPartitionSize) ? (int?)__jsonGpuPartitionSize : GpuPartitionSize;}
            {_gpuType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString>("gpuType"), out var __jsonGpuType) ? (string)__jsonGpuType : (string)GpuType;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ScaleUnitModel" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ScaleUnitModel" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._totalCapacity ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode) this._totalCapacity.ToJson(null,serializationMode) : null, "totalCapacity" ,container.Add );
            AddIf( null != (((object)this._scaleUnitType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString(this._scaleUnitType.ToString()) : null, "scaleUnitType" ,container.Add );
            AddIf( null != this._logicalFaultDomain ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNumber((int)this._logicalFaultDomain) : null, "logicalFaultDomain" ,container.Add );
            if (null != this._node)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.XNodeArray();
                foreach( var __x in this._node )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("nodes",__w);
            }
            AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            AddIf( null != (((object)this._model)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString(this._model.ToString()) : null, "model" ,container.Add );
            AddIf( null != this._isMultiNode ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonBoolean((bool)this._isMultiNode) : null, "isMultiNode" ,container.Add );
            AddIf( null != this._isGpuAvailable ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonBoolean((bool)this._isGpuAvailable) : null, "isGpuAvailable" ,container.Add );
            AddIf( null != this._gpuPartitionSize ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNumber((int)this._gpuPartitionSize) : null, "gpuPartitionSize" ,container.Add );
            AddIf( null != (((object)this._gpuType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonString(this._gpuType.ToString()) : null, "gpuType" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}