namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>All properties of an infrastructure role instance.</summary>
    public partial class InfraRoleInstanceModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleInstanceModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleInstanceModelInternal
    {

        /// <summary>Internal Acessors for Size</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleInstanceSize Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleInstanceModelInternal.Size { get => (this._size = this._size ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.InfraRoleInstanceSize()); set { {_size = value;} } }

        /// <summary>Backing field for <see cref="ScaleUnit" /> property.</summary>
        private string _scaleUnit;

        /// <summary>The cluster that the virtual machine's host is part of.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string ScaleUnit { get => this._scaleUnit; set => this._scaleUnit = value; }

        /// <summary>Backing field for <see cref="ScaleUnitNode" /> property.</summary>
        private string _scaleUnitNode;

        /// <summary>URI to the scale unit node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string ScaleUnitNode { get => this._scaleUnitNode; set => this._scaleUnitNode = value; }

        /// <summary>Backing field for <see cref="Size" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleInstanceSize _size;

        /// <summary>Size of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleInstanceSize Size { get => (this._size = this._size ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.InfraRoleInstanceSize()); set => this._size = value; }

        /// <summary>The number of cores assigned to the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public int? SizeCore { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleInstanceSizeInternal)Size).Core; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleInstanceSizeInternal)Size).Core = value ?? default(int); }

        /// <summary>The amount of memory, in GB, currently assigned to the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public float? SizeMemoryGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleInstanceSizeInternal)Size).MemoryGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleInstanceSizeInternal)Size).MemoryGb = value ?? default(float); }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.InfraRoleInstanceState? _state;

        /// <summary>The current state of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.InfraRoleInstanceState? State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="InfraRoleInstanceModel" /> instance.</summary>
        public InfraRoleInstanceModel()
        {

        }
    }
    /// All properties of an infrastructure role instance.
    public partial interface IInfraRoleInstanceModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The cluster that the virtual machine's host is part of.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The cluster that the virtual machine's host is part of.",
        SerializedName = @"scaleUnit",
        PossibleTypes = new [] { typeof(string) })]
        string ScaleUnit { get; set; }
        /// <summary>URI to the scale unit node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the scale unit node.",
        SerializedName = @"scaleUnitNode",
        PossibleTypes = new [] { typeof(string) })]
        string ScaleUnitNode { get; set; }
        /// <summary>The number of cores assigned to the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of cores assigned to the virtual machine.",
        SerializedName = @"cores",
        PossibleTypes = new [] { typeof(int) })]
        int? SizeCore { get; set; }
        /// <summary>The amount of memory, in GB, currently assigned to the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of memory, in GB, currently assigned to the virtual machine.",
        SerializedName = @"memoryGb",
        PossibleTypes = new [] { typeof(float) })]
        float? SizeMemoryGb { get; set; }
        /// <summary>The current state of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The current state of the virtual machine.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.InfraRoleInstanceState) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.InfraRoleInstanceState? State { get; set; }

    }
    /// All properties of an infrastructure role instance.
    internal partial interface IInfraRoleInstanceModelInternal

    {
        /// <summary>The cluster that the virtual machine's host is part of.</summary>
        string ScaleUnit { get; set; }
        /// <summary>URI to the scale unit node.</summary>
        string ScaleUnitNode { get; set; }
        /// <summary>Size of the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleInstanceSize Size { get; set; }
        /// <summary>The number of cores assigned to the virtual machine.</summary>
        int? SizeCore { get; set; }
        /// <summary>The amount of memory, in GB, currently assigned to the virtual machine.</summary>
        float? SizeMemoryGb { get; set; }
        /// <summary>The current state of the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.InfraRoleInstanceState? State { get; set; }

    }
}