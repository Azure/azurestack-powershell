namespace Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501
{
    using Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.PowerShell;

    /// <summary>Information related to a location's update status.</summary>
    [System.ComponentModel.TypeConverter(typeof(UpdateLocationTypeConverter))]
    public partial class UpdateLocation
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocation" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocation DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UpdateLocation(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocation" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocation DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UpdateLocation(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UpdateLocation" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocation FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UpdateLocation(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModel) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateLocationModelTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.ResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).CurrentVersion = (string) content.GetValueForProperty("CurrentVersion",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).CurrentVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).CurrentOemVersion = (string) content.GetValueForProperty("CurrentOemVersion",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).CurrentOemVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).LastUpdated = (global::System.DateTime?) content.GetValueForProperty("LastUpdated",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).LastUpdated, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UpdateLocation(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModel) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateLocationModelTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.ResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).CurrentVersion = (string) content.GetValueForProperty("CurrentVersion",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).CurrentVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).CurrentOemVersion = (string) content.GetValueForProperty("CurrentOemVersion",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).CurrentOemVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).LastUpdated = (global::System.DateTime?) content.GetValueForProperty("LastUpdated",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).LastUpdated, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState.CreateFrom);
            AfterDeserializePSObject(content);
        }
    }
    /// Information related to a location's update status.
    [System.ComponentModel.TypeConverter(typeof(UpdateLocationTypeConverter))]
    public partial interface IUpdateLocation

    {

    }
}