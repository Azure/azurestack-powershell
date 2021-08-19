namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Disk migration job properties.</summary>
    public partial class DiskMigrationJobProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CreationTime" /> property.</summary>
        private global::System.DateTime? _creationTime;

        /// <summary>The job creation time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? CreationTime { get => this._creationTime; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime? _endTime;

        /// <summary>The job end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTime { get => this._endTime; }

        /// <summary>Internal Acessors for CreationTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal.CreationTime { get => this._creationTime; set { {_creationTime = value;} } }

        /// <summary>Internal Acessors for EndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal.EndTime { get => this._endTime; set { {_endTime = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal.StartTime { get => this._startTime; set { {_startTime = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for Subtask</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTask[] Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal.Subtask { get => this._subtask; set { {_subtask = value;} } }

        /// <summary>Internal Acessors for TargetShare</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal.TargetShare { get => this._targetShare; set { {_targetShare = value;} } }

        /// <summary>Backing field for <see cref="MigrationId" /> property.</summary>
        private string _migrationId;

        /// <summary>The disk migration id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string MigrationId { get => this._migrationId; set => this._migrationId = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>The job start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus? _status;

        /// <summary>The current status of disk migration job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus? Status { get => this._status; }

        /// <summary>Backing field for <see cref="Subtask" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTask[] _subtask;

        /// <summary>The list of child migration tasks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTask[] Subtask { get => this._subtask; }

        /// <summary>Backing field for <see cref="TargetShare" /> property.</summary>
        private string _targetShare;

        /// <summary>The target share of migration job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string TargetShare { get => this._targetShare; }

        /// <summary>Creates an new <see cref="DiskMigrationJobProperties" /> instance.</summary>
        public DiskMigrationJobProperties()
        {

        }
    }
    /// Disk migration job properties.
    public partial interface IDiskMigrationJobProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The job creation time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The job creation time.",
        SerializedName = @"creationTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreationTime { get;  }
        /// <summary>The job end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The job end time.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get;  }
        /// <summary>The disk migration id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk migration id.",
        SerializedName = @"migrationId",
        PossibleTypes = new [] { typeof(string) })]
        string MigrationId { get; set; }
        /// <summary>The job start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The job start time.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get;  }
        /// <summary>The current status of disk migration job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The current status of disk migration job.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus? Status { get;  }
        /// <summary>The list of child migration tasks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of child migration tasks.",
        SerializedName = @"subtasks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTask) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTask[] Subtask { get;  }
        /// <summary>The target share of migration job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The target share of migration job.",
        SerializedName = @"targetShare",
        PossibleTypes = new [] { typeof(string) })]
        string TargetShare { get;  }

    }
    /// Disk migration job properties.
    internal partial interface IDiskMigrationJobPropertiesInternal

    {
        /// <summary>The job creation time.</summary>
        global::System.DateTime? CreationTime { get; set; }
        /// <summary>The job end time.</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>The disk migration id.</summary>
        string MigrationId { get; set; }
        /// <summary>The job start time.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>The current status of disk migration job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus? Status { get; set; }
        /// <summary>The list of child migration tasks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTask[] Subtask { get; set; }
        /// <summary>The target share of migration job.</summary>
        string TargetShare { get; set; }

    }
}