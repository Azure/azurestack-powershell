namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Holds UI definition file Uri and deployment template file URIs.</summary>
    public partial class DefinitionTemplates :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplates,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal
    {

        /// <summary>Backing field for <see cref="DefaultDeploymentTemplateId" /> property.</summary>
        private string _defaultDeploymentTemplateId;

        /// <summary>Default deployment template ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string DefaultDeploymentTemplateId { get => this._defaultDeploymentTemplateId; set => this._defaultDeploymentTemplateId = value; }

        /// <summary>Backing field for <see cref="DeploymentFragmentFileUri" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris _deploymentFragmentFileUri;

        /// <summary>
        /// List of key-value pairs containing the deployment fragment file IDs defined in the package manifest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris DeploymentFragmentFileUri { get => (this._deploymentFragmentFileUri = this._deploymentFragmentFileUri ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplatesDeploymentFragmentFileUris()); }

        /// <summary>Backing field for <see cref="DeploymentTemplateFileUri" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris _deploymentTemplateFileUri;

        /// <summary>
        /// List of key-value containing the deployment template file IDs defined in the package manifest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris DeploymentTemplateFileUri { get => (this._deploymentTemplateFileUri = this._deploymentTemplateFileUri ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplatesDeploymentTemplateFileUris()); }

        /// <summary>Internal Acessors for DeploymentFragmentFileUri</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal.DeploymentFragmentFileUri { get => (this._deploymentFragmentFileUri = this._deploymentFragmentFileUri ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplatesDeploymentFragmentFileUris()); set { {_deploymentFragmentFileUri = value;} } }

        /// <summary>Internal Acessors for DeploymentTemplateFileUri</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal.DeploymentTemplateFileUri { get => (this._deploymentTemplateFileUri = this._deploymentTemplateFileUri ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplatesDeploymentTemplateFileUris()); set { {_deploymentTemplateFileUri = value;} } }

        /// <summary>Backing field for <see cref="UiDefinitionFileUri" /> property.</summary>
        private string _uiDefinitionFileUri;

        /// <summary>UI definition file URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string UiDefinitionFileUri { get => this._uiDefinitionFileUri; set => this._uiDefinitionFileUri = value; }

        /// <summary>Creates an new <see cref="DefinitionTemplates" /> instance.</summary>
        public DefinitionTemplates()
        {

        }
    }
    /// Holds UI definition file Uri and deployment template file URIs.
    public partial interface IDefinitionTemplates :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Default deployment template ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default deployment template ID.",
        SerializedName = @"defaultDeploymentTemplateId",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultDeploymentTemplateId { get; set; }
        /// <summary>
        /// List of key-value pairs containing the deployment fragment file IDs defined in the package manifest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of key-value pairs containing the deployment fragment file IDs defined in the package manifest.",
        SerializedName = @"deploymentFragmentFileUris",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris DeploymentFragmentFileUri { get;  }
        /// <summary>
        /// List of key-value containing the deployment template file IDs defined in the package manifest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of key-value containing the deployment template file IDs defined in the package manifest.",
        SerializedName = @"deploymentTemplateFileUris",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris DeploymentTemplateFileUri { get;  }
        /// <summary>UI definition file URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"UI definition file URI.",
        SerializedName = @"uiDefinitionFileUri",
        PossibleTypes = new [] { typeof(string) })]
        string UiDefinitionFileUri { get; set; }

    }
    /// Holds UI definition file Uri and deployment template file URIs.
    internal partial interface IDefinitionTemplatesInternal

    {
        /// <summary>Default deployment template ID.</summary>
        string DefaultDeploymentTemplateId { get; set; }
        /// <summary>
        /// List of key-value pairs containing the deployment fragment file IDs defined in the package manifest.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris DeploymentFragmentFileUri { get; set; }
        /// <summary>
        /// List of key-value containing the deployment template file IDs defined in the package manifest.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris DeploymentTemplateFileUri { get; set; }
        /// <summary>UI definition file URI.</summary>
        string UiDefinitionFileUri { get; set; }

    }
}