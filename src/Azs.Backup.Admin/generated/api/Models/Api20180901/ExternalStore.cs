namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>Information about an external storage location.</summary>
    public partial class ExternalStore :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStore,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal
    {

        /// <summary>Backing field for <see cref="AvailableCapacity" /> property.</summary>
        private string _availableCapacity;

        /// <summary>Free space at the backup location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string AvailableCapacity { get => this._availableCapacity; }

        /// <summary>Backing field for <see cref="BackupFrequencyInHour" /> property.</summary>
        private int? _backupFrequencyInHour;

        /// <summary>The interval, in hours, for the frequency that the scheduler takes a backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public int? BackupFrequencyInHour { get => this._backupFrequencyInHour; set => this._backupFrequencyInHour = value; }

        /// <summary>Backing field for <see cref="BackupRetentionPeriodInDay" /> property.</summary>
        private int? _backupRetentionPeriodInDay;

        /// <summary>The retention period, in days, for backs in the storage location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public int? BackupRetentionPeriodInDay { get => this._backupRetentionPeriodInDay; set => this._backupRetentionPeriodInDay = value; }

        /// <summary>Backing field for <see cref="EncryptionCertBase64" /> property.</summary>
        private string _encryptionCertBase64;

        /// <summary>The base64 raw data for the backup encryption certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string EncryptionCertBase64 { get => this._encryptionCertBase64; set => this._encryptionCertBase64 = value; }

        /// <summary>Backing field for <see cref="EncryptionCertThumbprint" /> property.</summary>
        private string _encryptionCertThumbprint;

        /// <summary>The thumbprint of the encryption certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string EncryptionCertThumbprint { get => this._encryptionCertThumbprint; }

        /// <summary>Backing field for <see cref="IsBackupSchedulerEnabled" /> property.</summary>
        private bool? _isBackupSchedulerEnabled;

        /// <summary>True if the backup scheduler is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public bool? IsBackupSchedulerEnabled { get => this._isBackupSchedulerEnabled; set => this._isBackupSchedulerEnabled = value; }

        /// <summary>Backing field for <see cref="LastBackupTime" /> property.</summary>
        private global::System.DateTime? _lastBackupTime;

        /// <summary>Time of backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? LastBackupTime { get => this._lastBackupTime; }

        /// <summary>Internal Acessors for AvailableCapacity</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal.AvailableCapacity { get => this._availableCapacity; set { {_availableCapacity = value;} } }

        /// <summary>Internal Acessors for EncryptionCertThumbprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal.EncryptionCertThumbprint { get => this._encryptionCertThumbprint; set { {_encryptionCertThumbprint = value;} } }

        /// <summary>Internal Acessors for LastBackupTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal.LastBackupTime { get => this._lastBackupTime; set { {_lastBackupTime = value;} } }

        /// <summary>Internal Acessors for NextBackupTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IExternalStoreInternal.NextBackupTime { get => this._nextBackupTime; set { {_nextBackupTime = value;} } }

        /// <summary>Backing field for <see cref="NextBackupTime" /> property.</summary>
        private global::System.DateTime? _nextBackupTime;

        /// <summary>The scheduled time of the next backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? NextBackupTime { get => this._nextBackupTime; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>Password to access the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        /// <summary>Path to the update location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Backing field for <see cref="UserName" /> property.</summary>
        private string _userName;

        /// <summary>Username to access the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string UserName { get => this._userName; set => this._userName = value; }

        /// <summary>Creates an new <see cref="ExternalStore" /> instance.</summary>
        public ExternalStore()
        {

        }
    }
    /// Information about an external storage location.
    public partial interface IExternalStore :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IJsonSerializable
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
        int? BackupFrequencyInHour { get; set; }
        /// <summary>The retention period, in days, for backs in the storage location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The retention period, in days, for backs in the storage location.",
        SerializedName = @"backupRetentionPeriodInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupRetentionPeriodInDay { get; set; }
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
    /// Information about an external storage location.
    internal partial interface IExternalStoreInternal

    {
        /// <summary>Free space at the backup location.</summary>
        string AvailableCapacity { get; set; }
        /// <summary>The interval, in hours, for the frequency that the scheduler takes a backup.</summary>
        int? BackupFrequencyInHour { get; set; }
        /// <summary>The retention period, in days, for backs in the storage location.</summary>
        int? BackupRetentionPeriodInDay { get; set; }
        /// <summary>The base64 raw data for the backup encryption certificate.</summary>
        string EncryptionCertBase64 { get; set; }
        /// <summary>The thumbprint of the encryption certificate.</summary>
        string EncryptionCertThumbprint { get; set; }
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
        /// <summary>Username to access the location.</summary>
        string UserName { get; set; }

    }
}