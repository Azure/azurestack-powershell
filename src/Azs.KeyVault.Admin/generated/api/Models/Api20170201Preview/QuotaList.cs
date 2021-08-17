namespace Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Extensions;

    /// <summary>List of keyvault quotas.</summary>
    public partial class QuotaList :
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IQuotaList,
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IQuotaListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IQuota[] _value;

        /// <summary>List of keyvault quotas.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IQuota[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="QuotaList" /> instance.</summary>
        public QuotaList()
        {

        }
    }
    /// List of keyvault quotas.
    public partial interface IQuotaList :
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of keyvault quotas.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of keyvault quotas.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IQuota) })]
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IQuota[] Value { get; set; }

    }
    /// List of keyvault quotas.
    internal partial interface IQuotaListInternal

    {
        /// <summary>URI to the next page.</summary>
        string NextLink { get; set; }
        /// <summary>List of keyvault quotas.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IQuota[] Value { get; set; }

    }
}