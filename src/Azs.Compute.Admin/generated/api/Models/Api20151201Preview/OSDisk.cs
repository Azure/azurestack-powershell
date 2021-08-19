namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Operating system disk.</summary>
    public partial class OSDisk :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IOSDisk,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IOSDiskInternal
    {

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType? _oSType;

        /// <summary>Operating system type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType? OSType { get => this._oSType; set => this._oSType = value; }

        /// <summary>Backing field for <see cref="Uri" /> property.</summary>
        private string _uri;

        /// <summary>Location of the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string Uri { get => this._uri; set => this._uri = value; }

        /// <summary>Creates an new <see cref="OSDisk" /> instance.</summary>
        public OSDisk()
        {

        }
    }
    /// Operating system disk.
    public partial interface IOSDisk :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Operating system type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operating system type.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType? OSType { get; set; }
        /// <summary>Location of the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location of the disk.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get; set; }

    }
    /// Operating system disk.
    internal partial interface IOSDiskInternal

    {
        /// <summary>Operating system type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType? OSType { get; set; }
        /// <summary>Location of the disk.</summary>
        string Uri { get; set; }

    }
}