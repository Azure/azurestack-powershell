namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501
{
    using Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.PowerShell;

    /// <summary>Properties of a drive.</summary>
    [System.ComponentModel.TypeConverter(typeof(DriveModelTypeConverter))]
    public partial class DriveModel
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.DriveModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModel DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DriveModel(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.DriveModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModel DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DriveModel(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.DriveModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DriveModel(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).StorageNode = (string) content.GetValueForProperty("StorageNode",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).StorageNode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).SerialNumber = (string) content.GetValueForProperty("SerialNumber",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).SerialNumber, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).HealthStatus = (string) content.GetValueForProperty("HealthStatus",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).HealthStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).OperationalStatus = (string) content.GetValueForProperty("OperationalStatus",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).OperationalStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Usage = (string) content.GetValueForProperty("Usage",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Usage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).PhysicalLocation = (string) content.GetValueForProperty("PhysicalLocation",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).PhysicalLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Model = (string) content.GetValueForProperty("Model",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Model, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).FirmwareVersion = (string) content.GetValueForProperty("FirmwareVersion",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).FirmwareVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).IsIndicationEnabled = (bool?) content.GetValueForProperty("IsIndicationEnabled",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).IsIndicationEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Manufacturer = (string) content.GetValueForProperty("Manufacturer",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Manufacturer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).StoragePool = (string) content.GetValueForProperty("StoragePool",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).StoragePool, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).MediaType = (string) content.GetValueForProperty("MediaType",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).MediaType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).CapacityGb = (int?) content.GetValueForProperty("CapacityGb",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).CapacityGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Action = (string) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Action, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.DriveModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DriveModel(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).StorageNode = (string) content.GetValueForProperty("StorageNode",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).StorageNode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).SerialNumber = (string) content.GetValueForProperty("SerialNumber",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).SerialNumber, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).HealthStatus = (string) content.GetValueForProperty("HealthStatus",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).HealthStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).OperationalStatus = (string) content.GetValueForProperty("OperationalStatus",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).OperationalStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Usage = (string) content.GetValueForProperty("Usage",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Usage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).PhysicalLocation = (string) content.GetValueForProperty("PhysicalLocation",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).PhysicalLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Model = (string) content.GetValueForProperty("Model",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Model, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).FirmwareVersion = (string) content.GetValueForProperty("FirmwareVersion",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).FirmwareVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).IsIndicationEnabled = (bool?) content.GetValueForProperty("IsIndicationEnabled",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).IsIndicationEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Manufacturer = (string) content.GetValueForProperty("Manufacturer",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Manufacturer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).StoragePool = (string) content.GetValueForProperty("StoragePool",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).StoragePool, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).MediaType = (string) content.GetValueForProperty("MediaType",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).MediaType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).CapacityGb = (int?) content.GetValueForProperty("CapacityGb",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).CapacityGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Action = (string) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)this).Action, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DriveModel" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModel FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties of a drive.
    [System.ComponentModel.TypeConverter(typeof(DriveModelTypeConverter))]
    public partial interface IDriveModel

    {

    }
}