namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>Resource usage information.</summary>
    public partial class AdminOverviewResourceUsage :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal
    {

        /// <summary>Backing field for <see cref="InUseResourceCount" /> property.</summary>
        private long? _inUseResourceCount;

        /// <summary>Number of resources in use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public long? InUseResourceCount { get => this._inUseResourceCount; }

        /// <summary>Internal Acessors for InUseResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal.InUseResourceCount { get => this._inUseResourceCount; set { {_inUseResourceCount = value;} } }

        /// <summary>Internal Acessors for TotalResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal.TotalResourceCount { get => this._totalResourceCount; set { {_totalResourceCount = value;} } }

        /// <summary>Backing field for <see cref="TotalResourceCount" /> property.</summary>
        private long? _totalResourceCount;

        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public long? TotalResourceCount { get => this._totalResourceCount; }

        /// <summary>Creates an new <see cref="AdminOverviewResourceUsage" /> instance.</summary>
        public AdminOverviewResourceUsage()
        {

        }
    }
    /// Resource usage information.
    public partial interface IAdminOverviewResourceUsage :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Number of resources in use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in use.",
        SerializedName = @"inUseResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? InUseResourceCount { get;  }
        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total number of resources.",
        SerializedName = @"totalResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? TotalResourceCount { get;  }

    }
    /// Resource usage information.
    internal partial interface IAdminOverviewResourceUsageInternal

    {
        /// <summary>Number of resources in use.</summary>
        long? InUseResourceCount { get; set; }
        /// <summary>Total number of resources.</summary>
        long? TotalResourceCount { get; set; }

    }
}