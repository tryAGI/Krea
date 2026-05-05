#nullable enable

namespace Krea
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Get an asset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Asset> GetAssetAsync(
            string id,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an asset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.AutoSDKHttpResponse<global::Krea.Asset>> GetAssetAsResponseAsync(
            string id,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}