namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The linked resource access checks.</summary>
    public partial class LinkedAccessCheck :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedAccessCheck,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedAccessCheckInternal
    {

        /// <summary>Backing field for <see cref="ActionName" /> property.</summary>
        private string _actionName;

        /// <summary>The action name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string ActionName { get => this._actionName; set => this._actionName = value; }

        /// <summary>Backing field for <see cref="LinkedAction" /> property.</summary>
        private string _linkedAction;

        /// <summary>The linked action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string LinkedAction { get => this._linkedAction; set => this._linkedAction = value; }

        /// <summary>Backing field for <see cref="LinkedActionVerb" /> property.</summary>
        private string _linkedActionVerb;

        /// <summary>The linked action verb.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string LinkedActionVerb { get => this._linkedActionVerb; set => this._linkedActionVerb = value; }

        /// <summary>Backing field for <see cref="LinkedProperty" /> property.</summary>
        private string _linkedProperty;

        /// <summary>The linked property.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string LinkedProperty { get => this._linkedProperty; set => this._linkedProperty = value; }

        /// <summary>Backing field for <see cref="LinkedType" /> property.</summary>
        private string _linkedType;

        /// <summary>The linked type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string LinkedType { get => this._linkedType; set => this._linkedType = value; }

        /// <summary>Creates an new <see cref="LinkedAccessCheck" /> instance.</summary>
        public LinkedAccessCheck()
        {

        }
    }
    /// The linked resource access checks.
    public partial interface ILinkedAccessCheck :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The action name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The action name.",
        SerializedName = @"actionName",
        PossibleTypes = new [] { typeof(string) })]
        string ActionName { get; set; }
        /// <summary>The linked action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The linked action.",
        SerializedName = @"linkedAction",
        PossibleTypes = new [] { typeof(string) })]
        string LinkedAction { get; set; }
        /// <summary>The linked action verb.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The linked action verb.",
        SerializedName = @"linkedActionVerb",
        PossibleTypes = new [] { typeof(string) })]
        string LinkedActionVerb { get; set; }
        /// <summary>The linked property.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The linked property.",
        SerializedName = @"linkedProperty",
        PossibleTypes = new [] { typeof(string) })]
        string LinkedProperty { get; set; }
        /// <summary>The linked type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The linked type.",
        SerializedName = @"linkedType",
        PossibleTypes = new [] { typeof(string) })]
        string LinkedType { get; set; }

    }
    /// The linked resource access checks.
    internal partial interface ILinkedAccessCheckInternal

    {
        /// <summary>The action name.</summary>
        string ActionName { get; set; }
        /// <summary>The linked action.</summary>
        string LinkedAction { get; set; }
        /// <summary>The linked action verb.</summary>
        string LinkedActionVerb { get; set; }
        /// <summary>The linked property.</summary>
        string LinkedProperty { get; set; }
        /// <summary>The linked type.</summary>
        string LinkedType { get; set; }

    }
}