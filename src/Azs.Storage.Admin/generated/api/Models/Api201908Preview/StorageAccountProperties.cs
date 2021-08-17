namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Properties of a storage account.</summary>
    public partial class StorageAccountProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AccessTier" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountAccessTier? _accessTier;

        /// <summary>Required for storage accounts where kind = BlobStorage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountAccessTier? AccessTier { get => this._accessTier; }

        /// <summary>Backing field for <see cref="AccountId" /> property.</summary>
        private string _accountId;

        /// <summary>Internal storage account ID, which is not visible to tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string AccountId { get => this._accountId; }

        /// <summary>Backing field for <see cref="AccountStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus? _accountStatus;

        /// <summary>The status of storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountStatus? AccountStatus { get => this._accountStatus; set => this._accountStatus = value; }

        /// <summary>Backing field for <see cref="AccountType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountType? _accountType;

        /// <summary>Storage account type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountType? AccountType { get => this._accountType; }

        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public bool? BlobEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).BlobEnabled; }

        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string BlobLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).BlobLastEnabledTime; }

        /// <summary>Backing field for <see cref="CreationTime" /> property.</summary>
        private string _creationTime;

        /// <summary>The creation date and time of storage account in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string CreationTime { get => this._creationTime; }

        /// <summary>Backing field for <see cref="DeletedTime" /> property.</summary>
        private global::System.DateTime? _deletedTime;

        /// <summary>The date-time when the storage account was deleted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? DeletedTime { get => this._deletedTime; }

        /// <summary>Backing field for <see cref="Encryption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryption _encryption;

        /// <summary>The storage encryption setting</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryption Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryption()); }

        /// <summary>Encryption keySource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource? EncryptionKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).KeySource; }

        /// <summary>Backing field for <see cref="FaultDomain" /> property.</summary>
        private string _faultDomain;

        /// <summary>The fault domain for the storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string FaultDomain { get => this._faultDomain; }

        /// <summary>Backing field for <see cref="HealthState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountHealthState? _healthState;

        /// <summary>The internal health state for storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountHealthState? HealthState { get => this._healthState; }

        /// <summary>Internal Acessors for AccessTier</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountAccessTier? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.AccessTier { get => this._accessTier; set { {_accessTier = value;} } }

        /// <summary>Internal Acessors for AccountId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.AccountId { get => this._accountId; set { {_accountId = value;} } }

        /// <summary>Internal Acessors for AccountType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountType? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.AccountType { get => this._accountType; set { {_accountType = value;} } }

        /// <summary>Internal Acessors for BlobEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.BlobEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).BlobEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).BlobEnabled = value; }

        /// <summary>Internal Acessors for BlobLastEnabledTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.BlobLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).BlobLastEnabledTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).BlobLastEnabledTime = value; }

        /// <summary>Internal Acessors for CreationTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.CreationTime { get => this._creationTime; set { {_creationTime = value;} } }

        /// <summary>Internal Acessors for DeletedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.DeletedTime { get => this._deletedTime; set { {_deletedTime = value;} } }

        /// <summary>Internal Acessors for Encryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryption Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryption()); set { {_encryption = value;} } }

        /// <summary>Internal Acessors for EncryptionKeySource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.EncryptionKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).KeySource; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).KeySource = value; }

        /// <summary>Internal Acessors for EncryptionService</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.EncryptionService { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).Service; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).Service = value; }

        /// <summary>Internal Acessors for FaultDomain</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.FaultDomain { get => this._faultDomain; set { {_faultDomain = value;} } }

        /// <summary>Internal Acessors for HealthState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountHealthState? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.HealthState { get => this._healthState; set { {_healthState = value;} } }

        /// <summary>Internal Acessors for PrimaryEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpoints Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.PrimaryEndpoint { get => (this._primaryEndpoint = this._primaryEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccountPropertiesPrimaryEndpoints()); set { {_primaryEndpoint = value;} } }

        /// <summary>Internal Acessors for PrimaryLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.PrimaryLocation { get => this._primaryLocation; set { {_primaryLocation = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountState? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for QueueEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.QueueEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).QueueEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).QueueEnabled = value; }

        /// <summary>Internal Acessors for QueueLastEnabledTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.QueueLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).QueueLastEnabledTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).QueueLastEnabledTime = value; }

        /// <summary>Internal Acessors for ServiceBlob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.ServiceBlob { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).ServiceBlob; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).ServiceBlob = value; }

        /// <summary>Internal Acessors for ServiceQueue</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.ServiceQueue { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).ServiceQueue; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).ServiceQueue = value; }

        /// <summary>Internal Acessors for ServiceTable</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.ServiceTable { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).ServiceTable; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).ServiceTable = value; }

        /// <summary>Internal Acessors for StatusOfPrimary</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.LocationStatus? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.StatusOfPrimary { get => this._statusOfPrimary; set { {_statusOfPrimary = value;} } }

        /// <summary>Internal Acessors for SupportsHttpsTrafficOnly</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.SupportsHttpsTrafficOnly { get => this._supportsHttpsTrafficOnly; set { {_supportsHttpsTrafficOnly = value;} } }

        /// <summary>Internal Acessors for TableEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.TableEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).TableEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).TableEnabled = value; }

        /// <summary>Internal Acessors for TableLastEnabledTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.TableLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).TableLastEnabledTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).TableLastEnabledTime = value; }

        /// <summary>Internal Acessors for TenantResourceGroupName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.TenantResourceGroupName { get => this._tenantResourceGroupName; set { {_tenantResourceGroupName = value;} } }

        /// <summary>Internal Acessors for TenantStorageAccountName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.TenantStorageAccountName { get => this._tenantStorageAccountName; set { {_tenantStorageAccountName = value;} } }

        /// <summary>Internal Acessors for TenantSubscriptionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.TenantSubscriptionId { get => this._tenantSubscriptionId; set { {_tenantSubscriptionId = value;} } }

        /// <summary>Internal Acessors for TenantViewId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesInternal.TenantViewId { get => this._tenantViewId; set { {_tenantViewId = value;} } }

        /// <summary>Backing field for <see cref="PrimaryEndpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpoints _primaryEndpoint;

        /// <summary>
        /// The URLs that are used to perform a retrieval of a public BLOB, queue, or table object.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpoints PrimaryEndpoint { get => (this._primaryEndpoint = this._primaryEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageAccountPropertiesPrimaryEndpoints()); }

        /// <summary>Backing field for <see cref="PrimaryLocation" /> property.</summary>
        private string _primaryLocation;

        /// <summary>The primary location for the storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string PrimaryLocation { get => this._primaryLocation; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountState? _provisioningState;

        /// <summary>The provisioning state of storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.StorageAccountState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public bool? QueueEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).QueueEnabled; }

        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string QueueLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).QueueLastEnabledTime; }

        /// <summary>Backing field for <see cref="StatusOfPrimary" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.LocationStatus? _statusOfPrimary;

        /// <summary>The status of primary location of storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.LocationStatus? StatusOfPrimary { get => this._statusOfPrimary; }

        /// <summary>Backing field for <see cref="SupportsHttpsTrafficOnly" /> property.</summary>
        private bool? _supportsHttpsTrafficOnly;

        /// <summary>Storage account supports https traffic only or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public bool? SupportsHttpsTrafficOnly { get => this._supportsHttpsTrafficOnly; }

        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public bool? TableEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).TableEnabled; }

        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string TableLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal)Encryption).TableLastEnabledTime; }

        /// <summary>Backing field for <see cref="TenantResourceGroupName" /> property.</summary>
        private string _tenantResourceGroupName;

        /// <summary>The name of resource group under which the storage account locates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string TenantResourceGroupName { get => this._tenantResourceGroupName; }

        /// <summary>Backing field for <see cref="TenantStorageAccountName" /> property.</summary>
        private string _tenantStorageAccountName;

        /// <summary>Storage account name from tenant view.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string TenantStorageAccountName { get => this._tenantStorageAccountName; }

        /// <summary>Backing field for <see cref="TenantSubscriptionId" /> property.</summary>
        private string _tenantSubscriptionId;

        /// <summary>Subscription ID of the subscription under which the storage account locates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string TenantSubscriptionId { get => this._tenantSubscriptionId; }

        /// <summary>Backing field for <see cref="TenantViewId" /> property.</summary>
        private string _tenantViewId;

        /// <summary>Resource URI of storage account from tenant view.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string TenantViewId { get => this._tenantViewId; }

        /// <summary>Creates an new <see cref="StorageAccountProperties" /> instance.</summary>
        public StorageAccountProperties()
        {

        }
    }
    /// Properties of a storage account.
    public partial interface IStorageAccountProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
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
        /// <summary>
        /// The URLs that are used to perform a retrieval of a public BLOB, queue, or table object.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The URLs that are used to perform a retrieval of a public BLOB, queue, or table object.",
        SerializedName = @"primaryEndpoints",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpoints) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpoints PrimaryEndpoint { get;  }
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
    /// Properties of a storage account.
    internal partial interface IStorageAccountPropertiesInternal

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
        /// <summary>
        /// The URLs that are used to perform a retrieval of a public BLOB, queue, or table object.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpoints PrimaryEndpoint { get; set; }
        /// <summary>The primary location for the storage account.</summary>
        string PrimaryLocation { get; set; }
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