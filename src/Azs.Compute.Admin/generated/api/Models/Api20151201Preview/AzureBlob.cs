namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Azure or AzureStack blob information.</summary>
    public partial class AzureBlob :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IAzureBlob,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IAzureBlobInternal
    {

        /// <summary>Backing field for <see cref="Uri" /> property.</summary>
        private string _uri;

        /// <summary>URI to Azure or AzureStack blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string Uri { get => this._uri; set => this._uri = value; }

        /// <summary>Creates an new <see cref="AzureBlob" /> instance.</summary>
        public AzureBlob()
        {

        }
    }
    /// Azure or AzureStack blob information.
    public partial interface IAzureBlob :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to Azure or AzureStack blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to Azure or AzureStack blob.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get; set; }

    }
    /// Azure or AzureStack blob information.
    internal partial interface IAzureBlobInternal

    {
        /// <summary>URI to Azure or AzureStack blob.</summary>
        string Uri { get; set; }

    }
}