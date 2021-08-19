namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>The scale unit operator view.</summary>
    public partial class ScaleUnit :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnit,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnitInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.Resource();

        /// <summary>ID of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Id; }

        /// <summary>The scale unit last update time (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string LastUpdatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnitPropertiesInternal)Property).LastUpdatedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnitPropertiesInternal)Property).LastUpdatedTime = value ?? null; }

        /// <summary>Location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnitProperties Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnitInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.ScaleUnitProperties()); set { {_property = value;} } }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Name; }

        /// <summary>The nodes of the scale unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.INodeView[] Node { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnitPropertiesInternal)Property).Node; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnitPropertiesInternal)Property).Node = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnitProperties _property;

        /// <summary>The scale unit operator view properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnitProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.ScaleUnitProperties()); set => this._property = value; }

        /// <summary>The name of the scale unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string ScaleUnitName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnitPropertiesInternal)Property).ScaleUnitName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnitPropertiesInternal)Property).ScaleUnitName = value ?? null; }

        /// <summary>Type of Resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="ScaleUnit" /> instance.</summary>
        public ScaleUnit()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The scale unit operator view.
    public partial interface IScaleUnit :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResource
    {
        /// <summary>The scale unit last update time (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scale unit last update time (UTC).",
        SerializedName = @"lastUpdatedTime",
        PossibleTypes = new [] { typeof(string) })]
        string LastUpdatedTime { get; set; }
        /// <summary>The nodes of the scale unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The nodes of the scale unit.",
        SerializedName = @"nodes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.INodeView) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.INodeView[] Node { get; set; }
        /// <summary>The name of the scale unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the scale unit.",
        SerializedName = @"scaleUnitName",
        PossibleTypes = new [] { typeof(string) })]
        string ScaleUnitName { get; set; }

    }
    /// The scale unit operator view.
    internal partial interface IScaleUnitInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal
    {
        /// <summary>The scale unit last update time (UTC).</summary>
        string LastUpdatedTime { get; set; }
        /// <summary>The nodes of the scale unit.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.INodeView[] Node { get; set; }
        /// <summary>The scale unit operator view properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnitProperties Property { get; set; }
        /// <summary>The name of the scale unit.</summary>
        string ScaleUnitName { get; set; }

    }
}