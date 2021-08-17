namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.PowerShell;

    /// <summary>Holds information for a backup.</summary>
    [System.ComponentModel.TypeConverter(typeof(BackupInfoTypeConverter))]
    public partial class BackupInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.BackupInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BackupInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).BackupDataVersion = (string) content.GetValueForProperty("BackupDataVersion",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).BackupDataVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).RoleStatus = (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus[]) content.GetValueForProperty("RoleStatus",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).RoleStatus, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.RoleOperationStatusTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).CreatedDateTime = (global::System.DateTime?) content.GetValueForProperty("CreatedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).CreatedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).TimeTakenToCreate = (string) content.GetValueForProperty("TimeTakenToCreate",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).TimeTakenToCreate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).DeploymentId = (string) content.GetValueForProperty("DeploymentId",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).DeploymentId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).StampVersion = (string) content.GetValueForProperty("StampVersion",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).StampVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).OemVersion = (string) content.GetValueForProperty("OemVersion",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).OemVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).IsCloudRecoveryReady = (bool?) content.GetValueForProperty("IsCloudRecoveryReady",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).IsCloudRecoveryReady, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).EncryptionCertThumbprint = (string) content.GetValueForProperty("EncryptionCertThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).EncryptionCertThumbprint, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.BackupInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BackupInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).BackupDataVersion = (string) content.GetValueForProperty("BackupDataVersion",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).BackupDataVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).RoleStatus = (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus[]) content.GetValueForProperty("RoleStatus",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).RoleStatus, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.RoleOperationStatusTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).CreatedDateTime = (global::System.DateTime?) content.GetValueForProperty("CreatedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).CreatedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).TimeTakenToCreate = (string) content.GetValueForProperty("TimeTakenToCreate",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).TimeTakenToCreate, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).DeploymentId = (string) content.GetValueForProperty("DeploymentId",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).DeploymentId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).StampVersion = (string) content.GetValueForProperty("StampVersion",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).StampVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).OemVersion = (string) content.GetValueForProperty("OemVersion",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).OemVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).IsCloudRecoveryReady = (bool?) content.GetValueForProperty("IsCloudRecoveryReady",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).IsCloudRecoveryReady, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).EncryptionCertThumbprint = (string) content.GetValueForProperty("EncryptionCertThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)this).EncryptionCertThumbprint, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.BackupInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BackupInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.BackupInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BackupInfo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BackupInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Holds information for a backup.
    [System.ComponentModel.TypeConverter(typeof(BackupInfoTypeConverter))]
    public partial interface IBackupInfo

    {

    }
}