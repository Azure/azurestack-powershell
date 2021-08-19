namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Information about the disk image.</summary>
    public partial class ImageDetails :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IImageDetails,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IImageDetailsInternal
    {

        /// <summary>Backing field for <see cref="BillingPartNumber" /> property.</summary>
        private string _billingPartNumber;

        /// <summary>The part number is used to bill for software costs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string BillingPartNumber { get => this._billingPartNumber; set => this._billingPartNumber = value; }

        /// <summary>Creates an new <see cref="ImageDetails" /> instance.</summary>
        public ImageDetails()
        {

        }
    }
    /// Information about the disk image.
    public partial interface IImageDetails :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The part number is used to bill for software costs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The part number is used to bill for software costs.",
        SerializedName = @"billingPartNumber",
        PossibleTypes = new [] { typeof(string) })]
        string BillingPartNumber { get; set; }

    }
    /// Information about the disk image.
    internal partial interface IImageDetailsInternal

    {
        /// <summary>The part number is used to bill for software costs.</summary>
        string BillingPartNumber { get; set; }

    }
}