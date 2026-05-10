
#nullable enable

namespace Krea
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Veo3Request
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
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Krea.JsonConverters.Veo3RequestAspectRatioJsonConverter))]
        public global::Krea.Veo3RequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Range 4-8 seconds.<br/>
        /// Default Value: 8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generateAudio")]
        public bool? GenerateAudio { get; set; }

        /// <summary>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Krea.JsonConverters.Veo3RequestResolutionJsonConverter))]
        public global::Krea.Veo3RequestResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Veo3Request" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Veo3Request(
            string prompt,
            string? startImage,
            global::Krea.Veo3RequestAspectRatio? aspectRatio,
            double? duration,
            bool? generateAudio,
            global::Krea.Veo3RequestResolution? resolution)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.StartImage = startImage;
            this.AspectRatio = aspectRatio;
            this.Duration = duration;
            this.GenerateAudio = generateAudio;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Veo3Request" /> class.
        /// </summary>
        public Veo3Request()
        {
        }

    }
}