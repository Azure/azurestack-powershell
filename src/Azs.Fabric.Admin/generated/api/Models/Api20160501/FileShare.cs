namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Object that contains properties of the file share resource.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.DoNotFormat]
    public partial class FileShare :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFileShare,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFileShareInternal,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.Resource();

        /// <summary>Associated volume ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string AssociatedVolume { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFileShareModelInternal)Property).AssociatedVolume; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFileShareModelInternal)Property).AssociatedVolume = value ?? null; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id; }

        /// <summary>The region where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFileShareModel Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFileShareInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.FileShareModel()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFileShareModel _property;

        /// <summary>Properties of a file share resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFileShareModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.FileShareModel()); set => this._property = value; }

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type; }

        /// <summary>The UNCPath for the fileshare.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string UncPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFileShareModelInternal)Property).UncPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFileShareModelInternal)Property).UncPath = value ?? null; }

        /// <summary>Creates an new <see cref="FileShare" /> instance.</summary>
        public FileShare()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Object that contains properties of the file share resource.
    public partial interface IFileShare :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource
    {
        /// <summary>Associated volume ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Associated volume ID.",
        SerializedName = @"associatedVolume",
        PossibleTypes = new [] { typeof(string) })]
        string AssociatedVolume { get; set; }
        /// <summary>The UNCPath for the fileshare.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The UNCPath for the fileshare.",
        SerializedName = @"uncPath",
        PossibleTypes = new [] { typeof(string) })]
        string UncPath { get; set; }

    }
    /// Object that contains properties of the file share resource.
    internal partial interface IFileShareInternal :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal
    {
        /// <summary>Associated volume ID.</summary>
        string AssociatedVolume { get; set; }
        /// <summary>Properties of a file share resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFileShareModel Property { get; set; }
        /// <summary>The UNCPath for the fileshare.</summary>
        string UncPath { get; set; }

    }
}