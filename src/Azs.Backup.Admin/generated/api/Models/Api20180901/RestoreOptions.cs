namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>Properties for restore options.</summary>
    public partial class RestoreOptions :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRestoreOptions,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRestoreOptionsInternal
    {

        /// <summary>Backing field for <see cref="DecryptionCertBase64" /> property.</summary>
        private string _decryptionCertBase64;

        /// <summary>
        /// The certificate file raw data in Base64 string. This should be the .pfx file with the private key.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string DecryptionCertBase64 { get => this._decryptionCertBase64; set => this._decryptionCertBase64 = value; }

        /// <summary>Backing field for <see cref="DecryptionCertPassword" /> property.</summary>
        private string _decryptionCertPassword;

        /// <summary>The password for the decryption certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string DecryptionCertPassword { get => this._decryptionCertPassword; set => this._decryptionCertPassword = value; }

        /// <summary>Backing field for <see cref="RoleName" /> property.</summary>
        private string _roleName;

        /// <summary>
        /// The Azure Stack role name for restore, set it to empty for all infrastructure role
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string RoleName { get => this._roleName; set => this._roleName = value; }

        /// <summary>Creates an new <see cref="RestoreOptions" /> instance.</summary>
        public RestoreOptions()
        {

        }
    }
    /// Properties for restore options.
    public partial interface IRestoreOptions :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The certificate file raw data in Base64 string. This should be the .pfx file with the private key.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The certificate file raw data in Base64 string. This should be the .pfx file with the private key.",
        SerializedName = @"decryptionCertBase64",
        PossibleTypes = new [] { typeof(string) })]
        string DecryptionCertBase64 { get; set; }
        /// <summary>The password for the decryption certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The password for the decryption certificate.",
        SerializedName = @"decryptionCertPassword",
        PossibleTypes = new [] { typeof(string) })]
        string DecryptionCertPassword { get; set; }
        /// <summary>
        /// The Azure Stack role name for restore, set it to empty for all infrastructure role
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Azure Stack role name for restore, set it to empty for all infrastructure role",
        SerializedName = @"roleName",
        PossibleTypes = new [] { typeof(string) })]
        string RoleName { get; set; }

    }
    /// Properties for restore options.
    internal partial interface IRestoreOptionsInternal

    {
        /// <summary>
        /// The certificate file raw data in Base64 string. This should be the .pfx file with the private key.
        /// </summary>
        string DecryptionCertBase64 { get; set; }
        /// <summary>The password for the decryption certificate.</summary>
        string DecryptionCertPassword { get; set; }
        /// <summary>
        /// The Azure Stack role name for restore, set it to empty for all infrastructure role
        /// </summary>
        string RoleName { get; set; }

    }
}