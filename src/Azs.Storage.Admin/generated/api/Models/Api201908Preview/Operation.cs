namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Describes the supported REST operation.</summary>
    public partial class Operation :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperation,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplay _display;

        /// <summary>
        /// Contains the localized display information for this particular operation / action.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplay Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.Display()); }

        /// <summary>
        /// The localized friendly description for the operation, as it should be shown to the user. It should be thorough, yet concise
        /// – it will be used in tool tips and detailed views.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplayInternal)Display).Description; }

        /// <summary>
        /// The localized friendly name for the operation, as it should be shown to the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplayInternal)Display).Operation; }

        /// <summary>
        /// The localized friendly form of the resource provider name – it is expected to also include the publisher/company responsible.
        /// It should use Title Casing and begin with "Microsoft" for 1st party services. e.g. "Microsoft Monitoring Insights" or
        /// "Microsoft Compute."
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplayInternal)Display).Provider; }

        /// <summary>
        /// The localized friendly form of the resource type related to this action/operation – it should match the public documentation
        /// for the resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplayInternal)Display).Resource; }

        /// <summary>Internal Acessors for Display</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplay Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationInternal.Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.Display()); set { {_display = value;} } }

        /// <summary>Internal Acessors for DisplayDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationInternal.DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplayInternal)Display).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplayInternal)Display).Description = value; }

        /// <summary>Internal Acessors for DisplayOperation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationInternal.DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplayInternal)Display).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplayInternal)Display).Operation = value; }

        /// <summary>Internal Acessors for DisplayProvider</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationInternal.DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplayInternal)Display).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplayInternal)Display).Provider = value; }

        /// <summary>Internal Acessors for DisplayResource</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationInternal.DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplayInternal)Display).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplayInternal)Display).Resource = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// The name of the operation being performed on this particular object. It should match the action name that appears in RBAC
        /// / the event service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Creates an new <see cref="Operation" /> instance.</summary>
        public Operation()
        {

        }
    }
    /// Describes the supported REST operation.
    public partial interface IOperation :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The localized friendly description for the operation, as it should be shown to the user. It should be thorough, yet concise
        /// – it will be used in tool tips and detailed views.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The localized friendly description for the operation, as it should be shown to the user. It should be thorough, yet concise – it will be used in tool tips and detailed views.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get;  }
        /// <summary>
        /// The localized friendly name for the operation, as it should be shown to the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The localized friendly name for the operation, as it should be shown to the user.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get;  }
        /// <summary>
        /// The localized friendly form of the resource provider name – it is expected to also include the publisher/company responsible.
        /// It should use Title Casing and begin with "Microsoft" for 1st party services. e.g. "Microsoft Monitoring Insights" or
        /// "Microsoft Compute."
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The localized friendly form of the resource provider name – it is expected to also include the publisher/company responsible. It should use Title Casing and begin with ""Microsoft"" for 1st party services. e.g. ""Microsoft Monitoring Insights"" or ""Microsoft Compute.""",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get;  }
        /// <summary>
        /// The localized friendly form of the resource type related to this action/operation – it should match the public documentation
        /// for the resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The localized friendly form of the resource type related to this action/operation – it should match the public documentation for the resource provider.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get;  }
        /// <summary>
        /// The name of the operation being performed on this particular object. It should match the action name that appears in RBAC
        /// / the event service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the operation being performed on this particular object. It should match the action name that appears in RBAC / the event service.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }

    }
    /// Describes the supported REST operation.
    internal partial interface IOperationInternal

    {
        /// <summary>
        /// Contains the localized display information for this particular operation / action.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IDisplay Display { get; set; }
        /// <summary>
        /// The localized friendly description for the operation, as it should be shown to the user. It should be thorough, yet concise
        /// – it will be used in tool tips and detailed views.
        /// </summary>
        string DisplayDescription { get; set; }
        /// <summary>
        /// The localized friendly name for the operation, as it should be shown to the user.
        /// </summary>
        string DisplayOperation { get; set; }
        /// <summary>
        /// The localized friendly form of the resource provider name – it is expected to also include the publisher/company responsible.
        /// It should use Title Casing and begin with "Microsoft" for 1st party services. e.g. "Microsoft Monitoring Insights" or
        /// "Microsoft Compute."
        /// </summary>
        string DisplayProvider { get; set; }
        /// <summary>
        /// The localized friendly form of the resource type related to this action/operation – it should match the public documentation
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