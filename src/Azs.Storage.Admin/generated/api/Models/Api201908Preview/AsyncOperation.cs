namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Async operation content</summary>
    public partial class AsyncOperation :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperation,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationInternal
    {

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAsyncOperationInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Async operation name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Creates an new <see cref="AsyncOperation" /> instance.</summary>
        public AsyncOperation()
        {

        }
    }
    /// Async operation content
    public partial interface IAsyncOperation :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Async operation name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Async operation name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }

    }
    /// Async operation content
    internal partial interface IAsyncOperationInternal

    {
        /// <summary>Async operation name</summary>
        string Name { get; set; }

    }
}