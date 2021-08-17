namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Storage encryption setting</summary>
    public partial class StorageEncryption :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryption,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal
    {

        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public bool? BlobEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).BlobEnabled; }

        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string BlobLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).BlobLastEnabledTime; }

        /// <summary>Backing field for <see cref="KeySource" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource? _keySource;

        /// <summary>Encryption keySource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource? KeySource { get => this._keySource; }

        /// <summary>Internal Acessors for BlobEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal.BlobEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).BlobEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).BlobEnabled = value; }

        /// <summary>Internal Acessors for BlobLastEnabledTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal.BlobLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).BlobLastEnabledTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).BlobLastEnabledTime = value; }

        /// <summary>Internal Acessors for KeySource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal.KeySource { get => this._keySource; set { {_keySource = value;} } }

        /// <summary>Internal Acessors for QueueEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal.QueueEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).QueueEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).QueueEnabled = value; }

        /// <summary>Internal Acessors for QueueLastEnabledTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal.QueueLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).QueueLastEnabledTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).QueueLastEnabledTime = value; }

        /// <summary>Internal Acessors for Service</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal.Service { get => (this._service = this._service ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionServices()); set { {_service = value;} } }

        /// <summary>Internal Acessors for ServiceBlob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal.ServiceBlob { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).Blob; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).Blob = value; }

        /// <summary>Internal Acessors for ServiceQueue</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal.ServiceQueue { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).Queue; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).Queue = value; }

        /// <summary>Internal Acessors for ServiceTable</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal.ServiceTable { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).Table; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).Table = value; }

        /// <summary>Internal Acessors for TableEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal.TableEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).TableEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).TableEnabled = value; }

        /// <summary>Internal Acessors for TableLastEnabledTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionInternal.TableLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).TableLastEnabledTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).TableLastEnabledTime = value; }

        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public bool? QueueEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).QueueEnabled; }

        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string QueueLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).QueueLastEnabledTime; }

        /// <summary>Backing field for <see cref="Service" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices _service;

        /// <summary>Services for which encryption setting is mentioned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices Service { get => (this._service = this._service ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageEncryptionServices()); }

        /// <summary>Bool to indicate whether enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public bool? TableEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).TableEnabled; }

        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string TableLastEnabledTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServicesInternal)Service).TableLastEnabledTime; }

        /// <summary>Creates an new <see cref="StorageEncryption" /> instance.</summary>
        public StorageEncryption()
        {

        }
    }
    /// Storage encryption setting
    public partial interface IStorageEncryption :
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
        /// <summary>Encryption keySource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Encryption keySource",
        SerializedName = @"keySource",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource? KeySource { get;  }
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
    /// Storage encryption setting
    internal partial interface IStorageEncryptionInternal

    {
        /// <summary>Bool to indicate whether enabled or not.</summary>
        bool? BlobEnabled { get; set; }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        string BlobLastEnabledTime { get; set; }
        /// <summary>Encryption keySource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.EncryptionKeySource? KeySource { get; set; }
        /// <summary>Bool to indicate whether enabled or not.</summary>
        bool? QueueEnabled { get; set; }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        string QueueLastEnabledTime { get; set; }
        /// <summary>Services for which encryption setting is mentioned</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionServices Service { get; set; }
        /// <summary>Blob service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting ServiceBlob { get; set; }
        /// <summary>Queue service</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting ServiceQueue { get; set; }
        /// <summary>Table service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageEncryptionSetting ServiceTable { get; set; }
        /// <summary>Bool to indicate whether enabled or not.</summary>
        bool? TableEnabled { get; set; }
        /// <summary>
        /// A rough estimate of the date/time when the encryption was last enabled by the user.
        /// </summary>
        string TableLastEnabledTime { get; set; }

    }
}