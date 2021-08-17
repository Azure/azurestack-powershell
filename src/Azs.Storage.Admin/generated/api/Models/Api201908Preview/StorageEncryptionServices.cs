namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Services for which encryption setting is mentioned.</summary>
    public partial class StorageEncryptionServices :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal
    {

        /// <summary>Backing field for <see cref="Blob" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting _blob;

        /// <summary>Blob service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Blob { get => (this._blob = this._blob ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSetting()); }

        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public bool? BlobEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Blob).Enabled; }

        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string BlobLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Blob).LastEnabledTime; }

        /// <summary>Internal Acessors for Blob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal.Blob { get => (this._blob = this._blob ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSetting()); set { {_blob = value;} } }

        /// <summary>Internal Acessors for BlobEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal.BlobEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Blob).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Blob).Enabled = value; }

        /// <summary>Internal Acessors for BlobLastEnabledTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal.BlobLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Blob).LastEnabledTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Blob).LastEnabledTime = value; }

        /// <summary>Internal Acessors for Queue</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal.Queue { get => (this._queue = this._queue ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSetting()); set { {_queue = value;} } }

        /// <summary>Internal Acessors for QueueEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal.QueueEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Queue).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Queue).Enabled = value; }

        /// <summary>Internal Acessors for QueueLastEnabledTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal.QueueLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Queue).LastEnabledTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Queue).LastEnabledTime = value; }

        /// <summary>Internal Acessors for Table</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal.Table { get => (this._table = this._table ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSetting()); set { {_table = value;} } }

        /// <summary>Internal Acessors for TableEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal.TableEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Table).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Table).Enabled = value; }

        /// <summary>Internal Acessors for TableLastEnabledTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal.TableLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Table).LastEnabledTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Table).LastEnabledTime = value; }

        /// <summary>Backing field for <see cref="Queue" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting _queue;

        /// <summary>Queue service</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Queue { get => (this._queue = this._queue ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSetting()); }

        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public bool? QueueEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Queue).Enabled; }

        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string QueueLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Queue).LastEnabledTime; }

        /// <summary>Backing field for <see cref="Table" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting _table;

        /// <summary>Table service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Table { get => (this._table = this._table ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionSetting()); }

        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public bool? TableEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Table).Enabled; }

        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string TableLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSettingInternal)Table).LastEnabledTime; }

        /// <summary>Creates an new <see cref="StorageEncryptionServices" /> instance.</summary>
        public StorageEncryptionServices()
        {

        }
    }
    /// Services for which encryption setting is mentioned.
    public partial interface IStorageEncryptionServices :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Bool to indicate whether enabled or not.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BlobEnabled { get;  }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A rough estimate of the date/time when the encryption was last enabled by the user.",
        SerializedName = @"lastEnabledTime",
        PossibleTypes = new [] { typeof(string) })]
        string BlobLastEnabledTime { get;  }
        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Bool to indicate whether enabled or not.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? QueueEnabled { get;  }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A rough estimate of the date/time when the encryption was last enabled by the user.",
        SerializedName = @"lastEnabledTime",
        PossibleTypes = new [] { typeof(string) })]
        string QueueLastEnabledTime { get;  }
        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Bool to indicate whether enabled or not.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? TableEnabled { get;  }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A rough estimate of the date/time when the encryption was last enabled by the user.",
        SerializedName = @"lastEnabledTime",
        PossibleTypes = new [] { typeof(string) })]
        string TableLastEnabledTime { get;  }

    }
    /// Services for which encryption setting is mentioned.
    internal partial interface IStorageEncryptionServicesInternal

    {
        /// <summary>Blob service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Blob { get; set; }
        /// <summary>Bool to indicate whether enabled or not.</summary>
        bool? BlobEnabled { get; set; }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        string BlobLastEnabledTime { get; set; }
        /// <summary>Queue service</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Queue { get; set; }
        /// <summary>Bool to indicate whether enabled or not.</summary>
        bool? QueueEnabled { get; set; }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        string QueueLastEnabledTime { get; set; }
        /// <summary>Table service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Table { get; set; }
        /// <summary>Bool to indicate whether enabled or not.</summary>
        bool? TableEnabled { get; set; }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        string TableLastEnabledTime { get; set; }

    }
}