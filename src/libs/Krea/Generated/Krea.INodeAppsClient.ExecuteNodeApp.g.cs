#nullable enable

namespace Krea
{
    public partial interface INodeAppsClient
    {
        /// <summary>
        /// Execute a node app<br/>
        /// Submits execution of a node-app (visual workflow). Returns a job object.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> ExecuteNodeAppAsync(
            string id,

            global::Krea.NodeAppExecuteRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a node app<br/>
        /// Submits execution of a node-app (visual workflow). Returns a job object.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inputs">
        /// Key-value map of input names to values as defined by the node app.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> ExecuteNodeAppAsync(
            string id,
            object? inputs = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}