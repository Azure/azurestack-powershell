namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Properties of a gallery item.</summary>
    public partial class GalleryItemProperties1 :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal
    {

        /// <summary>Backing field for <see cref="AdditionalProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesAdditionalProperties _additionalProperty;

        /// <summary>List of additional properties provided for the item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesAdditionalProperties AdditionalProperty { get => (this._additionalProperty = this._additionalProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.GalleryItemPropertiesAdditionalProperties()); }

        /// <summary>Backing field for <see cref="Artifact" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IArtifact[] _artifact;

        /// <summary>List of artifacts for the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IArtifact[] Artifact { get => this._artifact; }

        /// <summary>Backing field for <see cref="CategoryId" /> property.</summary>
        private string[] _categoryId;

        /// <summary>List of category IDs the gallery item belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string[] CategoryId { get => this._categoryId; }

        /// <summary>Backing field for <see cref="ChangedTime" /> property.</summary>
        private global::System.DateTime? _changedTime;

        /// <summary>Last update time of gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? ChangedTime { get => this._changedTime; set => this._changedTime = value; }

        /// <summary>Backing field for <see cref="CreatedTime" /> property.</summary>
        private global::System.DateTime? _createdTime;

        /// <summary>The date and time that the gallery item was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedTime { get => this._createdTime; set => this._createdTime = value; }

        /// <summary>Backing field for <see cref="DefinitionTemplate" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplates _definitionTemplate;

        /// <summary>Definition template for gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplates DefinitionTemplate { get => (this._definitionTemplate = this._definitionTemplate ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplates()); }

        /// <summary>Default deployment template ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string DefinitionTemplateDefaultDeploymentTemplateId { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)DefinitionTemplate).DefaultDeploymentTemplateId; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)DefinitionTemplate).DefaultDeploymentTemplateId = value ?? null; }

        /// <summary>
        /// List of key-value pairs containing the deployment fragment file IDs defined in the package manifest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris DefinitionTemplateDeploymentFragmentFileUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)DefinitionTemplate).DeploymentFragmentFileUri; }

        /// <summary>
        /// List of key-value containing the deployment template file IDs defined in the package manifest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris DefinitionTemplateDeploymentTemplateFileUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)DefinitionTemplate).DeploymentTemplateFileUri; }

        /// <summary>UI definition file URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string DefinitionTemplateUiDefinitionFileUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)DefinitionTemplate).UiDefinitionFileUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)DefinitionTemplate).UiDefinitionFileUri = value ?? null; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The description of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IFilter[] _filter;

        /// <summary>List of filters for the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IFilter[] Filter { get => this._filter; }

        /// <summary>Backing field for <see cref="IconFileUri" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUris _iconFileUri;

        /// <summary>URIs to icon files.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUris IconFileUri { get => (this._iconFileUri = this._iconFileUri ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.GalleryItemPropertiesIconFileUris()); }

        /// <summary>URI to the hero icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string IconFileUriHero { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUrisInternal)IconFileUri).Hero; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUrisInternal)IconFileUri).Hero = value ?? null; }

        /// <summary>URI to the large icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string IconFileUriLarge { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUrisInternal)IconFileUri).Large; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUrisInternal)IconFileUri).Large = value ?? null; }

        /// <summary>URI to the medium icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string IconFileUriMedium { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUrisInternal)IconFileUri).Medium; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUrisInternal)IconFileUri).Medium = value ?? null; }

        /// <summary>URI to the small icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string IconFileUriSmall { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUrisInternal)IconFileUri).Small; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUrisInternal)IconFileUri).Small = value ?? null; }

        /// <summary>URI to the wide icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string IconFileUriWide { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUrisInternal)IconFileUri).Wide; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUrisInternal)IconFileUri).Wide = value ?? null; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private string _identity;

        /// <summary>Identity of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Identity { get => this._identity; set => this._identity = value; }

        /// <summary>Backing field for <see cref="Image" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImageGroup[] _image;

        /// <summary>List of images.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImageGroup[] Image { get => this._image; }

        /// <summary>Backing field for <see cref="ItemDisplayName" /> property.</summary>
        private string _itemDisplayName;

        /// <summary>Displayed name in the portal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string ItemDisplayName { get => this._itemDisplayName; set => this._itemDisplayName = value; }

        /// <summary>Backing field for <see cref="ItemName" /> property.</summary>
        private string _itemName;

        /// <summary>The display name for the gallery item, for the locale of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string ItemName { get => this._itemName; set => this._itemName = value; }

        /// <summary>Backing field for <see cref="ItemType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Support.GalleryItemMenuReferenceType? _itemType;

        /// <summary>Describes the type of the gallery item, either GalleryItem or ItemGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Support.GalleryItemMenuReferenceType? ItemType { get => this._itemType; set => this._itemType = value; }

        /// <summary>Backing field for <see cref="Link" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.ILinkProperties[] _link;

        /// <summary>Links provided for the item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.ILinkProperties[] Link { get => this._link; }

        /// <summary>Backing field for <see cref="LongSummary" /> property.</summary>
        private string _longSummary;

        /// <summary>Long summary of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string LongSummary { get => this._longSummary; set => this._longSummary = value; }

        /// <summary>Backing field for <see cref="MarketingMaterial" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IMarketingMaterial _marketingMaterial;

        /// <summary>Marketing materials for the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IMarketingMaterial MarketingMaterial { get => (this._marketingMaterial = this._marketingMaterial ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.MarketingMaterial()); set => this._marketingMaterial = value; }

        /// <summary>URI to educational material.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string MarketingMaterialLearnUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IMarketingMaterialInternal)MarketingMaterial).LearnUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IMarketingMaterialInternal)MarketingMaterial).LearnUri = value ?? null; }

        /// <summary>Path to the marketing site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public string MarketingMaterialPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IMarketingMaterialInternal)MarketingMaterial).Path; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IMarketingMaterialInternal)MarketingMaterial).Path = value ?? null; }

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenProperty _metadata;

        /// <summary>Custom item metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenProperty Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.OpenProperty()); }

        /// <summary>Dictionary of dynamic properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyProperties MetadataProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyInternal)Metadata).Property; }

        /// <summary>Internal Acessors for AdditionalProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesAdditionalProperties Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.AdditionalProperty { get => (this._additionalProperty = this._additionalProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.GalleryItemPropertiesAdditionalProperties()); set { {_additionalProperty = value;} } }

        /// <summary>Internal Acessors for Artifact</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IArtifact[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.Artifact { get => this._artifact; set { {_artifact = value;} } }

        /// <summary>Internal Acessors for CategoryId</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.CategoryId { get => this._categoryId; set { {_categoryId = value;} } }

        /// <summary>Internal Acessors for DefinitionTemplate</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplates Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.DefinitionTemplate { get => (this._definitionTemplate = this._definitionTemplate ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplates()); set { {_definitionTemplate = value;} } }

        /// <summary>Internal Acessors for DefinitionTemplateDeploymentFragmentFileUri</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.DefinitionTemplateDeploymentFragmentFileUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)DefinitionTemplate).DeploymentFragmentFileUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)DefinitionTemplate).DeploymentFragmentFileUri = value; }

        /// <summary>Internal Acessors for DefinitionTemplateDeploymentTemplateFileUri</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.DefinitionTemplateDeploymentTemplateFileUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)DefinitionTemplate).DeploymentTemplateFileUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)DefinitionTemplate).DeploymentTemplateFileUri = value; }

        /// <summary>Internal Acessors for Filter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IFilter[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.Filter { get => this._filter; set { {_filter = value;} } }

        /// <summary>Internal Acessors for IconFileUri</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUris Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.IconFileUri { get => (this._iconFileUri = this._iconFileUri ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.GalleryItemPropertiesIconFileUris()); set { {_iconFileUri = value;} } }

        /// <summary>Internal Acessors for Image</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImageGroup[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.Image { get => this._image; set { {_image = value;} } }

        /// <summary>Internal Acessors for Link</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.ILinkProperties[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.Link { get => this._link; set { {_link = value;} } }

        /// <summary>Internal Acessors for MarketingMaterial</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IMarketingMaterial Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.MarketingMaterial { get => (this._marketingMaterial = this._marketingMaterial ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.MarketingMaterial()); set { {_marketingMaterial = value;} } }

        /// <summary>Internal Acessors for Metadata</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenProperty Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.OpenProperty()); set { {_metadata = value;} } }

        /// <summary>Internal Acessors for MetadataProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyProperties Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.MetadataProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyInternal)Metadata).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOpenPropertyInternal)Metadata).Property = value; }

        /// <summary>Internal Acessors for Product</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProduct[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.Product { get => this._product; set { {_product = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.GalleryItemProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ScreenshotUri</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties1Internal.ScreenshotUri { get => this._screenshotUri; set { {_screenshotUri = value;} } }

        /// <summary>Backing field for <see cref="Product" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProduct[] _product;

        /// <summary>List of products.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IProduct[] Product { get => this._product; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties _property;

        /// <summary>List of properties provided for the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.GalleryItemProperties()); }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>The publisher of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Backing field for <see cref="PublisherDisplayName" /> property.</summary>
        private string _publisherDisplayName;

        /// <summary>Display name of the publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string PublisherDisplayName { get => this._publisherDisplayName; set => this._publisherDisplayName = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>Resource group name the gallery item belongs too.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="ScreenshotUri" /> property.</summary>
        private string[] _screenshotUri;

        /// <summary>List of screenshot image URIs provided for the item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string[] ScreenshotUri { get => this._screenshotUri; }

        /// <summary>Backing field for <see cref="Summary" /> property.</summary>
        private string _summary;

        /// <summary>Short summary of the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Summary { get => this._summary; set => this._summary = value; }

        /// <summary>Backing field for <see cref="UiDefinitionUri" /> property.</summary>
        private string _uiDefinitionUri;

        /// <summary>
        /// The URL of the view definition object that defines the UI information that is used when an instance of the gallery item
        /// resource definition is created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string UiDefinitionUri { get => this._uiDefinitionUri; set => this._uiDefinitionUri = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>The version identifier of the gallery item, in Major.Minor.Build format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="GalleryItemProperties1" /> instance.</summary>
        public GalleryItemProperties1()
        {

        }
    }
    /// Properties of a gallery item.
    public partial interface IGalleryItemProperties1 :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
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
        /// <summary>List of properties provided for the gallery item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of properties provided for the gallery item.",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties Property { get;  }
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
    internal partial interface IGalleryItemProperties1Internal

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
        /// <summary>List of properties provided for the gallery item.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemProperties Property { get; set; }
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