namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Disk migration job.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.DoNotFormat]
    public partial class DiskMigrationJob :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJob,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.Resource();

        /// <summary>The job creation time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).CreationTime; }

        /// <summary>The job end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).EndTime; }

        /// <summary>ID of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Id; }

        /// <summary>Location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for CreationTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobInternal.CreationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).CreationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).CreationTime = value; }

        /// <summary>Internal Acessors for EndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobInternal.EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).EndTime = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobProperties Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.DiskMigrationJobProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobInternal.StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).StartTime = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).Status = value; }

        /// <summary>Internal Acessors for Subtask</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTask[] Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobInternal.Subtask { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).Subtask; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).Subtask = value; }

        /// <summary>Internal Acessors for TargetShare</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobInternal.TargetShare { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).TargetShare; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).TargetShare = value; }

        /// <summary>The disk migration id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string MigrationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).MigrationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).MigrationId = value ?? null; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobProperties _property;

        /// <summary>Disk migration properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.DiskMigrationJobProperties()); set => this._property = value; }

        /// <summary>The job start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).StartTime; }

        /// <summary>The current status of disk migration job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.MigrationJobStatus? Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).Status; }

        /// <summary>The list of child migration tasks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IMigrationSubTask[] Subtask { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).Subtask; }

        /// <summary>The target share of migration job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string TargetShare { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobPropertiesInternal)Property).TargetShare; }

        /// <summary>Type of Resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="DiskMigrationJob" /> instance.</summary>
        public DiskMigrationJob()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Disk migration job.
    public partial interface IDiskMigrationJob :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResource
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
    /// Disk migration job.
    internal partial interface IDiskMigrationJobInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal
    {
        /// <summary>The job creation time.</summary>
        global::System.DateTime? CreationTime { get; set; }
        /// <summary>The job end time.</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>The disk migration id.</summary>
        string MigrationId { get; set; }
        /// <summary>Disk migration properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskMigrationJobProperties Property { get; set; }
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