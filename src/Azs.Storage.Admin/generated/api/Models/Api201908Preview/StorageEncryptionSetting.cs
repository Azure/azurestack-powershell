namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Storage Encryption setting</summary>
    public partial class StorageEncryptionSetting :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; }

        /// <summary>Backing field for <see cref="LastEnabledTime" /> property.</summary>
        private string _lastEnabledTime;

        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string LastEnabledTime { get => this._lastEnabledTime; }

        /// <summary>Internal Acessors for Enabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal.Enabled { get => this._enabled; set { {_enabled = value;} } }

        /// <summary>Internal Acessors for LastEnabledTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal.LastEnabledTime { get => this._lastEnabledTime; set { {_lastEnabledTime = value;} } }

        /// <summary>Creates an new <see cref="StorageEncryptionSetting" /> instance.</summary>
        public StorageEncryptionSetting()
        {

        }
    }
    /// Storage Encryption setting
    public partial interface IStorageEncryptionSetting :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Bool to indicate whether enabled or not.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get;  }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A rough estimate of the date/time when the encryption was last enabled by the user.",
        SerializedName = @"lastEnabledTime",
        PossibleTypes = new [] { typeof(string) })]
        string LastEnabledTime { get;  }

    }
    /// Storage Encryption setting
    internal partial interface IStorageEncryptionSettingInternal

    {
        /// <summary>Bool to indicate whether enabled or not.</summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        string LastEnabledTime { get; set; }

    }
}