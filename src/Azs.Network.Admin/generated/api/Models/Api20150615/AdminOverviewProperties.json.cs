namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>Admin overview properties.</summary>
    public partial class AdminOverviewProperties
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject into a new instance of <see cref="AdminOverviewProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AdminOverviewProperties(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_virtualNetworkHealth = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject>("virtualNetworkHealth"), out var __jsonVirtualNetworkHealth) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealth.FromJson(__jsonVirtualNetworkHealth) : VirtualNetworkHealth;}
            {_loadBalancerMuxHealth = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject>("loadBalancerMuxHealth"), out var __jsonLoadBalancerMuxHealth) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealth.FromJson(__jsonLoadBalancerMuxHealth) : LoadBalancerMuxHealth;}
            {_virtualGatewayHealth = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject>("virtualGatewayHealth"), out var __jsonVirtualGatewayHealth) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealth.FromJson(__jsonVirtualGatewayHealth) : VirtualGatewayHealth;}
            {_publicIPAddressUsage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject>("publicIpAddressUsage"), out var __jsonPublicIPAddressUsage) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsage.FromJson(__jsonPublicIPAddressUsage) : PublicIPAddressUsage;}
            {_backendIPUsage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject>("backendIpUsage"), out var __jsonBackendIPUsage) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsage.FromJson(__jsonBackendIPUsage) : BackendIPUsage;}
            {_macAddressUsage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject>("macAddressUsage"), out var __jsonMacAddressUsage) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsage.FromJson(__jsonMacAddressUsage) : MacAddressUsage;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject json ? new AdminOverviewProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AdminOverviewProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AdminOverviewProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._virtualNetworkHealth ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode) this._virtualNetworkHealth.ToJson(null,serializationMode) : null, "virtualNetworkHealth" ,container.Add );
            AddIf( null != this._loadBalancerMuxHealth ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode) this._loadBalancerMuxHealth.ToJson(null,serializationMode) : null, "loadBalancerMuxHealth" ,container.Add );
            AddIf( null != this._virtualGatewayHealth ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode) this._virtualGatewayHealth.ToJson(null,serializationMode) : null, "virtualGatewayHealth" ,container.Add );
            AddIf( null != this._publicIPAddressUsage ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode) this._publicIPAddressUsage.ToJson(null,serializationMode) : null, "publicIpAddressUsage" ,container.Add );
            AddIf( null != this._backendIPUsage ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode) this._backendIPUsage.ToJson(null,serializationMode) : null, "backendIpUsage" ,container.Add );
            AddIf( null != this._macAddressUsage ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode) this._macAddressUsage.ToJson(null,serializationMode) : null, "macAddressUsage" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}