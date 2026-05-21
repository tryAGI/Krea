#nullable enable

namespace Krea
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Generate image with Ideogram 3.0
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> GenerateIdeogram3Async(

            global::Krea.IdeogramRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate image with Ideogram 3.0
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.AutoSDKHttpResponse<global::Krea.Job>> GenerateIdeogram3AsResponseAsync(

            global::Krea.IdeogramRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate image with Ideogram 3.0
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="batchSize">
        /// Default Value: 1
        /// </param>
        /// <param name="width">
        /// Default Value: 1024
        /// </param>
        /// <param name="height">
        /// Default Value: 1024
        /// </param>
        /// <param name="seed">
        /// Default Value: 1337
        /// </param>
        /// <param name="styleImages"></param>
        /// <param name="characterReferenceImages">
        /// Reference images used to keep character identity consistent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> GenerateIdeogram3Async(
            string prompt,
            double? batchSize = default,
            double? width = default,
            double? height = default,
            double? seed = default,
            global::System.Collections.Generic.IList<global::Krea.StyleImage>? styleImages = default,
            global::System.Collections.Generic.IList<string>? characterReferenceImages = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}