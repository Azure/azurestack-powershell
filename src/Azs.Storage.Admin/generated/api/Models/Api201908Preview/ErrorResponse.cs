namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>The error response for request which failed.</summary>
    public partial class ErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IErrorResponse,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IErrorResponseInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>The error description code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string Code { get => this._code; }

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private string[] _detail;

        /// <summary>The error details information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string[] Detail { get => this._detail; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>The error description message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IErrorResponseInternal.Code { get => this._code; set { {_code = value;} } }

        /// <summary>Internal Acessors for Detail</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IErrorResponseInternal.Detail { get => this._detail; set { {_detail = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IErrorResponseInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IErrorResponseInternal.Target { get => this._target; set { {_target = value;} } }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private string _target;

        /// <summary>The error target description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string Target { get => this._target; }

        /// <summary>Creates an new <see cref="ErrorResponse" /> instance.</summary>
        public ErrorResponse()
        {

        }
    }
    /// The error response for request which failed.
    public partial interface IErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The error description code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error description code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The error details information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error details information.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(string) })]
        string[] Detail { get;  }
        /// <summary>The error description message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error description message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>The error target description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error target description.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }

    }
    /// The error response for request which failed.
    internal partial interface IErrorResponseInternal

    {
        /// <summary>The error description code.</summary>
        string Code { get; set; }
        /// <summary>The error details information.</summary>
        string[] Detail { get; set; }
        /// <summary>The error description message.</summary>
        string Message { get; set; }
        /// <summary>The error target description.</summary>
        string Target { get; set; }

    }
}