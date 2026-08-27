
#nullable enable

namespace Krea
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NanoBananaProRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batchSize")]
        public double? BatchSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Krea.JsonConverters.NanoBananaProRequestAspectRatioJsonConverter))]
        public global::Krea.NanoBananaProRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 1K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Krea.JsonConverters.NanoBananaProRequestResolutionJsonConverter))]
        public global::Krea.NanoBananaProRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Direct image prompts. If provided, `styleImages` is ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrls")]
        public global::System.Collections.Generic.IList<string>? ImageUrls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styleImages")]
        public global::System.Collections.Generic.IList<global::Krea.StyleImage>? StyleImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NanoBananaProRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="batchSize">
        /// Default Value: 1
        /// </param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="resolution">
        /// Default Value: 1K
        /// </param>
        /// <param name="imageUrls">
        /// Direct image prompts. If provided, `styleImages` is ignored.
        /// </param>
        /// <param name="styleImages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NanoBananaProRequest(
            string prompt,
            double? batchSize,
            double? width,
            double? height,
            global::Krea.NanoBananaProRequestAspectRatio? aspectRatio,
            global::Krea.NanoBananaProRequestResolution? resolution,
            global::System.Collections.Generic.IList<string>? imageUrls,
            global::System.Collections.Generic.IList<global::Krea.StyleImage>? styleImages)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.BatchSize = batchSize;
            this.Width = width;
            this.Height = height;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.ImageUrls = imageUrls;
            this.StyleImages = styleImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NanoBananaProRequest" /> class.
        /// </summary>
        public NanoBananaProRequest()
        {
        }

    }
}