namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Disk migration child task properties.</summary>
    public partial class MigrationSubTaskProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DiskId" /> property.</summary>
        private string _diskId;

        /// <summary>The id of disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string DiskId { get => this._diskId; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime? _endTime;

        /// <summary>The task end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTime { get => this._endTime; }

        /// <summary>Internal Acessors for DiskId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal.DiskId { get => this._diskId; set { {_diskId = value;} } }

        /// <summary>Internal Acessors for EndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal.EndTime { get => this._endTime; set { {_endTime = value;} } }

        /// <summary>Internal Acessors for MigrationSubtaskStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal.MigrationSubtaskStatus { get => this._migrationSubtaskStatus; set { {_migrationSubtaskStatus = value;} } }

        /// <summary>Internal Acessors for Reason</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal.Reason { get => this._reason; set { {_reason = value;} } }

        /// <summary>Internal Acessors for SourceShare</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal.SourceShare { get => this._sourceShare; set { {_sourceShare = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal.StartTime { get => this._startTime; set { {_startTime = value;} } }

        /// <summary>Internal Acessors for TargetDiskStateForMigration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal.TargetDiskStateForMigration { get => this._targetDiskStateForMigration; set { {_targetDiskStateForMigration = value;} } }

        /// <summary>Internal Acessors for TargetShare</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal.TargetShare { get => this._targetShare; set { {_targetShare = value;} } }

        /// <summary>Backing field for <see cref="MigrationSubtaskStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus? _migrationSubtaskStatus;

        /// <summary>The disk migration child task status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus? MigrationSubtaskStatus { get => this._migrationSubtaskStatus; }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private string _reason;

        /// <summary>The reason of task failure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string Reason { get => this._reason; }

        /// <summary>Backing field for <see cref="SourceShare" /> property.</summary>
        private string _sourceShare;

        /// <summary>The source share of migration task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string SourceShare { get => this._sourceShare; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>The task start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; }

        /// <summary>Backing field for <see cref="TargetDiskStateForMigration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState? _targetDiskStateForMigration;

        /// <summary>The disk status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState? TargetDiskStateForMigration { get => this._targetDiskStateForMigration; }

        /// <summary>Backing field for <see cref="TargetShare" /> property.</summary>
        private string _targetShare;

        /// <summary>The target share of migration task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string TargetShare { get => this._targetShare; }

        /// <summary>Creates an new <see cref="MigrationSubTaskProperties" /> instance.</summary>
        public MigrationSubTaskProperties()
        {

        }
    }
    /// Disk migration child task properties.
    public partial interface IMigrationSubTaskProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The id of disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The id of disk.",
        SerializedName = @"diskId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskId { get;  }
        /// <summary>The task end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The task end time.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get;  }
        /// <summary>The disk migration child task status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk migration child task status.",
        SerializedName = @"migrationSubtaskStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus? MigrationSubtaskStatus { get;  }
        /// <summary>The reason of task failure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The reason of task failure.",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        string Reason { get;  }
        /// <summary>The source share of migration task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The source share of migration task.",
        SerializedName = @"sourceShare",
        PossibleTypes = new [] { typeof(string) })]
        string SourceShare { get;  }
        /// <summary>The task start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The task start time.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get;  }
        /// <summary>The disk status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk status.",
        SerializedName = @"targetDiskStateForMigration",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState? TargetDiskStateForMigration { get;  }
        /// <summary>The target share of migration task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The target share of migration task.",
        SerializedName = @"targetShare",
        PossibleTypes = new [] { typeof(string) })]
        string TargetShare { get;  }

    }
    /// Disk migration child task properties.
    internal partial interface IMigrationSubTaskPropertiesInternal

    {
        /// <summary>The id of disk.</summary>
        string DiskId { get; set; }
        /// <summary>The task end time.</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>The disk migration child task status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus? MigrationSubtaskStatus { get; set; }
        /// <summary>The reason of task failure.</summary>
        string Reason { get; set; }
        /// <summary>The source share of migration task.</summary>
        string SourceShare { get; set; }
        /// <summary>The task start time.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>The disk status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState? TargetDiskStateForMigration { get; set; }
        /// <summary>The target share of migration task.</summary>
        string TargetShare { get; set; }

    }
}