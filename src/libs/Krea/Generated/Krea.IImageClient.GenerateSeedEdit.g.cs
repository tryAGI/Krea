#nullable enable

namespace Krea
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Edit image with SeedEdit (ByteDance)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> GenerateSeedEditAsync(

            global::Krea.FluxKontextRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit image with SeedEdit (ByteDance)
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="imageUrl">
        /// Primary image to edit.
        /// </param>
        /// <param name="strength">
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Default Value: 1860966557
        /// </param>
        /// <param name="steps">
        /// Diffusion steps. Range 1-100.<br/>
        /// Default Value: 25
        /// </param>
        /// <param name="width">
        /// Range 512-2368.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="height">
        /// Range 512-2368.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="guidanceScaleFlux">
        /// Prompt adherence strength. Range 0-24.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="relaxedModeAccess"></param>
        /// <param name="styleImages"></param>
        /// <param name="imageStyleRefs">
        /// Style reference images.
        /// </param>
        /// <param name="styles"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> GenerateSeedEditAsync(
            string prompt,
            string? imageUrl = default,
            double? strength = default,
            double? seed = default,
            int? steps = default,
            double? width = default,
            double? height = default,
            double? guidanceScaleFlux = default,
            bool? relaxedModeAccess = default,
            global::System.Collections.Generic.IList<global::Krea.StyleImage>? styleImages = default,
            global::System.Collections.Generic.IList<global::Krea.StyleImage>? imageStyleRefs = default,
            global::System.Collections.Generic.IList<global::Krea.StyleReference>? styles = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}