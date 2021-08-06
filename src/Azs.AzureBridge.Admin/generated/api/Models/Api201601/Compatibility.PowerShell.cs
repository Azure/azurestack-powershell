namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.PowerShell;

    /// <summary>Product compatibility</summary>
    [System.ComponentModel.TypeConverter(typeof(CompatibilityTypeConverter))]
    public partial class Compatibility
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.Compatibility"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Compatibility(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).IsCompatible = (bool?) content.GetValueForProperty("IsCompatible",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).IsCompatible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).Message, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).Issue = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[]) content.GetValueForProperty("Issue",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).Issue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue>(__y, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue.CreateFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.Compatibility"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Compatibility(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).IsCompatible = (bool?) content.GetValueForProperty("IsCompatible",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).IsCompatible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).Message, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).Issue = (Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[]) content.GetValueForProperty("Issue",((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal)this).Issue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue>(__y, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue.CreateFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.Compatibility"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Compatibility(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.Compatibility"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Compatibility(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Compatibility" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Product compatibility
    [System.ComponentModel.TypeConverter(typeof(CompatibilityTypeConverter))]
    public partial interface ICompatibility

    {

    }
}