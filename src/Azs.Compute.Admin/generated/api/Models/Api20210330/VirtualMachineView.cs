namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Properties for a virtual machine</summary>
    public partial class VirtualMachineView :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineView,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal
    {

        /// <summary>Backing field for <see cref="LastProvisioningErrorMessage" /> property.</summary>
        private string _lastProvisioningErrorMessage;

        /// <summary>The virtual machine last provisioning error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string LastProvisioningErrorMessage { get => this._lastProvisioningErrorMessage; set => this._lastProvisioningErrorMessage = value; }

        /// <summary>Backing field for <see cref="PowerState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.VMPowerState? _powerState;

        /// <summary>The fabric VM power state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.VMPowerState? PowerState { get => this._powerState; set => this._powerState = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The resource group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="TimeOfLastConfigurationChange" /> property.</summary>
        private string _timeOfLastConfigurationChange;

        /// <summary>The time of last configuration change (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string TimeOfLastConfigurationChange { get => this._timeOfLastConfigurationChange; set => this._timeOfLastConfigurationChange = value; }

        /// <summary>Backing field for <see cref="VMId" /> property.</summary>
        private string _vMId;

        /// <summary>The identifier of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string VMId { get => this._vMId; set => this._vMId = value; }

        /// <summary>Backing field for <see cref="VMName" /> property.</summary>
        private string _vMName;

        /// <summary>The name of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string VMName { get => this._vMName; set => this._vMName = value; }

        /// <summary>Backing field for <see cref="VMScaleSetName" /> property.</summary>
        private string _vMScaleSetName;

        /// <summary>The virtual machine scale set name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string VMScaleSetName { get => this._vMScaleSetName; set => this._vMScaleSetName = value; }

        /// <summary>Backing field for <see cref="VMSize" /> property.</summary>
        private string _vMSize;

        /// <summary>The virtual machine size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string VMSize { get => this._vMSize; set => this._vMSize = value; }

        /// <summary>Creates an new <see cref="VirtualMachineView" /> instance.</summary>
        public VirtualMachineView()
        {

        }
    }
    /// Properties for a virtual machine
    public partial interface IVirtualMachineView :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The virtual machine last provisioning error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The virtual machine last provisioning error message.",
        SerializedName = @"lastProvisioningErrorMessage",
        PossibleTypes = new [] { typeof(string) })]
        string LastProvisioningErrorMessage { get; set; }
        /// <summary>The fabric VM power state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The fabric VM power state.",
        SerializedName = @"powerState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.VMPowerState) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.VMPowerState? PowerState { get; set; }
        /// <summary>The resource group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource group name.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>The identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identifier of the subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>The time of last configuration change (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time of last configuration change (UTC).",
        SerializedName = @"timeOfLastConfigurationChange",
        PossibleTypes = new [] { typeof(string) })]
        string TimeOfLastConfigurationChange { get; set; }
        /// <summary>The identifier of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identifier of the virtual machine.",
        SerializedName = @"vmId",
        PossibleTypes = new [] { typeof(string) })]
        string VMId { get; set; }
        /// <summary>The name of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the virtual machine.",
        SerializedName = @"vmName",
        PossibleTypes = new [] { typeof(string) })]
        string VMName { get; set; }
        /// <summary>The virtual machine scale set name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The virtual machine scale set name.",
        SerializedName = @"vmScaleSetName",
        PossibleTypes = new [] { typeof(string) })]
        string VMScaleSetName { get; set; }
        /// <summary>The virtual machine size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The virtual machine size.",
        SerializedName = @"vmSize",
        PossibleTypes = new [] { typeof(string) })]
        string VMSize { get; set; }

    }
    /// Properties for a virtual machine
    internal partial interface IVirtualMachineViewInternal

    {
        /// <summary>The virtual machine last provisioning error message.</summary>
        string LastProvisioningErrorMessage { get; set; }
        /// <summary>The fabric VM power state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.VMPowerState? PowerState { get; set; }
        /// <summary>The resource group name.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>The identifier of the subscription.</summary>
        string SubscriptionId { get; set; }
        /// <summary>The time of last configuration change (UTC).</summary>
        string TimeOfLastConfigurationChange { get; set; }
        /// <summary>The identifier of the virtual machine.</summary>
        string VMId { get; set; }
        /// <summary>The name of the virtual machine.</summary>
        string VMName { get; set; }
        /// <summary>The virtual machine scale set name.</summary>
        string VMScaleSetName { get; set; }
        /// <summary>The virtual machine size.</summary>
        string VMSize { get; set; }

    }
}