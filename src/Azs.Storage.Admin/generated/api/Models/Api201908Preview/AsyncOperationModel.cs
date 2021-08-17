namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>The async operation body for srp request.</summary>
    public partial class AsyncOperationModel :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModel,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal
    {

        /// <summary>Backing field for <see cref="Context" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContext _context;

        /// <summary>Operation context.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContext Context { get => (this._context = this._context ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.OperationRequestContext()); }

        /// <summary>Activity id for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string ContextActivityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).ActivityId; }

        /// <summary>Operation api version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string ContextApiVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).ApiVersion; }

        /// <summary>Async operation error code if operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string ContextErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).ErrorCode; }

        /// <summary>Async operation name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string ContextOperationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).OperationName; }

        /// <summary>Runtime exception if operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string ContextRuntimeException { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).RuntimeException; }

        /// <summary>Start time for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string ContextStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).StartTime; }

        /// <summary>Backing field for <see cref="HttpStatus" /> property.</summary>
        private string _httpStatus;

        /// <summary>Http status for the async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string HttpStatus { get => this._httpStatus; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The operation id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="LocationHeader" /> property.</summary>
        private string _locationHeader;

        /// <summary>Location header for async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string LocationHeader { get => this._locationHeader; }

        /// <summary>Internal Acessors for Context</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContext Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.Context { get => (this._context = this._context ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.OperationRequestContext()); set { {_context = value;} } }

        /// <summary>Internal Acessors for ContextActivityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.ContextActivityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).ActivityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).ActivityId = value; }

        /// <summary>Internal Acessors for ContextApiVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.ContextApiVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).ApiVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).ApiVersion = value; }

        /// <summary>Internal Acessors for ContextErrorCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.ContextErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).ErrorCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).ErrorCode = value; }

        /// <summary>Internal Acessors for ContextOperationName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.ContextOperationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).OperationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).OperationName = value; }

        /// <summary>Internal Acessors for ContextRuntimeException</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.ContextRuntimeException { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).RuntimeException; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).RuntimeException = value; }

        /// <summary>Internal Acessors for ContextStartTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.ContextStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal)Context).StartTime = value; }

        /// <summary>Internal Acessors for HttpStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.HttpStatus { get => this._httpStatus; set { {_httpStatus = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for LocationHeader</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.LocationHeader { get => this._locationHeader; set { {_locationHeader = value;} } }

        /// <summary>Internal Acessors for Operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperation Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.Operation { get => (this._operation = this._operation ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.AsyncOperation()); set { {_operation = value;} } }

        /// <summary>Internal Acessors for OperationEndTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.OperationEndTime { get => this._operationEndTime; set { {_operationEndTime = value;} } }

        /// <summary>Internal Acessors for OperationName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.OperationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationInternal)Operation).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationInternal)Operation).Name = value; }

        /// <summary>Internal Acessors for OperationStartTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.OperationStartTime { get => this._operationStartTime; set { {_operationStartTime = value;} } }

        /// <summary>Internal Acessors for Response</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.Response { get => this._response; set { {_response = value;} } }

        /// <summary>Internal Acessors for SubscriptionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationModelInternal.SubscriptionId { get => this._subscriptionId; set { {_subscriptionId = value;} } }

        /// <summary>Backing field for <see cref="Operation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperation _operation;

        /// <summary>Async operation content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperation Operation { get => (this._operation = this._operation ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.AsyncOperation()); }

        /// <summary>Backing field for <see cref="OperationEndTime" /> property.</summary>
        private string _operationEndTime;

        /// <summary>Operation end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string OperationEndTime { get => this._operationEndTime; }

        /// <summary>Async operation name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string OperationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationInternal)Operation).Name; }

        /// <summary>Backing field for <see cref="OperationStartTime" /> property.</summary>
        private string _operationStartTime;

        /// <summary>Operation start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string OperationStartTime { get => this._operationStartTime; }

        /// <summary>Backing field for <see cref="Response" /> property.</summary>
        private string _response;

        /// <summary>Response for the async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string Response { get => this._response; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>Subscription id for async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; }

        /// <summary>Creates an new <see cref="AsyncOperationModel" /> instance.</summary>
        public AsyncOperationModel()
        {

        }
    }
    /// The async operation body for srp request.
    public partial interface IAsyncOperationModel :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Activity id for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Activity id for the operation.",
        SerializedName = @"activityId",
        PossibleTypes = new [] { typeof(string) })]
        string ContextActivityId { get;  }
        /// <summary>Operation api version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Operation api version.",
        SerializedName = @"apiVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ContextApiVersion { get;  }
        /// <summary>Async operation error code if operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Async operation error code if operation failed.",
        SerializedName = @"errorCode",
        PossibleTypes = new [] { typeof(string) })]
        string ContextErrorCode { get;  }
        /// <summary>Async operation name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Async operation name.",
        SerializedName = @"operationName",
        PossibleTypes = new [] { typeof(string) })]
        string ContextOperationName { get;  }
        /// <summary>Runtime exception if operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Runtime exception if operation failed.",
        SerializedName = @"runtimeException",
        PossibleTypes = new [] { typeof(string) })]
        string ContextRuntimeException { get;  }
        /// <summary>Start time for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Start time for the operation.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string ContextStartTime { get;  }
        /// <summary>Http status for the async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Http status for the async operation.",
        SerializedName = @"httpStatus",
        PossibleTypes = new [] { typeof(string) })]
        string HttpStatus { get;  }
        /// <summary>The operation id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The operation id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Location header for async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Location header for async operation.",
        SerializedName = @"locationHeader",
        PossibleTypes = new [] { typeof(string) })]
        string LocationHeader { get;  }
        /// <summary>Operation end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Operation end time.",
        SerializedName = @"operationEndTime",
        PossibleTypes = new [] { typeof(string) })]
        string OperationEndTime { get;  }
        /// <summary>Async operation name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Async operation name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string OperationName { get;  }
        /// <summary>Operation start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Operation start time.",
        SerializedName = @"operationStartTime",
        PossibleTypes = new [] { typeof(string) })]
        string OperationStartTime { get;  }
        /// <summary>Response for the async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Response for the async operation.",
        SerializedName = @"response",
        PossibleTypes = new [] { typeof(string) })]
        string Response { get;  }
        /// <summary>Subscription id for async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Subscription id for async operation.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get;  }

    }
    /// The async operation body for srp request.
    internal partial interface IAsyncOperationModelInternal

    {
        /// <summary>Operation context.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContext Context { get; set; }
        /// <summary>Activity id for the operation.</summary>
        string ContextActivityId { get; set; }
        /// <summary>Operation api version.</summary>
        string ContextApiVersion { get; set; }
        /// <summary>Async operation error code if operation failed.</summary>
        string ContextErrorCode { get; set; }
        /// <summary>Async operation name.</summary>
        string ContextOperationName { get; set; }
        /// <summary>Runtime exception if operation failed.</summary>
        string ContextRuntimeException { get; set; }
        /// <summary>Start time for the operation.</summary>
        string ContextStartTime { get; set; }
        /// <summary>Http status for the async operation.</summary>
        string HttpStatus { get; set; }
        /// <summary>The operation id.</summary>
        string Id { get; set; }
        /// <summary>Location header for async operation.</summary>
        string LocationHeader { get; set; }
        /// <summary>Async operation content.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperation Operation { get; set; }
        /// <summary>Operation end time.</summary>
        string OperationEndTime { get; set; }
        /// <summary>Async operation name</summary>
        string OperationName { get; set; }
        /// <summary>Operation start time.</summary>
        string OperationStartTime { get; set; }
        /// <summary>Response for the async operation.</summary>
        string Response { get; set; }
        /// <summary>Subscription id for async operation.</summary>
        string SubscriptionId { get; set; }

    }
}