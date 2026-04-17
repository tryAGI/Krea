
#nullable enable

namespace Krea
{
    /// <summary>
    /// Request body accepted by most Krea video endpoints.
    /// </summary>
    public sealed partial class VideoGenerationRequest
    {
        /// <summary>
        /// Text description of the desired video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Starting frame for image-to-video mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startImage")]
        public string? StartImage { get; set; }

        /// <summary>
        /// Ending frame (when supported by the model).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endImage")]
        public string? EndImage { get; set; }

        /// <summary>
        /// Aspect ratio, e.g. '16:9', '9:16', '1:1'.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Length in seconds. Supported range varies by model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Output resolution (e.g. '720p', '1080p').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// Whether to render audio alongside the video (model-dependent).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generateAudio")]
        public bool? GenerateAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationRequest(
            string prompt,
            string? startImage,
            string? endImage,
            string? aspectRatio,
            double? duration,
            string? resolution,
            bool? generateAudio)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.StartImage = startImage;
            this.EndImage = endImage;
            this.AspectRatio = aspectRatio;
            this.Duration = duration;
            this.Resolution = resolution;
            this.GenerateAudio = generateAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequest" /> class.
        /// </summary>
        public VideoGenerationRequest()
        {
        }
    }
}