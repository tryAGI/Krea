
#nullable enable

namespace Krea
{
    /// <summary>
    /// Uploaded user asset (image/video/audio/3D model) that can be referenced in generation requests.
    /// </summary>
    public sealed partial class Asset
    {
        /// <summary>
        /// Unique asset identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Public URL of the asset, suitable for use in generation requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when the asset was uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UploadedAt { get; set; }

        /// <summary>
        /// Pixel width, when applicable (images/videos).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Pixel height, when applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        /// File size in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        public double? SizeBytes { get; set; }

        /// <summary>
        /// MIME type of the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Optional human-readable description provided at upload time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Free-form metadata associated with the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique asset identifier.
        /// </param>
        /// <param name="imageUrl">
        /// Public URL of the asset, suitable for use in generation requests.
        /// </param>
        /// <param name="uploadedAt">
        /// ISO 8601 timestamp when the asset was uploaded.
        /// </param>
        /// <param name="width">
        /// Pixel width, when applicable (images/videos).
        /// </param>
        /// <param name="height">
        /// Pixel height, when applicable.
        /// </param>
        /// <param name="sizeBytes">
        /// File size in bytes.
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the uploaded file.
        /// </param>
        /// <param name="description">
        /// Optional human-readable description provided at upload time.
        /// </param>
        /// <param name="metadata">
        /// Free-form metadata associated with the asset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Asset(
            global::System.Guid id,
            string imageUrl,
            global::System.DateTime uploadedAt,
            double? width,
            double? height,
            double? sizeBytes,
            string? mimeType,
            string? description,
            object? metadata)
        {
            this.Id = id;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.UploadedAt = uploadedAt;
            this.Width = width;
            this.Height = height;
            this.SizeBytes = sizeBytes;
            this.MimeType = mimeType;
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        public Asset()
        {
        }

    }
}