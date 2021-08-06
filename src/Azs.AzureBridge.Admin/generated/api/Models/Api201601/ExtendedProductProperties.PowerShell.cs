namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.PowerShell;

    /// <summary>Product information.</summary>
    [System.ComponentModel.TypeConverter(typeof(ExtendedProductPropertiesTypeConverter))]
    public partial class ExtendedProductProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ExtendedProductProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedProductProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedProductProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ExtendedProductProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ExtendedProductProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedProductProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedProductProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ExtendedProductProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ExtendedProductProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ExtendedProductProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).SourceBlobUri = (string) content.GetValueForProperty("SourceBlobUri",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).SourceBlobUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).SourceBlob = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUri) content.GetValueForProperty("SourceBlob",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).SourceBlob, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.UriTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).ComputeRole = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole?) content.GetValueForProperty("ComputeRole",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).ComputeRole, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).IsSystemExtension = (bool?) content.GetValueForProperty("IsSystemExtension",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).IsSystemExtension, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).SupportMultipleExtension = (bool?) content.GetValueForProperty("SupportMultipleExtension",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).SupportMultipleExtension, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).VmosType = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem?) content.GetValueForProperty("VmosType",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).VmosType, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).VMScaleSetEnabled = (bool?) content.GetValueForProperty("VMScaleSetEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).VMScaleSetEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).OSDiskImageOperatingSystem = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem?) content.GetValueForProperty("OSDiskImageOperatingSystem",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).OSDiskImageOperatingSystem, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).OSDiskImageSourceBlobSasUri = (string) content.GetValueForProperty("OSDiskImageSourceBlobSasUri",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).OSDiskImageSourceBlobSasUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).OSDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImage) content.GetValueForProperty("OSDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).OSDiskImage, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.OSDiskImageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).DataDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[]) content.GetValueForProperty("DataDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).DataDiskImage, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage>(__y, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.DataDiskImageTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ExtendedProductProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ExtendedProductProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).SourceBlobUri = (string) content.GetValueForProperty("SourceBlobUri",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).SourceBlobUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).SourceBlob = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUri) content.GetValueForProperty("SourceBlob",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).SourceBlob, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.UriTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).ComputeRole = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole?) content.GetValueForProperty("ComputeRole",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).ComputeRole, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).IsSystemExtension = (bool?) content.GetValueForProperty("IsSystemExtension",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).IsSystemExtension, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).SupportMultipleExtension = (bool?) content.GetValueForProperty("SupportMultipleExtension",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).SupportMultipleExtension, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).VmosType = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem?) content.GetValueForProperty("VmosType",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).VmosType, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).VMScaleSetEnabled = (bool?) content.GetValueForProperty("VMScaleSetEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)this).VMScaleSetEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).OSDiskImageOperatingSystem = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem?) content.GetValueForProperty("OSDiskImageOperatingSystem",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).OSDiskImageOperatingSystem, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).OSDiskImageSourceBlobSasUri = (string) content.GetValueForProperty("OSDiskImageSourceBlobSasUri",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).OSDiskImageSourceBlobSasUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).OSDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImage) content.GetValueForProperty("OSDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).OSDiskImage, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.OSDiskImageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).DataDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[]) content.GetValueForProperty("DataDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)this).DataDiskImage, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage>(__y, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.DataDiskImageTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ExtendedProductProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedProductProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Product information.
    [System.ComponentModel.TypeConverter(typeof(ExtendedProductPropertiesTypeConverter))]
    public partial interface IExtendedProductProperties

    {

    }
}