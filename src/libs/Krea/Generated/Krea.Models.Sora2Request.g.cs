
#nullable enable

namespace Krea
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sora2Request
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
        /// Range 4-20 seconds.<br/>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Krea.JsonConverters.Sora2RequestAspectRatioJsonConverter))]
        public global::Krea.Sora2RequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sora2Request" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sora2Request(
            string prompt,
            string? startImage,
            double? duration,
            global::Krea.Sora2RequestAspectRatio? aspectRatio)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.StartImage = startImage;
            this.Duration = duration;
            this.AspectRatio = aspectRatio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sora2Request" /> class.
        /// </summary>
        public Sora2Request()
        {
        }

    }
}