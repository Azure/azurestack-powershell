namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>A long running operation status.</summary>
    public partial class OperationsStatus :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatus,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatusInternal
    {

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfoInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfoInternal)Error).Code = value ?? null; }

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string DetailNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfoInternal)Error).DetailNextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfoInternal)Error).DetailNextLink = value ?? null; }

        /// <summary>List of the extended error information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfo[] DetailValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfoInternal)Error).DetailValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfoInternal)Error).DetailValue = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime? _endTime;

        /// <summary>The end time of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTime { get => this._endTime; set => this._endTime = value; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfo _error;

        /// <summary>The operation error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfo Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ExtendedErrorInfo()); set => this._error = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatusIdentifier _id;

        /// <summary>The operation status identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatusIdentifier Id { get => (this._id = this._id ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.OperationsStatusIdentifier()); set => this._id = value; }

        /// <summary>The location of the operations status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string IdLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatusIdentifierInternal)Id).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatusIdentifierInternal)Id).Location = value ?? null; }

        /// <summary>The name of the operations status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string IdName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatusIdentifierInternal)Id).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatusIdentifierInternal)Id).Name = value ?? null; }

        /// <summary>The subscription identifier..</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string IdSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatusIdentifierInternal)Id).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatusIdentifierInternal)Id).SubscriptionId = value ?? null; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfoInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfoInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for Details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfoList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatusInternal.Details { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfoInternal)Error).Details; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfoInternal)Error).Details = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfo Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatusInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ExtendedErrorInfo()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatusIdentifier Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatusInternal.Id { get => (this._id = this._id ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.OperationsStatusIdentifier()); set { {_id = value;} } }

        /// <summary>Backing field for <see cref="PercentComplete" /> property.</summary>
        private float? _percentComplete;

        /// <summary>The completion percentage of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public float? PercentComplete { get => this._percentComplete; set => this._percentComplete = value; }

        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny _properties;

        /// <summary>The internal operation properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny Properties { get => (this._properties = this._properties ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Any()); set => this._properties = value; }

        /// <summary>Backing field for <see cref="ResponseContent" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny _responseContent;

        /// <summary>The content of the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny ResponseContent { get => (this._responseContent = this._responseContent ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Any()); set => this._responseContent = value; }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private string _retryAfter;

        /// <summary>The amount of time clients should wait..</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>The start time of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="TerminalHttpStatusCode" /> property.</summary>
        private string _terminalHttpStatusCode;

        /// <summary>The terminal http status code for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string TerminalHttpStatusCode { get => this._terminalHttpStatusCode; set => this._terminalHttpStatusCode = value; }

        /// <summary>Creates an new <see cref="OperationsStatus" /> instance.</summary>
        public OperationsStatus()
        {

        }
    }
    /// A long running operation status.
    public partial interface IOperationsStatus :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string DetailNextLink { get; set; }
        /// <summary>List of the extended error information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the extended error information.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfo[] DetailValue { get; set; }
        /// <summary>The end time of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The end time of the operation.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get; set; }
        /// <summary>The location of the operations status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the operations status.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string IdLocation { get; set; }
        /// <summary>The name of the operations status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the operations status.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string IdName { get; set; }
        /// <summary>The subscription identifier..</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subscription identifier..",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string IdSubscriptionId { get; set; }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>The completion percentage of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The completion percentage of the operation.",
        SerializedName = @"percentComplete",
        PossibleTypes = new [] { typeof(float) })]
        float? PercentComplete { get; set; }
        /// <summary>The internal operation properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The internal operation properties.",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny Properties { get; set; }
        /// <summary>The content of the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The content of the response.",
        SerializedName = @"responseContent",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny ResponseContent { get; set; }
        /// <summary>The amount of time clients should wait..</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of time clients should wait..",
        SerializedName = @"retryAfter",
        PossibleTypes = new [] { typeof(string) })]
        string RetryAfter { get; set; }
        /// <summary>The start time of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The start time of the operation.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get; set; }
        /// <summary>The status of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the operation.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>The terminal http status code for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The terminal http status code for the operation.",
        SerializedName = @"terminalHttpStatusCode",
        PossibleTypes = new [] { typeof(string) })]
        string TerminalHttpStatusCode { get; set; }

    }
    /// A long running operation status.
    internal partial interface IOperationsStatusInternal

    {
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>URI to next page.</summary>
        string DetailNextLink { get; set; }
        /// <summary>List of the extended error information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfo[] DetailValue { get; set; }
        /// <summary>The detailed error message details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfoList Details { get; set; }
        /// <summary>The end time of the operation.</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>The operation error.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtendedErrorInfo Error { get; set; }
        /// <summary>The operation status identifier.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationsStatusIdentifier Id { get; set; }
        /// <summary>The location of the operations status.</summary>
        string IdLocation { get; set; }
        /// <summary>The name of the operations status.</summary>
        string IdName { get; set; }
        /// <summary>The subscription identifier..</summary>
        string IdSubscriptionId { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>The completion percentage of the operation.</summary>
        float? PercentComplete { get; set; }
        /// <summary>The internal operation properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny Properties { get; set; }
        /// <summary>The content of the response.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny ResponseContent { get; set; }
        /// <summary>The amount of time clients should wait..</summary>
        string RetryAfter { get; set; }
        /// <summary>The start time of the operation.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>The status of the operation.</summary>
        string Status { get; set; }
        /// <summary>The terminal http status code for the operation.</summary>
        string TerminalHttpStatusCode { get; set; }

    }
}