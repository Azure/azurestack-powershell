namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Input data for setting GPU partitions.</summary>
    public partial class SetGpuPartitionSizeParameter :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ISetGpuPartitionSizeParameter,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ISetGpuPartitionSizeParameterInternal
    {

        /// <summary>Backing field for <see cref="GpuPartitionSize" /> property.</summary>
        private int? _gpuPartitionSize;

        /// <summary>Number of GPU partitions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public int? GpuPartitionSize { get => this._gpuPartitionSize; set => this._gpuPartitionSize = value; }

        /// <summary>Creates an new <see cref="SetGpuPartitionSizeParameter" /> instance.</summary>
        public SetGpuPartitionSizeParameter()
        {

        }
    }
    /// Input data for setting GPU partitions.
    public partial interface ISetGpuPartitionSizeParameter :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Number of GPU partitions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of GPU partitions",
        SerializedName = @"gpuPartitionSize",
        PossibleTypes = new [] { typeof(int) })]
        int? GpuPartitionSize { get; set; }

    }
    /// Input data for setting GPU partitions.
    internal partial interface ISetGpuPartitionSizeParameterInternal

    {
        /// <summary>Number of GPU partitions</summary>
        int? GpuPartitionSize { get; set; }

    }
}