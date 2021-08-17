namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Properties of a storage account.</summary>
    public partial class StorageAccountProperties
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject json ? new StorageAccountProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject into a new instance of <see cref="StorageAccountProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal StorageAccountProperties(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_encryption = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject>("encryption"), out var __jsonEncryption) ? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryption.FromJson(__jsonEncryption) : Encryption;}
            {_tenantViewId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("tenantViewId"), out var __jsonTenantViewId) ? (string)__jsonTenantViewId : (string)TenantViewId;}
            {_accountType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("accountType"), out var __jsonAccountType) ? (string)__jsonAccountType : (string)AccountType;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_primaryEndpoint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject>("primaryEndpoints"), out var __jsonPrimaryEndpoints) ? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccountPropertiesPrimaryEndpoints.FromJson(__jsonPrimaryEndpoints) : PrimaryEndpoint;}
            {_creationTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("creationTime"), out var __jsonCreationTime) ? (string)__jsonCreationTime : (string)CreationTime;}
            {_primaryLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("primaryLocation"), out var __jsonPrimaryLocation) ? (string)__jsonPrimaryLocation : (string)PrimaryLocation;}
            {_faultDomain = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("faultDomain"), out var __jsonFaultDomain) ? (string)__jsonFaultDomain : (string)FaultDomain;}
            {_statusOfPrimary = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("statusOfPrimary"), out var __jsonStatusOfPrimary) ? (string)__jsonStatusOfPrimary : (string)StatusOfPrimary;}
            {_tenantSubscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("tenantSubscriptionId"), out var __jsonTenantSubscriptionId) ? (string)__jsonTenantSubscriptionId : (string)TenantSubscriptionId;}
            {_tenantStorageAccountName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("tenantStorageAccountName"), out var __jsonTenantStorageAccountName) ? (string)__jsonTenantStorageAccountName : (string)TenantStorageAccountName;}
            {_tenantResourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("tenantResourceGroupName"), out var __jsonTenantResourceGroupName) ? (string)__jsonTenantResourceGroupName : (string)TenantResourceGroupName;}
            {_deletedTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("deletedTime"), out var __jsonDeletedTime) ? global::System.DateTime.TryParse((string)__jsonDeletedTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonDeletedTimeValue) ? __jsonDeletedTimeValue : DeletedTime : DeletedTime;}
            {_accountStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("accountStatus"), out var __jsonAccountStatus) ? (string)__jsonAccountStatus : (string)AccountStatus;}
            {_accountId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("accountId"), out var __jsonAccountId) ? (string)__jsonAccountId : (string)AccountId;}
            {_supportsHttpsTrafficOnly = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonBoolean>("supportsHttpsTrafficOnly"), out var __jsonSupportsHttpsTrafficOnly) ? (bool?)__jsonSupportsHttpsTrafficOnly : SupportsHttpsTrafficOnly;}
            {_accessTier = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("accessTier"), out var __jsonAccessTier) ? (string)__jsonAccessTier : (string)AccessTier;}
            {_healthState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString>("healthState"), out var __jsonHealthState) ? (string)__jsonHealthState : (string)HealthState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="StorageAccountProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="StorageAccountProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode" />.
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
                AddIf( null != this._encryption ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) this._encryption.ToJson(null,serializationMode) : null, "encryption" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._tenantViewId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._tenantViewId.ToString()) : null, "tenantViewId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._accountType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._accountType.ToString()) : null, "accountType" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._primaryEndpoint ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) this._primaryEndpoint.ToJson(null,serializationMode) : null, "primaryEndpoints" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._creationTime)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._creationTime.ToString()) : null, "creationTime" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._primaryLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._primaryLocation.ToString()) : null, "primaryLocation" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._faultDomain)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._faultDomain.ToString()) : null, "faultDomain" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._statusOfPrimary)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._statusOfPrimary.ToString()) : null, "statusOfPrimary" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._tenantSubscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._tenantSubscriptionId.ToString()) : null, "tenantSubscriptionId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._tenantStorageAccountName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._tenantStorageAccountName.ToString()) : null, "tenantStorageAccountName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._tenantResourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._tenantResourceGroupName.ToString()) : null, "tenantResourceGroupName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._deletedTime ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._deletedTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "deletedTime" ,container.Add );
            }
            AddIf( null != (((object)this._accountStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._accountStatus.ToString()) : null, "accountStatus" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._accountId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._accountId.ToString()) : null, "accountId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._supportsHttpsTrafficOnly ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonBoolean((bool)this._supportsHttpsTrafficOnly) : null, "supportsHttpsTrafficOnly" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._accessTier)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._accessTier.ToString()) : null, "accessTier" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._healthState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonString(this._healthState.ToString()) : null, "healthState" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}