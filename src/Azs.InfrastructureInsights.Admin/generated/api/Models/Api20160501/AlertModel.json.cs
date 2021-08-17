namespace Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Extensions;

    /// <summary>Contains alert data.</summary>
    public partial class AlertModel
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject into a new instance of <see cref="AlertModel" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AlertModel(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_closedTimestamp = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString>("closedTimestamp"), out var __jsonClosedTimestamp) ? (string)__jsonClosedTimestamp : (string)ClosedTimestamp;}
            {_createdTimestamp = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString>("createdTimestamp"), out var __jsonCreatedTimestamp) ? (string)__jsonCreatedTimestamp : (string)CreatedTimestamp;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonArray>("description"), out var __jsonDescription) ? If( __jsonDescription as Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary) (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.Dictionary.FromJson(__u) )) ))() : null : Description;}
            {_faultId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString>("faultId"), out var __jsonFaultId) ? (string)__jsonFaultId : (string)FaultId;}
            {_alertId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString>("alertId"), out var __jsonAlertId) ? (string)__jsonAlertId : (string)AlertId;}
            {_faultTypeId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString>("faultTypeId"), out var __jsonFaultTypeId) ? (string)__jsonFaultTypeId : (string)FaultTypeId;}
            {_lastUpdatedTimestamp = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString>("lastUpdatedTimestamp"), out var __jsonLastUpdatedTimestamp) ? (string)__jsonLastUpdatedTimestamp : (string)LastUpdatedTimestamp;}
            {_alertProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject>("alertProperties"), out var __jsonAlertProperties) ? Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.AlertModelAlertProperties.FromJson(__jsonAlertProperties) : AlertProperty;}
            {_remediation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonArray>("remediation"), out var __jsonRemediation) ? If( __jsonRemediation as Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary) (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.Dictionary.FromJson(__p) )) ))() : null : Remediation;}
            {_resourceRegistrationId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString>("resourceRegistrationId"), out var __jsonResourceRegistrationId) ? (string)__jsonResourceRegistrationId : (string)ResourceRegistrationId;}
            {_resourceProviderRegistrationId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString>("resourceProviderRegistrationId"), out var __jsonResourceProviderRegistrationId) ? (string)__jsonResourceProviderRegistrationId : (string)ResourceProviderRegistrationId;}
            {_severity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString>("severity"), out var __jsonSeverity) ? (string)__jsonSeverity : (string)Severity;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            {_title = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString>("title"), out var __jsonTitle) ? (string)__jsonTitle : (string)Title;}
            {_impactedResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString>("impactedResourceId"), out var __jsonImpactedResourceId) ? (string)__jsonImpactedResourceId : (string)ImpactedResourceId;}
            {_impactedResourceDisplayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString>("impactedResourceDisplayName"), out var __jsonImpactedResourceDisplayName) ? (string)__jsonImpactedResourceDisplayName : (string)ImpactedResourceDisplayName;}
            {_closedByUserAlias = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString>("closedByUserAlias"), out var __jsonClosedByUserAlias) ? (string)__jsonClosedByUserAlias : (string)ClosedByUserAlias;}
            {_hasValidRemediationAction = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonBoolean>("hasValidRemediationAction"), out var __jsonHasValidRemediationAction) ? (bool?)__jsonHasValidRemediationAction : HasValidRemediationAction;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModel.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModel.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModel FromJson(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject json ? new AlertModel(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AlertModel" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AlertModel" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._closedTimestamp)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString(this._closedTimestamp.ToString()) : null, "closedTimestamp" ,container.Add );
            AddIf( null != (((object)this._createdTimestamp)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString(this._createdTimestamp.ToString()) : null, "createdTimestamp" ,container.Add );
            if (null != this._description)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.XNodeArray();
                foreach( var __x in this._description )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("description",__w);
            }
            AddIf( null != (((object)this._faultId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString(this._faultId.ToString()) : null, "faultId" ,container.Add );
            AddIf( null != (((object)this._alertId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString(this._alertId.ToString()) : null, "alertId" ,container.Add );
            AddIf( null != (((object)this._faultTypeId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString(this._faultTypeId.ToString()) : null, "faultTypeId" ,container.Add );
            AddIf( null != (((object)this._lastUpdatedTimestamp)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString(this._lastUpdatedTimestamp.ToString()) : null, "lastUpdatedTimestamp" ,container.Add );
            AddIf( null != this._alertProperty ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) this._alertProperty.ToJson(null,serializationMode) : null, "alertProperties" ,container.Add );
            if (null != this._remediation)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.XNodeArray();
                foreach( var __s in this._remediation )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("remediation",__r);
            }
            AddIf( null != (((object)this._resourceRegistrationId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString(this._resourceRegistrationId.ToString()) : null, "resourceRegistrationId" ,container.Add );
            AddIf( null != (((object)this._resourceProviderRegistrationId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString(this._resourceProviderRegistrationId.ToString()) : null, "resourceProviderRegistrationId" ,container.Add );
            AddIf( null != (((object)this._severity)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString(this._severity.ToString()) : null, "severity" ,container.Add );
            AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            AddIf( null != (((object)this._title)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString(this._title.ToString()) : null, "title" ,container.Add );
            AddIf( null != (((object)this._impactedResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString(this._impactedResourceId.ToString()) : null, "impactedResourceId" ,container.Add );
            AddIf( null != (((object)this._impactedResourceDisplayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString(this._impactedResourceDisplayName.ToString()) : null, "impactedResourceDisplayName" ,container.Add );
            AddIf( null != (((object)this._closedByUserAlias)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonString(this._closedByUserAlias.ToString()) : null, "closedByUserAlias" ,container.Add );
            AddIf( null != this._hasValidRemediationAction ? (Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Json.JsonBoolean((bool)this._hasValidRemediationAction) : null, "hasValidRemediationAction" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}