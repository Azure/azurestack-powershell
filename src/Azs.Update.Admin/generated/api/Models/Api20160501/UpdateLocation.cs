namespace Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Extensions;

    /// <summary>Information related to a location's update status.</summary>
    public partial class UpdateLocation :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocation,
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.Resource();

        /// <summary>Current OEM version of your AzureStack deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.FormatTable(Index = 2, Width = 20)]
        public string CurrentOemVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModelInternal)Property).CurrentOemVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModelInternal)Property).CurrentOemVersion = value ?? null; }

        /// <summary>Current version of your AzureStack deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.FormatTable(Index = 1, Width = 20)]
        public string CurrentVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModelInternal)Property).CurrentVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModelInternal)Property).CurrentVersion = value ?? null; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Id; }

        /// <summary>Date of last update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public global::System.DateTime? LastUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModelInternal)Property).LastUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModelInternal)Property).LastUpdated = value ?? default(global::System.DateTime); }

        /// <summary>Region location of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModel Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateLocationModel()); set { {_property = value;} } }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.FormatTable(Index = 0, Width = 20)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModel _property;

        /// <summary>Model which holds information related to update location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateLocationModel()); set => this._property = value; }

        /// <summary>State with respect to the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.FormatTable(Index = 3, Width = 20)]
        public Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState? State { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModelInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModelInternal)Property).State = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState)""); }

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="UpdateLocation" /> instance.</summary>
        public UpdateLocation()
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
    /// Information related to a location's update status.
    public partial interface IUpdateLocation :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResource
    {
        /// <summary>Current OEM version of your AzureStack deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current OEM version of your AzureStack deployment.",
        SerializedName = @"currentOemVersion",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentOemVersion { get; set; }
        /// <summary>Current version of your AzureStack deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current version of your AzureStack deployment.",
        SerializedName = @"currentVersion",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentVersion { get; set; }
        /// <summary>Date of last update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Date of last update.",
        SerializedName = @"lastUpdated",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastUpdated { get; set; }
        /// <summary>State with respect to the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State with respect to the update.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState) })]
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState? State { get; set; }

    }
    /// Information related to a location's update status.
    internal partial interface IUpdateLocationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal
    {
        /// <summary>Current OEM version of your AzureStack deployment.</summary>
        string CurrentOemVersion { get; set; }
        /// <summary>Current version of your AzureStack deployment.</summary>
        string CurrentVersion { get; set; }
        /// <summary>Date of last update.</summary>
        global::System.DateTime? LastUpdated { get; set; }
        /// <summary>Model which holds information related to update location.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModel Property { get; set; }
        /// <summary>State with respect to the update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState? State { get; set; }

    }
}