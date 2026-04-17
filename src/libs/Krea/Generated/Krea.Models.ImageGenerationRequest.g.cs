
#nullable enable

namespace Krea
{
    /// <summary>
    /// Request body accepted by most Krea text-to-image endpoints.
    /// </summary>
    public sealed partial class ImageGenerationRequest
    {
        /// <summary>
        /// Text description of the desired image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Number of images to generate in one call. Range 1-4.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batchSize")]
        public double? BatchSize { get; set; }

        /// <summary>
        /// Output width in pixels. Check each model for supported range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Output height in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        /// Random seed for reproducibility.<br/>
        /// Default Value: 1337
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// Aspect ratio hint, when supported (e.g. '16:9', '1:1', '9:16').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Reference images weighted to steer composition/content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styleImages")]
        public global::System.Collections.Generic.IList<global::Krea.StyleImage>? StyleImages { get; set; }

        /// <summary>
        /// Trained LoRA styles to apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styles")]
        public global::System.Collections.Generic.IList<global::Krea.StyleReference>? Styles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text description of the desired image.
        /// </param>
        /// <param name="batchSize">
        /// Number of images to generate in one call. Range 1-4.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="width">
        /// Output width in pixels. Check each model for supported range.
        /// </param>
        /// <param name="height">
        /// Output height in pixels.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.<br/>
        /// Default Value: 1337
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio hint, when supported (e.g. '16:9', '1:1', '9:16').
        /// </param>
        /// <param name="styleImages">
        /// Reference images weighted to steer composition/content.
        /// </param>
        /// <param name="styles">
        /// Trained LoRA styles to apply.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationRequest(
            string prompt,
            double? batchSize,
            double? width,
            double? height,
            double? seed,
            string? aspectRatio,
            global::System.Collections.Generic.IList<global::Krea.StyleImage>? styleImages,
            global::System.Collections.Generic.IList<global::Krea.StyleReference>? styles)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.BatchSize = batchSize;
            this.Width = width;
            this.Height = height;
            this.Seed = seed;
            this.AspectRatio = aspectRatio;
            this.StyleImages = styleImages;
            this.Styles = styles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        public ImageGenerationRequest()
        {
        }
    }
}