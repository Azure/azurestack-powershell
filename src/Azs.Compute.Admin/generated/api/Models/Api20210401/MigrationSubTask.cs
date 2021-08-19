namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Disk migration child task.</summary>
    public partial class MigrationSubTask :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTask,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal
    {

        /// <summary>The id of disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string DiskId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).DiskId; }

        /// <summary>The task end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).EndTime; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The id of migration child task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for DiskId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal.DiskId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).DiskId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).DiskId = value; }

        /// <summary>Internal Acessors for EndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal.EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).EndTime = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskProperties Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.MigrationSubTaskProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Reason</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal.Reason { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).Reason; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).Reason = value; }

        /// <summary>Internal Acessors for SourceShare</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal.SourceShare { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).SourceShare; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).SourceShare = value; }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal.StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).StartTime = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).MigrationSubtaskStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).MigrationSubtaskStatus = value; }

        /// <summary>Internal Acessors for TargetDiskStateForMigration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal.TargetDiskStateForMigration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).TargetDiskStateForMigration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).TargetDiskStateForMigration = value; }

        /// <summary>Internal Acessors for TargetShare</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskInternal.TargetShare { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).TargetShare; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).TargetShare = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskProperties _property;

        /// <summary>Disk migration child task properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.MigrationSubTaskProperties()); set => this._property = value; }

        /// <summary>The reason of task failure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string Reason { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).Reason; }

        /// <summary>The source share of migration task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string SourceShare { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).SourceShare; }

        /// <summary>The task start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).StartTime; }

        /// <summary>The disk migration child task status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus? Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).MigrationSubtaskStatus; }

        /// <summary>The disk status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState? TargetDiskStateForMigration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).TargetDiskStateForMigration; }

        /// <summary>The target share of migration task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string TargetShare { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskPropertiesInternal)Property).TargetShare; }

        /// <summary>Creates an new <see cref="MigrationSubTask" /> instance.</summary>
        public MigrationSubTask()
        {

        }
    }
    /// Disk migration child task.
    public partial interface IMigrationSubTask :
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
        /// <summary>The id of migration child task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The id of migration child task.",
        SerializedName = @"migrationSubTaskId",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
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
        /// <summary>The disk migration child task status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk migration child task status.",
        SerializedName = @"migrationSubtaskStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus? Status { get;  }
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
    /// Disk migration child task.
    internal partial interface IMigrationSubTaskInternal

    {
        /// <summary>The id of disk.</summary>
        string DiskId { get; set; }
        /// <summary>The task end time.</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>The id of migration child task.</summary>
        string Id { get; set; }
        /// <summary>Disk migration child task properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTaskProperties Property { get; set; }
        /// <summary>The reason of task failure.</summary>
        string Reason { get; set; }
        /// <summary>The source share of migration task.</summary>
        string SourceShare { get; set; }
        /// <summary>The task start time.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>The disk migration child task status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationSubTaskStatus? Status { get; set; }
        /// <summary>The disk status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState? TargetDiskStateForMigration { get; set; }
        /// <summary>The target share of migration task.</summary>
        string TargetShare { get; set; }

    }
}