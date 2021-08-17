namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Representation of a volume resource.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.DoNotFormat]
    public partial class Volume :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolume,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.Resource();

        /// <summary>
        /// Detailed recommended action for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string Action { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).Action; }

        /// <summary>
        /// Detailed description for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).Description; }

        /// <summary>Health status of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string HealthStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).HealthStatus; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id; }

        /// <summary>The region where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Action</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal.Action { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).Action; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).Action = value; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal.Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).Description = value; }

        /// <summary>Internal Acessors for HealthStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal.HealthStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).HealthStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).HealthStatus = value; }

        /// <summary>Internal Acessors for OperationalStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal.OperationalStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).OperationalStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).OperationalStatus = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModel Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.VolumeModel()); set { {_property = value;} } }

        /// <summary>Internal Acessors for RemainingCapacityGB</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal.RemainingCapacityGB { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).RemainingCapacityGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).RemainingCapacityGb = value; }

        /// <summary>Internal Acessors for RepairStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal.RepairStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).RepairStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).RepairStatus = value; }

        /// <summary>Internal Acessors for TotalCapacityGB</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal.TotalCapacityGB { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).TotalCapacityGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).TotalCapacityGb = value; }

        /// <summary>Internal Acessors for VolumeLabel</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeInternal.VolumeLabel { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).VolumeLabel; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).VolumeLabel = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name; }

        /// <summary>Operational status of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string OperationalStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).OperationalStatus; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModel _property;

        /// <summary>Properties of a volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.VolumeModel()); set => this._property = value; }

        /// <summary>Remaining capacity in GB of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public int? RemainingCapacityGB { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).RemainingCapacityGb; }

        /// <summary>
        /// Repair status of the volume. Empty if no repair job running, something like 'Running, 90%' when repairing.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string RepairStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).RepairStatus; }

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Total capacity in GB of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public int? TotalCapacityGB { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).TotalCapacityGb; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type; }

        /// <summary>Volume label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string VolumeLabel { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal)Property).VolumeLabel; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }

        /// <summary>Creates an new <see cref="Volume" /> instance.</summary>
        public Volume()
        {

        }
    }
    /// Representation of a volume resource.
    public partial interface IVolume :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource
    {
        /// <summary>
        /// Detailed recommended action for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Detailed recommended action for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(string) })]
        string Action { get;  }
        /// <summary>
        /// Detailed description for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Detailed description for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>Health status of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Health status of the volume.",
        SerializedName = @"healthStatus",
        PossibleTypes = new [] { typeof(string) })]
        string HealthStatus { get;  }
        /// <summary>Operational status of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Operational status of the volume.",
        SerializedName = @"operationalStatus",
        PossibleTypes = new [] { typeof(string) })]
        string OperationalStatus { get;  }
        /// <summary>Remaining capacity in GB of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Remaining capacity in GB of the volume.",
        SerializedName = @"remainingCapacityGB",
        PossibleTypes = new [] { typeof(int) })]
        int? RemainingCapacityGB { get;  }
        /// <summary>
        /// Repair status of the volume. Empty if no repair job running, something like 'Running, 90%' when repairing.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Repair status of the volume. Empty if no repair job running, something like 'Running, 90%' when repairing.",
        SerializedName = @"repairStatus",
        PossibleTypes = new [] { typeof(string) })]
        string RepairStatus { get;  }
        /// <summary>Total capacity in GB of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total capacity in GB of the volume.",
        SerializedName = @"totalCapacityGB",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalCapacityGB { get;  }
        /// <summary>Volume label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Volume label.",
        SerializedName = @"volumeLabel",
        PossibleTypes = new [] { typeof(string) })]
        string VolumeLabel { get;  }

    }
    /// Representation of a volume resource.
    internal partial interface IVolumeInternal :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal
    {
        /// <summary>
        /// Detailed recommended action for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        string Action { get; set; }
        /// <summary>
        /// Detailed description for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        string Description { get; set; }
        /// <summary>Health status of the volume.</summary>
        string HealthStatus { get; set; }
        /// <summary>Operational status of the volume.</summary>
        string OperationalStatus { get; set; }
        /// <summary>Properties of a volume.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModel Property { get; set; }
        /// <summary>Remaining capacity in GB of the volume.</summary>
        int? RemainingCapacityGB { get; set; }
        /// <summary>
        /// Repair status of the volume. Empty if no repair job running, something like 'Running, 90%' when repairing.
        /// </summary>
        string RepairStatus { get; set; }
        /// <summary>Total capacity in GB of the volume.</summary>
        int? TotalCapacityGB { get; set; }
        /// <summary>Volume label.</summary>
        string VolumeLabel { get; set; }

    }
}