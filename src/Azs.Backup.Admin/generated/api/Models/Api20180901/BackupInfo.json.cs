namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>Holds information for a backup.</summary>
    public partial class BackupInfo
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject into a new instance of <see cref="BackupInfo" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal BackupInfo(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_backupDataVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("backupDataVersion"), out var __jsonBackupDataVersion) ? (string)__jsonBackupDataVersion : (string)BackupDataVersion;}
            {_roleStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonArray>("roleStatus"), out var __jsonRoleStatus) ? If( __jsonRoleStatus as Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus) (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.RoleOperationStatus.FromJson(__u) )) ))() : null : RoleStatus;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_createdDateTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("createdDateTime"), out var __jsonCreatedDateTime) ? global::System.DateTime.TryParse((string)__jsonCreatedDateTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreatedDateTimeValue) ? __jsonCreatedDateTimeValue : CreatedDateTime : CreatedDateTime;}
            {_timeTakenToCreate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("timeTakenToCreate"), out var __jsonTimeTakenToCreate) ? (string)__jsonTimeTakenToCreate : (string)TimeTakenToCreate;}
            {_deploymentId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("deploymentID"), out var __jsonDeploymentId) ? (string)__jsonDeploymentId : (string)DeploymentId;}
            {_stampVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("stampVersion"), out var __jsonStampVersion) ? (string)__jsonStampVersion : (string)StampVersion;}
            {_oemVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("oemVersion"), out var __jsonOemVersion) ? (string)__jsonOemVersion : (string)OemVersion;}
            {_isCloudRecoveryReady = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonBoolean>("isCloudRecoveryReady"), out var __jsonIsCloudRecoveryReady) ? (bool?)__jsonIsCloudRecoveryReady : IsCloudRecoveryReady;}
            {_encryptionCertThumbprint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("encryptionCertThumbprint"), out var __jsonEncryptionCertThumbprint) ? (string)__jsonEncryptionCertThumbprint : (string)EncryptionCertThumbprint;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo FromJson(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject json ? new BackupInfo(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="BackupInfo" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="BackupInfo" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._backupDataVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._backupDataVersion.ToString()) : null, "backupDataVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._roleStatus)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.XNodeArray();
                    foreach( var __x in this._roleStatus )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("roleStatus",__w);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._createdDateTime ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._createdDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "createdDateTime" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._timeTakenToCreate)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._timeTakenToCreate.ToString()) : null, "timeTakenToCreate" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._deploymentId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._deploymentId.ToString()) : null, "deploymentID" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._stampVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._stampVersion.ToString()) : null, "stampVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._oemVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._oemVersion.ToString()) : null, "oemVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._isCloudRecoveryReady ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonBoolean((bool)this._isCloudRecoveryReady) : null, "isCloudRecoveryReady" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._encryptionCertThumbprint)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._encryptionCertThumbprint.ToString()) : null, "encryptionCertThumbprint" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}