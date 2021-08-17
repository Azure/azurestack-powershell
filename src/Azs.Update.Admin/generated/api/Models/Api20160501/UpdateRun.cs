namespace Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Extensions;

    /// <summary>Representation of a update run resource.</summary>
    public partial class UpdateRun :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRun,
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunInternal,
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.Resource();

        /// <summary>Duration of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string Duration { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).Duration; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).Duration = value ?? null; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Id; }

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

        /// <summary>Internal Acessors for Progress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunInternal.Progress { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).Progress; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).Progress = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModel Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateRunModel()); set { {_property = value;} } }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.FormatTable(Index = 0, Width = 40)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Name; }

        /// <summary>Description of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string ProgressDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).ProgressDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).ProgressDescription = value ?? null; }

        /// <summary>Time at which this step stopped executing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.FormatTable(Index = 3)]
        public global::System.DateTime? ProgressEndTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).ProgressEndTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).ProgressEndTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Error message, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string ProgressErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).ProgressErrorMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).ProgressErrorMessage = value ?? null; }

        /// <summary>Name of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string ProgressName { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).ProgressName; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).ProgressName = value ?? null; }

        /// <summary>Time at which this step started executing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.FormatTable(Index = 2, Width = 25)]
        public global::System.DateTime? ProgressStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).ProgressStartTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).ProgressStartTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>State of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string ProgressStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).ProgressStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).ProgressStatus = value ?? null; }

        /// <summary>Inner steps</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep[] ProgressStep { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).ProgressStep; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).ProgressStep = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModel _property;

        /// <summary>Properties of a update run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.UpdateRunModel()); set => this._property = value; }

        /// <summary>State of the update run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.FormatTable(Index = 1, Width = 15)]
        public Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState? State { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).State = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState)""); }

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Update start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public global::System.DateTime? TimeStarted { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).TimeStarted; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal)Property).TimeStarted = value ?? default(global::System.DateTime); }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="UpdateRun" /> instance.</summary>
        public UpdateRun()
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
    /// Representation of a update run resource.
    public partial interface IUpdateRun :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResource
    {
        /// <summary>Duration of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Duration of the update.",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(string) })]
        string Duration { get; set; }
        /// <summary>Description of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the step.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string ProgressDescription { get; set; }
        /// <summary>Time at which this step stopped executing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time at which this step stopped executing",
        SerializedName = @"endTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ProgressEndTimeUtc { get; set; }
        /// <summary>Error message, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Error message, if any.",
        SerializedName = @"errorMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ProgressErrorMessage { get; set; }
        /// <summary>Name of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the step.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ProgressName { get; set; }
        /// <summary>Time at which this step started executing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time at which this step started executing",
        SerializedName = @"startTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ProgressStartTimeUtc { get; set; }
        /// <summary>State of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of the step.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string ProgressStatus { get; set; }
        /// <summary>Inner steps</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Inner steps",
        SerializedName = @"steps",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep) })]
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep[] ProgressStep { get; set; }
        /// <summary>State of the update run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of the update run.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState) })]
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState? State { get; set; }
        /// <summary>Update start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Update start time.",
        SerializedName = @"timeStarted",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TimeStarted { get; set; }

    }
    /// Representation of a update run resource.
    internal partial interface IUpdateRunInternal :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IResourceInternal
    {
        /// <summary>Duration of the update.</summary>
        string Duration { get; set; }
        /// <summary>Current progress of the update run.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep Progress { get; set; }
        /// <summary>Description of the step.</summary>
        string ProgressDescription { get; set; }
        /// <summary>Time at which this step stopped executing</summary>
        global::System.DateTime? ProgressEndTimeUtc { get; set; }
        /// <summary>Error message, if any.</summary>
        string ProgressErrorMessage { get; set; }
        /// <summary>Name of the step.</summary>
        string ProgressName { get; set; }
        /// <summary>Time at which this step started executing</summary>
        global::System.DateTime? ProgressStartTimeUtc { get; set; }
        /// <summary>State of the step.</summary>
        string ProgressStatus { get; set; }
        /// <summary>Inner steps</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep[] ProgressStep { get; set; }
        /// <summary>Properties of a update run.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModel Property { get; set; }
        /// <summary>State of the update run.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState? State { get; set; }
        /// <summary>Update start time.</summary>
        global::System.DateTime? TimeStarted { get; set; }

    }
}