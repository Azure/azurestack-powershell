namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>Properties of a backup location.</summary>
    public partial class BackupLocationModel :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModel,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal
    {

        /// <summary>Backing field for <see cref="ExternalStoreDefault" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStore _externalStoreDefault;

        /// <summary>Information about an external storage location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStore ExternalStoreDefault { get => (this._externalStoreDefault = this._externalStoreDefault ?? new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.ExternalStore()); set => this._externalStoreDefault = value; }

        /// <summary>Free space at the backup location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string ExternalStoreDefaultAvailableCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).AvailableCapacity; }

        /// <summary>The interval, in hours, for the frequency that the scheduler takes a backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public int? ExternalStoreDefaultBackupFrequencyInHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).BackupFrequencyInHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).BackupFrequencyInHour = value ?? default(int); }

        /// <summary>The retention period, in days, for backs in the storage location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public int? ExternalStoreDefaultBackupRetentionPeriodInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).BackupRetentionPeriodInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).BackupRetentionPeriodInDay = value ?? default(int); }

        /// <summary>The base64 raw data for the backup encryption certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string ExternalStoreDefaultEncryptionCertBase64 { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).EncryptionCertBase64; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).EncryptionCertBase64 = value ?? null; }

        /// <summary>The thumbprint of the encryption certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string ExternalStoreDefaultEncryptionCertThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).EncryptionCertThumbprint; }

        /// <summary>True if the backup scheduler is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public bool? ExternalStoreDefaultIsBackupSchedulerEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).IsBackupSchedulerEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).IsBackupSchedulerEnabled = value ?? default(bool); }

        /// <summary>Time of backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExternalStoreDefaultLastBackupTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).LastBackupTime; }

        /// <summary>The scheduled time of the next backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExternalStoreDefaultNextBackupTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).NextBackupTime; }

        /// <summary>Password to access the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string ExternalStoreDefaultPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).Password; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).Password = value ?? null; }

        /// <summary>Path to the update location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string ExternalStoreDefaultPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).Path; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).Path = value ?? null; }

        /// <summary>Username to access the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string ExternalStoreDefaultUserName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).UserName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).UserName = value ?? null; }

        /// <summary>Internal Acessors for ExternalStoreDefault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStore Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal.ExternalStoreDefault { get => (this._externalStoreDefault = this._externalStoreDefault ?? new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.ExternalStore()); set { {_externalStoreDefault = value;} } }

        /// <summary>Internal Acessors for ExternalStoreDefaultAvailableCapacity</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal.ExternalStoreDefaultAvailableCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).AvailableCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).AvailableCapacity = value; }

        /// <summary>Internal Acessors for ExternalStoreDefaultEncryptionCertThumbprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal.ExternalStoreDefaultEncryptionCertThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).EncryptionCertThumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).EncryptionCertThumbprint = value; }

        /// <summary>Internal Acessors for ExternalStoreDefaultLastBackupTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal.ExternalStoreDefaultLastBackupTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).LastBackupTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).LastBackupTime = value; }

        /// <summary>Internal Acessors for ExternalStoreDefaultNextBackupTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupLocationModelInternal.ExternalStoreDefaultNextBackupTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).NextBackupTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal)ExternalStoreDefault).NextBackupTime = value; }

        /// <summary>Creates an new <see cref="BackupLocationModel" /> instance.</summary>
        public BackupLocationModel()
        {

        }
    }
    /// Properties of a backup location.
    public partial interface IBackupLocationModel :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Free space at the backup location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Free space at the backup location.",
        SerializedName = @"availableCapacity",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalStoreDefaultAvailableCapacity { get;  }
        /// <summary>The interval, in hours, for the frequency that the scheduler takes a backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The interval, in hours, for the frequency that the scheduler takes a backup.",
        SerializedName = @"backupFrequencyInHours",
        PossibleTypes = new [] { typeof(int) })]
        int? ExternalStoreDefaultBackupFrequencyInHour { get; set; }
        /// <summary>The retention period, in days, for backs in the storage location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The retention period, in days, for backs in the storage location.",
        SerializedName = @"backupRetentionPeriodInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? ExternalStoreDefaultBackupRetentionPeriodInDay { get; set; }
        /// <summary>The base64 raw data for the backup encryption certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The base64 raw data for the backup encryption certificate.",
        SerializedName = @"encryptionCertBase64",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalStoreDefaultEncryptionCertBase64 { get; set; }
        /// <summary>The thumbprint of the encryption certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The thumbprint of the encryption certificate.",
        SerializedName = @"encryptionCertThumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalStoreDefaultEncryptionCertThumbprint { get;  }
        /// <summary>True if the backup scheduler is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if the backup scheduler is enabled.",
        SerializedName = @"isBackupSchedulerEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ExternalStoreDefaultIsBackupSchedulerEnabled { get; set; }
        /// <summary>Time of backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time of backup.",
        SerializedName = @"lastBackupTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExternalStoreDefaultLastBackupTime { get;  }
        /// <summary>The scheduled time of the next backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The scheduled time of the next backup.",
        SerializedName = @"nextBackupTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExternalStoreDefaultNextBackupTime { get;  }
        /// <summary>Password to access the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Password to access the location.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalStoreDefaultPassword { get; set; }
        /// <summary>Path to the update location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path to the update location",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalStoreDefaultPath { get; set; }
        /// <summary>Username to access the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Username to access the location.",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalStoreDefaultUserName { get; set; }

    }
    /// Properties of a backup location.
    internal partial interface IBackupLocationModelInternal

    {
        /// <summary>Information about an external storage location.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStore ExternalStoreDefault { get; set; }
        /// <summary>Free space at the backup location.</summary>
        string ExternalStoreDefaultAvailableCapacity { get; set; }
        /// <summary>The interval, in hours, for the frequency that the scheduler takes a backup.</summary>
        int? ExternalStoreDefaultBackupFrequencyInHour { get; set; }
        /// <summary>The retention period, in days, for backs in the storage location.</summary>
        int? ExternalStoreDefaultBackupRetentionPeriodInDay { get; set; }
        /// <summary>The base64 raw data for the backup encryption certificate.</summary>
        string ExternalStoreDefaultEncryptionCertBase64 { get; set; }
        /// <summary>The thumbprint of the encryption certificate.</summary>
        string ExternalStoreDefaultEncryptionCertThumbprint { get; set; }
        /// <summary>True if the backup scheduler is enabled.</summary>
        bool? ExternalStoreDefaultIsBackupSchedulerEnabled { get; set; }
        /// <summary>Time of backup.</summary>
        global::System.DateTime? ExternalStoreDefaultLastBackupTime { get; set; }
        /// <summary>The scheduled time of the next backup.</summary>
        global::System.DateTime? ExternalStoreDefaultNextBackupTime { get; set; }
        /// <summary>Password to access the location.</summary>
        string ExternalStoreDefaultPassword { get; set; }
        /// <summary>Path to the update location</summary>
        string ExternalStoreDefaultPath { get; set; }
        /// <summary>Username to access the location.</summary>
        string ExternalStoreDefaultUserName { get; set; }

    }
}