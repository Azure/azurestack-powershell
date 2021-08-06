namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Holds properties related to activation.</summary>
    public partial class Activation
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject into a new instance of <see cref="Activation" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Activation(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_azureRegistrationResourceIdentifier = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString>("azureRegistrationResourceIdentifier"), out var __jsonAzureRegistrationResourceIdentifier) ? (string)__jsonAzureRegistrationResourceIdentifier : (string)AzureRegistrationResourceIdentifier;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_expiration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString>("expiration"), out var __jsonExpiration) ? (string)__jsonExpiration : (string)Expiration;}
            {_marketplaceSyndicationEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonBoolean>("marketplaceSyndicationEnabled"), out var __jsonMarketplaceSyndicationEnabled) ? (bool?)__jsonMarketplaceSyndicationEnabled : MarketplaceSyndicationEnabled;}
            {_usageReportingEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonBoolean>("usageReportingEnabled"), out var __jsonUsageReportingEnabled) ? (bool?)__jsonUsageReportingEnabled : UsageReportingEnabled;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IActivation.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IActivation.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IActivation FromJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject json ? new Activation(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Activation" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Activation" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._azureRegistrationResourceIdentifier)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString(this._azureRegistrationResourceIdentifier.ToString()) : null, "azureRegistrationResourceIdentifier" ,container.Add );
            AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            AddIf( null != (((object)this._expiration)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonString(this._expiration.ToString()) : null, "expiration" ,container.Add );
            AddIf( null != this._marketplaceSyndicationEnabled ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonBoolean((bool)this._marketplaceSyndicationEnabled) : null, "marketplaceSyndicationEnabled" ,container.Add );
            AddIf( null != this._usageReportingEnabled ? (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonBoolean((bool)this._usageReportingEnabled) : null, "usageReportingEnabled" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}