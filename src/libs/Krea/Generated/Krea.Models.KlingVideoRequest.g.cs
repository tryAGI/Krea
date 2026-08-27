
#nullable enable

namespace Krea
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KlingVideoRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startImage")]
        public string? StartImage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endImage")]
        public string? EndImage { get; set; }

        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Krea.JsonConverters.KlingVideoRequestAspectRatioJsonConverter))]
        public global::Krea.KlingVideoRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Default Value: master
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Krea.JsonConverters.KlingVideoRequestModeJsonConverter))]
        public global::Krea.KlingVideoRequestMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KlingVideoRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="startImage"></param>
        /// <param name="endImage"></param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="duration">
        /// Default Value: 5
        /// </param>
        /// <param name="mode">
        /// Default Value: master
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KlingVideoRequest(
            string prompt,
            string? startImage,
            string? endImage,
            global::Krea.KlingVideoRequestAspectRatio? aspectRatio,
            double? duration,
            global::Krea.KlingVideoRequestMode? mode)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.StartImage = startImage;
            this.EndImage = endImage;
            this.AspectRatio = aspectRatio;
            this.Duration = duration;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KlingVideoRequest" /> class.
        /// </summary>
        public KlingVideoRequest()
        {
        }

    }
}