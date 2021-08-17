namespace Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Extensions;

    /// <summary>Information about each step of the update process.</summary>
    public partial class Step :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep,
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStepInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="EndTimeUtc" /> property.</summary>
        private global::System.DateTime? _endTimeUtc;

        /// <summary>Time at which this step stopped executing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTimeUtc { get => this._endTimeUtc; set => this._endTimeUtc = value; }

        /// <summary>Backing field for <see cref="ErrorMessage" /> property.</summary>
        private string _errorMessage;

        /// <summary>Error message, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string ErrorMessage { get => this._errorMessage; set => this._errorMessage = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="StartTimeUtc" /> property.</summary>
        private global::System.DateTime? _startTimeUtc;

        /// <summary>Time at which this step started executing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTimeUtc { get => this._startTimeUtc; set => this._startTimeUtc = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>State of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="Steps" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep[] _steps;

        /// <summary>Inner steps</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep[] Steps { get => this._steps; set => this._steps = value; }

        /// <summary>Creates an new <see cref="Step" /> instance.</summary>
        public Step()
        {

        }
    }
    /// Information about each step of the update process.
    public partial interface IStep :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Description of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the step.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Time at which this step stopped executing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time at which this step stopped executing",
        SerializedName = @"endTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTimeUtc { get; set; }
        /// <summary>Error message, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Error message, if any.",
        SerializedName = @"errorMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorMessage { get; set; }
        /// <summary>Name of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the step.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Time at which this step started executing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time at which this step started executing",
        SerializedName = @"startTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTimeUtc { get; set; }
        /// <summary>State of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of the step.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>Inner steps</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Inner steps",
        SerializedName = @"steps",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep) })]
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep[] Steps { get; set; }

    }
    /// Information about each step of the update process.
    internal partial interface IStepInternal

    {
        /// <summary>Description of the step.</summary>
        string Description { get; set; }
        /// <summary>Time at which this step stopped executing</summary>
        global::System.DateTime? EndTimeUtc { get; set; }
        /// <summary>Error message, if any.</summary>
        string ErrorMessage { get; set; }
        /// <summary>Name of the step.</summary>
        string Name { get; set; }
        /// <summary>Time at which this step started executing</summary>
        global::System.DateTime? StartTimeUtc { get; set; }
        /// <summary>State of the step.</summary>
        string Status { get; set; }
        /// <summary>Inner steps</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IStep[] Steps { get; set; }

    }
}