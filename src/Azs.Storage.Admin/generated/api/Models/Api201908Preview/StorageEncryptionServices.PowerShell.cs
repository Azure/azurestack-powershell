namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.PowerShell;

    /// <summary>Services for which encryption setting is mentioned.</summary>
    [System.ComponentModel.TypeConverter(typeof(StorageEncryptionServicesTypeConverter))]
    public partial class StorageEncryptionServices
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionServices"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StorageEncryptionServices(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionServices"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StorageEncryptionServices(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StorageEncryptionServices" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionServices"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StorageEncryptionServices(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).Blob = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("Blob",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).Blob, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).Table = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("Table",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).Table, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).Queue = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("Queue",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).Queue, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).BlobEnabled = (bool?) content.GetValueForProperty("BlobEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).BlobEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).BlobLastEnabledTime = (string) content.GetValueForProperty("BlobLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).BlobLastEnabledTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).TableEnabled = (bool?) content.GetValueForProperty("TableEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).TableEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).TableLastEnabledTime = (string) content.GetValueForProperty("TableLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).TableLastEnabledTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).QueueEnabled = (bool?) content.GetValueForProperty("QueueEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).QueueEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).QueueLastEnabledTime = (string) content.GetValueForProperty("QueueLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).QueueLastEnabledTime, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionServices"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StorageEncryptionServices(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).Blob = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("Blob",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).Blob, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).Table = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("Table",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).Table, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).Queue = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("Queue",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).Queue, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).BlobEnabled = (bool?) content.GetValueForProperty("BlobEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).BlobEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).BlobLastEnabledTime = (string) content.GetValueForProperty("BlobLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).BlobLastEnabledTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).TableEnabled = (bool?) content.GetValueForProperty("TableEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).TableEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).TableLastEnabledTime = (string) content.GetValueForProperty("TableLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).TableLastEnabledTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).QueueEnabled = (bool?) content.GetValueForProperty("QueueEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).QueueEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).QueueLastEnabledTime = (string) content.GetValueForProperty("QueueLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)this).QueueLastEnabledTime, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Services for which encryption setting is mentioned.
    [System.ComponentModel.TypeConverter(typeof(StorageEncryptionServicesTypeConverter))]
    public partial interface IStorageEncryptionServices

    {

    }
}