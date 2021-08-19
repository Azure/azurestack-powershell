namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Managed disk properties.</summary>
    public partial class DiskProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject into a new instance of <see cref="DiskProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DiskProperties(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_diskId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("diskId"), out var __jsonDiskId) ? (string)__jsonDiskId : (string)DiskId;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_sharePath = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("sharePath"), out var __jsonSharePath) ? (string)__jsonSharePath : (string)SharePath;}
            {_actualSizeGb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber>("actualSizeGB"), out var __jsonActualSizeGb) ? (long?)__jsonActualSizeGb : ActualSizeGb;}
            {_provisionSizeGb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber>("provisionSizeGB"), out var __jsonProvisionSizeGb) ? (long?)__jsonProvisionSizeGb : ProvisionSizeGb;}
            {_managedBy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("managedBy"), out var __jsonManagedBy) ? (string)__jsonManagedBy : (string)ManagedBy;}
            {_userResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("userResourceId"), out var __jsonUserResourceId) ? (string)__jsonUserResourceId : (string)UserResourceId;}
            {_diskType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("diskType"), out var __jsonDiskType) ? (string)__jsonDiskType : (string)DiskType;}
            {_diskSku = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("diskSku"), out var __jsonDiskSku) ? (string)__jsonDiskSku : (string)DiskSku;}
            {_creationSourceUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("creationSourceUri"), out var __jsonCreationSourceUri) ? (string)__jsonCreationSourceUri : (string)CreationSourceUri;}
            {_creationOption = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("creationOption"), out var __jsonCreationOption) ? (string)__jsonCreationOption : (string)CreationOption;}
            {_exclusiveAllocatedSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber>("exclusiveAllocatedSize"), out var __jsonExclusiveAllocatedSize) ? (long?)__jsonExclusiveAllocatedSize : ExclusiveAllocatedSize;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject json ? new DiskProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DiskProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DiskProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._diskId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._diskId.ToString()) : null, "diskId" ,container.Add );
            AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            AddIf( null != (((object)this._sharePath)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._sharePath.ToString()) : null, "sharePath" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._actualSizeGb ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber((long)this._actualSizeGb) : null, "actualSizeGB" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._provisionSizeGb ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber((long)this._provisionSizeGb) : null, "provisionSizeGB" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._managedBy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._managedBy.ToString()) : null, "managedBy" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._userResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._userResourceId.ToString()) : null, "userResourceId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._diskType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._diskType.ToString()) : null, "diskType" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._diskSku)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._diskSku.ToString()) : null, "diskSku" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._creationSourceUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._creationSourceUri.ToString()) : null, "creationSourceUri" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._creationOption)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._creationOption.ToString()) : null, "creationOption" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._exclusiveAllocatedSize ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber((long)this._exclusiveAllocatedSize) : null, "exclusiveAllocatedSize" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}