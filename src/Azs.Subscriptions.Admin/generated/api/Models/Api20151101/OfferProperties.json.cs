namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Represents an offering of services against which a subscription can be created.</summary>
    public partial class OfferProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOfferProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOfferProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOfferProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject json ? new OfferProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject into a new instance of <see cref="OfferProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OfferProperties(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_externalReferenceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString>("externalReferenceId"), out var __jsonExternalReferenceId) ? (string)__jsonExternalReferenceId : (string)ExternalReferenceId;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            {_subscriptionCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNumber>("subscriptionCount"), out var __jsonSubscriptionCount) ? (int?)__jsonSubscriptionCount : SubscriptionCount;}
            {_maxSubscriptionsPerAccount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNumber>("maxSubscriptionsPerAccount"), out var __jsonMaxSubscriptionsPerAccount) ? (int?)__jsonMaxSubscriptionsPerAccount : MaxSubscriptionsPerAccount;}
            {_basePlanIds = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonArray>("basePlanIds"), out var __jsonBasePlanIds) ? If( __jsonBasePlanIds as Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : BasePlanIds;}
            {_addonPlans = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonArray>("addonPlans"), out var __jsonAddonPlans) ? If( __jsonAddonPlans as Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAddonPlanDefinition[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAddonPlanDefinition) (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.AddonPlanDefinition.FromJson(__p) )) ))() : null : AddonPlans;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OfferProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OfferProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._externalReferenceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString(this._externalReferenceId.ToString()) : null, "externalReferenceId" ,container.Add );
            AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            AddIf( null != this._subscriptionCount ? (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNumber((int)this._subscriptionCount) : null, "subscriptionCount" ,container.Add );
            AddIf( null != this._maxSubscriptionsPerAccount ? (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNumber((int)this._maxSubscriptionsPerAccount) : null, "maxSubscriptionsPerAccount" ,container.Add );
            if (null != this._basePlanIds)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.XNodeArray();
                foreach( var __x in this._basePlanIds )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("basePlanIds",__w);
            }
            if (null != this._addonPlans)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.XNodeArray();
                foreach( var __s in this._addonPlans )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("addonPlans",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}