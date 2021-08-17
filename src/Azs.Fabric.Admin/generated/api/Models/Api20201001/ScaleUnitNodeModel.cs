namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Holds all properties related to a scale unit node.</summary>
    public partial class ScaleUnitNodeModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal
    {

        /// <summary>Backing field for <see cref="BiosVersion" /> property.</summary>
        private string _biosVersion;

        /// <summary>BIOS version of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string BiosVersion { get => this._biosVersion; set => this._biosVersion = value; }

        /// <summary>Backing field for <see cref="BmcAddress" /> property.</summary>
        private string _bmcAddress;

        /// <summary>BMC address of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string BmcAddress { get => this._bmcAddress; set => this._bmcAddress = value; }

        /// <summary>Backing field for <see cref="CanPowerOff" /> property.</summary>
        private bool? _canPowerOff;

        /// <summary>Value indicating whether the node can be powered off.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public bool? CanPowerOff { get => this._canPowerOff; set => this._canPowerOff = value; }

        /// <summary>Backing field for <see cref="Capacity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacity _capacity;

        /// <summary>Capacity of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacity Capacity { get => (this._capacity = this._capacity ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ScaleUnitCapacity()); set => this._capacity = value; }

        /// <summary>The number of CPU cores for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public long? CapacityCore { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacityInternal)Capacity).Core; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacityInternal)Capacity).Core = value ?? default(long); }

        /// <summary>The memory for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public float? CapacityMemoryGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacityInternal)Capacity).MemoryGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacityInternal)Capacity).MemoryGb = value ?? default(float); }

        /// <summary>Backing field for <see cref="Gpu" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel[] _gpu;

        /// <summary>GPU resource list of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel[] Gpu { get => this._gpu; set => this._gpu = value; }

        /// <summary>Internal Acessors for Capacity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacity Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal.Capacity { get => (this._capacity = this._capacity ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ScaleUnitCapacity()); set { {_capacity = value;} } }

        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        /// <summary>Model of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Model { get => this._model; set => this._model = value; }

        /// <summary>Backing field for <see cref="PowerState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.PowerState? _powerState;

        /// <summary>PowerState of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.PowerState? PowerState { get => this._powerState; set => this._powerState = value; }

        /// <summary>Backing field for <see cref="ScaleUnitName" /> property.</summary>
        private string _scaleUnitName;

        /// <summary>Cluster name of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string ScaleUnitName { get => this._scaleUnitName; set => this._scaleUnitName = value; }

        /// <summary>Backing field for <see cref="ScaleUnitNodeStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus? _scaleUnitNodeStatus;

        /// <summary>Status of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus? ScaleUnitNodeStatus { get => this._scaleUnitNodeStatus; set => this._scaleUnitNodeStatus = value; }

        /// <summary>Backing field for <see cref="ScaleUnitUri" /> property.</summary>
        private string _scaleUnitUri;

        /// <summary>URI of the corresponding cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string ScaleUnitUri { get => this._scaleUnitUri; set => this._scaleUnitUri = value; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>Serial number of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; set => this._serialNumber = value; }

        /// <summary>Backing field for <see cref="Vendor" /> property.</summary>
        private string _vendor;

        /// <summary>Vendor of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Vendor { get => this._vendor; set => this._vendor = value; }

        /// <summary>Creates an new <see cref="ScaleUnitNodeModel" /> instance.</summary>
        public ScaleUnitNodeModel()
        {

        }
    }
    /// Holds all properties related to a scale unit node.
    public partial interface IScaleUnitNodeModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>BIOS version of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"BIOS version of the physical machine.",
        SerializedName = @"biosVersion",
        PossibleTypes = new [] { typeof(string) })]
        string BiosVersion { get; set; }
        /// <summary>BMC address of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"BMC address of the physical machine.",
        SerializedName = @"bmcAddress",
        PossibleTypes = new [] { typeof(string) })]
        string BmcAddress { get; set; }
        /// <summary>Value indicating whether the node can be powered off.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value indicating whether the node can be powered off.",
        SerializedName = @"canPowerOff",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CanPowerOff { get; set; }
        /// <summary>The number of CPU cores for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of CPU cores for the physical machine.",
        SerializedName = @"cores",
        PossibleTypes = new [] { typeof(long) })]
        long? CapacityCore { get; set; }
        /// <summary>The memory for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The memory for the physical machine.",
        SerializedName = @"memoryGB",
        PossibleTypes = new [] { typeof(float) })]
        float? CapacityMemoryGb { get; set; }
        /// <summary>GPU resource list of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"GPU resource list of the physical machine.",
        SerializedName = @"gpus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel[] Gpu { get; set; }
        /// <summary>Model of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Model of the physical machine.",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        string Model { get; set; }
        /// <summary>PowerState of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"PowerState of the physical machine.",
        SerializedName = @"powerState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.PowerState) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.PowerState? PowerState { get; set; }
        /// <summary>Cluster name of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Cluster name of the physical machine.",
        SerializedName = @"scaleUnitName",
        PossibleTypes = new [] { typeof(string) })]
        string ScaleUnitName { get; set; }
        /// <summary>Status of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status of the physical machine.",
        SerializedName = @"scaleUnitNodeStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus? ScaleUnitNodeStatus { get; set; }
        /// <summary>URI of the corresponding cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI of the corresponding cluster.",
        SerializedName = @"scaleUnitUri",
        PossibleTypes = new [] { typeof(string) })]
        string ScaleUnitUri { get; set; }
        /// <summary>Serial number of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Serial number of the physical machine.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get; set; }
        /// <summary>Vendor of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Vendor of the physical machine.",
        SerializedName = @"vendor",
        PossibleTypes = new [] { typeof(string) })]
        string Vendor { get; set; }

    }
    /// Holds all properties related to a scale unit node.
    internal partial interface IScaleUnitNodeModelInternal

    {
        /// <summary>BIOS version of the physical machine.</summary>
        string BiosVersion { get; set; }
        /// <summary>BMC address of the physical machine.</summary>
        string BmcAddress { get; set; }
        /// <summary>Value indicating whether the node can be powered off.</summary>
        bool? CanPowerOff { get; set; }
        /// <summary>Capacity of the physical machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacity Capacity { get; set; }
        /// <summary>The number of CPU cores for the physical machine.</summary>
        long? CapacityCore { get; set; }
        /// <summary>The memory for the physical machine.</summary>
        float? CapacityMemoryGb { get; set; }
        /// <summary>GPU resource list of the physical machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel[] Gpu { get; set; }
        /// <summary>Model of the physical machine.</summary>
        string Model { get; set; }
        /// <summary>PowerState of the physical machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.PowerState? PowerState { get; set; }
        /// <summary>Cluster name of the physical machine.</summary>
        string ScaleUnitName { get; set; }
        /// <summary>Status of the physical machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus? ScaleUnitNodeStatus { get; set; }
        /// <summary>URI of the corresponding cluster.</summary>
        string ScaleUnitUri { get; set; }
        /// <summary>Serial number of the physical machine.</summary>
        string SerialNumber { get; set; }
        /// <summary>Vendor of the physical machine.</summary>
        string Vendor { get; set; }

    }
}