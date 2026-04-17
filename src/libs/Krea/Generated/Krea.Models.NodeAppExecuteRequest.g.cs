
#nullable enable

namespace Krea
{
    /// <summary>
    /// Execute a visual "Node App" workflow. Inputs are workflow-specific.
    /// </summary>
    public sealed partial class NodeAppExecuteRequest
    {
        /// <summary>
        /// Key-value map of input names to values as defined by the node app.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeAppExecuteRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Key-value map of input names to values as defined by the node app.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeAppExecuteRequest(
            object? inputs)
        {
            this.Inputs = inputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeAppExecuteRequest" /> class.
        /// </summary>
        public NodeAppExecuteRequest()
        {
        }
    }
}