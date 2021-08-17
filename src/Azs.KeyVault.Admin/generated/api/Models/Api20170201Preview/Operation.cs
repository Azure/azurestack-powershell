namespace Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Extensions;

    /// <summary>Describes the supported rest operation.</summary>
    public partial class Operation :
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IOperation,
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IOperationInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IDisplay _display;

        /// <summary>
        /// Contains the localized display information for this particular operation / action.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IDisplay Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.Display()); set => this._display = value; }

        /// <summary>
        /// The localized friendly description for the operation, as it should be shown to the user. It should be thorough, yet concise
        /// it will be used in tool tips and detailed views.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Inlined)]
        public string DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IDisplayInternal)Display).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IDisplayInternal)Display).Description = value ?? null; }

        /// <summary>
        /// The localized friendly name for the operation, as it should be shown to the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IDisplayInternal)Display).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IDisplayInternal)Display).Operation = value ?? null; }

        /// <summary>
        /// The localized friendly form of the resource provider name; it is expected to also include the publisher/company responsible.
        /// It should use Title Casing and begin with "Microsoft" for 1st party services. e.g. "Microsoft Monitoring Insights" or
        /// "Microsoft Compute."
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IDisplayInternal)Display).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IDisplayInternal)Display).Provider = value ?? null; }

        /// <summary>
        /// The localized friendly form of the resource type related to this action/operation; it should match the public documentation
        /// for the resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IDisplayInternal)Display).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IDisplayInternal)Display).Resource = value ?? null; }

        /// <summary>Internal Acessors for Display</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IDisplay Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IOperationInternal.Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.Display()); set { {_display = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// The name of the operation being performed on this particular object. It should match the action name that appears in RBAC
        /// / the event service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="Operation" /> instance.</summary>
        public Operation()
        {

        }
    }
    /// Describes the supported rest operation.
    public partial interface IOperation :
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The localized friendly description for the operation, as it should be shown to the user. It should be thorough, yet concise
        /// it will be used in tool tips and detailed views.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The localized friendly description for the operation, as it should be shown to the user. It should be thorough, yet concise it will be used in tool tips and detailed views.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>
        /// The localized friendly name for the operation, as it should be shown to the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The localized friendly name for the operation, as it should be shown to the user.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get; set; }
        /// <summary>
        /// The localized friendly form of the resource provider name; it is expected to also include the publisher/company responsible.
        /// It should use Title Casing and begin with "Microsoft" for 1st party services. e.g. "Microsoft Monitoring Insights" or
        /// "Microsoft Compute."
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The localized friendly form of the resource provider name; it is expected to also include the publisher/company responsible. It should use Title Casing and begin with ""Microsoft"" for 1st party services. e.g. ""Microsoft Monitoring Insights"" or ""Microsoft Compute.""",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get; set; }
        /// <summary>
        /// The localized friendly form of the resource type related to this action/operation; it should match the public documentation
        /// for the resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The localized friendly form of the resource type related to this action/operation; it should match the public documentation for the resource provider.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get; set; }
        /// <summary>
        /// The name of the operation being performed on this particular object. It should match the action name that appears in RBAC
        /// / the event service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the operation being performed on this particular object. It should match the action name that appears in RBAC / the event service.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Describes the supported rest operation.
    internal partial interface IOperationInternal

    {
        /// <summary>
        /// Contains the localized display information for this particular operation / action.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IDisplay Display { get; set; }
        /// <summary>
        /// The localized friendly description for the operation, as it should be shown to the user. It should be thorough, yet concise
        /// it will be used in tool tips and detailed views.
        /// </summary>
        string DisplayDescription { get; set; }
        /// <summary>
        /// The localized friendly name for the operation, as it should be shown to the user.
        /// </summary>
        string DisplayOperation { get; set; }
        /// <summary>
        /// The localized friendly form of the resource provider name; it is expected to also include the publisher/company responsible.
        /// It should use Title Casing and begin with "Microsoft" for 1st party services. e.g. "Microsoft Monitoring Insights" or
        /// "Microsoft Compute."
        /// </summary>
        string DisplayProvider { get; set; }
        /// <summary>
        /// The localized friendly form of the resource type related to this action/operation; it should match the public documentation
        /// for the resource provider.
        /// </summary>
        string DisplayResource { get; set; }
        /// <summary>
        /// The name of the operation being performed on this particular object. It should match the action name that appears in RBAC
        /// / the event service.
        /// </summary>
        string Name { get; set; }

    }
}