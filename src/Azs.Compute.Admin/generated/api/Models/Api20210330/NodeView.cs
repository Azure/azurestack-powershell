namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Properties for a node</summary>
    public partial class NodeView :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.INodeView,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.INodeViewInternal
    {

        /// <summary>Backing field for <see cref="LastUpdatedTime" /> property.</summary>
        private string _lastUpdatedTime;

        /// <summary>The node last update time (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string LastUpdatedTime { get => this._lastUpdatedTime; set => this._lastUpdatedTime = value; }

        /// <summary>Backing field for <see cref="NodeHealthState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState? _nodeHealthState;

        /// <summary>The node health state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState? NodeHealthState { get => this._nodeHealthState; set => this._nodeHealthState = value; }

        /// <summary>Backing field for <see cref="NodeName" /> property.</summary>
        private string _nodeName;

        /// <summary>The name of the node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string NodeName { get => this._nodeName; set => this._nodeName = value; }

        /// <summary>Backing field for <see cref="VirtualMachine" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineView[] _virtualMachine;

        /// <summary>The virtual machines on the node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineView[] VirtualMachine { get => this._virtualMachine; set => this._virtualMachine = value; }

        /// <summary>Creates an new <see cref="NodeView" /> instance.</summary>
        public NodeView()
        {

        }
    }
    /// Properties for a node
    public partial interface INodeView :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The node last update time (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The node last update time (UTC).",
        SerializedName = @"lastUpdatedTime",
        PossibleTypes = new [] { typeof(string) })]
        string LastUpdatedTime { get; set; }
        /// <summary>The node health state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The node health state.",
        SerializedName = @"nodeHealthState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState? NodeHealthState { get; set; }
        /// <summary>The name of the node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the node.",
        SerializedName = @"nodeName",
        PossibleTypes = new [] { typeof(string) })]
        string NodeName { get; set; }
        /// <summary>The virtual machines on the node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The virtual machines on the node.",
        SerializedName = @"virtualMachines",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineView) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineView[] VirtualMachine { get; set; }

    }
    /// Properties for a node
    internal partial interface INodeViewInternal

    {
        /// <summary>The node last update time (UTC).</summary>
        string LastUpdatedTime { get; set; }
        /// <summary>The node health state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.NodeHealthState? NodeHealthState { get; set; }
        /// <summary>The name of the node.</summary>
        string NodeName { get; set; }
        /// <summary>The virtual machines on the node.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineView[] VirtualMachine { get; set; }

    }
}