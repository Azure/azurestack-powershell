namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Represents a REST operation.</summary>
    public partial class Operation :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperation,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationDisplayDefinition _display;

        /// <summary>Information about the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationDisplayDefinition Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.OperationDisplayDefinition()); set => this._display = value; }

        /// <summary>Description of the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationDisplayDefinitionInternal)Display).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationDisplayDefinitionInternal)Display).Description = value ?? null; }

        /// <summary>Type of REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationDisplayDefinitionInternal)Display).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationDisplayDefinitionInternal)Display).Operation = value ?? null; }

        /// <summary>Provider of the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationDisplayDefinitionInternal)Display).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationDisplayDefinitionInternal)Display).Provider = value ?? null; }

        /// <summary>Resource returned by the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationDisplayDefinitionInternal)Display).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationDisplayDefinitionInternal)Display).Resource = value ?? null; }

        /// <summary>Internal Acessors for Display</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationDisplayDefinition Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationInternal.Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.OperationDisplayDefinition()); set { {_display = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Origin" /> property.</summary>
        private string _origin;

        /// <summary>Origin of the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Origin { get => this._origin; set => this._origin = value; }

        /// <summary>Creates an new <see cref="Operation" /> instance.</summary>
        public Operation()
        {

        }
    }
    /// Represents a REST operation.
    public partial interface IOperation :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Description of the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the REST operation.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>Type of REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of REST operation.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get; set; }
        /// <summary>Provider of the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provider of the REST operation.",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get; set; }
        /// <summary>Resource returned by the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource returned by the REST operation.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get; set; }
        /// <summary>Name of the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the REST operation.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Origin of the REST operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Origin of the REST operation.",
        SerializedName = @"origin",
        PossibleTypes = new [] { typeof(string) })]
        string Origin { get; set; }

    }
    /// Represents a REST operation.
    internal partial interface IOperationInternal

    {
        /// <summary>Information about the REST operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationDisplayDefinition Display { get; set; }
        /// <summary>Description of the REST operation.</summary>
        string DisplayDescription { get; set; }
        /// <summary>Type of REST operation.</summary>
        string DisplayOperation { get; set; }
        /// <summary>Provider of the REST operation.</summary>
        string DisplayProvider { get; set; }
        /// <summary>Resource returned by the REST operation.</summary>
        string DisplayResource { get; set; }
        /// <summary>Name of the REST operation.</summary>
        string Name { get; set; }
        /// <summary>Origin of the REST operation.</summary>
        string Origin { get; set; }

    }
}