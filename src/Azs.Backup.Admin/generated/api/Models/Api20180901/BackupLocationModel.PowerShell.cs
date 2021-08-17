namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.PowerShell;

    /// <summary>Properties of a backup location.</summary>
    [System.ComponentModel.TypeConverter(typeof(BackupLocationModelTypeConverter))]
    public partial class BackupLocationModel
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.BackupLocationModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BackupLocationModel(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefault = (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStore) content.GetValueForProperty("ExternalStoreDefault",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefault, Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.ExternalStoreTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultPath = (string) content.GetValueForProperty("ExternalStoreDefaultPath",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultUserName = (string) content.GetValueForProperty("ExternalStoreDefaultUserName",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultUserName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultPassword = (string) content.GetValueForProperty("ExternalStoreDefaultPassword",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultPassword, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultEncryptionCertBase64 = (string) content.GetValueForProperty("ExternalStoreDefaultEncryptionCertBase64",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultEncryptionCertBase64, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultEncryptionCertThumbprint = (string) content.GetValueForProperty("ExternalStoreDefaultEncryptionCertThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultEncryptionCertThumbprint, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultBackupFrequencyInHour = (int?) content.GetValueForProperty("ExternalStoreDefaultBackupFrequencyInHour",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultBackupFrequencyInHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultAvailableCapacity = (string) content.GetValueForProperty("ExternalStoreDefaultAvailableCapacity",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultAvailableCapacity, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultIsBackupSchedulerEnabled = (bool?) content.GetValueForProperty("ExternalStoreDefaultIsBackupSchedulerEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultIsBackupSchedulerEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultNextBackupTime = (global::System.DateTime?) content.GetValueForProperty("ExternalStoreDefaultNextBackupTime",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultNextBackupTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultLastBackupTime = (global::System.DateTime?) content.GetValueForProperty("ExternalStoreDefaultLastBackupTime",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultLastBackupTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultBackupRetentionPeriodInDay = (int?) content.GetValueForProperty("ExternalStoreDefaultBackupRetentionPeriodInDay",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultBackupRetentionPeriodInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.BackupLocationModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BackupLocationModel(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefault = (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStore) content.GetValueForProperty("ExternalStoreDefault",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefault, Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.ExternalStoreTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultPath = (string) content.GetValueForProperty("ExternalStoreDefaultPath",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultUserName = (string) content.GetValueForProperty("ExternalStoreDefaultUserName",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultUserName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultPassword = (string) content.GetValueForProperty("ExternalStoreDefaultPassword",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultPassword, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultEncryptionCertBase64 = (string) content.GetValueForProperty("ExternalStoreDefaultEncryptionCertBase64",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultEncryptionCertBase64, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultEncryptionCertThumbprint = (string) content.GetValueForProperty("ExternalStoreDefaultEncryptionCertThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultEncryptionCertThumbprint, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultBackupFrequencyInHour = (int?) content.GetValueForProperty("ExternalStoreDefaultBackupFrequencyInHour",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultBackupFrequencyInHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultAvailableCapacity = (string) content.GetValueForProperty("ExternalStoreDefaultAvailableCapacity",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultAvailableCapacity, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultIsBackupSchedulerEnabled = (bool?) content.GetValueForProperty("ExternalStoreDefaultIsBackupSchedulerEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultIsBackupSchedulerEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultNextBackupTime = (global::System.DateTime?) content.GetValueForProperty("ExternalStoreDefaultNextBackupTime",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultNextBackupTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultLastBackupTime = (global::System.DateTime?) content.GetValueForProperty("ExternalStoreDefaultLastBackupTime",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultLastBackupTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultBackupRetentionPeriodInDay = (int?) content.GetValueForProperty("ExternalStoreDefaultBackupRetentionPeriodInDay",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)this).ExternalStoreDefaultBackupRetentionPeriodInDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.BackupLocationModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModel DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BackupLocationModel(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.BackupLocationModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModel DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BackupLocationModel(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BackupLocationModel" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModel FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties of a backup location.
    [System.ComponentModel.TypeConverter(typeof(BackupLocationModelTypeConverter))]
    public partial interface IBackupLocationModel

    {

    }
}