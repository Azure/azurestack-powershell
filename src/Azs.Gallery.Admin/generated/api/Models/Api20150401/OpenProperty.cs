namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Open type used to define dynamic properties.</summary>
    public partial class OpenProperty :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenProperty,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyProperties Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.OpenPropertyProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyProperties _property;

        /// <summary>Dictionary of dynamic properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.OpenPropertyProperties()); }

        /// <summary>Creates an new <see cref="OpenProperty" /> instance.</summary>
        public OpenProperty()
        {

        }
    }
    /// Open type used to define dynamic properties.
    public partial interface IOpenProperty :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Dictionary of dynamic properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Dictionary of dynamic properties.",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyProperties Property { get;  }

    }
    /// Open type used to define dynamic properties.
    internal partial interface IOpenPropertyInternal

    {
        /// <summary>Dictionary of dynamic properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyProperties Property { get; set; }

    }
}