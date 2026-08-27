
#nullable enable

namespace Krea
{
    /// <summary>
    /// Image reference with strength weighting.
    /// </summary>
    public sealed partial class StyleImage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Weight for this reference image. Range -2 to 2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Strength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleImage" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="strength">
        /// Weight for this reference image. Range -2 to 2.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StyleImage(
            string url,
            double strength)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Strength = strength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleImage" /> class.
        /// </summary>
        public StyleImage()
        {
        }

    }
}