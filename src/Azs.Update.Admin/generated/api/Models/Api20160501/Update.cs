namespace Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Extensions;

    /// <summary>Information pertaining to an update.</summary>
    public partial class Update :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.Resource();

        /// <summary>Description of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).Description = value ?? null; }

        /// <summary>Name of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.FormatTable(Index = 1, Width = 30)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).DisplayName = value ?? null; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Id; }

        /// <summary>Date update was installed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public global::System.DateTime? InstalledDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).InstalledDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).InstalledDate = value ?? default(global::System.DateTime); }

        /// <summary>Link to the KB article about the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string KbLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).KbLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).KbLink = value ?? null; }

        /// <summary>Region location of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.FormatTable(Index = 0, Width = 15)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModel Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateModel()); set { {_property = value;} } }

        /// <summary>The minimum OEM version required to install.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string MinOemVersionRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).MinOemVersionRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).MinOemVersionRequired = value ?? null; }

        /// <summary>The minimum version required to install.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string MinVersionRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).MinVersionRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).MinVersionRequired = value ?? null; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.FormatTable(Index = 2, Width = 40)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Name; }

        /// <summary>OEM version of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string OemVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).OemVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).OemVersion = value ?? null; }

        /// <summary>Path to the update package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string PackagePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).PackagePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).PackagePath = value ?? null; }

        /// <summary>Size of update package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public long? PackageSizeInMb { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).PackageSizeInMb; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).PackageSizeInMb = value ?? default(long); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModel _property;

        /// <summary>Properties of an update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateModel()); set => this._property = value; }

        /// <summary>Publisher of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.FormatTable(Index = 4, Width = 15)]
        public string Publisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).Publisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).Publisher = value ?? null; }

        /// <summary>Current state of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.FormatTable(Index = 3, Width = 20)]
        public Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateState? State { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).State = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateState)""); }

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Type; }

        /// <summary>Version of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal)Property).Version = value ?? null; }

        /// <summary>Creates an new <see cref="Update" /> instance.</summary>
        public Update()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Information pertaining to an update.
    public partial interface IUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResource
    {
        /// <summary>Description of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the update.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Name of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the update.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Date update was installed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Date update was installed.",
        SerializedName = @"installedDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? InstalledDate { get; set; }
        /// <summary>Link to the KB article about the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link to the KB article about the update.",
        SerializedName = @"kbLink",
        PossibleTypes = new [] { typeof(string) })]
        string KbLink { get; set; }
        /// <summary>The minimum OEM version required to install.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The minimum OEM version required to install.",
        SerializedName = @"minOemVersionRequired",
        PossibleTypes = new [] { typeof(string) })]
        string MinOemVersionRequired { get; set; }
        /// <summary>The minimum version required to install.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The minimum version required to install.",
        SerializedName = @"minVersionRequired",
        PossibleTypes = new [] { typeof(string) })]
        string MinVersionRequired { get; set; }
        /// <summary>OEM version of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"OEM version of the update.",
        SerializedName = @"oemVersion",
        PossibleTypes = new [] { typeof(string) })]
        string OemVersion { get; set; }
        /// <summary>Path to the update package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path to the update package.",
        SerializedName = @"packagePath",
        PossibleTypes = new [] { typeof(string) })]
        string PackagePath { get; set; }
        /// <summary>Size of update package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Size of update package.",
        SerializedName = @"packageSizeInMb",
        PossibleTypes = new [] { typeof(long) })]
        long? PackageSizeInMb { get; set; }
        /// <summary>Publisher of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Publisher of the update.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }
        /// <summary>Current state of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current state of the update.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateState) })]
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateState? State { get; set; }
        /// <summary>Version of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of the update.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Information pertaining to an update.
    internal partial interface IUpdateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal
    {
        /// <summary>Description of the update.</summary>
        string Description { get; set; }
        /// <summary>Name of the update.</summary>
        string DisplayName { get; set; }
        /// <summary>Date update was installed.</summary>
        global::System.DateTime? InstalledDate { get; set; }
        /// <summary>Link to the KB article about the update.</summary>
        string KbLink { get; set; }
        /// <summary>The minimum OEM version required to install.</summary>
        string MinOemVersionRequired { get; set; }
        /// <summary>The minimum version required to install.</summary>
        string MinVersionRequired { get; set; }
        /// <summary>OEM version of the update.</summary>
        string OemVersion { get; set; }
        /// <summary>Path to the update package.</summary>
        string PackagePath { get; set; }
        /// <summary>Size of update package.</summary>
        long? PackageSizeInMb { get; set; }
        /// <summary>Properties of an update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModel Property { get; set; }
        /// <summary>Publisher of the update.</summary>
        string Publisher { get; set; }
        /// <summary>Current state of the update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateState? State { get; set; }
        /// <summary>Version of the update.</summary>
        string Version { get; set; }

    }
}