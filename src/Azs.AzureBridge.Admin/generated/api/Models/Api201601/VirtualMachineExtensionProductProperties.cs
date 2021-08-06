namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Product information.</summary>
    public partial class VirtualMachineExtensionProductProperties :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductProperties,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ComputeRole" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole? _computeRole;

        /// <summary>Specifies kind of compute role included in the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole? ComputeRole { get => this._computeRole; }

        /// <summary>Backing field for <see cref="IsSystemExtension" /> property.</summary>
        private bool? _isSystemExtension;

        /// <summary>Specifies if product is a Virtual Machine Extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public bool? IsSystemExtension { get => this._isSystemExtension; set => this._isSystemExtension = value; }

        /// <summary>Internal Acessors for ComputeRole</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole? Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal.ComputeRole { get => this._computeRole; set { {_computeRole = value;} } }

        /// <summary>Internal Acessors for SourceBlob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUri Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal.SourceBlob { get => (this._sourceBlob = this._sourceBlob ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.Uri()); set { {_sourceBlob = value;} } }

        /// <summary>Internal Acessors for VmosType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal.VmosType { get => this._vmosType; set { {_vmosType = value;} } }

        /// <summary>Backing field for <see cref="SourceBlob" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUri _sourceBlob;

        /// <summary>Specifies a download location where content can be downloaded from.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUri SourceBlob { get => (this._sourceBlob = this._sourceBlob ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.Uri()); }

        /// <summary>The URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string SourceBlobUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUriInternal)SourceBlob).Uri1; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUriInternal)SourceBlob).Uri1 = value ?? null; }

        /// <summary>Backing field for <see cref="SupportMultipleExtension" /> property.</summary>
        private bool? _supportMultipleExtension;

        /// <summary>Indicates if specified product supports multiple extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public bool? SupportMultipleExtension { get => this._supportMultipleExtension; set => this._supportMultipleExtension = value; }

        /// <summary>Backing field for <see cref="VMScaleSetEnabled" /> property.</summary>
        private bool? _vMScaleSetEnabled;

        /// <summary>Indicates if virtual machine Scale Set is enabled in the specified product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public bool? VMScaleSetEnabled { get => this._vMScaleSetEnabled; set => this._vMScaleSetEnabled = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Specifies product version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Backing field for <see cref="VmosType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? _vmosType;

        /// <summary>Specifies operating system used by the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? VmosType { get => this._vmosType; }

        /// <summary>
        /// Creates an new <see cref="VirtualMachineExtensionProductProperties" /> instance.
        /// </summary>
        public VirtualMachineExtensionProductProperties()
        {

        }
    }
    /// Product information.
    public partial interface IVirtualMachineExtensionProductProperties :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Specifies kind of compute role included in the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies kind of compute role included in the package.",
        SerializedName = @"computeRole",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole? ComputeRole { get;  }
        /// <summary>Specifies if product is a Virtual Machine Extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies if product is a Virtual Machine Extension.",
        SerializedName = @"isSystemExtension",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsSystemExtension { get; set; }
        /// <summary>The URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string SourceBlobUri { get; set; }
        /// <summary>Indicates if specified product supports multiple extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if specified product supports multiple extensions.",
        SerializedName = @"supportMultipleExtensions",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SupportMultipleExtension { get; set; }
        /// <summary>Indicates if virtual machine Scale Set is enabled in the specified product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if virtual machine Scale Set is enabled in the specified product.",
        SerializedName = @"vmScaleSetEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? VMScaleSetEnabled { get; set; }
        /// <summary>Specifies product version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies product version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }
        /// <summary>Specifies operating system used by the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies operating system used by the product.",
        SerializedName = @"vmOsType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? VmosType { get;  }

    }
    /// Product information.
    internal partial interface IVirtualMachineExtensionProductPropertiesInternal

    {
        /// <summary>Specifies kind of compute role included in the package.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole? ComputeRole { get; set; }
        /// <summary>Specifies if product is a Virtual Machine Extension.</summary>
        bool? IsSystemExtension { get; set; }
        /// <summary>Specifies a download location where content can be downloaded from.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUri SourceBlob { get; set; }
        /// <summary>The URI.</summary>
        string SourceBlobUri { get; set; }
        /// <summary>Indicates if specified product supports multiple extensions.</summary>
        bool? SupportMultipleExtension { get; set; }
        /// <summary>Indicates if virtual machine Scale Set is enabled in the specified product.</summary>
        bool? VMScaleSetEnabled { get; set; }
        /// <summary>Specifies product version.</summary>
        string Version { get; set; }
        /// <summary>Specifies operating system used by the product.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? VmosType { get; set; }

    }
}