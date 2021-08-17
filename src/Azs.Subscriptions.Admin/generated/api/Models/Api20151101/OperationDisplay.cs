namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Display information for the operation.</summary>
    public partial class OperationDisplay :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationDisplay,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationDisplayInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Description { get => this._description; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationDisplayInternal.Description { get => this._description; set { {_description = value;} } }

        /// <summary>Internal Acessors for Operation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationDisplayInternal.Operation { get => this._operation; set { {_operation = value;} } }

        /// <summary>Internal Acessors for Provider</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationDisplayInternal.Provider { get => this._provider; set { {_provider = value;} } }

        /// <summary>Internal Acessors for Resource</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOperationDisplayInternal.Resource { get => this._resource; set { {_resource = value;} } }

        /// <summary>Backing field for <see cref="Operation" /> property.</summary>
        private string _operation;

        /// <summary>Display name of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Operation { get => this._operation; }

        /// <summary>Backing field for <see cref="Provider" /> property.</summary>
        private string _provider;

        /// <summary>Resource provider display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Provider { get => this._provider; }

        /// <summary>Backing field for <see cref="Resource" /> property.</summary>
        private string _resource;

        /// <summary>Resource type display name related to the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Resource { get => this._resource; }

        /// <summary>Creates an new <see cref="OperationDisplay" /> instance.</summary>
        public OperationDisplay()
        {

        }
    }
    /// Display information for the operation.
    public partial interface IOperationDisplay :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Description for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Description for the operation.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>Display name of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Display name of the operation.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string Operation { get;  }
        /// <summary>Resource provider display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource provider display name.",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string Provider { get;  }
        /// <summary>Resource type display name related to the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource type display name related to the operation.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string Resource { get;  }

    }
    /// Display information for the operation.
    internal partial interface IOperationDisplayInternal

    {
        /// <summary>Description for the operation.</summary>
        string Description { get; set; }
        /// <summary>Display name of the operation.</summary>
        string Operation { get; set; }
        /// <summary>Resource provider display name.</summary>
        string Provider { get; set; }
        /// <summary>Resource type display name related to the operation.</summary>
        string Resource { get; set; }

    }
}