namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Holds an array of downloaded products and the URI to the next page.</summary>
    public partial class DownloadedProductResourcesPage :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductResourcesPage,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductResourcesPageInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductResource[] _value;

        /// <summary>Array of downloaded products.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DownloadedProductResourcesPage" /> instance.</summary>
        public DownloadedProductResourcesPage()
        {

        }
    }
    /// Holds an array of downloaded products and the URI to the next page.
    public partial interface IDownloadedProductResourcesPage :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Array of downloaded products.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Array of downloaded products.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductResource[] Value { get; set; }

    }
    /// Holds an array of downloaded products and the URI to the next page.
    internal partial interface IDownloadedProductResourcesPageInternal

    {
        /// <summary>URI to next page.</summary>
        string NextLink { get; set; }
        /// <summary>Array of downloaded products.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IDownloadedProductResource[] Value { get; set; }

    }
}