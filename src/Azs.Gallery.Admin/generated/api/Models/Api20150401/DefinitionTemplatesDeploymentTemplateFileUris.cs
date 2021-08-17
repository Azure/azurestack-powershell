namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>
    /// List of key-value containing the deployment template file IDs defined in the package manifest.
    /// </summary>
    public partial class DefinitionTemplatesDeploymentTemplateFileUris :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUrisInternal
    {

        /// <summary>
        /// Creates an new <see cref="DefinitionTemplatesDeploymentTemplateFileUris" /> instance.
        /// </summary>
        public DefinitionTemplatesDeploymentTemplateFileUris()
        {

        }
    }
    /// List of key-value containing the deployment template file IDs defined in the package manifest.
    public partial interface IDefinitionTemplatesDeploymentTemplateFileUris :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IAssociativeArray<string>
    {

    }
    /// List of key-value containing the deployment template file IDs defined in the package manifest.
    internal partial interface IDefinitionTemplatesDeploymentTemplateFileUrisInternal

    {

    }
}