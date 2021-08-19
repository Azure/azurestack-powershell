namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Virtual Machine Extension Image.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.DoNotFormat]
    public partial class VMExtension :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtension,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResource __crpResource = new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.CrpResource();

        /// <summary>Compute role</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string ComputeRole { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).ComputeRole; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).ComputeRole = value ?? null; }

        /// <summary>ID of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Id; }

        /// <summary>Indicates if the extension is for the system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public bool? IsSystemExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).IsSystemExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).IsSystemExtension = value ?? default(bool); }

        /// <summary>Location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionProperties Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.VMExtensionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for SourceBlob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IAzureBlob Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionInternal.SourceBlob { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).SourceBlob; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).SourceBlob = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionProperties _property;

        /// <summary>Inner properties of a Virtual Machine Extension Image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.VMExtensionProperties()); set => this._property = value; }

        /// <summary>Provisioning state of extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).ProvisioningState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState)""); }

        /// <summary>The publisher of the VM Extension</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string Publisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).Publisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).Publisher = value ?? null; }

        /// <summary>URI to Azure or AzureStack blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string SourceBlobUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).SourceBlobUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).SourceBlobUri = value ?? null; }

        /// <summary>True if supports multiple extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public bool? SupportMultipleExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).SupportMultipleExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).SupportMultipleExtension = value ?? default(bool); }

        /// <summary>Type of Resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Type; }

        /// <summary>
        /// Value indicating whether the extension is enabled for virtual machine scale set support.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public bool? VMScaleSetEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).VMScaleSetEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).VMScaleSetEnabled = value ?? default(bool); }

        /// <summary>
        /// Target virtual machine operating system type necessary for deploying the extension handler.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType? VmosType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).VmosType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionPropertiesInternal)Property).VmosType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType)""); }

        /// <summary>Creates an new <see cref="VMExtension" /> instance.</summary>
        public VMExtension()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__crpResource), __crpResource);
            await eventListener.AssertObjectIsValid(nameof(__crpResource), __crpResource);
        }
    }
    /// Virtual Machine Extension Image.
    public partial interface IVMExtension :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResource
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
    /// Virtual Machine Extension Image.
    internal partial interface IVMExtensionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal
    {
        /// <summary>Compute role</summary>
        string ComputeRole { get; set; }
        /// <summary>Indicates if the extension is for the system.</summary>
        bool? IsSystemExtension { get; set; }
        /// <summary>Inner properties of a Virtual Machine Extension Image.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IVMExtensionProperties Property { get; set; }
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