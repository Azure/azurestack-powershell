namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Operation request context.</summary>
    public partial class OperationRequestContext :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContext,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal
    {

        /// <summary>Backing field for <see cref="ActivityId" /> property.</summary>
        private string _activityId;

        /// <summary>Activity id for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string ActivityId { get => this._activityId; }

        /// <summary>Backing field for <see cref="ApiVersion" /> property.</summary>
        private string _apiVersion;

        /// <summary>Operation api version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string ApiVersion { get => this._apiVersion; }

        /// <summary>Backing field for <see cref="ErrorCode" /> property.</summary>
        private string _errorCode;

        /// <summary>Async operation error code if operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string ErrorCode { get => this._errorCode; }

        /// <summary>Internal Acessors for ActivityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal.ActivityId { get => this._activityId; set { {_activityId = value;} } }

        /// <summary>Internal Acessors for ApiVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal.ApiVersion { get => this._apiVersion; set { {_apiVersion = value;} } }

        /// <summary>Internal Acessors for ErrorCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal.ErrorCode { get => this._errorCode; set { {_errorCode = value;} } }

        /// <summary>Internal Acessors for OperationName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal.OperationName { get => this._operationName; set { {_operationName = value;} } }

        /// <summary>Internal Acessors for RuntimeException</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal.RuntimeException { get => this._runtimeException; set { {_runtimeException = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationRequestContextInternal.StartTime { get => this._startTime; set { {_startTime = value;} } }

        /// <summary>Backing field for <see cref="OperationName" /> property.</summary>
        private string _operationName;

        /// <summary>Async operation name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string OperationName { get => this._operationName; }

        /// <summary>Backing field for <see cref="RuntimeException" /> property.</summary>
        private string _runtimeException;

        /// <summary>Runtime exception if operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string RuntimeException { get => this._runtimeException; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private string _startTime;

        /// <summary>Start time for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string StartTime { get => this._startTime; }

        /// <summary>Creates an new <see cref="OperationRequestContext" /> instance.</summary>
        public OperationRequestContext()
        {

        }
    }
    /// Operation request context.
    public partial interface IOperationRequestContext :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Activity id for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Activity id for the operation.",
        SerializedName = @"activityId",
        PossibleTypes = new [] { typeof(string) })]
        string ActivityId { get;  }
        /// <summary>Operation api version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Operation api version.",
        SerializedName = @"apiVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ApiVersion { get;  }
        /// <summary>Async operation error code if operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Async operation error code if operation failed.",
        SerializedName = @"errorCode",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorCode { get;  }
        /// <summary>Async operation name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Async operation name.",
        SerializedName = @"operationName",
        PossibleTypes = new [] { typeof(string) })]
        string OperationName { get;  }
        /// <summary>Runtime exception if operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Runtime exception if operation failed.",
        SerializedName = @"runtimeException",
        PossibleTypes = new [] { typeof(string) })]
        string RuntimeException { get;  }
        /// <summary>Start time for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Start time for the operation.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string StartTime { get;  }

    }
    /// Operation request context.
    internal partial interface IOperationRequestContextInternal

    {
        /// <summary>Activity id for the operation.</summary>
        string ActivityId { get; set; }
        /// <summary>Operation api version.</summary>
        string ApiVersion { get; set; }
        /// <summary>Async operation error code if operation failed.</summary>
        string ErrorCode { get; set; }
        /// <summary>Async operation name.</summary>
        string OperationName { get; set; }
        /// <summary>Runtime exception if operation failed.</summary>
        string RuntimeException { get; set; }
        /// <summary>Start time for the operation.</summary>
        string StartTime { get; set; }

    }
}