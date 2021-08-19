namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Information about datadisk.</summary>
    public partial class DataDisk :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IDataDisk,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IDataDiskInternal
    {

        /// <summary>Backing field for <see cref="Lun" /> property.</summary>
        private int? _lun;

        /// <summary>Logical unit number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public int? Lun { get => this._lun; set => this._lun = value; }

        /// <summary>Backing field for <see cref="Uri" /> property.</summary>
        private string _uri;

        /// <summary>Location of the disk template.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string Uri { get => this._uri; set => this._uri = value; }

        /// <summary>Creates an new <see cref="DataDisk" /> instance.</summary>
        public DataDisk()
        {

        }
    }
    /// Information about datadisk.
    public partial interface IDataDisk :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Logical unit number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Logical unit number.",
        SerializedName = @"lun",
        PossibleTypes = new [] { typeof(int) })]
        int? Lun { get; set; }
        /// <summary>Location of the disk template.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location of the disk template.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get; set; }

    }
    /// Information about datadisk.
    internal partial interface IDataDiskInternal

    {
        /// <summary>Logical unit number.</summary>
        int? Lun { get; set; }
        /// <summary>Location of the disk template.</summary>
        string Uri { get; set; }

    }
}