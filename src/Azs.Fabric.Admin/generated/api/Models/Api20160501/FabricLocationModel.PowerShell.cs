namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.PowerShell;

    /// <summary>All properties of a fabric location resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(FabricLocationModelTypeConverter))]
    public partial class FabricLocationModel
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.FabricLocationModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModel DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FabricLocationModel(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.FabricLocationModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModel DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FabricLocationModel(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.FabricLocationModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FabricLocationModel(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).PepIPAddress = (string[]) content.GetValueForProperty("PepIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).PepIPAddress, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).TimeServer = (string) content.GetValueForProperty("TimeServer",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).TimeServer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).StampInformationId = (string) content.GetValueForProperty("StampInformationId",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).StampInformationId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExternalDnsipAddress01 = (string) content.GetValueForProperty("ExternalDnsipAddress01",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExternalDnsipAddress01, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExternalDnsipAddress02 = (string) content.GetValueForProperty("ExternalDnsipAddress02",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExternalDnsipAddress02, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExclusiveAdminOperationRunning = (bool?) content.GetValueForProperty("ExclusiveAdminOperationRunning",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExclusiveAdminOperationRunning, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExclusiveAdminOperationName = (string) content.GetValueForProperty("ExclusiveAdminOperationName",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExclusiveAdminOperationName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).StartUpActionPlanStartTime = (global::System.DateTime?) content.GetValueForProperty("StartUpActionPlanStartTime",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).StartUpActionPlanStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).StartUpActionPlanEndTime = (global::System.DateTime?) content.GetValueForProperty("StartUpActionPlanEndTime",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).StartUpActionPlanEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ShutDownActionPlanStartTime = (global::System.DateTime?) content.GetValueForProperty("ShutDownActionPlanStartTime",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ShutDownActionPlanStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ShutDownActionPlanEndTime = (global::System.DateTime?) content.GetValueForProperty("ShutDownActionPlanEndTime",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ShutDownActionPlanEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.FabricLocationModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FabricLocationModel(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).PepIPAddress = (string[]) content.GetValueForProperty("PepIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).PepIPAddress, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).TimeServer = (string) content.GetValueForProperty("TimeServer",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).TimeServer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).StampInformationId = (string) content.GetValueForProperty("StampInformationId",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).StampInformationId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExternalDnsipAddress01 = (string) content.GetValueForProperty("ExternalDnsipAddress01",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExternalDnsipAddress01, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExternalDnsipAddress02 = (string) content.GetValueForProperty("ExternalDnsipAddress02",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExternalDnsipAddress02, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExclusiveAdminOperationRunning = (bool?) content.GetValueForProperty("ExclusiveAdminOperationRunning",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExclusiveAdminOperationRunning, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExclusiveAdminOperationName = (string) content.GetValueForProperty("ExclusiveAdminOperationName",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ExclusiveAdminOperationName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).StartUpActionPlanStartTime = (global::System.DateTime?) content.GetValueForProperty("StartUpActionPlanStartTime",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).StartUpActionPlanStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).StartUpActionPlanEndTime = (global::System.DateTime?) content.GetValueForProperty("StartUpActionPlanEndTime",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).StartUpActionPlanEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ShutDownActionPlanStartTime = (global::System.DateTime?) content.GetValueForProperty("ShutDownActionPlanStartTime",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ShutDownActionPlanStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ShutDownActionPlanEndTime = (global::System.DateTime?) content.GetValueForProperty("ShutDownActionPlanEndTime",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal)this).ShutDownActionPlanEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FabricLocationModel" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModel FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// All properties of a fabric location resource.
    [System.ComponentModel.TypeConverter(typeof(FabricLocationModelTypeConverter))]
    public partial interface IFabricLocationModel

    {

    }
}