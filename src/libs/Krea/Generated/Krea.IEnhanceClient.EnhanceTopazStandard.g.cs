#nullable enable

namespace Krea
{
    public partial interface IEnhanceClient
    {
        /// <summary>
        /// Enhance image with Topaz (standard)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> EnhanceTopazStandardAsync(

            global::Krea.TopazEnhanceRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enhance image with Topaz (standard)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.AutoSDKHttpResponse<global::Krea.Job>> EnhanceTopazStandardAsResponseAsync(

            global::Krea.TopazEnhanceRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enhance image with Topaz (standard)
        /// </summary>
        /// <param name="batchSize">
        /// Default Value: 1
        /// </param>
        /// <param name="width">
        /// Output width in pixels. Range 1-32000.
        /// </param>
        /// <param name="height">
        /// Output height in pixels. Range 1-32000.
        /// </param>
        /// <param name="seed">
        /// Default Value: 1337
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="outputFormat">
        /// Default Value: jpg
        /// </param>
        /// <param name="subjectDetection">
        /// Default Value: All
        /// </param>
        /// <param name="faceEnhancement">
        /// Default Value: false
        /// </param>
        /// <param name="faceEnhancementCreativity">
        /// Default Value: 0.5
        /// </param>
        /// <param name="faceEnhancementStrength">
        /// Default Value: 0.5
        /// </param>
        /// <param name="cropToFill">
        /// Default Value: false
        /// </param>
        /// <param name="imageUrl">
        /// Source image to enhance.
        /// </param>
        /// <param name="model">
        /// Topaz model variant.
        /// </param>
        /// <param name="upscalingActivated">
        /// Default Value: false
        /// </param>
        /// <param name="imageScalingFactor">
        /// Range 1-32.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="sharpen">
        /// Default Value: 0.5
        /// </param>
        /// <param name="denoise">
        /// Default Value: 0.5
        /// </param>
        /// <param name="fixCompression">
        /// Default Value: 0.5
        /// </param>
        /// <param name="strength">
        /// Default Value: 0.5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Job> EnhanceTopazStandardAsync(
            double width,
            double height,
            string imageUrl,
            global::Krea.TopazEnhanceRequestModel model,
            double? batchSize = default,
            double? seed = default,
            string? prompt = default,
            global::Krea.TopazEnhanceRequestOutputFormat? outputFormat = default,
            global::Krea.TopazEnhanceRequestSubjectDetection? subjectDetection = default,
            bool? faceEnhancement = default,
            double? faceEnhancementCreativity = default,
            double? faceEnhancementStrength = default,
            bool? cropToFill = default,
            bool? upscalingActivated = default,
            double? imageScalingFactor = default,
            double? sharpen = default,
            double? denoise = default,
            double? fixCompression = default,
            double? strength = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}