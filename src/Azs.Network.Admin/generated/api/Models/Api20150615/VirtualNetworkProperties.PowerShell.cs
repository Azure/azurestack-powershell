namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.PowerShell;

    /// <summary>Properties of a virtual network.</summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualNetworkPropertiesTypeConverter))]
    public partial class VirtualNetworkProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.VirtualNetworkProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualNetworkProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.VirtualNetworkProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualNetworkProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualNetworkProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.VirtualNetworkProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualNetworkProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationState = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationState) content.GetValueForProperty("ConfigurationState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationState, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.VirtualNetworkConfigurationStateTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)this).Uri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateStatus = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStateStatusType?) content.GetValueForProperty("ConfigurationStateStatus",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateStatus, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStateStatusType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateLastUpdatedTime = (global::System.DateTime?) content.GetValueForProperty("ConfigurationStateLastUpdatedTime",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateLastUpdatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateVirtualNetworkInterfaceError = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus[]) content.GetValueForProperty("ConfigurationStateVirtualNetworkInterfaceError",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateVirtualNetworkInterfaceError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.VirtualNetworkConfigurationStatusTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateHostError = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus[]) content.GetValueForProperty("ConfigurationStateHostError",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateHostError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.VirtualNetworkConfigurationStatusTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.VirtualNetworkProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualNetworkProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationState = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationState) content.GetValueForProperty("ConfigurationState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationState, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.VirtualNetworkConfigurationStateTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)this).Uri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateStatus = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStateStatusType?) content.GetValueForProperty("ConfigurationStateStatus",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateStatus, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStateStatusType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateLastUpdatedTime = (global::System.DateTime?) content.GetValueForProperty("ConfigurationStateLastUpdatedTime",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateLastUpdatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateVirtualNetworkInterfaceError = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus[]) content.GetValueForProperty("ConfigurationStateVirtualNetworkInterfaceError",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateVirtualNetworkInterfaceError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.VirtualNetworkConfigurationStatusTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateHostError = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus[]) content.GetValueForProperty("ConfigurationStateHostError",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)this).ConfigurationStateHostError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.VirtualNetworkConfigurationStatusTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }
    }
    /// Properties of a virtual network.
    [System.ComponentModel.TypeConverter(typeof(VirtualNetworkPropertiesTypeConverter))]
    public partial interface IVirtualNetworkProperties

    {

    }
}