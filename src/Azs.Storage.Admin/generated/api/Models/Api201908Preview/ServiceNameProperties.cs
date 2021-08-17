namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>The properties for service name.</summary>
    public partial class ServiceNameProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IServiceNameProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IServiceNamePropertiesInternal
    {

        /// <summary>Internal Acessors for ServiceName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IServiceNamePropertiesInternal.ServiceName { get => this._serviceName; set { {_serviceName = value;} } }

        /// <summary>Backing field for <see cref="ServiceName" /> property.</summary>
        private string _serviceName;

        /// <summary>Service Name for Storage Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string ServiceName { get => this._serviceName; }

        /// <summary>Creates an new <see cref="ServiceNameProperties" /> instance.</summary>
        public ServiceNameProperties()
        {

        }
    }
    /// The properties for service name.
    public partial interface IServiceNameProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Service Name for Storage Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Service Name for Storage Service.",
        SerializedName = @"serviceName",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceName { get;  }

    }
    /// The properties for service name.
    internal partial interface IServiceNamePropertiesInternal

    {
        /// <summary>Service Name for Storage Service.</summary>
        string ServiceName { get; set; }

    }
}