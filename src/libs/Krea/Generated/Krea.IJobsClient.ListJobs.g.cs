#nullable enable

namespace Krea
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// List jobs<br/>
        /// Lists generation jobs for the authenticated account with pagination.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="types"></param>
        /// <param name="status">
        /// Lifecycle status of a generation job.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.JobList> ListJobsAsync(
            global::System.DateTime? cursor = default,
            int? limit = default,
            string? types = default,
            global::Krea.JobStatus? status = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}