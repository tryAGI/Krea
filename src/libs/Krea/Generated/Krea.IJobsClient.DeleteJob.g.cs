#nullable enable

namespace Krea
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Delete a job by ID<br/>
        /// Deletes a job. Completed output assets may still be accessible via their URLs.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteJobAsync(
            string id,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}