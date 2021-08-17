namespace Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Extensions;

    /// <summary>
    /// Contains the localized display information for this particular operation / action.
    /// </summary>
    public partial class Display :
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IDisplay,
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IDisplayInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>
        /// The localized friendly description for the operation, as it should be shown to the user. It should be thorough, yet concise
        /// it will be used in tool tips and detailed views.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Operation" /> property.</summary>
        private string _operation;

        /// <summary>
        /// The localized friendly name for the operation, as it should be shown to the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Owned)]
        public string Operation { get => this._operation; set => this._operation = value; }

        /// <summary>Backing field for <see cref="Provider" /> property.</summary>
        private string _provider;

        /// <summary>
        /// The localized friendly form of the resource provider name; it is expected to also include the publisher/company responsible.
        /// It should use Title Casing and begin with "Microsoft" for 1st party services. e.g. "Microsoft Monitoring Insights" or
        /// "Microsoft Compute."
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Owned)]
        public string Provider { get => this._provider; set => this._provider = value; }

        /// <summary>Backing field for <see cref="Resource" /> property.</summary>
        private string _resource;

        /// <summary>
        /// The localized friendly form of the resource type related to this action/operation; it should match the public documentation
        /// for the resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Owned)]
        public string Resource { get => this._resource; set => this._resource = value; }

        /// <summary>Creates an new <see cref="Display" /> instance.</summary>
        public Display()
        {

        }
    }
    /// Contains the localized display information for this particular operation / action.
    public partial interface IDisplay :
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
        string Description { get; set; }
        /// <summary>
        /// The localized friendly name for the operation, as it should be shown to the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The localized friendly name for the operation, as it should be shown to the user.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string Operation { get; set; }
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
        string Provider { get; set; }
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
        string Resource { get; set; }

    }
    /// Contains the localized display information for this particular operation / action.
    internal partial interface IDisplayInternal

    {
        /// <summary>
        /// The localized friendly description for the operation, as it should be shown to the user. It should be thorough, yet concise
        /// it will be used in tool tips and detailed views.
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// The localized friendly name for the operation, as it should be shown to the user.
        /// </summary>
        string Operation { get; set; }
        /// <summary>
        /// The localized friendly form of the resource provider name; it is expected to also include the publisher/company responsible.
        /// It should use Title Casing and begin with "Microsoft" for 1st party services. e.g. "Microsoft Monitoring Insights" or
        /// "Microsoft Compute."
        /// </summary>
        string Provider { get; set; }
        /// <summary>
        /// The localized friendly form of the resource type related to this action/operation; it should match the public documentation
        /// for the resource provider.
        /// </summary>
        string Resource { get; set; }

    }
}