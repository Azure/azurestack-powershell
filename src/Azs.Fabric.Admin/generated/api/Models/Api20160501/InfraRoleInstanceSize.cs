namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>The capacity information for a virtual machine.</summary>
    public partial class InfraRoleInstanceSize :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleInstanceSize,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleInstanceSizeInternal
    {

        /// <summary>Backing field for <see cref="Core" /> property.</summary>
        private int? _core;

        /// <summary>The number of cores assigned to the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public int? Core { get => this._core; set => this._core = value; }

        /// <summary>Backing field for <see cref="MemoryGb" /> property.</summary>
        private float? _memoryGb;

        /// <summary>The amount of memory, in GB, currently assigned to the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public float? MemoryGb { get => this._memoryGb; set => this._memoryGb = value; }

        /// <summary>Creates an new <see cref="InfraRoleInstanceSize" /> instance.</summary>
        public InfraRoleInstanceSize()
        {

        }
    }
    /// The capacity information for a virtual machine.
    public partial interface IInfraRoleInstanceSize :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The number of cores assigned to the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of cores assigned to the virtual machine.",
        SerializedName = @"cores",
        PossibleTypes = new [] { typeof(int) })]
        int? Core { get; set; }
        /// <summary>The amount of memory, in GB, currently assigned to the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of memory, in GB, currently assigned to the virtual machine.",
        SerializedName = @"memoryGb",
        PossibleTypes = new [] { typeof(float) })]
        float? MemoryGb { get; set; }

    }
    /// The capacity information for a virtual machine.
    internal partial interface IInfraRoleInstanceSizeInternal

    {
        /// <summary>The number of cores assigned to the virtual machine.</summary>
        int? Core { get; set; }
        /// <summary>The amount of memory, in GB, currently assigned to the virtual machine.</summary>
        float? MemoryGb { get; set; }

    }
}