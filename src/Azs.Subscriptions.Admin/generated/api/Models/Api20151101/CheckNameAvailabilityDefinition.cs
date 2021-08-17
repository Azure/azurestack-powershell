namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The check name availability action definition.</summary>
    public partial class CheckNameAvailabilityDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ICheckNameAvailabilityDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ICheckNameAvailabilityDefinitionInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The resource name to verify.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>The resource type to verify.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; set => this._resourceType = value; }

        /// <summary>Creates an new <see cref="CheckNameAvailabilityDefinition" /> instance.</summary>
        public CheckNameAvailabilityDefinition()
        {

        }
    }
    /// The check name availability action definition.
    public partial interface ICheckNameAvailabilityDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The resource name to verify.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource name to verify.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The resource type to verify.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource type to verify.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get; set; }

    }
    /// The check name availability action definition.
    internal partial interface ICheckNameAvailabilityDefinitionInternal

    {
        /// <summary>The resource name to verify.</summary>
        string Name { get; set; }
        /// <summary>The resource type to verify.</summary>
        string ResourceType { get; set; }

    }
}