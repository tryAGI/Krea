#nullable enable

namespace Krea
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Generate image with Seedream 5 Lite
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> GenerateSeedream5LiteAsync(

            global::Krea.ImageGenerationRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate image with Seedream 5 Lite
        /// </summary>
        /// <param name="prompt">
        /// Text description of the desired image.
        /// </param>
        /// <param name="batchSize">
        /// Number of images to generate in one call. Range 1-4.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="width">
        /// Output width in pixels. Check each model for supported range.
        /// </param>
        /// <param name="height">
        /// Output height in pixels.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.<br/>
        /// Default Value: 1337
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio hint, when supported (e.g. '16:9', '1:1', '9:16').
        /// </param>
        /// <param name="styleImages">
        /// Reference images weighted to steer composition/content.
        /// </param>
        /// <param name="styles">
        /// Trained LoRA styles to apply.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> GenerateSeedream5LiteAsync(
            string prompt,
            double? batchSize = default,
            double? width = default,
            double? height = default,
            double? seed = default,
            string? aspectRatio = default,
            global::System.Collections.Generic.IList<global::Krea.StyleImage>? styleImages = default,
            global::System.Collections.Generic.IList<global::Krea.StyleReference>? styles = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}