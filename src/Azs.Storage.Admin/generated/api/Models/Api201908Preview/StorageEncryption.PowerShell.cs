namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.PowerShell;

    /// <summary>Storage encryption setting</summary>
    [System.ComponentModel.TypeConverter(typeof(StorageEncryptionTypeConverter))]
    public partial class StorageEncryption
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryption"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryption"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryption DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StorageEncryption(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryption"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryption"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryption DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StorageEncryption(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StorageEncryption" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryption FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryption"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StorageEncryption(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).Service = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices) content.GetValueForProperty("Service",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).Service, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionServicesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).KeySource = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource?) content.GetValueForProperty("KeySource",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).KeySource, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).ServiceBlob = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("ServiceBlob",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).ServiceBlob, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).ServiceTable = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("ServiceTable",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).ServiceTable, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).ServiceQueue = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("ServiceQueue",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).ServiceQueue, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).BlobEnabled = (bool?) content.GetValueForProperty("BlobEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).BlobEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).BlobLastEnabledTime = (string) content.GetValueForProperty("BlobLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).BlobLastEnabledTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).TableEnabled = (bool?) content.GetValueForProperty("TableEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).TableEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).TableLastEnabledTime = (string) content.GetValueForProperty("TableLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).TableLastEnabledTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).QueueEnabled = (bool?) content.GetValueForProperty("QueueEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).QueueEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).QueueLastEnabledTime = (string) content.GetValueForProperty("QueueLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).QueueLastEnabledTime, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryption"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StorageEncryption(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).Service = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices) content.GetValueForProperty("Service",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).Service, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionServicesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).KeySource = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource?) content.GetValueForProperty("KeySource",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).KeySource, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).ServiceBlob = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("ServiceBlob",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).ServiceBlob, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).ServiceTable = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("ServiceTable",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).ServiceTable, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).ServiceQueue = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("ServiceQueue",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).ServiceQueue, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).BlobEnabled = (bool?) content.GetValueForProperty("BlobEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).BlobEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).BlobLastEnabledTime = (string) content.GetValueForProperty("BlobLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).BlobLastEnabledTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).TableEnabled = (bool?) content.GetValueForProperty("TableEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).TableEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).TableLastEnabledTime = (string) content.GetValueForProperty("TableLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).TableLastEnabledTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).QueueEnabled = (bool?) content.GetValueForProperty("QueueEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).QueueEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).QueueLastEnabledTime = (string) content.GetValueForProperty("QueueLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)this).QueueLastEnabledTime, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Storage encryption setting
    [System.ComponentModel.TypeConverter(typeof(StorageEncryptionTypeConverter))]
    public partial interface IStorageEncryption

    {

    }
}