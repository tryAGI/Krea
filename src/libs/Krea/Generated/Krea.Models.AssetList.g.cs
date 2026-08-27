
#nullable enable

namespace Krea
{
    /// <summary>
    /// Paginated list of assets.
    /// </summary>
    public sealed partial class AssetList
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::Krea.Asset>? Items { get; set; }

        /// <summary>
        /// Opaque cursor to fetch the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetList" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="nextCursor">
        /// Opaque cursor to fetch the next page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetList(
            global::System.Collections.Generic.IList<global::Krea.Asset>? items,
            string? nextCursor)
        {
            this.Items = items;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetList" /> class.
        /// </summary>
        public AssetList()
        {
        }

    }
}