namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Holds Compute quota information used to control resource allocation.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.DoNotFormat]
    public partial class Quota :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuota,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResource __crpResource = new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.CrpResource();

        /// <summary>Maximum number of availability sets allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public int? AvailabilitySetCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).AvailabilitySetCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).AvailabilitySetCount = value ?? default(int); }

        /// <summary>Maximum number of cores allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public int? CoresLimit { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).CoresLimit; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).CoresLimit = value ?? default(int); }

        /// <summary>Maximum number of dda gpus allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public int? DdagpuCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).DdagpuCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).DdagpuCount = value ?? default(int); }

        /// <summary>ID of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Id; }

        /// <summary>Location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaProperties Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.QuotaProperties()); set { {_property = value;} } }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Name; }

        /// <summary>Maximum number of partitioned gpus allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public int? PartitionedGpuCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).PartitionedGpuCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).PartitionedGpuCount = value ?? default(int); }

        /// <summary>Maximum number of managed disks and snapshots of type premium allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public int? PremiumManagedDiskAndSnapshotSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).MaxAllocationPremiumManagedDisksAndSnapshot; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).MaxAllocationPremiumManagedDisksAndSnapshot = value ?? default(int); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaProperties _property;

        /// <summary>Compute Quota properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.QuotaProperties()); set => this._property = value; }

        /// <summary>Maximum number of managed disks and snapshots of type standard allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public int? StandardManagedDiskAndSnapshotSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).MaxAllocationStandardManagedDisksAndSnapshot; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).MaxAllocationStandardManagedDisksAndSnapshot = value ?? default(int); }

        /// <summary>Type of Resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Type; }

        /// <summary>Maximum number of scale sets allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public int? VMScaleSetCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).VMScaleSetCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).VMScaleSetCount = value ?? default(int); }

        /// <summary>Maximum number of virtual machines allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public int? VirtualMachineCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).VirtualMachineCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal)Property).VirtualMachineCount = value ?? default(int); }

        /// <summary>Creates an new <see cref="Quota" /> instance.</summary>
        public Quota()
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
            await eventListener.AssertNotNull(nameof(__crpResource), __crpResource);
            await eventListener.AssertObjectIsValid(nameof(__crpResource), __crpResource);
        }
    }
    /// Holds Compute quota information used to control resource allocation.
    public partial interface IQuota :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResource
    {
        /// <summary>Maximum number of availability sets allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of availability sets allowed.",
        SerializedName = @"availabilitySetCount",
        PossibleTypes = new [] { typeof(int) })]
        int? AvailabilitySetCount { get; set; }
        /// <summary>Maximum number of cores allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of cores allowed.",
        SerializedName = @"coresLimit",
        PossibleTypes = new [] { typeof(int) })]
        int? CoresLimit { get; set; }
        /// <summary>Maximum number of dda gpus allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of dda gpus allowed.",
        SerializedName = @"ddagpuCount",
        PossibleTypes = new [] { typeof(int) })]
        int? DdagpuCount { get; set; }
        /// <summary>Maximum number of partitioned gpus allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of partitioned gpus allowed.",
        SerializedName = @"partitionedGpuCount",
        PossibleTypes = new [] { typeof(int) })]
        int? PartitionedGpuCount { get; set; }
        /// <summary>Maximum number of managed disks and snapshots of type premium allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of managed disks and snapshots of type premium allowed.",
        SerializedName = @"maxAllocationPremiumManagedDisksAndSnapshots",
        PossibleTypes = new [] { typeof(int) })]
        int? PremiumManagedDiskAndSnapshotSize { get; set; }
        /// <summary>Maximum number of managed disks and snapshots of type standard allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of managed disks and snapshots of type standard allowed.",
        SerializedName = @"maxAllocationStandardManagedDisksAndSnapshots",
        PossibleTypes = new [] { typeof(int) })]
        int? StandardManagedDiskAndSnapshotSize { get; set; }
        /// <summary>Maximum number of scale sets allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of scale sets allowed.",
        SerializedName = @"vmScaleSetCount",
        PossibleTypes = new [] { typeof(int) })]
        int? VMScaleSetCount { get; set; }
        /// <summary>Maximum number of virtual machines allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of virtual machines allowed.",
        SerializedName = @"virtualMachineCount",
        PossibleTypes = new [] { typeof(int) })]
        int? VirtualMachineCount { get; set; }

    }
    /// Holds Compute quota information used to control resource allocation.
    internal partial interface IQuotaInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal
    {
        /// <summary>Maximum number of availability sets allowed.</summary>
        int? AvailabilitySetCount { get; set; }
        /// <summary>Maximum number of cores allowed.</summary>
        int? CoresLimit { get; set; }
        /// <summary>Maximum number of dda gpus allowed.</summary>
        int? DdagpuCount { get; set; }
        /// <summary>Maximum number of partitioned gpus allowed.</summary>
        int? PartitionedGpuCount { get; set; }
        /// <summary>Maximum number of managed disks and snapshots of type premium allowed.</summary>
        int? PremiumManagedDiskAndSnapshotSize { get; set; }
        /// <summary>Compute Quota properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaProperties Property { get; set; }
        /// <summary>Maximum number of managed disks and snapshots of type standard allowed.</summary>
        int? StandardManagedDiskAndSnapshotSize { get; set; }
        /// <summary>Maximum number of scale sets allowed.</summary>
        int? VMScaleSetCount { get; set; }
        /// <summary>Maximum number of virtual machines allowed.</summary>
        int? VirtualMachineCount { get; set; }

    }
}