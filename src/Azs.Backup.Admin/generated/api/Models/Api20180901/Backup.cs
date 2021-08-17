namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>Information related to a backup.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.DoNotFormat]
    public partial class Backup :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackup,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInternal,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.Resource();

        /// <summary>Version of the backup data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string BackupDataVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoBackupDataVersion; }

        /// <summary>Creation time of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreatedDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoCreatedDateTime; }

        /// <summary>Deployment Id of the stamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string DeploymentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoDeploymentId; }

        /// <summary>The thumbprint of the certificate used to encrypt the backup encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string EncryptionCertThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoEncryptionCertThumbprint; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Id; }

        /// <summary>True if the backup can be used for cloud recovery scenario.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public bool? IsCloudRecoveryReady { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoIsCloudRecoveryReady; }

        /// <summary>Location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for BackupDataVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInternal.BackupDataVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoBackupDataVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoBackupDataVersion = value; }

        /// <summary>Internal Acessors for CreatedDateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInternal.CreatedDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoCreatedDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoCreatedDateTime = value; }

        /// <summary>Internal Acessors for DeploymentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInternal.DeploymentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoDeploymentId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoDeploymentId = value; }

        /// <summary>Internal Acessors for EncryptionCertThumbprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInternal.EncryptionCertThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoEncryptionCertThumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoEncryptionCertThumbprint = value; }

        /// <summary>Internal Acessors for Info</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInternal.Info { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfo = value; }

        /// <summary>Internal Acessors for IsCloudRecoveryReady</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInternal.IsCloudRecoveryReady { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoIsCloudRecoveryReady; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoIsCloudRecoveryReady = value; }

        /// <summary>Internal Acessors for OemVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInternal.OemVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoOemVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoOemVersion = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModel Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.BackupModel()); set { {_property = value;} } }

        /// <summary>Internal Acessors for RoleStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus[] Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInternal.RoleStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoRoleStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoRoleStatus = value; }

        /// <summary>Internal Acessors for StampVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInternal.StampVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoStampVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoStampVersion = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoStatus = value; }

        /// <summary>Internal Acessors for TimeTakenToCreate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInternal.TimeTakenToCreate { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoTimeTakenToCreate; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoTimeTakenToCreate = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Type = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Name; }

        /// <summary>OEM version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string OemVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoOemVersion; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModel _property;

        /// <summary>Properties for a backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.BackupModel()); set => this._property = value; }

        /// <summary>Backup status for each role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus[] RoleStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoRoleStatus; }

        /// <summary>Azure Stack stamp version of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string StampVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoStampVersion; }

        /// <summary>Current status of the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoStatus; }

        /// <summary>List of key value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Duration to create the backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string TimeTakenToCreate { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModelInternal)Property).BackupInfoTimeTakenToCreate; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="Backup" /> instance.</summary>
        public Backup()
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
    /// Information related to a backup.
    public partial interface IBackup :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResource
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
    /// Information related to a backup.
    internal partial interface IBackupInternal :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IResourceInternal
    {
        /// <summary>Version of the backup data.</summary>
        string BackupDataVersion { get; set; }
        /// <summary>Creation time of the backup.</summary>
        global::System.DateTime? CreatedDateTime { get; set; }
        /// <summary>Deployment Id of the stamp.</summary>
        string DeploymentId { get; set; }
        /// <summary>The thumbprint of the certificate used to encrypt the backup encryption key.</summary>
        string EncryptionCertThumbprint { get; set; }
        /// <summary>Holds information for a backup.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupInfo Info { get; set; }
        /// <summary>True if the backup can be used for cloud recovery scenario.</summary>
        bool? IsCloudRecoveryReady { get; set; }
        /// <summary>OEM version.</summary>
        string OemVersion { get; set; }
        /// <summary>Properties for a backup.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IBackupModel Property { get; set; }
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