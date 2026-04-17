
#nullable enable

namespace Krea
{
    /// <summary>
    /// Multipart upload body. `file` is binary data.
    /// </summary>
    public sealed partial class AssetUploadRequest
    {
        /// <summary>
        /// Binary file contents. Allowed: JPEG, PNG, WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3. Max 75 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// Binary file contents. Allowed: JPEG, PNG, WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3. Max 75 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Optional description to store with the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetUploadRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// Binary file contents. Allowed: JPEG, PNG, WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3. Max 75 MB.
        /// </param>
        /// <param name="filename">
        /// Binary file contents. Allowed: JPEG, PNG, WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3. Max 75 MB.
        /// </param>
        /// <param name="description">
        /// Optional description to store with the asset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetUploadRequest(
            byte[] file,
            string filename,
            string? description)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetUploadRequest" /> class.
        /// </summary>
        public AssetUploadRequest()
        {
        }
    }
}