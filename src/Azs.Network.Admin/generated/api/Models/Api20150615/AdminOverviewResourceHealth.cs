namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>Resource health information.</summary>
    public partial class AdminOverviewResourceHealth :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal
    {

        /// <summary>Backing field for <see cref="ErrorResourceCount" /> property.</summary>
        private long? _errorResourceCount;

        /// <summary>Number of resources in the error state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public long? ErrorResourceCount { get => this._errorResourceCount; }

        /// <summary>Backing field for <see cref="HealthUnknownCount" /> property.</summary>
        private long? _healthUnknownCount;

        /// <summary>Number of resources in an unknown state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public long? HealthUnknownCount { get => this._healthUnknownCount; }

        /// <summary>Backing field for <see cref="HealthyResourceCount" /> property.</summary>
        private long? _healthyResourceCount;

        /// <summary>Number of resources in the success state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public long? HealthyResourceCount { get => this._healthyResourceCount; }

        /// <summary>Internal Acessors for ErrorResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal.ErrorResourceCount { get => this._errorResourceCount; set { {_errorResourceCount = value;} } }

        /// <summary>Internal Acessors for HealthUnknownCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal.HealthUnknownCount { get => this._healthUnknownCount; set { {_healthUnknownCount = value;} } }

        /// <summary>Internal Acessors for HealthyResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal.HealthyResourceCount { get => this._healthyResourceCount; set { {_healthyResourceCount = value;} } }

        /// <summary>Internal Acessors for TotalResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal.TotalResourceCount { get => this._totalResourceCount; set { {_totalResourceCount = value;} } }

        /// <summary>Internal Acessors for WarningResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal.WarningResourceCount { get => this._warningResourceCount; set { {_warningResourceCount = value;} } }

        /// <summary>Backing field for <see cref="TotalResourceCount" /> property.</summary>
        private long? _totalResourceCount;

        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public long? TotalResourceCount { get => this._totalResourceCount; }

        /// <summary>Backing field for <see cref="WarningResourceCount" /> property.</summary>
        private long? _warningResourceCount;

        /// <summary>Number of resources in the warning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public long? WarningResourceCount { get => this._warningResourceCount; }

        /// <summary>Creates an new <see cref="AdminOverviewResourceHealth" /> instance.</summary>
        public AdminOverviewResourceHealth()
        {

        }
    }
    /// Resource health information.
    public partial interface IAdminOverviewResourceHealth :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Number of resources in the error state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in the error state.",
        SerializedName = @"errorResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? ErrorResourceCount { get;  }
        /// <summary>Number of resources in an unknown state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in an unknown state.",
        SerializedName = @"healthUnknownCount",
        PossibleTypes = new [] { typeof(long) })]
        long? HealthUnknownCount { get;  }
        /// <summary>Number of resources in the success state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in the success state.",
        SerializedName = @"healthyResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? HealthyResourceCount { get;  }
        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total number of resources.",
        SerializedName = @"totalResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? TotalResourceCount { get;  }
        /// <summary>Number of resources in the warning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in the warning state.",
        SerializedName = @"warningResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? WarningResourceCount { get;  }

    }
    /// Resource health information.
    internal partial interface IAdminOverviewResourceHealthInternal

    {
        /// <summary>Number of resources in the error state.</summary>
        long? ErrorResourceCount { get; set; }
        /// <summary>Number of resources in an unknown state.</summary>
        long? HealthUnknownCount { get; set; }
        /// <summary>Number of resources in the success state.</summary>
        long? HealthyResourceCount { get; set; }
        /// <summary>Total number of resources.</summary>
        long? TotalResourceCount { get; set; }
        /// <summary>Number of resources in the warning state.</summary>
        long? WarningResourceCount { get; set; }

    }
}