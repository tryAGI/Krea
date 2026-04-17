
#nullable enable

namespace Krea
{
    /// <summary>
    /// Topaz standard/bloom/generative enhancement request.
    /// </summary>
    public sealed partial class TopazEnhanceRequest
    {
        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batchSize")]
        public double? BatchSize { get; set; }

        /// <summary>
        /// Output width in pixels. Range 1-32000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Width { get; set; }

        /// <summary>
        /// Output height in pixels. Range 1-32000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Height { get; set; }

        /// <summary>
        /// Default Value: 1337
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Default Value: jpg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Krea.JsonConverters.TopazEnhanceRequestOutputFormatJsonConverter))]
        public global::Krea.TopazEnhanceRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Default Value: All
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_detection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Krea.JsonConverters.TopazEnhanceRequestSubjectDetectionJsonConverter))]
        public global::Krea.TopazEnhanceRequestSubjectDetection? SubjectDetection { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_enhancement")]
        public bool? FaceEnhancement { get; set; }

        /// <summary>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_enhancement_creativity")]
        public double? FaceEnhancementCreativity { get; set; }

        /// <summary>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_enhancement_strength")]
        public double? FaceEnhancementStrength { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_to_fill")]
        public bool? CropToFill { get; set; }

        /// <summary>
        /// Source image to enhance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// Topaz model variant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Krea.JsonConverters.TopazEnhanceRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Krea.TopazEnhanceRequestModel Model { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscaling_activated")]
        public bool? UpscalingActivated { get; set; }

        /// <summary>
        /// Range 1-32.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_scaling_factor")]
        public double? ImageScalingFactor { get; set; }

        /// <summary>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharpen")]
        public double? Sharpen { get; set; }

        /// <summary>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("denoise")]
        public double? Denoise { get; set; }

        /// <summary>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fix_compression")]
        public double? FixCompression { get; set; }

        /// <summary>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public double? Strength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopazEnhanceRequest" /> class.
        /// </summary>
        /// <param name="width">
        /// Output width in pixels. Range 1-32000.
        /// </param>
        /// <param name="height">
        /// Output height in pixels. Range 1-32000.
        /// </param>
        /// <param name="imageUrl">
        /// Source image to enhance.
        /// </param>
        /// <param name="model">
        /// Topaz model variant.
        /// </param>
        /// <param name="batchSize">
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Default Value: 1337
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="outputFormat">
        /// Default Value: jpg
        /// </param>
        /// <param name="subjectDetection">
        /// Default Value: All
        /// </param>
        /// <param name="faceEnhancement">
        /// Default Value: false
        /// </param>
        /// <param name="faceEnhancementCreativity">
        /// Default Value: 0.5
        /// </param>
        /// <param name="faceEnhancementStrength">
        /// Default Value: 0.5
        /// </param>
        /// <param name="cropToFill">
        /// Default Value: false
        /// </param>
        /// <param name="upscalingActivated">
        /// Default Value: false
        /// </param>
        /// <param name="imageScalingFactor">
        /// Range 1-32.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="sharpen">
        /// Default Value: 0.5
        /// </param>
        /// <param name="denoise">
        /// Default Value: 0.5
        /// </param>
        /// <param name="fixCompression">
        /// Default Value: 0.5
        /// </param>
        /// <param name="strength">
        /// Default Value: 0.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopazEnhanceRequest(
            double width,
            double height,
            string imageUrl,
            global::Krea.TopazEnhanceRequestModel model,
            double? batchSize,
            double? seed,
            string? prompt,
            global::Krea.TopazEnhanceRequestOutputFormat? outputFormat,
            global::Krea.TopazEnhanceRequestSubjectDetection? subjectDetection,
            bool? faceEnhancement,
            double? faceEnhancementCreativity,
            double? faceEnhancementStrength,
            bool? cropToFill,
            bool? upscalingActivated,
            double? imageScalingFactor,
            double? sharpen,
            double? denoise,
            double? fixCompression,
            double? strength)
        {
            this.BatchSize = batchSize;
            this.Width = width;
            this.Height = height;
            this.Seed = seed;
            this.Prompt = prompt;
            this.OutputFormat = outputFormat;
            this.SubjectDetection = subjectDetection;
            this.FaceEnhancement = faceEnhancement;
            this.FaceEnhancementCreativity = faceEnhancementCreativity;
            this.FaceEnhancementStrength = faceEnhancementStrength;
            this.CropToFill = cropToFill;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Model = model;
            this.UpscalingActivated = upscalingActivated;
            this.ImageScalingFactor = imageScalingFactor;
            this.Sharpen = sharpen;
            this.Denoise = denoise;
            this.FixCompression = fixCompression;
            this.Strength = strength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopazEnhanceRequest" /> class.
        /// </summary>
        public TopazEnhanceRequest()
        {
        }
    }
}