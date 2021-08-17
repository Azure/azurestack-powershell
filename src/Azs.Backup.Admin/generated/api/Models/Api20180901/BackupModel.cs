namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>Properties for a backup.</summary>
    public partial class BackupModel :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModel,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal
    {

        /// <summary>Backing field for <see cref="BackupInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo _backupInfo;

        /// <summary>Holds information for a backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo BackupInfo { get => (this._backupInfo = this._backupInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.BackupInfo()); set => this._backupInfo = value; }

        /// <summary>Version of the backup data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string BackupInfoBackupDataVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).BackupDataVersion; }

        /// <summary>Creation time of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? BackupInfoCreatedDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).CreatedDateTime; }

        /// <summary>Deployment Id of the stamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string BackupInfoDeploymentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).DeploymentId; }

        /// <summary>The thumbprint of the certificate used to encrypt the backup encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string BackupInfoEncryptionCertThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).EncryptionCertThumbprint; }

        /// <summary>True if the backup can be used for cloud recovery scenario.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public bool? BackupInfoIsCloudRecoveryReady { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).IsCloudRecoveryReady; }

        /// <summary>OEM version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string BackupInfoOemVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).OemVersion; }

        /// <summary>Backup status for each role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus[] BackupInfoRoleStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).RoleStatus; }

        /// <summary>Azure Stack stamp version of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string BackupInfoStampVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).StampVersion; }

        /// <summary>Current status of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? BackupInfoStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).Status; }

        /// <summary>Duration to create the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string BackupInfoTimeTakenToCreate { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).TimeTakenToCreate; }

        /// <summary>Internal Acessors for BackupInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal.BackupInfo { get => (this._backupInfo = this._backupInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.BackupInfo()); set { {_backupInfo = value;} } }

        /// <summary>Internal Acessors for BackupInfoBackupDataVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal.BackupInfoBackupDataVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).BackupDataVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).BackupDataVersion = value; }

        /// <summary>Internal Acessors for BackupInfoCreatedDateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal.BackupInfoCreatedDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).CreatedDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).CreatedDateTime = value; }

        /// <summary>Internal Acessors for BackupInfoDeploymentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal.BackupInfoDeploymentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).DeploymentId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).DeploymentId = value; }

        /// <summary>Internal Acessors for BackupInfoEncryptionCertThumbprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal.BackupInfoEncryptionCertThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).EncryptionCertThumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).EncryptionCertThumbprint = value; }

        /// <summary>Internal Acessors for BackupInfoIsCloudRecoveryReady</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal.BackupInfoIsCloudRecoveryReady { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).IsCloudRecoveryReady; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).IsCloudRecoveryReady = value; }

        /// <summary>Internal Acessors for BackupInfoOemVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal.BackupInfoOemVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).OemVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).OemVersion = value; }

        /// <summary>Internal Acessors for BackupInfoRoleStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus[] Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal.BackupInfoRoleStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).RoleStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).RoleStatus = value; }

        /// <summary>Internal Acessors for BackupInfoStampVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal.BackupInfoStampVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).StampVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).StampVersion = value; }

        /// <summary>Internal Acessors for BackupInfoStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal.BackupInfoStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).Status = value; }

        /// <summary>Internal Acessors for BackupInfoTimeTakenToCreate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal.BackupInfoTimeTakenToCreate { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).TimeTakenToCreate; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfoInternal)BackupInfo).TimeTakenToCreate = value; }

        /// <summary>Creates an new <see cref="BackupModel" /> instance.</summary>
        public BackupModel()
        {

        }
    }
    /// Properties for a backup.
    public partial interface IBackupModel :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Version of the backup data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Version of the backup data.",
        SerializedName = @"backupDataVersion",
        PossibleTypes = new [] { typeof(string) })]
        string BackupInfoBackupDataVersion { get;  }
        /// <summary>Creation time of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Creation time of the backup.",
        SerializedName = @"createdDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? BackupInfoCreatedDateTime { get;  }
        /// <summary>Deployment Id of the stamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Deployment Id of the stamp.",
        SerializedName = @"deploymentID",
        PossibleTypes = new [] { typeof(string) })]
        string BackupInfoDeploymentId { get;  }
        /// <summary>The thumbprint of the certificate used to encrypt the backup encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The thumbprint of the certificate used to encrypt the backup encryption key.",
        SerializedName = @"encryptionCertThumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string BackupInfoEncryptionCertThumbprint { get;  }
        /// <summary>True if the backup can be used for cloud recovery scenario.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"True if the backup can be used for cloud recovery scenario.",
        SerializedName = @"isCloudRecoveryReady",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BackupInfoIsCloudRecoveryReady { get;  }
        /// <summary>OEM version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"OEM version.",
        SerializedName = @"oemVersion",
        PossibleTypes = new [] { typeof(string) })]
        string BackupInfoOemVersion { get;  }
        /// <summary>Backup status for each role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Backup status for each role.",
        SerializedName = @"roleStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus[] BackupInfoRoleStatus { get;  }
        /// <summary>Azure Stack stamp version of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure Stack stamp version of the backup.",
        SerializedName = @"stampVersion",
        PossibleTypes = new [] { typeof(string) })]
        string BackupInfoStampVersion { get;  }
        /// <summary>Current status of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current status of the backup.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? BackupInfoStatus { get;  }
        /// <summary>Duration to create the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Duration to create the backup.",
        SerializedName = @"timeTakenToCreate",
        PossibleTypes = new [] { typeof(string) })]
        string BackupInfoTimeTakenToCreate { get;  }

    }
    /// Properties for a backup.
    internal partial interface IBackupModelInternal

    {
        /// <summary>Holds information for a backup.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo BackupInfo { get; set; }
        /// <summary>Version of the backup data.</summary>
        string BackupInfoBackupDataVersion { get; set; }
        /// <summary>Creation time of the backup.</summary>
        global::System.DateTime? BackupInfoCreatedDateTime { get; set; }
        /// <summary>Deployment Id of the stamp.</summary>
        string BackupInfoDeploymentId { get; set; }
        /// <summary>The thumbprint of the certificate used to encrypt the backup encryption key.</summary>
        string BackupInfoEncryptionCertThumbprint { get; set; }
        /// <summary>True if the backup can be used for cloud recovery scenario.</summary>
        bool? BackupInfoIsCloudRecoveryReady { get; set; }
        /// <summary>OEM version.</summary>
        string BackupInfoOemVersion { get; set; }
        /// <summary>Backup status for each role.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus[] BackupInfoRoleStatus { get; set; }
        /// <summary>Azure Stack stamp version of the backup.</summary>
        string BackupInfoStampVersion { get; set; }
        /// <summary>Current status of the backup.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? BackupInfoStatus { get; set; }
        /// <summary>Duration to create the backup.</summary>
        string BackupInfoTimeTakenToCreate { get; set; }

    }
}