namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.PowerShell;

    /// <summary>Resource usage information.</summary>
    [System.ComponentModel.TypeConverter(typeof(AdminOverviewResourceUsageTypeConverter))]
    public partial class AdminOverviewResourceUsage
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AdminOverviewResourceUsage(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)this).TotalResourceCount = (long?) content.GetValueForProperty("TotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)this).TotalResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)this).InUseResourceCount = (long?) content.GetValueForProperty("InUseResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)this).InUseResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AdminOverviewResourceUsage(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)this).TotalResourceCount = (long?) content.GetValueForProperty("TotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)this).TotalResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)this).InUseResourceCount = (long?) content.GetValueForProperty("InUseResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)this).InUseResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AdminOverviewResourceUsage(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AdminOverviewResourceUsage(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AdminOverviewResourceUsage" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Resource usage information.
    [System.ComponentModel.TypeConverter(typeof(AdminOverviewResourceUsageTypeConverter))]
    public partial interface IAdminOverviewResourceUsage

    {

    }
}