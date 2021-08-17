namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>The GPU information on the physical machine.</summary>
    public partial class GpuModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModelInternal
    {

        /// <summary>Backing field for <see cref="HostDriverVersion" /> property.</summary>
        private string _hostDriverVersion;

        /// <summary>GPU host driver version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string HostDriverVersion { get => this._hostDriverVersion; set => this._hostDriverVersion = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>GPU name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Oem" /> property.</summary>
        private string _oem;

        /// <summary>GPU OEM information</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Oem { get => this._oem; set => this._oem = value; }

        /// <summary>Backing field for <see cref="PartitionSize" /> property.</summary>
        private int? _partitionSize;

        /// <summary>GPU partition size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public int? PartitionSize { get => this._partitionSize; set => this._partitionSize = value; }

        /// <summary>Backing field for <see cref="SlotLocation" /> property.</summary>
        private string _slotLocation;

        /// <summary>GPU slot location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string SlotLocation { get => this._slotLocation; set => this._slotLocation = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.GpuType? _type;

        /// <summary>Type of GPU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.GpuType? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="GpuModel" /> instance.</summary>
        public GpuModel()
        {

        }
    }
    /// The GPU information on the physical machine.
    public partial interface IGpuModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>GPU host driver version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"GPU host driver version.",
        SerializedName = @"hostDriverVersion",
        PossibleTypes = new [] { typeof(string) })]
        string HostDriverVersion { get; set; }
        /// <summary>GPU name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"GPU name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>GPU OEM information</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"GPU OEM information",
        SerializedName = @"oem",
        PossibleTypes = new [] { typeof(string) })]
        string Oem { get; set; }
        /// <summary>GPU partition size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"GPU partition size.",
        SerializedName = @"partitionSize",
        PossibleTypes = new [] { typeof(int) })]
        int? PartitionSize { get; set; }
        /// <summary>GPU slot location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"GPU slot location.",
        SerializedName = @"slotLocation",
        PossibleTypes = new [] { typeof(string) })]
        string SlotLocation { get; set; }
        /// <summary>Type of GPU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of GPU.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.GpuType) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.GpuType? Type { get; set; }

    }
    /// The GPU information on the physical machine.
    internal partial interface IGpuModelInternal

    {
        /// <summary>GPU host driver version.</summary>
        string HostDriverVersion { get; set; }
        /// <summary>GPU name.</summary>
        string Name { get; set; }
        /// <summary>GPU OEM information</summary>
        string Oem { get; set; }
        /// <summary>GPU partition size.</summary>
        int? PartitionSize { get; set; }
        /// <summary>GPU slot location.</summary>
        string SlotLocation { get; set; }
        /// <summary>Type of GPU.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.GpuType? Type { get; set; }

    }
}