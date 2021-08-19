namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Properties for a Compute Quota</summary>
    public partial class QuotaProperties
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject json ? new QuotaProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject into a new instance of <see cref="QuotaProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal QuotaProperties(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_availabilitySetCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber>("availabilitySetCount"), out var __jsonAvailabilitySetCount) ? (int?)__jsonAvailabilitySetCount : AvailabilitySetCount;}
            {_coresLimit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber>("coresLimit"), out var __jsonCoresLimit) ? (int?)__jsonCoresLimit : CoresLimit;}
            {_virtualMachineCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber>("virtualMachineCount"), out var __jsonVirtualMachineCount) ? (int?)__jsonVirtualMachineCount : VirtualMachineCount;}
            {_vMScaleSetCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber>("vmScaleSetCount"), out var __jsonVMScaleSetCount) ? (int?)__jsonVMScaleSetCount : VMScaleSetCount;}
            {_maxAllocationStandardManagedDisksAndSnapshot = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber>("maxAllocationStandardManagedDisksAndSnapshots"), out var __jsonMaxAllocationStandardManagedDisksAndSnapshots) ? (int?)__jsonMaxAllocationStandardManagedDisksAndSnapshots : MaxAllocationStandardManagedDisksAndSnapshot;}
            {_maxAllocationPremiumManagedDisksAndSnapshot = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber>("maxAllocationPremiumManagedDisksAndSnapshots"), out var __jsonMaxAllocationPremiumManagedDisksAndSnapshots) ? (int?)__jsonMaxAllocationPremiumManagedDisksAndSnapshots : MaxAllocationPremiumManagedDisksAndSnapshot;}
            {_ddagpuCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber>("ddagpuCount"), out var __jsonDdagpuCount) ? (int?)__jsonDdagpuCount : DdagpuCount;}
            {_partitionedGpuCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber>("partitionedGpuCount"), out var __jsonPartitionedGpuCount) ? (int?)__jsonPartitionedGpuCount : PartitionedGpuCount;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="QuotaProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="QuotaProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._availabilitySetCount ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber((int)this._availabilitySetCount) : null, "availabilitySetCount" ,container.Add );
            AddIf( null != this._coresLimit ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber((int)this._coresLimit) : null, "coresLimit" ,container.Add );
            AddIf( null != this._virtualMachineCount ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber((int)this._virtualMachineCount) : null, "virtualMachineCount" ,container.Add );
            AddIf( null != this._vMScaleSetCount ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber((int)this._vMScaleSetCount) : null, "vmScaleSetCount" ,container.Add );
            AddIf( null != this._maxAllocationStandardManagedDisksAndSnapshot ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber((int)this._maxAllocationStandardManagedDisksAndSnapshot) : null, "maxAllocationStandardManagedDisksAndSnapshots" ,container.Add );
            AddIf( null != this._maxAllocationPremiumManagedDisksAndSnapshot ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber((int)this._maxAllocationPremiumManagedDisksAndSnapshot) : null, "maxAllocationPremiumManagedDisksAndSnapshots" ,container.Add );
            AddIf( null != this._ddagpuCount ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber((int)this._ddagpuCount) : null, "ddagpuCount" ,container.Add );
            AddIf( null != this._partitionedGpuCount ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNumber((int)this._partitionedGpuCount) : null, "partitionedGpuCount" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}