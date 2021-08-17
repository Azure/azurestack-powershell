// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support
{

    /// <summary>The status of page BLOB acquisition.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.AcquisitionStatusTypeConverter))]
    public partial struct AcquisitionStatus :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Unknown".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Unknown", "Unknown", global::System.Management.Automation.CompletionResultType.ParameterValue, "Unknown");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "NotAcquired".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("NotAcquired", "NotAcquired", global::System.Management.Automation.CompletionResultType.ParameterValue, "NotAcquired");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Pending".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Pending", "Pending", global::System.Management.Automation.CompletionResultType.ParameterValue, "Pending");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Success".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Success", "Success", global::System.Management.Automation.CompletionResultType.ParameterValue, "Success");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Failed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Failed", "Failed", global::System.Management.Automation.CompletionResultType.ParameterValue, "Failed");
            }
        }
    }
}