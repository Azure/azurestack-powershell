namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>Properties for restore options.</summary>
    public partial class RestoreOptions
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRestoreOptions.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRestoreOptions.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRestoreOptions FromJson(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject json ? new RestoreOptions(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject into a new instance of <see cref="RestoreOptions" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal RestoreOptions(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_roleName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("roleName"), out var __jsonRoleName) ? (string)__jsonRoleName : (string)RoleName;}
            {_decryptionCertBase64 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("decryptionCertBase64"), out var __jsonDecryptionCertBase64) ? (string)__jsonDecryptionCertBase64 : (string)DecryptionCertBase64;}
            {_decryptionCertPassword = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString>("decryptionCertPassword"), out var __jsonDecryptionCertPassword) ? (string)__jsonDecryptionCertPassword : (string)DecryptionCertPassword;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RestoreOptions" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RestoreOptions" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._roleName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._roleName.ToString()) : null, "roleName" ,container.Add );
            AddIf( null != (((object)this._decryptionCertBase64)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._decryptionCertBase64.ToString()) : null, "decryptionCertBase64" ,container.Add );
            AddIf( null != (((object)this._decryptionCertPassword)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonString(this._decryptionCertPassword.ToString()) : null, "decryptionCertPassword" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}