namespace Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501
{
    using Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.PowerShell;

    /// <summary>Properties of an update run.</summary>
    [System.ComponentModel.TypeConverter(typeof(UpdateRunModelTypeConverter))]
    public partial class UpdateRunModel
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateRunModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModel DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UpdateRunModel(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateRunModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModel DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UpdateRunModel(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UpdateRunModel" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModel FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateRunModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UpdateRunModel(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).Progress = (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep) content.GetValueForProperty("Progress",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).Progress, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.StepTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).TimeStarted = (global::System.DateTime?) content.GetValueForProperty("TimeStarted",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).TimeStarted, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).Duration = (string) content.GetValueForProperty("Duration",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).Duration, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressName = (string) content.GetValueForProperty("ProgressName",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressDescription = (string) content.GetValueForProperty("ProgressDescription",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressErrorMessage = (string) content.GetValueForProperty("ProgressErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressErrorMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressStatus = (string) content.GetValueForProperty("ProgressStatus",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressStartTimeUtc = (global::System.DateTime?) content.GetValueForProperty("ProgressStartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressStartTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressEndTimeUtc = (global::System.DateTime?) content.GetValueForProperty("ProgressEndTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressEndTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressStep = (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep[]) content.GetValueForProperty("ProgressStep",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressStep, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep>(__y, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.StepTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateRunModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UpdateRunModel(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).Progress = (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep) content.GetValueForProperty("Progress",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).Progress, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.StepTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).TimeStarted = (global::System.DateTime?) content.GetValueForProperty("TimeStarted",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).TimeStarted, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).Duration = (string) content.GetValueForProperty("Duration",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).Duration, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressName = (string) content.GetValueForProperty("ProgressName",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressDescription = (string) content.GetValueForProperty("ProgressDescription",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressErrorMessage = (string) content.GetValueForProperty("ProgressErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressErrorMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressStatus = (string) content.GetValueForProperty("ProgressStatus",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressStartTimeUtc = (global::System.DateTime?) content.GetValueForProperty("ProgressStartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressStartTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressEndTimeUtc = (global::System.DateTime?) content.GetValueForProperty("ProgressEndTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressEndTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressStep = (Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep[]) content.GetValueForProperty("ProgressStep",((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)this).ProgressStep, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep>(__y, Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.StepTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }
    }
    /// Properties of an update run.
    [System.ComponentModel.TypeConverter(typeof(UpdateRunModelTypeConverter))]
    public partial interface IUpdateRunModel

    {

    }
}