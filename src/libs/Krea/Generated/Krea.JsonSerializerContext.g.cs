
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Krea
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Krea.JsonConverters.JobStatusJsonConverter),

            typeof(global::Krea.JsonConverters.JobStatusNullableJsonConverter),

            typeof(global::Krea.JsonConverters.NanoBananaProRequestAspectRatioJsonConverter),

            typeof(global::Krea.JsonConverters.NanoBananaProRequestAspectRatioNullableJsonConverter),

            typeof(global::Krea.JsonConverters.NanoBananaProRequestResolutionJsonConverter),

            typeof(global::Krea.JsonConverters.NanoBananaProRequestResolutionNullableJsonConverter),

            typeof(global::Krea.JsonConverters.KlingVideoRequestAspectRatioJsonConverter),

            typeof(global::Krea.JsonConverters.KlingVideoRequestAspectRatioNullableJsonConverter),

            typeof(global::Krea.JsonConverters.KlingVideoRequestModeJsonConverter),

            typeof(global::Krea.JsonConverters.KlingVideoRequestModeNullableJsonConverter),

            typeof(global::Krea.JsonConverters.Veo3RequestAspectRatioJsonConverter),

            typeof(global::Krea.JsonConverters.Veo3RequestAspectRatioNullableJsonConverter),

            typeof(global::Krea.JsonConverters.Veo3RequestResolutionJsonConverter),

            typeof(global::Krea.JsonConverters.Veo3RequestResolutionNullableJsonConverter),

            typeof(global::Krea.JsonConverters.Sora2RequestAspectRatioJsonConverter),

            typeof(global::Krea.JsonConverters.Sora2RequestAspectRatioNullableJsonConverter),

            typeof(global::Krea.JsonConverters.TopazEnhanceRequestOutputFormatJsonConverter),

            typeof(global::Krea.JsonConverters.TopazEnhanceRequestOutputFormatNullableJsonConverter),

            typeof(global::Krea.JsonConverters.TopazEnhanceRequestSubjectDetectionJsonConverter),

            typeof(global::Krea.JsonConverters.TopazEnhanceRequestSubjectDetectionNullableJsonConverter),

            typeof(global::Krea.JsonConverters.TopazEnhanceRequestModelJsonConverter),

            typeof(global::Krea.JsonConverters.TopazEnhanceRequestModelNullableJsonConverter),

            typeof(global::Krea.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.JobStatus), TypeInfoPropertyName = "JobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.JobResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.Job))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.JobList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Krea.Job>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.Asset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.AssetList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Krea.Asset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.AssetUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.DeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.StyleImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.StyleReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.ImageGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Krea.StyleImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Krea.StyleReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.FluxKontextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.NanoBananaProRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.NanoBananaProRequestAspectRatio), TypeInfoPropertyName = "NanoBananaProRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.NanoBananaProRequestResolution), TypeInfoPropertyName = "NanoBananaProRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.IdeogramRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.VideoGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.KlingVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.KlingVideoRequestAspectRatio), TypeInfoPropertyName = "KlingVideoRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.KlingVideoRequestMode), TypeInfoPropertyName = "KlingVideoRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.Veo3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.Veo3RequestAspectRatio), TypeInfoPropertyName = "Veo3RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.Veo3RequestResolution), TypeInfoPropertyName = "Veo3RequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.Sora2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.Sora2RequestAspectRatio), TypeInfoPropertyName = "Sora2RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.TopazEnhanceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.TopazEnhanceRequestOutputFormat), TypeInfoPropertyName = "TopazEnhanceRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.TopazEnhanceRequestSubjectDetection), TypeInfoPropertyName = "TopazEnhanceRequestSubjectDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.TopazEnhanceRequestModel), TypeInfoPropertyName = "TopazEnhanceRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.StyleTrainRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.Style))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.StyleList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Krea.Style>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.StyleShareLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.NodeApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.NodeAppExecuteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Krea.UpdateStyleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Krea.Job>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Krea.Asset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Krea.StyleImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Krea.StyleReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Krea.Style>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}