namespace Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101
{
    using Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.PowerShell;

    /// <summary>List of supported operations.</summary>
    [System.ComponentModel.TypeConverter(typeof(SubscriptionTypeConverter))]
    public partial class Subscription
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.Subscription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Subscription(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.Subscription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Subscription(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Subscription" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscription FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.Subscription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Subscription(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).OfferId = (string) content.GetValueForProperty("OfferId",((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).OfferId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).TenantId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.Subscription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Subscription(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).DisplayName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).OfferId = (string) content.GetValueForProperty("OfferId",((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).OfferId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.Subscription.Support.SubscriptionState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ISubscriptionInternal)this).TenantId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// List of supported operations.
    [System.ComponentModel.TypeConverter(typeof(SubscriptionTypeConverter))]
    public partial interface ISubscription

    {

    }
}