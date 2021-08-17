namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>List of properties provided for the gallery item.</summary>
    public partial class GalleryItemProperties :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesInternal
    {

        /// <summary>Creates an new <see cref="GalleryItemProperties" /> instance.</summary>
        public GalleryItemProperties()
        {

        }
    }
    /// List of properties provided for the gallery item.
    public partial interface IGalleryItemProperties :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IAssociativeArray<string>
    {

    }
    /// List of properties provided for the gallery item.
    internal partial interface IGalleryItemPropertiesInternal

    {

    }
}