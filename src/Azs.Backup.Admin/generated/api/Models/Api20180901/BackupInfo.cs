namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>Holds information for a backup.</summary>
    public partial class BackupInfo :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal
    {

        /// <summary>Backing field for <see cref="BackupDataVersion" /> property.</summary>
        private string _backupDataVersion;

        /// <summary>Version of the backup data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string BackupDataVersion { get => this._backupDataVersion; }

        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private global::System.DateTime? _createdDateTime;

        /// <summary>Creation time of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedDateTime { get => this._createdDateTime; }

        /// <summary>Backing field for <see cref="DeploymentId" /> property.</summary>
        private string _deploymentId;

        /// <summary>Deployment Id of the stamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string DeploymentId { get => this._deploymentId; }

        /// <summary>Backing field for <see cref="EncryptionCertThumbprint" /> property.</summary>
        private string _encryptionCertThumbprint;

        /// <summary>The thumbprint of the certificate used to encrypt the backup encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string EncryptionCertThumbprint { get => this._encryptionCertThumbprint; }

        /// <summary>Backing field for <see cref="IsCloudRecoveryReady" /> property.</summary>
        private bool? _isCloudRecoveryReady;

        /// <summary>True if the backup can be used for cloud recovery scenario.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public bool? IsCloudRecoveryReady { get => this._isCloudRecoveryReady; }

        /// <summary>Internal Acessors for BackupDataVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal.BackupDataVersion { get => this._backupDataVersion; set { {_backupDataVersion = value;} } }

        /// <summary>Internal Acessors for CreatedDateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal.CreatedDateTime { get => this._createdDateTime; set { {_createdDateTime = value;} } }

        /// <summary>Internal Acessors for DeploymentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal.DeploymentId { get => this._deploymentId; set { {_deploymentId = value;} } }

        /// <summary>Internal Acessors for EncryptionCertThumbprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal.EncryptionCertThumbprint { get => this._encryptionCertThumbprint; set { {_encryptionCertThumbprint = value;} } }

        /// <summary>Internal Acessors for IsCloudRecoveryReady</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal.IsCloudRecoveryReady { get => this._isCloudRecoveryReady; set { {_isCloudRecoveryReady = value;} } }

        /// <summary>Internal Acessors for OemVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal.OemVersion { get => this._oemVersion; set { {_oemVersion = value;} } }

        /// <summary>Internal Acessors for RoleStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus[] Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal.RoleStatus { get => this._roleStatus; set { {_roleStatus = value;} } }

        /// <summary>Internal Acessors for StampVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal.StampVersion { get => this._stampVersion; set { {_stampVersion = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for TimeTakenToCreate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal.TimeTakenToCreate { get => this._timeTakenToCreate; set { {_timeTakenToCreate = value;} } }

        /// <summary>Backing field for <see cref="OemVersion" /> property.</summary>
        private string _oemVersion;

        /// <summary>OEM version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string OemVersion { get => this._oemVersion; }

        /// <summary>Backing field for <see cref="RoleStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus[] _roleStatus;

        /// <summary>Backup status for each role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus[] RoleStatus { get => this._roleStatus; }

        /// <summary>Backing field for <see cref="StampVersion" /> property.</summary>
        private string _stampVersion;

        /// <summary>Azure Stack stamp version of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string StampVersion { get => this._stampVersion; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? _status;

        /// <summary>Current status of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? Status { get => this._status; }

        /// <summary>Backing field for <see cref="TimeTakenToCreate" /> property.</summary>
        private string _timeTakenToCreate;

        /// <summary>Duration to create the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string TimeTakenToCreate { get => this._timeTakenToCreate; }

        /// <summary>Creates an new <see cref="BackupInfo" /> instance.</summary>
        public BackupInfo()
        {

        }
    }
    /// Holds information for a backup.
    public partial interface IBackupInfo :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Version of the backup data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Version of the backup data.",
        SerializedName = @"backupDataVersion",
        PossibleTypes = new [] { typeof(string) })]
        string BackupDataVersion { get;  }
        /// <summary>Creation time of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Creation time of the backup.",
        SerializedName = @"createdDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedDateTime { get;  }
        /// <summary>Deployment Id of the stamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Deployment Id of the stamp.",
        SerializedName = @"deploymentID",
        PossibleTypes = new [] { typeof(string) })]
        string DeploymentId { get;  }
        /// <summary>The thumbprint of the certificate used to encrypt the backup encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The thumbprint of the certificate used to encrypt the backup encryption key.",
        SerializedName = @"encryptionCertThumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionCertThumbprint { get;  }
        /// <summary>True if the backup can be used for cloud recovery scenario.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"True if the backup can be used for cloud recovery scenario.",
        SerializedName = @"isCloudRecoveryReady",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsCloudRecoveryReady { get;  }
        /// <summary>OEM version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"OEM version.",
        SerializedName = @"oemVersion",
        PossibleTypes = new [] { typeof(string) })]
        string OemVersion { get;  }
        /// <summary>Backup status for each role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Backup status for each role.",
        SerializedName = @"roleStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus[] RoleStatus { get;  }
        /// <summary>Azure Stack stamp version of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure Stack stamp version of the backup.",
        SerializedName = @"stampVersion",
        PossibleTypes = new [] { typeof(string) })]
        string StampVersion { get;  }
        /// <summary>Current status of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current status of the backup.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? Status { get;  }
        /// <summary>Duration to create the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Duration to create the backup.",
        SerializedName = @"timeTakenToCreate",
        PossibleTypes = new [] { typeof(string) })]
        string TimeTakenToCreate { get;  }

    }
    /// Holds information for a backup.
    internal partial interface IBackupInfoInternal

    {
        /// <summary>Version of the backup data.</summary>
        string BackupDataVersion { get; set; }
        /// <summary>Creation time of the backup.</summary>
        global::System.DateTime? CreatedDateTime { get; set; }
        /// <summary>Deployment Id of the stamp.</summary>
        string DeploymentId { get; set; }
        /// <summary>The thumbprint of the certificate used to encrypt the backup encryption key.</summary>
        string EncryptionCertThumbprint { get; set; }
        /// <summary>True if the backup can be used for cloud recovery scenario.</summary>
        bool? IsCloudRecoveryReady { get; set; }
        /// <summary>OEM version.</summary>
        string OemVersion { get; set; }
        /// <summary>Backup status for each role.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus[] RoleStatus { get; set; }
        /// <summary>Azure Stack stamp version of the backup.</summary>
        string StampVersion { get; set; }
        /// <summary>Current status of the backup.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? Status { get; set; }
        /// <summary>Duration to create the backup.</summary>
        string TimeTakenToCreate { get; set; }

    }
}