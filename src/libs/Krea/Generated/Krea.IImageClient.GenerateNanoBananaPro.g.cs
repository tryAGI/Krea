#nullable enable

namespace Krea
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Generate image with Nano Banana Pro
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> GenerateNanoBananaProAsync(

            global::Krea.NanoBananaProRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate image with Nano Banana Pro
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.AutoSDKHttpResponse<global::Krea.Job>> GenerateNanoBananaProAsResponseAsync(

            global::Krea.NanoBananaProRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate image with Nano Banana Pro
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="batchSize">
        /// Default Value: 1
        /// </param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="resolution">
        /// Default Value: 1K
        /// </param>
        /// <param name="imageUrls">
        /// Direct image prompts. If provided, `styleImages` is ignored.
        /// </param>
        /// <param name="styleImages"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> GenerateNanoBananaProAsync(
            string prompt,
            double? batchSize = default,
            double? width = default,
            double? height = default,
            global::Krea.NanoBananaProRequestAspectRatio? aspectRatio = default,
            global::Krea.NanoBananaProRequestResolution? resolution = default,
            global::System.Collections.Generic.IList<string>? imageUrls = default,
            global::System.Collections.Generic.IList<global::Krea.StyleImage>? styleImages = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}