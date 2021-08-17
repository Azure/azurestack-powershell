namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>Information about an external storage location.</summary>
    public partial class ExternalStore
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject into a new instance of <see cref="ExternalStore" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ExternalStore(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_path = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("path"), out var __jsonPath) ? (string)__jsonPath : (string)Path;}
            {_userName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("userName"), out var __jsonUserName) ? (string)__jsonUserName : (string)UserName;}
            {_password = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("password"), out var __jsonPassword) ? (string)__jsonPassword : (string)Password;}
            {_encryptionCertBase64 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("encryptionCertBase64"), out var __jsonEncryptionCertBase64) ? (string)__jsonEncryptionCertBase64 : (string)EncryptionCertBase64;}
            {_encryptionCertThumbprint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("encryptionCertThumbprint"), out var __jsonEncryptionCertThumbprint) ? (string)__jsonEncryptionCertThumbprint : (string)EncryptionCertThumbprint;}
            {_backupFrequencyInHour = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNumber>("backupFrequencyInHours"), out var __jsonBackupFrequencyInHours) ? (int?)__jsonBackupFrequencyInHours : BackupFrequencyInHour;}
            {_availableCapacity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("availableCapacity"), out var __jsonAvailableCapacity) ? (string)__jsonAvailableCapacity : (string)AvailableCapacity;}
            {_isBackupSchedulerEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonBoolean>("isBackupSchedulerEnabled"), out var __jsonIsBackupSchedulerEnabled) ? (bool?)__jsonIsBackupSchedulerEnabled : IsBackupSchedulerEnabled;}
            {_nextBackupTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("nextBackupTime"), out var __jsonNextBackupTime) ? global::System.DateTime.TryParse((string)__jsonNextBackupTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonNextBackupTimeValue) ? __jsonNextBackupTimeValue : NextBackupTime : NextBackupTime;}
            {_lastBackupTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("lastBackupTime"), out var __jsonLastBackupTime) ? global::System.DateTime.TryParse((string)__jsonLastBackupTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastBackupTimeValue) ? __jsonLastBackupTimeValue : LastBackupTime : LastBackupTime;}
            {_backupRetentionPeriodInDay = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNumber>("backupRetentionPeriodInDays"), out var __jsonBackupRetentionPeriodInDays) ? (int?)__jsonBackupRetentionPeriodInDays : BackupRetentionPeriodInDay;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStore.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStore.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStore FromJson(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject json ? new ExternalStore(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ExternalStore" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ExternalStore" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._path)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._path.ToString()) : null, "path" ,container.Add );
            AddIf( null != (((object)this._userName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._userName.ToString()) : null, "userName" ,container.Add );
            AddIf( null != (((object)this._password)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._password.ToString()) : null, "password" ,container.Add );
            AddIf( null != (((object)this._encryptionCertBase64)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._encryptionCertBase64.ToString()) : null, "encryptionCertBase64" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._encryptionCertThumbprint)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._encryptionCertThumbprint.ToString()) : null, "encryptionCertThumbprint" ,container.Add );
            }
            AddIf( null != this._backupFrequencyInHour ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNumber((int)this._backupFrequencyInHour) : null, "backupFrequencyInHours" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._availableCapacity)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._availableCapacity.ToString()) : null, "availableCapacity" ,container.Add );
            }
            AddIf( null != this._isBackupSchedulerEnabled ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonBoolean((bool)this._isBackupSchedulerEnabled) : null, "isBackupSchedulerEnabled" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._nextBackupTime ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._nextBackupTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "nextBackupTime" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._lastBackupTime ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._lastBackupTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastBackupTime" ,container.Add );
            }
            AddIf( null != this._backupRetentionPeriodInDay ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNumber((int)this._backupRetentionPeriodInDay) : null, "backupRetentionPeriodInDays" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}