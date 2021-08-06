namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Product information.</summary>
    public partial class ExtendedProductProperties :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedProductProperties,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedProductPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductProperties __virtualMachineExtensionProductProperties = new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.VirtualMachineExtensionProductProperties();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductProperties __virtualMachineProductProperties = new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.VirtualMachineProductProperties();

        /// <summary>Specifies kind of compute role included in the package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole? ComputeRole { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).ComputeRole; }

        /// <summary>List of attached data disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[] DataDiskImage { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)__virtualMachineProductProperties).DataDiskImage; }

        /// <summary>Specifies if product is a Virtual Machine Extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public bool? IsSystemExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).IsSystemExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).IsSystemExtension = value ?? default(bool); }

        /// <summary>Internal Acessors for ComputeRole</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ComputeRole? Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal.ComputeRole { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).ComputeRole; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).ComputeRole = value; }

        /// <summary>Internal Acessors for SourceBlob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUri Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal.SourceBlob { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).SourceBlob; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).SourceBlob = value; }

        /// <summary>Internal Acessors for VmosType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal.VmosType { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).VmosType; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).VmosType = value; }

        /// <summary>Internal Acessors for DataDiskImage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[] Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal.DataDiskImage { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)__virtualMachineProductProperties).DataDiskImage; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)__virtualMachineProductProperties).DataDiskImage = value; }

        /// <summary>Internal Acessors for OSDiskImage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImage Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal.OSDiskImage { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)__virtualMachineProductProperties).OSDiskImage; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)__virtualMachineProductProperties).OSDiskImage = value; }

        /// <summary>Internal Acessors for OSDiskImageOperatingSystem</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal.OSDiskImageOperatingSystem { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)__virtualMachineProductProperties).OSDiskImageOperatingSystem; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)__virtualMachineProductProperties).OSDiskImageOperatingSystem = value; }

        /// <summary>Internal Acessors for OSDiskImageSourceBlobSasUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal.OSDiskImageSourceBlobSasUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)__virtualMachineProductProperties).OSDiskImageSourceBlobSasUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)__virtualMachineProductProperties).OSDiskImageSourceBlobSasUri = value; }

        /// <summary>OS disk image used by product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImage OSDiskImage { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)__virtualMachineProductProperties).OSDiskImage; }

        /// <summary>OS operating system type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? OSDiskImageOperatingSystem { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)__virtualMachineProductProperties).OSDiskImageOperatingSystem; }

        /// <summary>SAS key for source blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string OSDiskImageSourceBlobSasUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal)__virtualMachineProductProperties).OSDiskImageSourceBlobSasUri; }

        /// <summary>Specifies a download location where content can be downloaded from.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUri SourceBlob { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).SourceBlob; }

        /// <summary>The URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string SourceBlobUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).SourceBlobUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).SourceBlobUri = value ?? null; }

        /// <summary>Indicates if specified product supports multiple extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public bool? SupportMultipleExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).SupportMultipleExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).SupportMultipleExtension = value ?? default(bool); }

        /// <summary>Indicates if virtual machine Scale Set is enabled in the specified product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public bool? VMScaleSetEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).VMScaleSetEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).VMScaleSetEnabled = value ?? default(bool); }

        /// <summary>Specifies product version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).Version = value ?? null; }

        /// <summary>Specifies operating system used by the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? VmosType { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal)__virtualMachineExtensionProductProperties).VmosType; }

        /// <summary>Creates an new <see cref="ExtendedProductProperties" /> instance.</summary>
        public ExtendedProductProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__virtualMachineExtensionProductProperties), __virtualMachineExtensionProductProperties);
            await eventListener.AssertObjectIsValid(nameof(__virtualMachineExtensionProductProperties), __virtualMachineExtensionProductProperties);
            await eventListener.AssertNotNull(nameof(__virtualMachineProductProperties), __virtualMachineProductProperties);
            await eventListener.AssertObjectIsValid(nameof(__virtualMachineProductProperties), __virtualMachineProductProperties);
        }
    }
    /// Product information.
    public partial interface IExtendedProductProperties :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductProperties,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductProperties
    {

    }
    /// Product information.
    internal partial interface IExtendedProductPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineExtensionProductPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal
    {

    }
}