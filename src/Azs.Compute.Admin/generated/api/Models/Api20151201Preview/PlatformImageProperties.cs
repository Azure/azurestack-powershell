namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Properties of platform image.</summary>
    public partial class PlatformImageProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImageProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DataDisk" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IDataDisk[] _dataDisk;

        /// <summary>Data disks used by the platform image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IDataDisk[] DataDisk { get => this._dataDisk; set => this._dataDisk = value; }

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IImageDetails _detail;

        /// <summary>Information about the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IImageDetails Detail { get => (this._detail = this._detail ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ImageDetails()); set => this._detail = value; }

        /// <summary>The part number is used to bill for software costs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string DetailBillingPartNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IImageDetailsInternal)Detail).BillingPartNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IImageDetailsInternal)Detail).BillingPartNumber = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IImageDetails Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal.Detail { get => (this._detail = this._detail ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ImageDetails()); set { {_detail = value;} } }

        /// <summary>Internal Acessors for OSDisk</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IOSDisk Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal.OSDisk { get => (this._oSDisk = this._oSDisk ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.OSDisk()); set { {_oSDisk = value;} } }

        /// <summary>Backing field for <see cref="OSDisk" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IOSDisk _oSDisk;

        /// <summary>Operating system used for this platform image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IOSDisk OSDisk { get => (this._oSDisk = this._oSDisk ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.OSDisk()); set => this._oSDisk = value; }

        /// <summary>Operating system type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType? OSDiskOstype { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IOSDiskInternal)OSDisk).OSType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IOSDiskInternal)OSDisk).OSType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType)""); }

        /// <summary>Location of the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string OSDiskUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IOSDiskInternal)OSDisk).Uri; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IOSDiskInternal)OSDisk).Uri = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning status of the platform image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Creates an new <see cref="PlatformImageProperties" /> instance.</summary>
        public PlatformImageProperties()
        {

        }
    }
    /// Properties of platform image.
    public partial interface IPlatformImageProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Data disks used by the platform image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Data disks used by the platform image.",
        SerializedName = @"dataDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IDataDisk) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IDataDisk[] DataDisk { get; set; }
        /// <summary>The part number is used to bill for software costs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The part number is used to bill for software costs.",
        SerializedName = @"billingPartNumber",
        PossibleTypes = new [] { typeof(string) })]
        string DetailBillingPartNumber { get; set; }
        /// <summary>Operating system type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operating system type.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType? OSDiskOstype { get; set; }
        /// <summary>Location of the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location of the disk.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string OSDiskUri { get; set; }
        /// <summary>Provisioning status of the platform image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provisioning status of the platform image.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState? ProvisioningState { get; set; }

    }
    /// Properties of platform image.
    internal partial interface IPlatformImagePropertiesInternal

    {
        /// <summary>Data disks used by the platform image.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IDataDisk[] DataDisk { get; set; }
        /// <summary>Information about the image.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IImageDetails Detail { get; set; }
        /// <summary>The part number is used to bill for software costs.</summary>
        string DetailBillingPartNumber { get; set; }
        /// <summary>Operating system used for this platform image.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IOSDisk OSDisk { get; set; }
        /// <summary>Operating system type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType? OSDiskOstype { get; set; }
        /// <summary>Location of the disk.</summary>
        string OSDiskUri { get; set; }
        /// <summary>Provisioning status of the platform image.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}