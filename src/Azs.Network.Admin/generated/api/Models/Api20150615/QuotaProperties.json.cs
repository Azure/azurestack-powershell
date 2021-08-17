namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>Properties of a quota.</summary>
    public partial class QuotaProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject json ? new QuotaProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject into a new instance of <see cref="QuotaProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal QuotaProperties(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __provisionedResource = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ProvisionedResource(json);
            {_maxPublicIpsPerSubscription = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNumber>("maxPublicIpsPerSubscription"), out var __jsonMaxPublicIpsPerSubscription) ? (long?)__jsonMaxPublicIpsPerSubscription : MaxPublicIpsPerSubscription;}
            {_maxVnetsPerSubscription = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNumber>("maxVnetsPerSubscription"), out var __jsonMaxVnetsPerSubscription) ? (long?)__jsonMaxVnetsPerSubscription : MaxVnetsPerSubscription;}
            {_maxVirtualNetworkGatewaysPerSubscription = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNumber>("maxVirtualNetworkGatewaysPerSubscription"), out var __jsonMaxVirtualNetworkGatewaysPerSubscription) ? (long?)__jsonMaxVirtualNetworkGatewaysPerSubscription : MaxVirtualNetworkGatewaysPerSubscription;}
            {_maxVirtualNetworkGatewayConnectionsPerSubscription = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNumber>("maxVirtualNetworkGatewayConnectionsPerSubscription"), out var __jsonMaxVirtualNetworkGatewayConnectionsPerSubscription) ? (long?)__jsonMaxVirtualNetworkGatewayConnectionsPerSubscription : MaxVirtualNetworkGatewayConnectionsPerSubscription;}
            {_maxLoadBalancersPerSubscription = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNumber>("maxLoadBalancersPerSubscription"), out var __jsonMaxLoadBalancersPerSubscription) ? (long?)__jsonMaxLoadBalancersPerSubscription : MaxLoadBalancersPerSubscription;}
            {_maxNicsPerSubscription = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNumber>("maxNicsPerSubscription"), out var __jsonMaxNicsPerSubscription) ? (long?)__jsonMaxNicsPerSubscription : MaxNicsPerSubscription;}
            {_maxSecurityGroupsPerSubscription = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNumber>("maxSecurityGroupsPerSubscription"), out var __jsonMaxSecurityGroupsPerSubscription) ? (long?)__jsonMaxSecurityGroupsPerSubscription : MaxSecurityGroupsPerSubscription;}
            {_migrationPhase = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonString>("migrationPhase"), out var __jsonMigrationPhase) ? (string)__jsonMigrationPhase : (string)MigrationPhase;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="QuotaProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="QuotaProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __provisionedResource?.ToJson(container, serializationMode);
            AddIf( null != this._maxPublicIpsPerSubscription ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNumber((long)this._maxPublicIpsPerSubscription) : null, "maxPublicIpsPerSubscription" ,container.Add );
            AddIf( null != this._maxVnetsPerSubscription ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNumber((long)this._maxVnetsPerSubscription) : null, "maxVnetsPerSubscription" ,container.Add );
            AddIf( null != this._maxVirtualNetworkGatewaysPerSubscription ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNumber((long)this._maxVirtualNetworkGatewaysPerSubscription) : null, "maxVirtualNetworkGatewaysPerSubscription" ,container.Add );
            AddIf( null != this._maxVirtualNetworkGatewayConnectionsPerSubscription ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNumber((long)this._maxVirtualNetworkGatewayConnectionsPerSubscription) : null, "maxVirtualNetworkGatewayConnectionsPerSubscription" ,container.Add );
            AddIf( null != this._maxLoadBalancersPerSubscription ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNumber((long)this._maxLoadBalancersPerSubscription) : null, "maxLoadBalancersPerSubscription" ,container.Add );
            AddIf( null != this._maxNicsPerSubscription ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNumber((long)this._maxNicsPerSubscription) : null, "maxNicsPerSubscription" ,container.Add );
            AddIf( null != this._maxSecurityGroupsPerSubscription ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNumber((long)this._maxSecurityGroupsPerSubscription) : null, "maxSecurityGroupsPerSubscription" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._migrationPhase)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonString(this._migrationPhase.ToString()) : null, "migrationPhase" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}