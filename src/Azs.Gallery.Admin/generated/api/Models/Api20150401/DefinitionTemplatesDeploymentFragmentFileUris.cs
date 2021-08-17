namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>
    /// List of key-value pairs containing the deployment fragment file IDs defined in the package manifest.
    /// </summary>
    public partial class DefinitionTemplatesDeploymentFragmentFileUris :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUrisInternal
    {

        /// <summary>
        /// Creates an new <see cref="DefinitionTemplatesDeploymentFragmentFileUris" /> instance.
        /// </summary>
        public DefinitionTemplatesDeploymentFragmentFileUris()
        {

        }
    }
    /// List of key-value pairs containing the deployment fragment file IDs defined in the package manifest.
    public partial interface IDefinitionTemplatesDeploymentFragmentFileUris :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IAssociativeArray<string>
    {

    }
    /// List of key-value pairs containing the deployment fragment file IDs defined in the package manifest.
    internal partial interface IDefinitionTemplatesDeploymentFragmentFileUrisInternal

    {

    }
}