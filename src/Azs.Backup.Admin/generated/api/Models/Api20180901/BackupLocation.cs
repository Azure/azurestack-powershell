namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>Information about the backup location.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.DoNotFormat]
    public partial class BackupLocation :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocation,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.Resource();

        /// <summary>Free space at the backup location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string AvailableCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultAvailableCapacity; }

        /// <summary>The interval, in hours, for the frequency that the scheduler takes a backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public int? BackupFrequencyInHours { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultBackupFrequencyInHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultBackupFrequencyInHour = value ?? default(int); }

        /// <summary>The retention period, in days, for backs in the storage location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public int? BackupRetentionPeriodInDays { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultBackupRetentionPeriodInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultBackupRetentionPeriodInDay = value ?? default(int); }

        /// <summary>The base64 raw data for the backup encryption certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string EncryptionCertBase64 { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultEncryptionCertBase64; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultEncryptionCertBase64 = value ?? null; }

        /// <summary>The thumbprint of the encryption certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string EncryptionCertThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultEncryptionCertThumbprint; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Id; }

        /// <summary>True if the backup scheduler is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public bool? IsBackupSchedulerEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultIsBackupSchedulerEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultIsBackupSchedulerEnabled = value ?? default(bool); }

        /// <summary>Time of backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastBackupTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultLastBackupTime; }

        /// <summary>Location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for AvailableCapacity</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationInternal.AvailableCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultAvailableCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultAvailableCapacity = value; }

        /// <summary>Internal Acessors for EncryptionCertThumbprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationInternal.EncryptionCertThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultEncryptionCertThumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultEncryptionCertThumbprint = value; }

        /// <summary>Internal Acessors for ExternalStoreDefault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStore Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationInternal.ExternalStoreDefault { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefault; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefault = value; }

        /// <summary>Internal Acessors for LastBackupTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationInternal.LastBackupTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultLastBackupTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultLastBackupTime = value; }

        /// <summary>Internal Acessors for NextBackupTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationInternal.NextBackupTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultNextBackupTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultNextBackupTime = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModel Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.BackupLocationModel()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Type = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Name; }

        /// <summary>The scheduled time of the next backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? NextBackupTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultNextBackupTime; }

        /// <summary>Password to access the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string Password { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultPassword = value ?? null; }

        /// <summary>Path to the update location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string Path { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultPath = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModel _property;

        /// <summary>Properties of a backup location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.BackupLocationModel()); set => this._property = value; }

        /// <summary>List of key value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Type; }

        /// <summary>Username to access the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string UserName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultUserName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal)Property).ExternalStoreDefaultUserName = value ?? null; }

        /// <summary>Creates an new <see cref="BackupLocation" /> instance.</summary>
        public BackupLocation()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Information about the backup location.
    public partial interface IBackupLocation :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResource
    {
        /// <summary>Free space at the backup location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Free space at the backup location.",
        SerializedName = @"availableCapacity",
        PossibleTypes = new [] { typeof(string) })]
        string AvailableCapacity { get;  }
        /// <summary>The interval, in hours, for the frequency that the scheduler takes a backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The interval, in hours, for the frequency that the scheduler takes a backup.",
        SerializedName = @"backupFrequencyInHours",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupFrequencyInHours { get; set; }
        /// <summary>The retention period, in days, for backs in the storage location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The retention period, in days, for backs in the storage location.",
        SerializedName = @"backupRetentionPeriodInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupRetentionPeriodInDays { get; set; }
        /// <summary>The base64 raw data for the backup encryption certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The base64 raw data for the backup encryption certificate.",
        SerializedName = @"encryptionCertBase64",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionCertBase64 { get; set; }
        /// <summary>The thumbprint of the encryption certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The thumbprint of the encryption certificate.",
        SerializedName = @"encryptionCertThumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionCertThumbprint { get;  }
        /// <summary>True if the backup scheduler is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if the backup scheduler is enabled.",
        SerializedName = @"isBackupSchedulerEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsBackupSchedulerEnabled { get; set; }
        /// <summary>Time of backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time of backup.",
        SerializedName = @"lastBackupTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastBackupTime { get;  }
        /// <summary>The scheduled time of the next backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The scheduled time of the next backup.",
        SerializedName = @"nextBackupTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? NextBackupTime { get;  }
        /// <summary>Password to access the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Password to access the location.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }
        /// <summary>Path to the update location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path to the update location",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get; set; }
        /// <summary>Username to access the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Username to access the location.",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }

    }
    /// Information about the backup location.
    internal partial interface IBackupLocationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal
    {
        /// <summary>Free space at the backup location.</summary>
        string AvailableCapacity { get; set; }
        /// <summary>The interval, in hours, for the frequency that the scheduler takes a backup.</summary>
        int? BackupFrequencyInHours { get; set; }
        /// <summary>The retention period, in days, for backs in the storage location.</summary>
        int? BackupRetentionPeriodInDays { get; set; }
        /// <summary>The base64 raw data for the backup encryption certificate.</summary>
        string EncryptionCertBase64 { get; set; }
        /// <summary>The thumbprint of the encryption certificate.</summary>
        string EncryptionCertThumbprint { get; set; }
        /// <summary>Information about an external storage location.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStore ExternalStoreDefault { get; set; }
        /// <summary>True if the backup scheduler is enabled.</summary>
        bool? IsBackupSchedulerEnabled { get; set; }
        /// <summary>Time of backup.</summary>
        global::System.DateTime? LastBackupTime { get; set; }
        /// <summary>The scheduled time of the next backup.</summary>
        global::System.DateTime? NextBackupTime { get; set; }
        /// <summary>Password to access the location.</summary>
        string Password { get; set; }
        /// <summary>Path to the update location</summary>
        string Path { get; set; }
        /// <summary>Properties of a backup location.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModel Property { get; set; }
        /// <summary>Username to access the location.</summary>
        string UserName { get; set; }

    }
}