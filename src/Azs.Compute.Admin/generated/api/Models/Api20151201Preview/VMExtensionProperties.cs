namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Properties of a Virtual Machine Extension Image.</summary>
    public partial class VMExtensionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ComputeRole" /> property.</summary>
        private string _computeRole;

        /// <summary>Compute role</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string ComputeRole { get => this._computeRole; set => this._computeRole = value; }

        /// <summary>Backing field for <see cref="IsSystemExtension" /> property.</summary>
        private bool? _isSystemExtension;

        /// <summary>Indicates if the extension is for the system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public bool? IsSystemExtension { get => this._isSystemExtension; set => this._isSystemExtension = value; }

        /// <summary>Internal Acessors for SourceBlob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IAzureBlob Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal.SourceBlob { get => (this._sourceBlob = this._sourceBlob ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.AzureBlob()); set { {_sourceBlob = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning state of extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>The publisher of the VM Extension</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Backing field for <see cref="SourceBlob" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IAzureBlob _sourceBlob;

        /// <summary>URI to Azure or AzureStack blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IAzureBlob SourceBlob { get => (this._sourceBlob = this._sourceBlob ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.AzureBlob()); set => this._sourceBlob = value; }

        /// <summary>URI to Azure or AzureStack blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string SourceBlobUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IAzureBlobInternal)SourceBlob).Uri; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IAzureBlobInternal)SourceBlob).Uri = value ?? null; }

        /// <summary>Backing field for <see cref="SupportMultipleExtension" /> property.</summary>
        private bool? _supportMultipleExtension;

        /// <summary>True if supports multiple extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public bool? SupportMultipleExtension { get => this._supportMultipleExtension; set => this._supportMultipleExtension = value; }

        /// <summary>Backing field for <see cref="VMScaleSetEnabled" /> property.</summary>
        private bool? _vMScaleSetEnabled;

        /// <summary>
        /// Value indicating whether the extension is enabled for virtual machine scale set support.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public bool? VMScaleSetEnabled { get => this._vMScaleSetEnabled; set => this._vMScaleSetEnabled = value; }

        /// <summary>Backing field for <see cref="VmosType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType? _vmosType;

        /// <summary>
        /// Target virtual machine operating system type necessary for deploying the extension handler.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType? VmosType { get => this._vmosType; set => this._vmosType = value; }

        /// <summary>Creates an new <see cref="VMExtensionProperties" /> instance.</summary>
        public VMExtensionProperties()
        {

        }
    }
    /// Properties of a Virtual Machine Extension Image.
    public partial interface IVMExtensionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Compute role</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Compute role",
        SerializedName = @"computeRole",
        PossibleTypes = new [] { typeof(string) })]
        string ComputeRole { get; set; }
        /// <summary>Indicates if the extension is for the system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if the extension is for the system.",
        SerializedName = @"isSystemExtension",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsSystemExtension { get; set; }
        /// <summary>Provisioning state of extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provisioning state of extension.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The publisher of the VM Extension</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The publisher of the VM Extension",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }
        /// <summary>URI to Azure or AzureStack blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to Azure or AzureStack blob.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string SourceBlobUri { get; set; }
        /// <summary>True if supports multiple extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if supports multiple extensions.",
        SerializedName = @"supportMultipleExtensions",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SupportMultipleExtension { get; set; }
        /// <summary>
        /// Value indicating whether the extension is enabled for virtual machine scale set support.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value indicating whether the extension is enabled for virtual machine scale set support.",
        SerializedName = @"vmScaleSetEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? VMScaleSetEnabled { get; set; }
        /// <summary>
        /// Target virtual machine operating system type necessary for deploying the extension handler.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target virtual machine operating system type necessary for deploying the extension handler.",
        SerializedName = @"vmOsType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType? VmosType { get; set; }

    }
    /// Properties of a Virtual Machine Extension Image.
    internal partial interface IVMExtensionPropertiesInternal

    {
        /// <summary>Compute role</summary>
        string ComputeRole { get; set; }
        /// <summary>Indicates if the extension is for the system.</summary>
        bool? IsSystemExtension { get; set; }
        /// <summary>Provisioning state of extension.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The publisher of the VM Extension</summary>
        string Publisher { get; set; }
        /// <summary>URI to Azure or AzureStack blob.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IAzureBlob SourceBlob { get; set; }
        /// <summary>URI to Azure or AzureStack blob.</summary>
        string SourceBlobUri { get; set; }
        /// <summary>True if supports multiple extensions.</summary>
        bool? SupportMultipleExtension { get; set; }
        /// <summary>
        /// Value indicating whether the extension is enabled for virtual machine scale set support.
        /// </summary>
        bool? VMScaleSetEnabled { get; set; }
        /// <summary>
        /// Target virtual machine operating system type necessary for deploying the extension handler.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType? VmosType { get; set; }

    }
}