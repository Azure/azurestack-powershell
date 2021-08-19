namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Properties for a virtual machine</summary>
    public partial class VirtualMachineView
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineView.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineView.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineView FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject json ? new VirtualMachineView(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VirtualMachineView" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VirtualMachineView" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._vMName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._vMName.ToString()) : null, "vmName" ,container.Add );
            AddIf( null != (((object)this._vMId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._vMId.ToString()) : null, "vmId" ,container.Add );
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            AddIf( null != (((object)this._vMSize)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._vMSize.ToString()) : null, "vmSize" ,container.Add );
            AddIf( null != (((object)this._vMScaleSetName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._vMScaleSetName.ToString()) : null, "vmScaleSetName" ,container.Add );
            AddIf( null != (((object)this._lastProvisioningErrorMessage)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._lastProvisioningErrorMessage.ToString()) : null, "lastProvisioningErrorMessage" ,container.Add );
            AddIf( null != (((object)this._timeOfLastConfigurationChange)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._timeOfLastConfigurationChange.ToString()) : null, "timeOfLastConfigurationChange" ,container.Add );
            AddIf( null != (((object)this._powerState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString(this._powerState.ToString()) : null, "powerState" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject into a new instance of <see cref="VirtualMachineView" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VirtualMachineView(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_vMName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("vmName"), out var __jsonVMName) ? (string)__jsonVMName : (string)VMName;}
            {_vMId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("vmId"), out var __jsonVMId) ? (string)__jsonVMId : (string)VMId;}
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)SubscriptionId;}
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)ResourceGroupName;}
            {_vMSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("vmSize"), out var __jsonVMSize) ? (string)__jsonVMSize : (string)VMSize;}
            {_vMScaleSetName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("vmScaleSetName"), out var __jsonVMScaleSetName) ? (string)__jsonVMScaleSetName : (string)VMScaleSetName;}
            {_lastProvisioningErrorMessage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("lastProvisioningErrorMessage"), out var __jsonLastProvisioningErrorMessage) ? (string)__jsonLastProvisioningErrorMessage : (string)LastProvisioningErrorMessage;}
            {_timeOfLastConfigurationChange = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("timeOfLastConfigurationChange"), out var __jsonTimeOfLastConfigurationChange) ? (string)__jsonTimeOfLastConfigurationChange : (string)TimeOfLastConfigurationChange;}
            {_powerState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonString>("powerState"), out var __jsonPowerState) ? (string)__jsonPowerState : (string)PowerState;}
            AfterFromJson(json);
        }
    }
}