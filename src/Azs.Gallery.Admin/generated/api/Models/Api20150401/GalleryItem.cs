namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Properties of a gallery item.</summary>
    public partial class GalleryItem :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItem,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.Resource();

        /// <summary>List of additional properties provided for the item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesAdditionalProperties AdditionalProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).AdditionalProperty; }

        /// <summary>List of artifacts for the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IArtifact[] Artifact { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Artifact; }

        /// <summary>List of category IDs the gallery item belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string[] CategoryId { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).CategoryId; }

        /// <summary>Last update time of gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public global::System.DateTime? ChangedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).ChangedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).ChangedTime = value ?? default(global::System.DateTime); }

        /// <summary>The date and time that the gallery item was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public global::System.DateTime? CreatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).CreatedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).CreatedTime = value ?? default(global::System.DateTime); }

        /// <summary>Default deployment template ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string DefinitionTemplateDefaultDeploymentTemplateId { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).DefinitionTemplateDefaultDeploymentTemplateId; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).DefinitionTemplateDefaultDeploymentTemplateId = value ?? null; }

        /// <summary>
        /// List of key-value pairs containing the deployment fragment file IDs defined in the package manifest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris DefinitionTemplateDeploymentFragmentFileUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).DefinitionTemplateDeploymentFragmentFileUri; }

        /// <summary>
        /// List of key-value containing the deployment template file IDs defined in the package manifest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris DefinitionTemplateDeploymentTemplateFileUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).DefinitionTemplateDeploymentTemplateFileUri; }

        /// <summary>UI definition file URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string DefinitionTemplateUiDefinitionFileUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).DefinitionTemplateUiDefinitionFileUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).DefinitionTemplateUiDefinitionFileUri = value ?? null; }

        /// <summary>The description of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Description = value ?? null; }

        /// <summary>List of filters for the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IFilter[] Filter { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Filter; }

        /// <summary>List of properties provided for the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties GalleryItemProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Property; }

        /// <summary>URI to the hero icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string IconFileUriHero { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).IconFileUriHero; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).IconFileUriHero = value ?? null; }

        /// <summary>URI to the large icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string IconFileUriLarge { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).IconFileUriLarge; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).IconFileUriLarge = value ?? null; }

        /// <summary>URI to the medium icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string IconFileUriMedium { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).IconFileUriMedium; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).IconFileUriMedium = value ?? null; }

        /// <summary>URI to the small icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string IconFileUriSmall { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).IconFileUriSmall; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).IconFileUriSmall = value ?? null; }

        /// <summary>URI to the wide icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string IconFileUriWide { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).IconFileUriWide; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).IconFileUriWide = value ?? null; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Id; }

        /// <summary>Identity of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string Identity { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Identity; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Identity = value ?? null; }

        /// <summary>List of images.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImageGroup[] Image { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Image; }

        /// <summary>Displayed name in the portal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.FormatTable(Index = 4)]
        public string ItemDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).ItemDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).ItemDisplayName = value ?? null; }

        /// <summary>The display name for the gallery item, for the locale of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.FormatTable(Index = 3)]
        public string ItemName { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).ItemName; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).ItemName = value ?? null; }

        /// <summary>Describes the type of the gallery item, either GalleryItem or ItemGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Support.GalleryItemMenuReferenceType? ItemType { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).ItemType; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).ItemType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Support.GalleryItemMenuReferenceType)""); }

        /// <summary>Links provided for the item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.ILinkProperties[] Link { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Link; }

        /// <summary>Location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Location; }

        /// <summary>Long summary of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string LongSummary { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).LongSummary; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).LongSummary = value ?? null; }

        /// <summary>URI to educational material.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string MarketingMaterialLearnUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).MarketingMaterialLearnUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).MarketingMaterialLearnUri = value ?? null; }

        /// <summary>Path to the marketing site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string MarketingMaterialPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).MarketingMaterialPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).MarketingMaterialPath = value ?? null; }

        /// <summary>Dictionary of dynamic properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyProperties MetadataProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).MetadataProperty; }

        /// <summary>Internal Acessors for AdditionalProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesAdditionalProperties Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.AdditionalProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).AdditionalProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).AdditionalProperty = value; }

        /// <summary>Internal Acessors for Artifact</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IArtifact[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.Artifact { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Artifact; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Artifact = value; }

        /// <summary>Internal Acessors for CategoryId</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.CategoryId { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).CategoryId; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).CategoryId = value; }

        /// <summary>Internal Acessors for DefinitionTemplate</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplates Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.DefinitionTemplate { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).DefinitionTemplate; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).DefinitionTemplate = value; }

        /// <summary>Internal Acessors for DefinitionTemplateDeploymentFragmentFileUri</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.DefinitionTemplateDeploymentFragmentFileUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).DefinitionTemplateDeploymentFragmentFileUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).DefinitionTemplateDeploymentFragmentFileUri = value; }

        /// <summary>Internal Acessors for DefinitionTemplateDeploymentTemplateFileUri</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.DefinitionTemplateDeploymentTemplateFileUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).DefinitionTemplateDeploymentTemplateFileUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).DefinitionTemplateDeploymentTemplateFileUri = value; }

        /// <summary>Internal Acessors for Filter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IFilter[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.Filter { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Filter; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Filter = value; }

        /// <summary>Internal Acessors for GalleryItemProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.GalleryItemProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Property = value; }

        /// <summary>Internal Acessors for IconFileUri</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUris Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.IconFileUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).IconFileUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).IconFileUri = value; }

        /// <summary>Internal Acessors for Image</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImageGroup[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.Image { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Image; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Image = value; }

        /// <summary>Internal Acessors for Link</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.ILinkProperties[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.Link { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Link; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Link = value; }

        /// <summary>Internal Acessors for MarketingMaterial</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IMarketingMaterial Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.MarketingMaterial { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).MarketingMaterial; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).MarketingMaterial = value; }

        /// <summary>Internal Acessors for Metadata</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenProperty Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.Metadata { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Metadata; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Metadata = value; }

        /// <summary>Internal Acessors for MetadataProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyProperties Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.MetadataProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).MetadataProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).MetadataProperty = value; }

        /// <summary>Internal Acessors for Product</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProduct[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.Product { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Product; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Product = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1 Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.GalleryItemProperties1()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ScreenshotUri</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemInternal.ScreenshotUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).ScreenshotUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).ScreenshotUri = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal.Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Location = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Tag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceTags Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal.Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Tag = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Type = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Name; }

        /// <summary>List of products.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProduct[] Product { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Product; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1 _property;

        /// <summary>Properties of a gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1 Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.GalleryItemProperties1()); set => this._property = value; }

        /// <summary>The publisher of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.FormatTable(Index = 1)]
        public string Publisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Publisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Publisher = value ?? null; }

        /// <summary>Display name of the publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.FormatTable(Index = 2)]
        public string PublisherDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).PublisherDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).PublisherDisplayName = value ?? null; }

        /// <summary>Resource group name the gallery item belongs too.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string ResourceGroupName { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).ResourceGroupName; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).ResourceGroupName = value ?? null; }

        /// <summary>List of screenshot image URIs provided for the item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string[] ScreenshotUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).ScreenshotUri; }

        /// <summary>Short summary of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.FormatTable(Index = 6)]
        public string Summary { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Summary; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Summary = value ?? null; }

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Tag; }

        /// <summary>Type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal)__resource).Type; }

        /// <summary>
        /// The URL of the view definition object that defines the UI information that is used when an instance of the gallery item
        /// resource definition is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.DoNotFormat]
        public string UiDefinitionUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).UiDefinitionUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).UiDefinitionUri = value ?? null; }

        /// <summary>The version identifier of the gallery item, in Major.Minor.Build format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.FormatTable(Index = 5)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal)Property).Version = value ?? null; }

        /// <summary>Creates an new <see cref="GalleryItem" /> instance.</summary>
        public GalleryItem()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Properties of a gallery item.
    public partial interface IGalleryItem :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResource
    {
        /// <summary>List of additional properties provided for the item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of additional properties provided for the item.",
        SerializedName = @"additionalProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesAdditionalProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesAdditionalProperties AdditionalProperty { get;  }
        /// <summary>List of artifacts for the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of artifacts for the gallery item.",
        SerializedName = @"artifacts",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IArtifact) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IArtifact[] Artifact { get;  }
        /// <summary>List of category IDs the gallery item belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of category IDs the gallery item belongs to.",
        SerializedName = @"categoryIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] CategoryId { get;  }
        /// <summary>Last update time of gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Last update time of gallery item.",
        SerializedName = @"changedTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ChangedTime { get; set; }
        /// <summary>The date and time that the gallery item was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The date and time that the gallery item was created.",
        SerializedName = @"createdTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedTime { get; set; }
        /// <summary>Default deployment template ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default deployment template ID.",
        SerializedName = @"defaultDeploymentTemplateId",
        PossibleTypes = new [] { typeof(string) })]
        string DefinitionTemplateDefaultDeploymentTemplateId { get; set; }
        /// <summary>
        /// List of key-value pairs containing the deployment fragment file IDs defined in the package manifest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of key-value pairs containing the deployment fragment file IDs defined in the package manifest.",
        SerializedName = @"deploymentFragmentFileUris",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris DefinitionTemplateDeploymentFragmentFileUri { get;  }
        /// <summary>
        /// List of key-value containing the deployment template file IDs defined in the package manifest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of key-value containing the deployment template file IDs defined in the package manifest.",
        SerializedName = @"deploymentTemplateFileUris",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris DefinitionTemplateDeploymentTemplateFileUri { get;  }
        /// <summary>UI definition file URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"UI definition file URI.",
        SerializedName = @"uiDefinitionFileUri",
        PossibleTypes = new [] { typeof(string) })]
        string DefinitionTemplateUiDefinitionFileUri { get; set; }
        /// <summary>The description of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description of the gallery item.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>List of filters for the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of filters for the gallery item.",
        SerializedName = @"filters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IFilter) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IFilter[] Filter { get;  }
        /// <summary>List of properties provided for the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of properties provided for the gallery item.",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties GalleryItemProperty { get;  }
        /// <summary>URI to the hero icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the hero icon.",
        SerializedName = @"hero",
        PossibleTypes = new [] { typeof(string) })]
        string IconFileUriHero { get; set; }
        /// <summary>URI to the large icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the large icon.",
        SerializedName = @"large",
        PossibleTypes = new [] { typeof(string) })]
        string IconFileUriLarge { get; set; }
        /// <summary>URI to the medium icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the medium icon.",
        SerializedName = @"medium",
        PossibleTypes = new [] { typeof(string) })]
        string IconFileUriMedium { get; set; }
        /// <summary>URI to the small icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the small icon.",
        SerializedName = @"small",
        PossibleTypes = new [] { typeof(string) })]
        string IconFileUriSmall { get; set; }
        /// <summary>URI to the wide icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the wide icon.",
        SerializedName = @"wide",
        PossibleTypes = new [] { typeof(string) })]
        string IconFileUriWide { get; set; }
        /// <summary>Identity of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity of the gallery item.",
        SerializedName = @"identity",
        PossibleTypes = new [] { typeof(string) })]
        string Identity { get; set; }
        /// <summary>List of images.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of images.",
        SerializedName = @"images",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImageGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImageGroup[] Image { get;  }
        /// <summary>Displayed name in the portal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Displayed name in the portal.",
        SerializedName = @"itemDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string ItemDisplayName { get; set; }
        /// <summary>The display name for the gallery item, for the locale of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name for the gallery item, for the locale of the request.",
        SerializedName = @"itemName",
        PossibleTypes = new [] { typeof(string) })]
        string ItemName { get; set; }
        /// <summary>Describes the type of the gallery item, either GalleryItem or ItemGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Describes the type of the gallery item, either GalleryItem or ItemGroup.",
        SerializedName = @"itemType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Support.GalleryItemMenuReferenceType) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Support.GalleryItemMenuReferenceType? ItemType { get; set; }
        /// <summary>Links provided for the item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Links provided for the item.",
        SerializedName = @"links",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.ILinkProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.ILinkProperties[] Link { get;  }
        /// <summary>Long summary of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Long summary of the gallery item.",
        SerializedName = @"longSummary",
        PossibleTypes = new [] { typeof(string) })]
        string LongSummary { get; set; }
        /// <summary>URI to educational material.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to educational material.",
        SerializedName = @"learnUri",
        PossibleTypes = new [] { typeof(string) })]
        string MarketingMaterialLearnUri { get; set; }
        /// <summary>Path to the marketing site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path to the marketing site.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string MarketingMaterialPath { get; set; }
        /// <summary>Dictionary of dynamic properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Dictionary of dynamic properties.",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyProperties MetadataProperty { get;  }
        /// <summary>List of products.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of products.",
        SerializedName = @"products",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProduct) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProduct[] Product { get;  }
        /// <summary>The publisher of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The publisher of the gallery item.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }
        /// <summary>Display name of the publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the publisher.",
        SerializedName = @"publisherDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string PublisherDisplayName { get; set; }
        /// <summary>Resource group name the gallery item belongs too.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource group name the gallery item belongs too.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>List of screenshot image URIs provided for the item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of screenshot image URIs provided for the item.",
        SerializedName = @"screenshotUris",
        PossibleTypes = new [] { typeof(string) })]
        string[] ScreenshotUri { get;  }
        /// <summary>Short summary of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Short summary of the gallery item.",
        SerializedName = @"summary",
        PossibleTypes = new [] { typeof(string) })]
        string Summary { get; set; }
        /// <summary>
        /// The URL of the view definition object that defines the UI information that is used when an instance of the gallery item
        /// resource definition is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL of the view definition object that defines the UI information that is used when an instance of the gallery item resource definition is created.",
        SerializedName = @"uiDefinitionUri",
        PossibleTypes = new [] { typeof(string) })]
        string UiDefinitionUri { get; set; }
        /// <summary>The version identifier of the gallery item, in Major.Minor.Build format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version identifier of the gallery item, in Major.Minor.Build format.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Properties of a gallery item.
    internal partial interface IGalleryItemInternal :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IResourceInternal
    {
        /// <summary>List of additional properties provided for the item.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesAdditionalProperties AdditionalProperty { get; set; }
        /// <summary>List of artifacts for the gallery item.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IArtifact[] Artifact { get; set; }
        /// <summary>List of category IDs the gallery item belongs to.</summary>
        string[] CategoryId { get; set; }
        /// <summary>Last update time of gallery item.</summary>
        global::System.DateTime? ChangedTime { get; set; }
        /// <summary>The date and time that the gallery item was created.</summary>
        global::System.DateTime? CreatedTime { get; set; }
        /// <summary>Definition template for gallery item.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplates DefinitionTemplate { get; set; }
        /// <summary>Default deployment template ID.</summary>
        string DefinitionTemplateDefaultDeploymentTemplateId { get; set; }
        /// <summary>
        /// List of key-value pairs containing the deployment fragment file IDs defined in the package manifest.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris DefinitionTemplateDeploymentFragmentFileUri { get; set; }
        /// <summary>
        /// List of key-value containing the deployment template file IDs defined in the package manifest.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris DefinitionTemplateDeploymentTemplateFileUri { get; set; }
        /// <summary>UI definition file URI.</summary>
        string DefinitionTemplateUiDefinitionFileUri { get; set; }
        /// <summary>The description of the gallery item.</summary>
        string Description { get; set; }
        /// <summary>List of filters for the gallery item.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IFilter[] Filter { get; set; }
        /// <summary>List of properties provided for the gallery item.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties GalleryItemProperty { get; set; }
        /// <summary>URIs to icon files.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUris IconFileUri { get; set; }
        /// <summary>URI to the hero icon.</summary>
        string IconFileUriHero { get; set; }
        /// <summary>URI to the large icon.</summary>
        string IconFileUriLarge { get; set; }
        /// <summary>URI to the medium icon.</summary>
        string IconFileUriMedium { get; set; }
        /// <summary>URI to the small icon.</summary>
        string IconFileUriSmall { get; set; }
        /// <summary>URI to the wide icon.</summary>
        string IconFileUriWide { get; set; }
        /// <summary>Identity of the gallery item.</summary>
        string Identity { get; set; }
        /// <summary>List of images.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImageGroup[] Image { get; set; }
        /// <summary>Displayed name in the portal.</summary>
        string ItemDisplayName { get; set; }
        /// <summary>The display name for the gallery item, for the locale of the request.</summary>
        string ItemName { get; set; }
        /// <summary>Describes the type of the gallery item, either GalleryItem or ItemGroup.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Support.GalleryItemMenuReferenceType? ItemType { get; set; }
        /// <summary>Links provided for the item.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.ILinkProperties[] Link { get; set; }
        /// <summary>Long summary of the gallery item.</summary>
        string LongSummary { get; set; }
        /// <summary>Marketing materials for the gallery item.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IMarketingMaterial MarketingMaterial { get; set; }
        /// <summary>URI to educational material.</summary>
        string MarketingMaterialLearnUri { get; set; }
        /// <summary>Path to the marketing site.</summary>
        string MarketingMaterialPath { get; set; }
        /// <summary>Custom item metadata.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenProperty Metadata { get; set; }
        /// <summary>Dictionary of dynamic properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyProperties MetadataProperty { get; set; }
        /// <summary>List of products.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProduct[] Product { get; set; }
        /// <summary>Properties of a gallery item.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1 Property { get; set; }
        /// <summary>The publisher of the gallery item.</summary>
        string Publisher { get; set; }
        /// <summary>Display name of the publisher.</summary>
        string PublisherDisplayName { get; set; }
        /// <summary>Resource group name the gallery item belongs too.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>List of screenshot image URIs provided for the item.</summary>
        string[] ScreenshotUri { get; set; }
        /// <summary>Short summary of the gallery item.</summary>
        string Summary { get; set; }
        /// <summary>
        /// The URL of the view definition object that defines the UI information that is used when an instance of the gallery item
        /// resource definition is created.
        /// </summary>
        string UiDefinitionUri { get; set; }
        /// <summary>The version identifier of the gallery item, in Major.Minor.Build format.</summary>
        string Version { get; set; }

    }
}