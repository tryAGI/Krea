
#nullable enable

namespace Krea
{
    /// <summary>
    /// Job object returned by generation endpoints and `/jobs/{id}`.
    /// </summary>
    public sealed partial class Job
    {
        /// <summary>
        /// Unique job identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        /// Lifecycle status of a generation job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Krea.JsonConverters.JobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Krea.JobStatus Status { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when the job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when the job finished. Null until completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Job output. Null until the job finishes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::Krea.JobResult? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Unique job identifier.
        /// </param>
        /// <param name="status">
        /// Lifecycle status of a generation job.
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp when the job was created.
        /// </param>
        /// <param name="completedAt">
        /// ISO 8601 timestamp when the job finished. Null until completion.
        /// </param>
        /// <param name="result">
        /// Job output. Null until the job finishes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Job(
            global::System.Guid jobId,
            global::Krea.JobStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime? completedAt,
            global::Krea.JobResult? result)
        {
            this.JobId = jobId;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        public Job()
        {
        }

    }
}