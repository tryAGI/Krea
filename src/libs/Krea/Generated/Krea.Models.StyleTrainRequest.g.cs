
#nullable enable

namespace Krea
{
    /// <summary>
    /// Train a custom LoRA style from a set of reference images.
    /// </summary>
    public sealed partial class StyleTrainRequest
    {
        /// <summary>
        /// Display name for the style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Training images (URLs to uploaded Krea assets work best).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ImageUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleTrainRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name for the style.
        /// </param>
        /// <param name="imageUrls">
        /// Training images (URLs to uploaded Krea assets work best).
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StyleTrainRequest(
            string name,
            global::System.Collections.Generic.IList<string> imageUrls,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ImageUrls = imageUrls ?? throw new global::System.ArgumentNullException(nameof(imageUrls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleTrainRequest" /> class.
        /// </summary>
        public StyleTrainRequest()
        {
        }

    }
}