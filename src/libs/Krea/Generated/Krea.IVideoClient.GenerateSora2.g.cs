#nullable enable

namespace Krea
{
    public partial interface IVideoClient
    {
        /// <summary>
        /// Generate video with Sora 2 (OpenAI)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> GenerateSora2Async(

            global::Krea.Sora2Request request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate video with Sora 2 (OpenAI)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.AutoSDKHttpResponse<global::Krea.Job>> GenerateSora2AsResponseAsync(

            global::Krea.Sora2Request request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate video with Sora 2 (OpenAI)
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="startImage"></param>
        /// <param name="duration">
        /// Range 4-20 seconds.<br/>
        /// Default Value: 4
        /// </param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> GenerateSora2Async(
            string prompt,
            string? startImage = default,
            double? duration = default,
            global::Krea.Sora2RequestAspectRatio? aspectRatio = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}