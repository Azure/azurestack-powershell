namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Properties of a scale unit.</summary>
    public partial class ScaleUnitModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitModelInternal
    {

        /// <summary>Backing field for <see cref="GpuPartitionSize" /> property.</summary>
        private int? _gpuPartitionSize;

        /// <summary>GPU partition size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public int? GpuPartitionSize { get => this._gpuPartitionSize; set => this._gpuPartitionSize = value; }

        /// <summary>Backing field for <see cref="GpuType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.GpuType? _gpuType;

        /// <summary>Type of GPU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.GpuType? GpuType { get => this._gpuType; set => this._gpuType = value; }

        /// <summary>Backing field for <see cref="IsGpuAvailable" /> property.</summary>
        private bool? _isGpuAvailable;

        /// <summary>Denotes if GPU resource is available in the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public bool? IsGpuAvailable { get => this._isGpuAvailable; set => this._isGpuAvailable = value; }

        /// <summary>Backing field for <see cref="IsMultiNode" /> property.</summary>
        private bool? _isMultiNode;

        /// <summary>Denotes if more than one node in cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public bool? IsMultiNode { get => this._isMultiNode; set => this._isMultiNode = value; }

        /// <summary>Backing field for <see cref="LogicalFaultDomain" /> property.</summary>
        private int? _logicalFaultDomain;

        /// <summary>Fault domain name of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public int? LogicalFaultDomain { get => this._logicalFaultDomain; set => this._logicalFaultDomain = value; }

        /// <summary>Internal Acessors for TotalCapacity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacity Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitModelInternal.TotalCapacity { get => (this._totalCapacity = this._totalCapacity ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ScaleUnitCapacity()); set { {_totalCapacity = value;} } }

        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        /// <summary>Model of the servers in the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Model { get => this._model; set => this._model = value; }

        /// <summary>Backing field for <see cref="Node" /> property.</summary>
        private string[] _node;

        /// <summary>List of nodes in the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string[] Node { get => this._node; set => this._node = value; }

        /// <summary>Backing field for <see cref="ScaleUnitType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitType? _scaleUnitType;

        /// <summary>Type of cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitType? ScaleUnitType { get => this._scaleUnitType; set => this._scaleUnitType = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitState? _state;

        /// <summary>Current state of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitState? State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="TotalCapacity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacity _totalCapacity;

        /// <summary>Capacity information for the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacity TotalCapacity { get => (this._totalCapacity = this._totalCapacity ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ScaleUnitCapacity()); set => this._totalCapacity = value; }

        /// <summary>The number of CPU cores for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public long? TotalCapacityCore { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacityInternal)TotalCapacity).Core; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacityInternal)TotalCapacity).Core = value ?? default(long); }

        /// <summary>The memory for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public float? TotalCapacityMemoryGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacityInternal)TotalCapacity).MemoryGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacityInternal)TotalCapacity).MemoryGb = value ?? default(float); }

        /// <summary>Creates an new <see cref="ScaleUnitModel" /> instance.</summary>
        public ScaleUnitModel()
        {

        }
    }
    /// Properties of a scale unit.
    public partial interface IScaleUnitModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>GPU partition size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"GPU partition size.",
        SerializedName = @"gpuPartitionSize",
        PossibleTypes = new [] { typeof(int) })]
        int? GpuPartitionSize { get; set; }
        /// <summary>Type of GPU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of GPU.",
        SerializedName = @"gpuType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.GpuType) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.GpuType? GpuType { get; set; }
        /// <summary>Denotes if GPU resource is available in the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Denotes if GPU resource is available in the cluster.",
        SerializedName = @"isGpuAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsGpuAvailable { get; set; }
        /// <summary>Denotes if more than one node in cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Denotes if more than one node in cluster.",
        SerializedName = @"isMultiNode",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsMultiNode { get; set; }
        /// <summary>Fault domain name of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fault domain name of the cluster.",
        SerializedName = @"logicalFaultDomain",
        PossibleTypes = new [] { typeof(int) })]
        int? LogicalFaultDomain { get; set; }
        /// <summary>Model of the servers in the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Model of the servers in the cluster.",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        string Model { get; set; }
        /// <summary>List of nodes in the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of nodes in the server.",
        SerializedName = @"nodes",
        PossibleTypes = new [] { typeof(string) })]
        string[] Node { get; set; }
        /// <summary>Type of cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of cluster.",
        SerializedName = @"scaleUnitType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitType) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitType? ScaleUnitType { get; set; }
        /// <summary>Current state of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current state of the cluster.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitState) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitState? State { get; set; }
        /// <summary>The number of CPU cores for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of CPU cores for the physical machine.",
        SerializedName = @"cores",
        PossibleTypes = new [] { typeof(long) })]
        long? TotalCapacityCore { get; set; }
        /// <summary>The memory for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The memory for the physical machine.",
        SerializedName = @"memoryGB",
        PossibleTypes = new [] { typeof(float) })]
        float? TotalCapacityMemoryGb { get; set; }

    }
    /// Properties of a scale unit.
    internal partial interface IScaleUnitModelInternal

    {
        /// <summary>GPU partition size.</summary>
        int? GpuPartitionSize { get; set; }
        /// <summary>Type of GPU.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.GpuType? GpuType { get; set; }
        /// <summary>Denotes if GPU resource is available in the cluster.</summary>
        bool? IsGpuAvailable { get; set; }
        /// <summary>Denotes if more than one node in cluster.</summary>
        bool? IsMultiNode { get; set; }
        /// <summary>Fault domain name of the cluster.</summary>
        int? LogicalFaultDomain { get; set; }
        /// <summary>Model of the servers in the cluster.</summary>
        string Model { get; set; }
        /// <summary>List of nodes in the server.</summary>
        string[] Node { get; set; }
        /// <summary>Type of cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitType? ScaleUnitType { get; set; }
        /// <summary>Current state of the cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitState? State { get; set; }
        /// <summary>Capacity information for the cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacity TotalCapacity { get; set; }
        /// <summary>The number of CPU cores for the physical machine.</summary>
        long? TotalCapacityCore { get; set; }
        /// <summary>The memory for the physical machine.</summary>
        float? TotalCapacityMemoryGb { get; set; }

    }
}