
#nullable enable

namespace Krea
{
    /// <summary>
    /// Flux Kontext request body for image-to-image editing.
    /// </summary>
    public sealed partial class FluxKontextRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Primary image to edit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public double? Strength { get; set; }

        /// <summary>
        /// Default Value: 1860966557
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// Diffusion steps. Range 1-100.<br/>
        /// Default Value: 25
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Range 512-2368.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Range 512-2368.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        /// Prompt adherence strength. Range 0-24.<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale_flux")]
        public double? GuidanceScaleFlux { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relaxedModeAccess")]
        public bool? RelaxedModeAccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styleImages")]
        public global::System.Collections.Generic.IList<global::Krea.StyleImage>? StyleImages { get; set; }

        /// <summary>
        /// Style reference images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageStyleRefs")]
        public global::System.Collections.Generic.IList<global::Krea.StyleImage>? ImageStyleRefs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styles")]
        public global::System.Collections.Generic.IList<global::Krea.StyleReference>? Styles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluxKontextRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="imageUrl">
        /// Primary image to edit.
        /// </param>
        /// <param name="strength">
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Default Value: 1860966557
        /// </param>
        /// <param name="steps">
        /// Diffusion steps. Range 1-100.<br/>
        /// Default Value: 25
        /// </param>
        /// <param name="width">
        /// Range 512-2368.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="height">
        /// Range 512-2368.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="guidanceScaleFlux">
        /// Prompt adherence strength. Range 0-24.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="relaxedModeAccess"></param>
        /// <param name="styleImages"></param>
        /// <param name="imageStyleRefs">
        /// Style reference images.
        /// </param>
        /// <param name="styles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FluxKontextRequest(
            string prompt,
            string? imageUrl,
            double? strength,
            double? seed,
            int? steps,
            double? width,
            double? height,
            double? guidanceScaleFlux,
            bool? relaxedModeAccess,
            global::System.Collections.Generic.IList<global::Krea.StyleImage>? styleImages,
            global::System.Collections.Generic.IList<global::Krea.StyleImage>? imageStyleRefs,
            global::System.Collections.Generic.IList<global::Krea.StyleReference>? styles)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ImageUrl = imageUrl;
            this.Strength = strength;
            this.Seed = seed;
            this.Steps = steps;
            this.Width = width;
            this.Height = height;
            this.GuidanceScaleFlux = guidanceScaleFlux;
            this.RelaxedModeAccess = relaxedModeAccess;
            this.StyleImages = styleImages;
            this.ImageStyleRefs = imageStyleRefs;
            this.Styles = styles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluxKontextRequest" /> class.
        /// </summary>
        public FluxKontextRequest()
        {
        }

    }
}