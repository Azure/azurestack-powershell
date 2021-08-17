namespace Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Extensions;

    /// <summary>Properties of an update run.</summary>
    public partial class UpdateRunModel :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModel,
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal
    {

        /// <summary>Backing field for <see cref="Duration" /> property.</summary>
        private string _duration;

        /// <summary>Duration of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string Duration { get => this._duration; set => this._duration = value; }

        /// <summary>Internal Acessors for Progress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateRunModelInternal.Progress { get => (this._progress = this._progress ?? new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.Step()); set { {_progress = value;} } }

        /// <summary>Backing field for <see cref="Progress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep _progress;

        /// <summary>Current progress of the update run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep Progress { get => (this._progress = this._progress ?? new Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.Step()); set => this._progress = value; }

        /// <summary>Description of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        public string ProgressDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal)Progress).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal)Progress).Description = value ?? null; }

        /// <summary>Time at which this step stopped executing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? ProgressEndTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal)Progress).EndTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal)Progress).EndTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Error message, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        public string ProgressErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal)Progress).ErrorMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal)Progress).ErrorMessage = value ?? null; }

        /// <summary>Name of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        public string ProgressName { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal)Progress).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal)Progress).Name = value ?? null; }

        /// <summary>Time at which this step started executing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? ProgressStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal)Progress).StartTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal)Progress).StartTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>State of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        public string ProgressStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal)Progress).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal)Progress).Status = value ?? null; }

        /// <summary>Inner steps</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep[] ProgressStep { get => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal)Progress).Steps; set => ((Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal)Progress).Steps = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState? _state;

        /// <summary>State of the update run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState? State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="TimeStarted" /> property.</summary>
        private global::System.DateTime? _timeStarted;

        /// <summary>Update start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? TimeStarted { get => this._timeStarted; set => this._timeStarted = value; }

        /// <summary>Creates an new <see cref="UpdateRunModel" /> instance.</summary>
        public UpdateRunModel()
        {

        }
    }
    /// Properties of an update run.
    public partial interface IUpdateRunModel :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.IJsonSerializable
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
    /// Properties of an update run.
    internal partial interface IUpdateRunModelInternal

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
        /// <summary>State of the update run.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateRunState? State { get; set; }
        /// <summary>Update start time.</summary>
        global::System.DateTime? TimeStarted { get; set; }

    }
}