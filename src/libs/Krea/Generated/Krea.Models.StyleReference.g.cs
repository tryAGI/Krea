
#nullable enable

namespace Krea
{
    /// <summary>
    /// Trained style (LoRA) reference.
    /// </summary>
    public sealed partial class StyleReference
    {
        /// <summary>
        /// Style identifier returned by `/styles/train`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Weight for the style. Range -2 to 2.
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
        /// Initializes a new instance of the <see cref="StyleReference" /> class.
        /// </summary>
        /// <param name="id">
        /// Style identifier returned by `/styles/train`.
        /// </param>
        /// <param name="strength">
        /// Weight for the style. Range -2 to 2.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StyleReference(
            string id,
            double strength)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Strength = strength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleReference" /> class.
        /// </summary>
        public StyleReference()
        {
        }
    }
}