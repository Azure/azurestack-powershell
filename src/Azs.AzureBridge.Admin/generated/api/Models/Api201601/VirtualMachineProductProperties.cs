namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Product information.</summary>
    public partial class VirtualMachineProductProperties :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductProperties,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DataDiskImage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[] _dataDiskImage;

        /// <summary>List of attached data disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[] DataDiskImage { get => this._dataDiskImage; }

        /// <summary>Internal Acessors for DataDiskImage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[] Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal.DataDiskImage { get => this._dataDiskImage; set { {_dataDiskImage = value;} } }

        /// <summary>Internal Acessors for OSDiskImage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImage Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal.OSDiskImage { get => (this._oSDiskImage = this._oSDiskImage ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.OSDiskImage()); set { {_oSDiskImage = value;} } }

        /// <summary>Internal Acessors for OSDiskImageOperatingSystem</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal.OSDiskImageOperatingSystem { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImageInternal)OSDiskImage).OperatingSystem; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImageInternal)OSDiskImage).OperatingSystem = value; }

        /// <summary>Internal Acessors for OSDiskImageSourceBlobSasUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IVirtualMachineProductPropertiesInternal.OSDiskImageSourceBlobSasUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImageInternal)OSDiskImage).SourceBlobSasUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImageInternal)OSDiskImage).SourceBlobSasUri = value; }

        /// <summary>Backing field for <see cref="OSDiskImage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImage _oSDiskImage;

        /// <summary>OS disk image used by product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImage OSDiskImage { get => (this._oSDiskImage = this._oSDiskImage ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.OSDiskImage()); }

        /// <summary>OS operating system type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? OSDiskImageOperatingSystem { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImageInternal)OSDiskImage).OperatingSystem; }

        /// <summary>SAS key for source blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string OSDiskImageSourceBlobSasUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImageInternal)OSDiskImage).SourceBlobSasUri; }

        /// <summary>Creates an new <see cref="VirtualMachineProductProperties" /> instance.</summary>
        public VirtualMachineProductProperties()
        {

        }
    }
    /// Product information.
    public partial interface IVirtualMachineProductProperties :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>List of attached data disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of attached data disks.",
        SerializedName = @"dataDiskImages",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[] DataDiskImage { get;  }
        /// <summary>OS operating system type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"OS operating system type.",
        SerializedName = @"operatingSystem",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? OSDiskImageOperatingSystem { get;  }
        /// <summary>SAS key for source blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"SAS key for source blob.",
        SerializedName = @"sourceBlobSasUri",
        PossibleTypes = new [] { typeof(string) })]
        string OSDiskImageSourceBlobSasUri { get;  }

    }
    /// Product information.
    internal partial interface IVirtualMachineProductPropertiesInternal

    {
        /// <summary>List of attached data disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage[] DataDiskImage { get; set; }
        /// <summary>OS disk image used by product.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImage OSDiskImage { get; set; }
        /// <summary>OS operating system type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? OSDiskImageOperatingSystem { get; set; }
        /// <summary>SAS key for source blob.</summary>
        string OSDiskImageSourceBlobSasUri { get; set; }

    }
}