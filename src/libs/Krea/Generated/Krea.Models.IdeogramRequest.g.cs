
#nullable enable

namespace Krea
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IdeogramRequest
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
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        /// Default Value: 1337
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public double? Seed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styleImages")]
        public global::System.Collections.Generic.IList<global::Krea.StyleImage>? StyleImages { get; set; }

        /// <summary>
        /// Reference images used to keep character identity consistent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characterReferenceImages")]
        public global::System.Collections.Generic.IList<string>? CharacterReferenceImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdeogramRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="batchSize">
        /// Default Value: 1
        /// </param>
        /// <param name="width">
        /// Default Value: 1024
        /// </param>
        /// <param name="height">
        /// Default Value: 1024
        /// </param>
        /// <param name="seed">
        /// Default Value: 1337
        /// </param>
        /// <param name="styleImages"></param>
        /// <param name="characterReferenceImages">
        /// Reference images used to keep character identity consistent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdeogramRequest(
            string prompt,
            double? batchSize,
            double? width,
            double? height,
            double? seed,
            global::System.Collections.Generic.IList<global::Krea.StyleImage>? styleImages,
            global::System.Collections.Generic.IList<string>? characterReferenceImages)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.BatchSize = batchSize;
            this.Width = width;
            this.Height = height;
            this.Seed = seed;
            this.StyleImages = styleImages;
            this.CharacterReferenceImages = characterReferenceImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdeogramRequest" /> class.
        /// </summary>
        public IdeogramRequest()
        {
        }

    }
}