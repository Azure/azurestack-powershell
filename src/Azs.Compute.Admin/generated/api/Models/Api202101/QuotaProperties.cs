namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Properties for a Compute Quota</summary>
    public partial class QuotaProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AvailabilitySetCount" /> property.</summary>
        private int? _availabilitySetCount;

        /// <summary>Maximum number of availability sets allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public int? AvailabilitySetCount { get => this._availabilitySetCount; set => this._availabilitySetCount = value; }

        /// <summary>Backing field for <see cref="CoresLimit" /> property.</summary>
        private int? _coresLimit;

        /// <summary>Maximum number of cores allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public int? CoresLimit { get => this._coresLimit; set => this._coresLimit = value; }

        /// <summary>Backing field for <see cref="DdagpuCount" /> property.</summary>
        private int? _ddagpuCount;

        /// <summary>Maximum number of dda gpus allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public int? DdagpuCount { get => this._ddagpuCount; set => this._ddagpuCount = value; }

        /// <summary>
        /// Backing field for <see cref="MaxAllocationPremiumManagedDisksAndSnapshot" /> property.
        /// </summary>
        private int? _maxAllocationPremiumManagedDisksAndSnapshot;

        /// <summary>Maximum number of managed disks and snapshots of type premium allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public int? MaxAllocationPremiumManagedDisksAndSnapshot { get => this._maxAllocationPremiumManagedDisksAndSnapshot; set => this._maxAllocationPremiumManagedDisksAndSnapshot = value; }

        /// <summary>
        /// Backing field for <see cref="MaxAllocationStandardManagedDisksAndSnapshot" /> property.
        /// </summary>
        private int? _maxAllocationStandardManagedDisksAndSnapshot;

        /// <summary>Maximum number of managed disks and snapshots of type standard allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public int? MaxAllocationStandardManagedDisksAndSnapshot { get => this._maxAllocationStandardManagedDisksAndSnapshot; set => this._maxAllocationStandardManagedDisksAndSnapshot = value; }

        /// <summary>Backing field for <see cref="PartitionedGpuCount" /> property.</summary>
        private int? _partitionedGpuCount;

        /// <summary>Maximum number of partitioned gpus allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public int? PartitionedGpuCount { get => this._partitionedGpuCount; set => this._partitionedGpuCount = value; }

        /// <summary>Backing field for <see cref="VMScaleSetCount" /> property.</summary>
        private int? _vMScaleSetCount;

        /// <summary>Maximum number of scale sets allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public int? VMScaleSetCount { get => this._vMScaleSetCount; set => this._vMScaleSetCount = value; }

        /// <summary>Backing field for <see cref="VirtualMachineCount" /> property.</summary>
        private int? _virtualMachineCount;

        /// <summary>Maximum number of virtual machines allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public int? VirtualMachineCount { get => this._virtualMachineCount; set => this._virtualMachineCount = value; }

        /// <summary>Creates an new <see cref="QuotaProperties" /> instance.</summary>
        public QuotaProperties()
        {

        }
    }
    /// Properties for a Compute Quota
    public partial interface IQuotaProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
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
        /// <summary>Maximum number of managed disks and snapshots of type premium allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of managed disks and snapshots of type premium allowed.",
        SerializedName = @"maxAllocationPremiumManagedDisksAndSnapshots",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxAllocationPremiumManagedDisksAndSnapshot { get; set; }
        /// <summary>Maximum number of managed disks and snapshots of type standard allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of managed disks and snapshots of type standard allowed.",
        SerializedName = @"maxAllocationStandardManagedDisksAndSnapshots",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxAllocationStandardManagedDisksAndSnapshot { get; set; }
        /// <summary>Maximum number of partitioned gpus allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of partitioned gpus allowed.",
        SerializedName = @"partitionedGpuCount",
        PossibleTypes = new [] { typeof(int) })]
        int? PartitionedGpuCount { get; set; }
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
    /// Properties for a Compute Quota
    internal partial interface IQuotaPropertiesInternal

    {
        /// <summary>Maximum number of availability sets allowed.</summary>
        int? AvailabilitySetCount { get; set; }
        /// <summary>Maximum number of cores allowed.</summary>
        int? CoresLimit { get; set; }
        /// <summary>Maximum number of dda gpus allowed.</summary>
        int? DdagpuCount { get; set; }
        /// <summary>Maximum number of managed disks and snapshots of type premium allowed.</summary>
        int? MaxAllocationPremiumManagedDisksAndSnapshot { get; set; }
        /// <summary>Maximum number of managed disks and snapshots of type standard allowed.</summary>
        int? MaxAllocationStandardManagedDisksAndSnapshot { get; set; }
        /// <summary>Maximum number of partitioned gpus allowed.</summary>
        int? PartitionedGpuCount { get; set; }
        /// <summary>Maximum number of scale sets allowed.</summary>
        int? VMScaleSetCount { get; set; }
        /// <summary>Maximum number of virtual machines allowed.</summary>
        int? VirtualMachineCount { get; set; }

    }
}