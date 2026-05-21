#nullable enable

namespace Krea
{
    public partial interface IVideoClient
    {
        /// <summary>
        /// Generate video with Veo 3 Fast
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> GenerateVeo3FastAsync(

            global::Krea.Veo3Request request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate video with Veo 3 Fast
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.AutoSDKHttpResponse<global::Krea.Job>> GenerateVeo3FastAsResponseAsync(

            global::Krea.Veo3Request request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate video with Veo 3 Fast
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="startImage"></param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="duration">
        /// Range 4-8 seconds.<br/>
        /// Default Value: 8
        /// </param>
        /// <param name="generateAudio">
        /// Default Value: false
        /// </param>
        /// <param name="resolution">
        /// Default Value: 720p
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> GenerateVeo3FastAsync(
            string prompt,
            string? startImage = default,
            global::Krea.Veo3RequestAspectRatio? aspectRatio = default,
            double? duration = default,
            bool? generateAudio = default,
            global::Krea.Veo3RequestResolution? resolution = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}