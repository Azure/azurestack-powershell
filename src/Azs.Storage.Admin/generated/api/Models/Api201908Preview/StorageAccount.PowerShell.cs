namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.PowerShell;

    /// <summary>Properties of the storage account.</summary>
    [System.ComponentModel.TypeConverter(typeof(StorageAccountTypeConverter))]
    public partial class StorageAccount
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccount"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccount" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccount DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StorageAccount(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccount"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccount" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccount DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StorageAccount(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StorageAccount" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccount FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccount"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StorageAccount(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccountPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountKind?) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountKind.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccountTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Encryption = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryption) content.GetValueForProperty("Encryption",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Encryption, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantViewId = (string) content.GetValueForProperty("TenantViewId",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantViewId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccountType = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountType?) content.GetValueForProperty("AccountType",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccountType, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).PrimaryEndpoints = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpoints) content.GetValueForProperty("PrimaryEndpoints",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).PrimaryEndpoints, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccountPropertiesPrimaryEndpointsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).CreationTime = (string) content.GetValueForProperty("CreationTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).CreationTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).PrimaryLocation = (string) content.GetValueForProperty("PrimaryLocation",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).PrimaryLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).FaultDomain = (string) content.GetValueForProperty("FaultDomain",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).FaultDomain, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).StatusOfPrimary = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.LocationStatus?) content.GetValueForProperty("StatusOfPrimary",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).StatusOfPrimary, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.LocationStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantSubscriptionId = (string) content.GetValueForProperty("TenantSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantSubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantStorageAccountName = (string) content.GetValueForProperty("TenantStorageAccountName",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantStorageAccountName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantResourceGroupName = (string) content.GetValueForProperty("TenantResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).DeletedTime = (global::System.DateTime?) content.GetValueForProperty("DeletedTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).DeletedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccountStatus = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus?) content.GetValueForProperty("AccountStatus",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccountStatus, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccountId = (string) content.GetValueForProperty("AccountId",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).SupportsHttpsTrafficOnly = (bool?) content.GetValueForProperty("SupportsHttpsTrafficOnly",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).SupportsHttpsTrafficOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccessTier = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountAccessTier?) content.GetValueForProperty("AccessTier",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccessTier, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountAccessTier.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).HealthState = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountHealthState?) content.GetValueForProperty("HealthState",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).HealthState, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountHealthState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).EncryptionKeySource = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource?) content.GetValueForProperty("EncryptionKeySource",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).EncryptionKeySource, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).EncryptionService = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices) content.GetValueForProperty("EncryptionService",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).EncryptionService, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionServicesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ServiceBlob = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("ServiceBlob",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ServiceBlob, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ServiceTable = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("ServiceTable",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ServiceTable, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ServiceQueue = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("ServiceQueue",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ServiceQueue, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).BlobEnabled = (bool?) content.GetValueForProperty("BlobEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).BlobEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).BlobLastEnabledTime = (string) content.GetValueForProperty("BlobLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).BlobLastEnabledTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TableEnabled = (bool?) content.GetValueForProperty("TableEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TableEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TableLastEnabledTime = (string) content.GetValueForProperty("TableLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TableLastEnabledTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).QueueEnabled = (bool?) content.GetValueForProperty("QueueEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).QueueEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).QueueLastEnabledTime = (string) content.GetValueForProperty("QueueLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).QueueLastEnabledTime, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccount"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StorageAccount(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccountPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountKind?) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountKind.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccountTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Encryption = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryption) content.GetValueForProperty("Encryption",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).Encryption, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantViewId = (string) content.GetValueForProperty("TenantViewId",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantViewId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccountType = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountType?) content.GetValueForProperty("AccountType",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccountType, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).PrimaryEndpoints = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpoints) content.GetValueForProperty("PrimaryEndpoints",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).PrimaryEndpoints, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccountPropertiesPrimaryEndpointsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).CreationTime = (string) content.GetValueForProperty("CreationTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).CreationTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).PrimaryLocation = (string) content.GetValueForProperty("PrimaryLocation",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).PrimaryLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).FaultDomain = (string) content.GetValueForProperty("FaultDomain",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).FaultDomain, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).StatusOfPrimary = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.LocationStatus?) content.GetValueForProperty("StatusOfPrimary",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).StatusOfPrimary, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.LocationStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantSubscriptionId = (string) content.GetValueForProperty("TenantSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantSubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantStorageAccountName = (string) content.GetValueForProperty("TenantStorageAccountName",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantStorageAccountName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantResourceGroupName = (string) content.GetValueForProperty("TenantResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TenantResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).DeletedTime = (global::System.DateTime?) content.GetValueForProperty("DeletedTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).DeletedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccountStatus = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus?) content.GetValueForProperty("AccountStatus",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccountStatus, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccountId = (string) content.GetValueForProperty("AccountId",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).SupportsHttpsTrafficOnly = (bool?) content.GetValueForProperty("SupportsHttpsTrafficOnly",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).SupportsHttpsTrafficOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccessTier = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountAccessTier?) content.GetValueForProperty("AccessTier",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).AccessTier, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountAccessTier.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).HealthState = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountHealthState?) content.GetValueForProperty("HealthState",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).HealthState, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountHealthState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).EncryptionKeySource = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource?) content.GetValueForProperty("EncryptionKeySource",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).EncryptionKeySource, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).EncryptionService = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices) content.GetValueForProperty("EncryptionService",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).EncryptionService, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionServicesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ServiceBlob = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("ServiceBlob",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ServiceBlob, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ServiceTable = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("ServiceTable",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ServiceTable, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ServiceQueue = (Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting) content.GetValueForProperty("ServiceQueue",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).ServiceQueue, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSettingTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).BlobEnabled = (bool?) content.GetValueForProperty("BlobEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).BlobEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).BlobLastEnabledTime = (string) content.GetValueForProperty("BlobLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).BlobLastEnabledTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TableEnabled = (bool?) content.GetValueForProperty("TableEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TableEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TableLastEnabledTime = (string) content.GetValueForProperty("TableLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).TableLastEnabledTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).QueueEnabled = (bool?) content.GetValueForProperty("QueueEnabled",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).QueueEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).QueueLastEnabledTime = (string) content.GetValueForProperty("QueueLastEnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal)this).QueueLastEnabledTime, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties of the storage account.
    [System.ComponentModel.TypeConverter(typeof(StorageAccountTypeConverter))]
    public partial interface IStorageAccount

    {

    }
}