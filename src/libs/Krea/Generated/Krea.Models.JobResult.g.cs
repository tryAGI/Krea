
#nullable enable

namespace Krea
{
    /// <summary>
    /// Output payload for a completed job.
    /// </summary>
    public sealed partial class JobResult
    {
        /// <summary>
        /// Output asset URLs produced by the job (images, videos, etc).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<string>? Urls { get; set; }

        /// <summary>
        /// Style identifier. Only set for completed style-training (LoRA) jobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_id")]
        public string? StyleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobResult" /> class.
        /// </summary>
        /// <param name="urls">
        /// Output asset URLs produced by the job (images, videos, etc).
        /// </param>
        /// <param name="styleId">
        /// Style identifier. Only set for completed style-training (LoRA) jobs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobResult(
            global::System.Collections.Generic.IList<string>? urls,
            string? styleId)
        {
            this.Urls = urls;
            this.StyleId = styleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobResult" /> class.
        /// </summary>
        public JobResult()
        {
        }

    }
}