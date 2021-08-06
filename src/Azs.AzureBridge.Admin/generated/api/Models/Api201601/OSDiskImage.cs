namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>OS disk image.</summary>
    public partial class OSDiskImage :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImage,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImageInternal
    {

        /// <summary>Internal Acessors for OperatingSystem</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImageInternal.OperatingSystem { get => this._operatingSystem; set { {_operatingSystem = value;} } }

        /// <summary>Internal Acessors for SourceBlobSasUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IOSDiskImageInternal.SourceBlobSasUri { get => this._sourceBlobSasUri; set { {_sourceBlobSasUri = value;} } }

        /// <summary>Backing field for <see cref="OperatingSystem" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? _operatingSystem;

        /// <summary>OS operating system type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? OperatingSystem { get => this._operatingSystem; }

        /// <summary>Backing field for <see cref="SourceBlobSasUri" /> property.</summary>
        private string _sourceBlobSasUri;

        /// <summary>SAS key for source blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string SourceBlobSasUri { get => this._sourceBlobSasUri; }

        /// <summary>Creates an new <see cref="OSDiskImage" /> instance.</summary>
        public OSDiskImage()
        {

        }
    }
    /// OS disk image.
    public partial interface IOSDiskImage :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>OS operating system type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"OS operating system type.",
        SerializedName = @"operatingSystem",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? OperatingSystem { get;  }
        /// <summary>SAS key for source blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"SAS key for source blob.",
        SerializedName = @"sourceBlobSasUri",
        PossibleTypes = new [] { typeof(string) })]
        string SourceBlobSasUri { get;  }

    }
    /// OS disk image.
    internal partial interface IOSDiskImageInternal

    {
        /// <summary>OS operating system type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem? OperatingSystem { get; set; }
        /// <summary>SAS key for source blob.</summary>
        string SourceBlobSasUri { get; set; }

    }
}