namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Data disk image.</summary>
    public partial class DataDiskImage :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImage,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImageInternal
    {

        /// <summary>Backing field for <see cref="Lun" /> property.</summary>
        private int? _lun;

        /// <summary>The LUN.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public int? Lun { get => this._lun; }

        /// <summary>Internal Acessors for Lun</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImageInternal.Lun { get => this._lun; set { {_lun = value;} } }

        /// <summary>Internal Acessors for SourceBlobSasUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDataDiskImageInternal.SourceBlobSasUri { get => this._sourceBlobSasUri; set { {_sourceBlobSasUri = value;} } }

        /// <summary>Backing field for <see cref="SourceBlobSasUri" /> property.</summary>
        private string _sourceBlobSasUri;

        /// <summary>SAS key for source blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string SourceBlobSasUri { get => this._sourceBlobSasUri; }

        /// <summary>Creates an new <see cref="DataDiskImage" /> instance.</summary>
        public DataDiskImage()
        {

        }
    }
    /// Data disk image.
    public partial interface IDataDiskImage :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The LUN.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The LUN.",
        SerializedName = @"lun",
        PossibleTypes = new [] { typeof(int) })]
        int? Lun { get;  }
        /// <summary>SAS key for source blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"SAS key for source blob.",
        SerializedName = @"sourceBlobSasUri",
        PossibleTypes = new [] { typeof(string) })]
        string SourceBlobSasUri { get;  }

    }
    /// Data disk image.
    internal partial interface IDataDiskImageInternal

    {
        /// <summary>The LUN.</summary>
        int? Lun { get; set; }
        /// <summary>SAS key for source blob.</summary>
        string SourceBlobSasUri { get; set; }

    }
}