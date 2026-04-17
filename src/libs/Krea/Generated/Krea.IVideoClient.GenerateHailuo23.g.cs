#nullable enable

namespace Krea
{
    public partial interface IVideoClient
    {
        /// <summary>
        /// Generate video with Hailuo 2.3
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> GenerateHailuo23Async(

            global::Krea.VideoGenerationRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate video with Hailuo 2.3
        /// </summary>
        /// <param name="prompt">
        /// Text description of the desired video.
        /// </param>
        /// <param name="startImage">
        /// Starting frame for image-to-video mode.
        /// </param>
        /// <param name="endImage">
        /// Ending frame (when supported by the model).
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio, e.g. '16:9', '9:16', '1:1'.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="duration">
        /// Length in seconds. Supported range varies by model.
        /// </param>
        /// <param name="resolution">
        /// Output resolution (e.g. '720p', '1080p').
        /// </param>
        /// <param name="generateAudio">
        /// Whether to render audio alongside the video (model-dependent).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> GenerateHailuo23Async(
            string prompt,
            string? startImage = default,
            string? endImage = default,
            string? aspectRatio = default,
            double? duration = default,
            string? resolution = default,
            bool? generateAudio = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}