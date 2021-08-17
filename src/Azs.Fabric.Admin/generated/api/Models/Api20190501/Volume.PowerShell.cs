namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501
{
    using Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.PowerShell;

    /// <summary>Representation of a volume resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(VolumeTypeConverter))]
    public partial class Volume
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.Volume"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolume" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolume DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Volume(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.Volume"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolume" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolume DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Volume(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Volume" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolume FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.Volume"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Volume(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModel) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.VolumeModelTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).TotalCapacityGB = (int?) content.GetValueForProperty("TotalCapacityGB",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).TotalCapacityGB, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).RemainingCapacityGB = (int?) content.GetValueForProperty("RemainingCapacityGB",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).RemainingCapacityGB, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).HealthStatus = (string) content.GetValueForProperty("HealthStatus",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).HealthStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).OperationalStatus = (string) content.GetValueForProperty("OperationalStatus",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).OperationalStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).RepairStatus = (string) content.GetValueForProperty("RepairStatus",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).RepairStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).Action = (string) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).Action, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).VolumeLabel = (string) content.GetValueForProperty("VolumeLabel",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).VolumeLabel, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.Volume"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Volume(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModel) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.VolumeModelTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).TotalCapacityGB = (int?) content.GetValueForProperty("TotalCapacityGB",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).TotalCapacityGB, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).RemainingCapacityGB = (int?) content.GetValueForProperty("RemainingCapacityGB",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).RemainingCapacityGB, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).HealthStatus = (string) content.GetValueForProperty("HealthStatus",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).HealthStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).OperationalStatus = (string) content.GetValueForProperty("OperationalStatus",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).OperationalStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).RepairStatus = (string) content.GetValueForProperty("RepairStatus",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).RepairStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).Action = (string) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).Action, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).VolumeLabel = (string) content.GetValueForProperty("VolumeLabel",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal)this).VolumeLabel, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// Representation of a volume resource.
    [System.ComponentModel.TypeConverter(typeof(VolumeTypeConverter))]
    public partial interface IVolume

    {

    }
}