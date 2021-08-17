namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Error response.</summary>
    public partial class ExtendedErrorInfo :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedErrorInfo,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedErrorInfoInternal
    {

        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinitionInternal)Error).Code; }

        /// <summary>Internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinition[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinitionInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinition _error;

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinition Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ErrorDefinition()); set => this._error = value; }

        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinitionInternal)Error).Message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedErrorInfoInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinitionInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinitionInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinition[] Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedErrorInfoInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinitionInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinitionInternal)Error).Detail = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinition Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedErrorInfoInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ErrorDefinition()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IExtendedErrorInfoInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinitionInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinitionInternal)Error).Message = value; }

        /// <summary>Creates an new <see cref="ExtendedErrorInfo" /> instance.</summary>
        public ExtendedErrorInfo()
        {

        }
    }
    /// Error response.
    public partial interface IExtendedErrorInfo :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Service specific error code which serves as the substatus for the HTTP error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Internal error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Internal error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinition) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinition[] Detail { get;  }
        /// <summary>Description of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Description of the error.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }

    }
    /// Error response.
    internal partial interface IExtendedErrorInfoInternal

    {
        /// <summary>
        /// Service specific error code which serves as the substatus for the HTTP error code.
        /// </summary>
        string Code { get; set; }
        /// <summary>Internal error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinition[] Detail { get; set; }
        /// <summary>The error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IErrorDefinition Error { get; set; }
        /// <summary>Description of the error.</summary>
        string Message { get; set; }

    }
}