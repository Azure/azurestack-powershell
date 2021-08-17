namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.PowerShell;

    /// <summary>The GPU information on the physical machine.</summary>
    [System.ComponentModel.TypeConverter(typeof(GpuModelTypeConverter))]
    public partial class GpuModel
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.GpuModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new GpuModel(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.GpuModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new GpuModel(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="GpuModel" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.GpuModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal GpuModel(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).HostDriverVersion = (string) content.GetValueForProperty("HostDriverVersion",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).HostDriverVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).PartitionSize = (int?) content.GetValueForProperty("PartitionSize",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).PartitionSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).SlotLocation = (string) content.GetValueForProperty("SlotLocation",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).SlotLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).Oem = (string) content.GetValueForProperty("Oem",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).Oem, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.GpuType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.GpuType.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.GpuModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal GpuModel(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).HostDriverVersion = (string) content.GetValueForProperty("HostDriverVersion",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).HostDriverVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).PartitionSize = (int?) content.GetValueForProperty("PartitionSize",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).PartitionSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).SlotLocation = (string) content.GetValueForProperty("SlotLocation",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).SlotLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).Oem = (string) content.GetValueForProperty("Oem",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).Oem, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.GpuType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.GpuType.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The GPU information on the physical machine.
    [System.ComponentModel.TypeConverter(typeof(GpuModelTypeConverter))]
    public partial interface IGpuModel

    {

    }
}