namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>Status of a long running operation.</summary>
    public partial class LongRunningOperationStatus :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.ILongRunningOperationStatus,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.ILongRunningOperationStatusInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>Operation result code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string Code { get => this._code; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Description of the operation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.ILongRunningOperationStatusInternal.Code { get => this._code; set { {_code = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.ILongRunningOperationStatusInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Creates an new <see cref="LongRunningOperationStatus" /> instance.</summary>
        public LongRunningOperationStatus()
        {

        }
    }
    /// Status of a long running operation.
    public partial interface ILongRunningOperationStatus :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Operation result code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Operation result code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Description of the operation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Description of the operation status.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }

    }
    /// Status of a long running operation.
    internal partial interface ILongRunningOperationStatusInternal

    {
        /// <summary>Operation result code.</summary>
        string Code { get; set; }
        /// <summary>Description of the operation status.</summary>
        string Message { get; set; }

    }
}