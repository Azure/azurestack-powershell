namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Disk migration child task properties.</summary>
    public partial class MigrationSubTaskProperties
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject json ? new MigrationSubTaskProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject into a new instance of <see cref="MigrationSubTaskProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MigrationSubTaskProperties(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_migrationSubtaskStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("migrationSubtaskStatus"), out var __jsonMigrationSubtaskStatus) ? (string)__jsonMigrationSubtaskStatus : (string)MigrationSubtaskStatus;}
            {_reason = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("reason"), out var __jsonReason) ? (string)__jsonReason : (string)Reason;}
            {_startTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("startTime"), out var __jsonStartTime) ? global::System.DateTime.TryParse((string)__jsonStartTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStartTimeValue) ? __jsonStartTimeValue : StartTime : StartTime;}
            {_endTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("endTime"), out var __jsonEndTime) ? global::System.DateTime.TryParse((string)__jsonEndTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonEndTimeValue) ? __jsonEndTimeValue : EndTime : EndTime;}
            {_targetShare = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("targetShare"), out var __jsonTargetShare) ? (string)__jsonTargetShare : (string)TargetShare;}
            {_sourceShare = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("sourceShare"), out var __jsonSourceShare) ? (string)__jsonSourceShare : (string)SourceShare;}
            {_targetDiskStateForMigration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("targetDiskStateForMigration"), out var __jsonTargetDiskStateForMigration) ? (string)__jsonTargetDiskStateForMigration : (string)TargetDiskStateForMigration;}
            {_diskId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("diskId"), out var __jsonDiskId) ? (string)__jsonDiskId : (string)DiskId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MigrationSubTaskProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MigrationSubTaskProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" />.
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
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._migrationSubtaskStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._migrationSubtaskStatus.ToString()) : null, "migrationSubtaskStatus" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._reason)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._reason.ToString()) : null, "reason" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._startTime ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._startTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "startTime" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._endTime ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._endTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "endTime" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._targetShare)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._targetShare.ToString()) : null, "targetShare" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._sourceShare)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._sourceShare.ToString()) : null, "sourceShare" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._targetDiskStateForMigration)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._targetDiskStateForMigration.ToString()) : null, "targetDiskStateForMigration" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._diskId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._diskId.ToString()) : null, "diskId" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}