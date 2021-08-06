namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>The URI.</summary>
    public partial class Uri :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUri,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IUriInternal
    {

        /// <summary>Backing field for <see cref="Uri1" /> property.</summary>
        private string _uri1;

        /// <summary>The URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string Uri1 { get => this._uri1; set => this._uri1 = value; }

        /// <summary>Creates an new <see cref="Uri" /> instance.</summary>
        public Uri()
        {

        }
    }
    /// The URI.
    public partial interface IUri :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri1 { get; set; }

    }
    /// The URI.
    internal partial interface IUriInternal

    {
        /// <summary>The URI.</summary>
        string Uri1 { get; set; }

    }
}