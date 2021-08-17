namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>The capacity information for a physical machine.</summary>
    public partial class ScaleUnitCapacity :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacity,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacityInternal
    {

        /// <summary>Backing field for <see cref="Core" /> property.</summary>
        private long? _core;

        /// <summary>The number of CPU cores for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public long? Core { get => this._core; set => this._core = value; }

        /// <summary>Backing field for <see cref="MemoryGb" /> property.</summary>
        private float? _memoryGb;

        /// <summary>The memory for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public float? MemoryGb { get => this._memoryGb; set => this._memoryGb = value; }

        /// <summary>Creates an new <see cref="ScaleUnitCapacity" /> instance.</summary>
        public ScaleUnitCapacity()
        {

        }
    }
    /// The capacity information for a physical machine.
    public partial interface IScaleUnitCapacity :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The number of CPU cores for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of CPU cores for the physical machine.",
        SerializedName = @"cores",
        PossibleTypes = new [] { typeof(long) })]
        long? Core { get; set; }
        /// <summary>The memory for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The memory for the physical machine.",
        SerializedName = @"memoryGB",
        PossibleTypes = new [] { typeof(float) })]
        float? MemoryGb { get; set; }

    }
    /// The capacity information for a physical machine.
    internal partial interface IScaleUnitCapacityInternal

    {
        /// <summary>The number of CPU cores for the physical machine.</summary>
        long? Core { get; set; }
        /// <summary>The memory for the physical machine.</summary>
        float? MemoryGb { get; set; }

    }
}