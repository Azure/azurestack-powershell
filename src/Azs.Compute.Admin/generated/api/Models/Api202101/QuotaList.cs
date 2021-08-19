namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>List of Compute quotas</summary>
    public partial class QuotaList :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaList,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuotaListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuota[] _value;

        /// <summary>List of Compute quotas</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuota[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="QuotaList" /> instance.</summary>
        public QuotaList()
        {

        }
    }
    /// List of Compute quotas
    public partial interface IQuotaList :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of Compute quotas</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of Compute quotas",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuota) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuota[] Value { get; set; }

    }
    /// List of Compute quotas
    internal partial interface IQuotaListInternal

    {
        /// <summary>URI to the next page.</summary>
        string NextLink { get; set; }
        /// <summary>List of Compute quotas</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api202101.IQuota[] Value { get; set; }

    }
}