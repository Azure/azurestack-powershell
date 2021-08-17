namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.PowerShell;

    /// <summary>Network quota resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(QuotaTypeConverter))]
    public partial class Quota
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.Quota"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Quota(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.Quota"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Quota(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Quota" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.Quota"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Quota(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.QuotaPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxPublicIpsPerSubscription = (long?) content.GetValueForProperty("MaxPublicIpsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxPublicIpsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxVnetsPerSubscription = (long?) content.GetValueForProperty("MaxVnetsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxVnetsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxVirtualNetworkGatewaysPerSubscription = (long?) content.GetValueForProperty("MaxVirtualNetworkGatewaysPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxVirtualNetworkGatewaysPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxVirtualNetworkGatewayConnectionsPerSubscription = (long?) content.GetValueForProperty("MaxVirtualNetworkGatewayConnectionsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxVirtualNetworkGatewayConnectionsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxLoadBalancersPerSubscription = (long?) content.GetValueForProperty("MaxLoadBalancersPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxLoadBalancersPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxNicsPerSubscription = (long?) content.GetValueForProperty("MaxNicsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxNicsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxSecurityGroupsPerSubscription = (long?) content.GetValueForProperty("MaxSecurityGroupsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxSecurityGroupsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MigrationPhase = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType?) content.GetValueForProperty("MigrationPhase",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MigrationPhase, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.Quota"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Quota(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.QuotaPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxPublicIpsPerSubscription = (long?) content.GetValueForProperty("MaxPublicIpsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxPublicIpsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxVnetsPerSubscription = (long?) content.GetValueForProperty("MaxVnetsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxVnetsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxVirtualNetworkGatewaysPerSubscription = (long?) content.GetValueForProperty("MaxVirtualNetworkGatewaysPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxVirtualNetworkGatewaysPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxVirtualNetworkGatewayConnectionsPerSubscription = (long?) content.GetValueForProperty("MaxVirtualNetworkGatewayConnectionsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxVirtualNetworkGatewayConnectionsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxLoadBalancersPerSubscription = (long?) content.GetValueForProperty("MaxLoadBalancersPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxLoadBalancersPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxNicsPerSubscription = (long?) content.GetValueForProperty("MaxNicsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxNicsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxSecurityGroupsPerSubscription = (long?) content.GetValueForProperty("MaxSecurityGroupsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MaxSecurityGroupsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MigrationPhase = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType?) content.GetValueForProperty("MigrationPhase",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal)this).MigrationPhase, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Network quota resource.
    [System.ComponentModel.TypeConverter(typeof(QuotaTypeConverter))]
    public partial interface IQuota

    {

    }
}