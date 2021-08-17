namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Properties of storage setting.</summary>
    public partial class SettingProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.ISettingProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.ISettingPropertiesInternal
    {

        /// <summary>
        /// Backing field for <see cref="RetentionPeriodForDeletedStorageAccountsInDay" /> property.
        /// </summary>
        private int? _retentionPeriodForDeletedStorageAccountsInDay;

        /// <summary>
        /// The number of days a deleted storage account is kept before being permanently deleted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public int? RetentionPeriodForDeletedStorageAccountsInDay { get => this._retentionPeriodForDeletedStorageAccountsInDay; set => this._retentionPeriodForDeletedStorageAccountsInDay = value; }

        /// <summary>Creates an new <see cref="SettingProperties" /> instance.</summary>
        public SettingProperties()
        {

        }
    }
    /// Properties of storage setting.
    public partial interface ISettingProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The number of days a deleted storage account is kept before being permanently deleted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of days a deleted storage account is kept before being permanently deleted.",
        SerializedName = @"retentionPeriodForDeletedStorageAccountsInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionPeriodForDeletedStorageAccountsInDay { get; set; }

    }
    /// Properties of storage setting.
    internal partial interface ISettingPropertiesInternal

    {
        /// <summary>
        /// The number of days a deleted storage account is kept before being permanently deleted.
        /// </summary>
        int? RetentionPeriodForDeletedStorageAccountsInDay { get; set; }

    }
}