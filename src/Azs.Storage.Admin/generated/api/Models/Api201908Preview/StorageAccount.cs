namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Properties of the storage account.</summary>
    public partial class StorageAccount :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccount,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.Resource();

        /// <summary>Required for storage accounts where kind = BlobStorage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountAccessTier? AccessTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).AccessTier; }

        /// <summary>Internal storage account ID, which is not visible to tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string AccountId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).AccountId; }

        /// <summary>The status of storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus? AccountStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).AccountStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).AccountStatus = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus)""); }

        /// <summary>Storage account type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountType? AccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).AccountType; }

        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public bool? BlobEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).BlobEnabled; }

        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string BlobLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).BlobLastEnabledTime; }

        /// <summary>The creation date and time of storage account in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).CreationTime; }

        /// <summary>The date-time when the storage account was deleted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? DeletedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).DeletedTime; }

        /// <summary>Encryption keySource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource? EncryptionKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).EncryptionKeySource; }

        /// <summary>The fault domain for the storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string FaultDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).FaultDomain; }

        /// <summary>The internal health state for storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountHealthState? HealthState { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).HealthState; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Id; }

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountKind? _kind;

        /// <summary>Indicates the type of storage account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountKind? Kind { get => this._kind; }

        /// <summary>Resource Location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Location; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal.Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Location = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for AccessTier</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountAccessTier? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.AccessTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).AccessTier; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).AccessTier = value; }

        /// <summary>Internal Acessors for AccountId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.AccountId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).AccountId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).AccountId = value; }

        /// <summary>Internal Acessors for AccountType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountType? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.AccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).AccountType; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).AccountType = value; }

        /// <summary>Internal Acessors for BlobEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.BlobEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).BlobEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).BlobEnabled = value; }

        /// <summary>Internal Acessors for BlobLastEnabledTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.BlobLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).BlobLastEnabledTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).BlobLastEnabledTime = value; }

        /// <summary>Internal Acessors for CreationTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).CreationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).CreationTime = value; }

        /// <summary>Internal Acessors for DeletedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.DeletedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).DeletedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).DeletedTime = value; }

        /// <summary>Internal Acessors for Encryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryption Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.Encryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).Encryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).Encryption = value; }

        /// <summary>Internal Acessors for EncryptionKeySource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.EncryptionKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).EncryptionKeySource; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).EncryptionKeySource = value; }

        /// <summary>Internal Acessors for EncryptionService</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.EncryptionService { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).EncryptionService; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).EncryptionService = value; }

        /// <summary>Internal Acessors for FaultDomain</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.FaultDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).FaultDomain; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).FaultDomain = value; }

        /// <summary>Internal Acessors for HealthState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountHealthState? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.HealthState { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).HealthState; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).HealthState = value; }

        /// <summary>Internal Acessors for Kind</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountKind? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.Kind { get => this._kind; set { {_kind = value;} } }

        /// <summary>Internal Acessors for PrimaryEndpoints</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpoints Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.PrimaryEndpoints { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).PrimaryEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).PrimaryEndpoint = value; }

        /// <summary>Internal Acessors for PrimaryLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.PrimaryLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).PrimaryLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).PrimaryLocation = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountProperties Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccountProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountState? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for QueueEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.QueueEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).QueueEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).QueueEnabled = value; }

        /// <summary>Internal Acessors for QueueLastEnabledTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.QueueLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).QueueLastEnabledTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).QueueLastEnabledTime = value; }

        /// <summary>Internal Acessors for ServiceBlob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.ServiceBlob { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).ServiceBlob; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).ServiceBlob = value; }

        /// <summary>Internal Acessors for ServiceQueue</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.ServiceQueue { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).ServiceQueue; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).ServiceQueue = value; }

        /// <summary>Internal Acessors for ServiceTable</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.ServiceTable { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).ServiceTable; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).ServiceTable = value; }

        /// <summary>Internal Acessors for StatusOfPrimary</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.LocationStatus? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.StatusOfPrimary { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).StatusOfPrimary; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).StatusOfPrimary = value; }

        /// <summary>Internal Acessors for SupportsHttpsTrafficOnly</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.SupportsHttpsTrafficOnly { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).SupportsHttpsTrafficOnly; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).SupportsHttpsTrafficOnly = value; }

        /// <summary>Internal Acessors for TableEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.TableEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TableEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TableEnabled = value; }

        /// <summary>Internal Acessors for TableLastEnabledTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.TableLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TableLastEnabledTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TableLastEnabledTime = value; }

        /// <summary>Internal Acessors for Tag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountTags Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccountTags()); set { {_tag = value;} } }

        /// <summary>Internal Acessors for TenantResourceGroupName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.TenantResourceGroupName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TenantResourceGroupName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TenantResourceGroupName = value; }

        /// <summary>Internal Acessors for TenantStorageAccountName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.TenantStorageAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TenantStorageAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TenantStorageAccountName = value; }

        /// <summary>Internal Acessors for TenantSubscriptionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.TenantSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TenantSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TenantSubscriptionId = value; }

        /// <summary>Internal Acessors for TenantViewId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountInternal.TenantViewId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TenantViewId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TenantViewId = value; }

        /// <summary>Resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Name; }

        /// <summary>
        /// The URLs that are used to perform a retrieval of a public BLOB, queue, or table object.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpoints PrimaryEndpoints { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).PrimaryEndpoint; }

        /// <summary>The primary location for the storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string PrimaryLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).PrimaryLocation; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountProperties _property;

        /// <summary>Properties of the storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccountProperties()); }

        /// <summary>The provisioning state of storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public bool? QueueEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).QueueEnabled; }

        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string QueueLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).QueueLastEnabledTime; }

        /// <summary>The status of primary location of storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.LocationStatus? StatusOfPrimary { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).StatusOfPrimary; }

        /// <summary>Storage account supports https traffic only or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public bool? SupportsHttpsTrafficOnly { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).SupportsHttpsTrafficOnly; }

        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public bool? TableEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TableEnabled; }

        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string TableLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TableLastEnabledTime; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccountTags()); }

        /// <summary>The name of resource group under which the storage account locates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string TenantResourceGroupName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TenantResourceGroupName; }

        /// <summary>Storage account name from tenant view.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string TenantStorageAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TenantStorageAccountName; }

        /// <summary>Subscription ID of the subscription under which the storage account locates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string TenantSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TenantSubscriptionId; }

        /// <summary>Resource URI of storage account from tenant view.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string TenantViewId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal)Property).TenantViewId; }

        /// <summary>Resource Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="StorageAccount" /> instance.</summary>
        public StorageAccount()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Properties of the storage account.
    public partial interface IStorageAccount :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResource
    {
        /// <summary>Required for storage accounts where kind = BlobStorage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Required for storage accounts where kind = BlobStorage.",
        SerializedName = @"accessTier",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountAccessTier) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountAccessTier? AccessTier { get;  }
        /// <summary>Internal storage account ID, which is not visible to tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Internal storage account ID, which is not visible to tenant.",
        SerializedName = @"accountId",
        PossibleTypes = new [] { typeof(string) })]
        string AccountId { get;  }
        /// <summary>The status of storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of storage account.",
        SerializedName = @"accountStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus? AccountStatus { get; set; }
        /// <summary>Storage account type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Storage account type.",
        SerializedName = @"accountType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountType) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountType? AccountType { get;  }
        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Bool to indicate whether enabled or not.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BlobEnabled { get;  }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A rough estimate of the date/time when the encryption was last enabled by the user.",
        SerializedName = @"lastEnabledTime",
        PossibleTypes = new [] { typeof(string) })]
        string BlobLastEnabledTime { get;  }
        /// <summary>The creation date and time of storage account in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The creation date and time of storage account in UTC.",
        SerializedName = @"creationTime",
        PossibleTypes = new [] { typeof(string) })]
        string CreationTime { get;  }
        /// <summary>The date-time when the storage account was deleted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The date-time when the storage account was deleted.",
        SerializedName = @"deletedTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? DeletedTime { get;  }
        /// <summary>Encryption keySource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Encryption keySource",
        SerializedName = @"keySource",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource? EncryptionKeySource { get;  }
        /// <summary>The fault domain for the storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The fault domain for the storage account.",
        SerializedName = @"faultDomain",
        PossibleTypes = new [] { typeof(string) })]
        string FaultDomain { get;  }
        /// <summary>The internal health state for storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The internal health state for storage account.",
        SerializedName = @"healthState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountHealthState) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountHealthState? HealthState { get;  }
        /// <summary>Indicates the type of storage account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Indicates the type of storage account",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountKind) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountKind? Kind { get;  }
        /// <summary>
        /// The URLs that are used to perform a retrieval of a public BLOB, queue, or table object.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The URLs that are used to perform a retrieval of a public BLOB, queue, or table object.",
        SerializedName = @"primaryEndpoints",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpoints) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpoints PrimaryEndpoints { get;  }
        /// <summary>The primary location for the storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The primary location for the storage account.",
        SerializedName = @"primaryLocation",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryLocation { get;  }
        /// <summary>The provisioning state of storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of storage account.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountState) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountState? ProvisioningState { get;  }
        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Bool to indicate whether enabled or not.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? QueueEnabled { get;  }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A rough estimate of the date/time when the encryption was last enabled by the user.",
        SerializedName = @"lastEnabledTime",
        PossibleTypes = new [] { typeof(string) })]
        string QueueLastEnabledTime { get;  }
        /// <summary>The status of primary location of storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The status of primary location of storage account.",
        SerializedName = @"statusOfPrimary",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.LocationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.LocationStatus? StatusOfPrimary { get;  }
        /// <summary>Storage account supports https traffic only or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Storage account supports https traffic only or not",
        SerializedName = @"supportsHttpsTrafficOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SupportsHttpsTrafficOnly { get;  }
        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Bool to indicate whether enabled or not.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? TableEnabled { get;  }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A rough estimate of the date/time when the encryption was last enabled by the user.",
        SerializedName = @"lastEnabledTime",
        PossibleTypes = new [] { typeof(string) })]
        string TableLastEnabledTime { get;  }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountTags Tag { get;  }
        /// <summary>The name of resource group under which the storage account locates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of resource group under which the storage account locates.",
        SerializedName = @"tenantResourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string TenantResourceGroupName { get;  }
        /// <summary>Storage account name from tenant view.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Storage account name from tenant view.",
        SerializedName = @"tenantStorageAccountName",
        PossibleTypes = new [] { typeof(string) })]
        string TenantStorageAccountName { get;  }
        /// <summary>Subscription ID of the subscription under which the storage account locates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Subscription ID of the subscription under which the storage account locates.",
        SerializedName = @"tenantSubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantSubscriptionId { get;  }
        /// <summary>Resource URI of storage account from tenant view.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource URI of storage account from tenant view.",
        SerializedName = @"tenantViewId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantViewId { get;  }

    }
    /// Properties of the storage account.
    internal partial interface IStorageAccountInternal :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal
    {
        /// <summary>Required for storage accounts where kind = BlobStorage.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountAccessTier? AccessTier { get; set; }
        /// <summary>Internal storage account ID, which is not visible to tenant.</summary>
        string AccountId { get; set; }
        /// <summary>The status of storage account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus? AccountStatus { get; set; }
        /// <summary>Storage account type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountType? AccountType { get; set; }
        /// <summary>Bool to indicate whether enabled or not.</summary>
        bool? BlobEnabled { get; set; }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        string BlobLastEnabledTime { get; set; }
        /// <summary>The creation date and time of storage account in UTC.</summary>
        string CreationTime { get; set; }
        /// <summary>The date-time when the storage account was deleted.</summary>
        global::System.DateTime? DeletedTime { get; set; }
        /// <summary>The storage encryption setting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryption Encryption { get; set; }
        /// <summary>Encryption keySource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource? EncryptionKeySource { get; set; }
        /// <summary>Services for which encryption setting is mentioned</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices EncryptionService { get; set; }
        /// <summary>The fault domain for the storage account.</summary>
        string FaultDomain { get; set; }
        /// <summary>The internal health state for storage account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountHealthState? HealthState { get; set; }
        /// <summary>Indicates the type of storage account</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountKind? Kind { get; set; }
        /// <summary>
        /// The URLs that are used to perform a retrieval of a public BLOB, queue, or table object.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpoints PrimaryEndpoints { get; set; }
        /// <summary>The primary location for the storage account.</summary>
        string PrimaryLocation { get; set; }
        /// <summary>Properties of the storage account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountProperties Property { get; set; }
        /// <summary>The provisioning state of storage account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountState? ProvisioningState { get; set; }
        /// <summary>Bool to indicate whether enabled or not.</summary>
        bool? QueueEnabled { get; set; }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        string QueueLastEnabledTime { get; set; }
        /// <summary>Blob service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting ServiceBlob { get; set; }
        /// <summary>Queue service</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting ServiceQueue { get; set; }
        /// <summary>Table service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting ServiceTable { get; set; }
        /// <summary>The status of primary location of storage account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.LocationStatus? StatusOfPrimary { get; set; }
        /// <summary>Storage account supports https traffic only or not</summary>
        bool? SupportsHttpsTrafficOnly { get; set; }
        /// <summary>Bool to indicate whether enabled or not.</summary>
        bool? TableEnabled { get; set; }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        string TableLastEnabledTime { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountTags Tag { get; set; }
        /// <summary>The name of resource group under which the storage account locates.</summary>
        string TenantResourceGroupName { get; set; }
        /// <summary>Storage account name from tenant view.</summary>
        string TenantStorageAccountName { get; set; }
        /// <summary>Subscription ID of the subscription under which the storage account locates.</summary>
        string TenantSubscriptionId { get; set; }
        /// <summary>Resource URI of storage account from tenant view.</summary>
        string TenantViewId { get; set; }

    }
}