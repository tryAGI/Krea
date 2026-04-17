#nullable enable

namespace Krea
{
    public partial interface IStylesClient
    {
        /// <summary>
        /// Train a custom style (LoRA)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> TrainStyleAsync(

            global::Krea.StyleTrainRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Train a custom style (LoRA)
        /// </summary>
        /// <param name="name">
        /// Display name for the style.
        /// </param>
        /// <param name="description"></param>
        /// <param name="imageUrls">
        /// Training images (URLs to uploaded Krea assets work best).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> TrainStyleAsync(
            string name,
            global::System.Collections.Generic.IList<string> imageUrls,
            string? description = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}