namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Parameters used to create a new platform image.</summary>
    public partial class PlatformImageParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImageParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImageParametersInternal
    {

        /// <summary>Data disks used by the platform image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IDataDisk[] DataDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal)Property).DataDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal)Property).DataDisk = value ?? null /* arrayOf */; }

        /// <summary>The part number is used to bill for software costs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string DetailBillingPartNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal)Property).DetailBillingPartNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal)Property).DetailBillingPartNumber = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IImageDetails Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImageParametersInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal)Property).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal)Property).Detail = value; }

        /// <summary>Internal Acessors for OSDisk</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IOSDisk Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImageParametersInternal.OSDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal)Property).OSDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal)Property).OSDisk = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImageProperties Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImageParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.PlatformImageProperties()); set { {_property = value;} } }

        /// <summary>Operating system type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType? OSDiskOstype { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal)Property).OSDiskOstype; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal)Property).OSDiskOstype = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.OSType)""); }

        /// <summary>Location of the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string OSDiskUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal)Property).OSDiskUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal)Property).OSDiskUri = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImageProperties _property;

        /// <summary>Platform image properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImageProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.PlatformImageProperties()); set => this._property = value; }

        /// <summary>Provisioning status of the platform image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImagePropertiesInternal)Property).ProvisioningState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState)""); }

        /// <summary>Creates an new <see cref="PlatformImageParameters" /> instance.</summary>
        public PlatformImageParameters()
        {

        }
    }
    /// Parameters used to create a new platform image.
    public partial interface IPlatformImageParameters :
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
    /// Parameters used to create a new platform image.
    internal partial interface IPlatformImageParametersInternal

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
        /// <summary>Platform image properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IPlatformImageProperties Property { get; set; }
        /// <summary>Provisioning status of the platform image.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}