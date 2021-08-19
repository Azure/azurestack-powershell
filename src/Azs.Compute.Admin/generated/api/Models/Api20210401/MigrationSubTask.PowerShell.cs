namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.PowerShell;

    /// <summary>Disk migration child task.</summary>
    [System.ComponentModel.TypeConverter(typeof(MigrationSubTaskTypeConverter))]
    public partial class MigrationSubTask
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.MigrationSubTask"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTask" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTask DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MigrationSubTask(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.MigrationSubTask"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTask" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTask DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MigrationSubTask(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MigrationSubTask" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTask FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.MigrationSubTask"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MigrationSubTask(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.MigrationSubTaskPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Reason = (string) content.GetValueForProperty("Reason",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Reason, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).TargetShare = (string) content.GetValueForProperty("TargetShare",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).TargetShare, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).SourceShare = (string) content.GetValueForProperty("SourceShare",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).SourceShare, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).TargetDiskStateForMigration = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState?) content.GetValueForProperty("TargetDiskStateForMigration",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).TargetDiskStateForMigration, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).DiskId = (string) content.GetValueForProperty("DiskId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).DiskId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.MigrationSubTask"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MigrationSubTask(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.MigrationSubTaskPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Reason = (string) content.GetValueForProperty("Reason",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).Reason, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).TargetShare = (string) content.GetValueForProperty("TargetShare",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).TargetShare, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).SourceShare = (string) content.GetValueForProperty("SourceShare",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).SourceShare, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).TargetDiskStateForMigration = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState?) content.GetValueForProperty("TargetDiskStateForMigration",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).TargetDiskStateForMigration, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).DiskId = (string) content.GetValueForProperty("DiskId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal)this).DiskId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Disk migration child task.
    [System.ComponentModel.TypeConverter(typeof(MigrationSubTaskTypeConverter))]
    public partial interface IMigrationSubTask

    {

    }
}