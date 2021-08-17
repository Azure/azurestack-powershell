namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.PowerShell;

    /// <summary>Properties of a quota.</summary>
    [System.ComponentModel.TypeConverter(typeof(QuotaPropertiesTypeConverter))]
    public partial class QuotaProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.QuotaProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new QuotaProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.QuotaProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new QuotaProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="QuotaProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.QuotaProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal QuotaProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxPublicIpsPerSubscription = (long?) content.GetValueForProperty("MaxPublicIpsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxPublicIpsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxVnetsPerSubscription = (long?) content.GetValueForProperty("MaxVnetsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxVnetsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxVirtualNetworkGatewaysPerSubscription = (long?) content.GetValueForProperty("MaxVirtualNetworkGatewaysPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxVirtualNetworkGatewaysPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxVirtualNetworkGatewayConnectionsPerSubscription = (long?) content.GetValueForProperty("MaxVirtualNetworkGatewayConnectionsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxVirtualNetworkGatewayConnectionsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxLoadBalancersPerSubscription = (long?) content.GetValueForProperty("MaxLoadBalancersPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxLoadBalancersPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxNicsPerSubscription = (long?) content.GetValueForProperty("MaxNicsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxNicsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxSecurityGroupsPerSubscription = (long?) content.GetValueForProperty("MaxSecurityGroupsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxSecurityGroupsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MigrationPhase = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType?) content.GetValueForProperty("MigrationPhase",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MigrationPhase, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.QuotaProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal QuotaProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxPublicIpsPerSubscription = (long?) content.GetValueForProperty("MaxPublicIpsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxPublicIpsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxVnetsPerSubscription = (long?) content.GetValueForProperty("MaxVnetsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxVnetsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxVirtualNetworkGatewaysPerSubscription = (long?) content.GetValueForProperty("MaxVirtualNetworkGatewaysPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxVirtualNetworkGatewaysPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxVirtualNetworkGatewayConnectionsPerSubscription = (long?) content.GetValueForProperty("MaxVirtualNetworkGatewayConnectionsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxVirtualNetworkGatewayConnectionsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxLoadBalancersPerSubscription = (long?) content.GetValueForProperty("MaxLoadBalancersPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxLoadBalancersPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxNicsPerSubscription = (long?) content.GetValueForProperty("MaxNicsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxNicsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxSecurityGroupsPerSubscription = (long?) content.GetValueForProperty("MaxSecurityGroupsPerSubscription",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MaxSecurityGroupsPerSubscription, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MigrationPhase = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType?) content.GetValueForProperty("MigrationPhase",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)this).MigrationPhase, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties of a quota.
    [System.ComponentModel.TypeConverter(typeof(QuotaPropertiesTypeConverter))]
    public partial interface IQuotaProperties

    {

    }
}