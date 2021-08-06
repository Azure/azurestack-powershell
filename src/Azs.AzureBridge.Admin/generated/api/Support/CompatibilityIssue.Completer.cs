// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support
{

    /// <summary>Compatibility issue</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssueTypeConverter))]
    public partial struct CompatibilityIssue :
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
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "HigherDeviceVersionRequired".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("HigherDeviceVersionRequired", "HigherDeviceVersionRequired", global::System.Management.Automation.CompletionResultType.ParameterValue, "HigherDeviceVersionRequired");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "LowerDeviceVersionRequired".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("LowerDeviceVersionRequired", "LowerDeviceVersionRequired", global::System.Management.Automation.CompletionResultType.ParameterValue, "LowerDeviceVersionRequired");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CapacityBillingModelRequired".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("CapacityBillingModelRequired", "CapacityBillingModelRequired", global::System.Management.Automation.CompletionResultType.ParameterValue, "CapacityBillingModelRequired");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PayAsYouGoBillingModelRequired".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("PayAsYouGoBillingModelRequired", "PayAsYouGoBillingModelRequired", global::System.Management.Automation.CompletionResultType.ParameterValue, "PayAsYouGoBillingModelRequired");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DevelopmentBillingModelRequired".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("DevelopmentBillingModelRequired", "DevelopmentBillingModelRequired", global::System.Management.Automation.CompletionResultType.ParameterValue, "DevelopmentBillingModelRequired");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AzureADIdentitySystemRequired".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("AzureADIdentitySystemRequired", "AzureADIdentitySystemRequired", global::System.Management.Automation.CompletionResultType.ParameterValue, "AzureADIdentitySystemRequired");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ADFSIdentitySystemRequired".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ADFSIdentitySystemRequired", "ADFSIdentitySystemRequired", global::System.Management.Automation.CompletionResultType.ParameterValue, "ADFSIdentitySystemRequired");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ConnectionToInternetRequired".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ConnectionToInternetRequired", "ConnectionToInternetRequired", global::System.Management.Automation.CompletionResultType.ParameterValue, "ConnectionToInternetRequired");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ConnectionToAzureRequired".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ConnectionToAzureRequired", "ConnectionToAzureRequired", global::System.Management.Automation.CompletionResultType.ParameterValue, "ConnectionToAzureRequired");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DisconnectedEnvironmentRequired".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("DisconnectedEnvironmentRequired", "DisconnectedEnvironmentRequired", global::System.Management.Automation.CompletionResultType.ParameterValue, "DisconnectedEnvironmentRequired");
            }
        }
    }
}