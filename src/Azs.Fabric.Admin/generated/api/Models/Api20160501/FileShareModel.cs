namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Properties of a file share resource.</summary>
    public partial class FileShareModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFileShareModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFileShareModelInternal
    {

        /// <summary>Backing field for <see cref="AssociatedVolume" /> property.</summary>
        private string _associatedVolume;

        /// <summary>Associated volume ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string AssociatedVolume { get => this._associatedVolume; set => this._associatedVolume = value; }

        /// <summary>Backing field for <see cref="UncPath" /> property.</summary>
        private string _uncPath;

        /// <summary>The UNCPath for the fileshare.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string UncPath { get => this._uncPath; set => this._uncPath = value; }

        /// <summary>Creates an new <see cref="FileShareModel" /> instance.</summary>
        public FileShareModel()
        {

        }
    }
    /// Properties of a file share resource.
    public partial interface IFileShareModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Associated volume ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Associated volume ID.",
        SerializedName = @"associatedVolume",
        PossibleTypes = new [] { typeof(string) })]
        string AssociatedVolume { get; set; }
        /// <summary>The UNCPath for the fileshare.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The UNCPath for the fileshare.",
        SerializedName = @"uncPath",
        PossibleTypes = new [] { typeof(string) })]
        string UncPath { get; set; }

    }
    /// Properties of a file share resource.
    internal partial interface IFileShareModelInternal

    {
        /// <summary>Associated volume ID.</summary>
        string AssociatedVolume { get; set; }
        /// <summary>The UNCPath for the fileshare.</summary>
        string UncPath { get; set; }

    }
}