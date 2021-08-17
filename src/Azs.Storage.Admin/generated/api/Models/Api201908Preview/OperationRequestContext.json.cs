namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Operation request context.</summary>
    public partial class OperationRequestContext
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContext.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContext.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContext FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject json ? new OperationRequestContext(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject into a new instance of <see cref="OperationRequestContext" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OperationRequestContext(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_apiVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("apiVersion"), out var __jsonApiVersion) ? (string)__jsonApiVersion : (string)ApiVersion;}
            {_activityId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("activityId"), out var __jsonActivityId) ? (string)__jsonActivityId : (string)ActivityId;}
            {_operationName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("operationName"), out var __jsonOperationName) ? (string)__jsonOperationName : (string)OperationName;}
            {_errorCode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("errorCode"), out var __jsonErrorCode) ? (string)__jsonErrorCode : (string)ErrorCode;}
            {_runtimeException = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("runtimeException"), out var __jsonRuntimeException) ? (string)__jsonRuntimeException : (string)RuntimeException;}
            {_startTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("startTime"), out var __jsonStartTime) ? (string)__jsonStartTime : (string)StartTime;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OperationRequestContext" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OperationRequestContext" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._apiVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._apiVersion.ToString()) : null, "apiVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._activityId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._activityId.ToString()) : null, "activityId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._operationName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._operationName.ToString()) : null, "operationName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._errorCode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._errorCode.ToString()) : null, "errorCode" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._runtimeException)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._runtimeException.ToString()) : null, "runtimeException" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._startTime)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._startTime.ToString()) : null, "startTime" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}