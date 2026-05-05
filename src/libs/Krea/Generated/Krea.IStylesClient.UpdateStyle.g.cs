#nullable enable

namespace Krea
{
    public partial interface IStylesClient
    {
        /// <summary>
        /// Update a style
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Style> UpdateStyleAsync(
            string id,

            global::Krea.UpdateStyleRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a style
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.AutoSDKHttpResponse<global::Krea.Style>> UpdateStyleAsResponseAsync(
            string id,

            global::Krea.UpdateStyleRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a style
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Style> UpdateStyleAsync(
            string id,
            string? name = default,
            string? description = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}