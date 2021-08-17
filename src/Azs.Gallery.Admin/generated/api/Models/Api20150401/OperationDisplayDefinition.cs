namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Information about the REST operation.</summary>
    public partial class OperationDisplayDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationDisplayDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationDisplayDefinitionInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Operation" /> property.</summary>
        private string _operation;

        /// <summary>Type of REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Operation { get => this._operation; set => this._operation = value; }

        /// <summary>Backing field for <see cref="Provider" /> property.</summary>
        private string _provider;

        /// <summary>Provider of the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Provider { get => this._provider; set => this._provider = value; }

        /// <summary>Backing field for <see cref="Resource" /> property.</summary>
        private string _resource;

        /// <summary>Resource returned by the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Resource { get => this._resource; set => this._resource = value; }

        /// <summary>Creates an new <see cref="OperationDisplayDefinition" /> instance.</summary>
        public OperationDisplayDefinition()
        {

        }
    }
    /// Information about the REST operation.
    public partial interface IOperationDisplayDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Description of the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the REST operation.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Type of REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of REST operation.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string Operation { get; set; }
        /// <summary>Provider of the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provider of the REST operation.",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string Provider { get; set; }
        /// <summary>Resource returned by the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource returned by the REST operation.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string Resource { get; set; }

    }
    /// Information about the REST operation.
    internal partial interface IOperationDisplayDefinitionInternal

    {
        /// <summary>Description of the REST operation.</summary>
        string Description { get; set; }
        /// <summary>Type of REST operation.</summary>
        string Operation { get; set; }
        /// <summary>Provider of the REST operation.</summary>
        string Provider { get; set; }
        /// <summary>Resource returned by the REST operation.</summary>
        string Resource { get; set; }

    }
}