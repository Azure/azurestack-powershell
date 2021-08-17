namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Extension Client Access Section.</summary>
    public partial class ResourceAccess :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceAccess,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceAccessInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Resource" /> property.</summary>
        private string _resource;

        /// <summary>The resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Resource { get => this._resource; set => this._resource = value; }

        /// <summary>Creates an new <see cref="ResourceAccess" /> instance.</summary>
        public ResourceAccess()
        {

        }
    }
    /// Extension Client Access Section.
    public partial interface IResourceAccess :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string Resource { get; set; }

    }
    /// Extension Client Access Section.
    internal partial interface IResourceAccessInternal

    {
        /// <summary>The name.</summary>
        string Name { get; set; }
        /// <summary>The resource.</summary>
        string Resource { get; set; }

    }
}