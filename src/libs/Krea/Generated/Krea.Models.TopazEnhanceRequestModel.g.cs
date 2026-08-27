
#nullable enable

namespace Krea
{
    /// <summary>
    /// Topaz model variant.
    /// </summary>
    public enum TopazEnhanceRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        Cgi,
        /// <summary>
        ///
        /// </summary>
        HighFidelityV2,
        /// <summary>
        ///
        /// </summary>
        LowResolutionV2,
        /// <summary>
        ///
        /// </summary>
        StandardV2,
        /// <summary>
        ///
        /// </summary>
        TextRefine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopazEnhanceRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopazEnhanceRequestModel value)
        {
            return value switch
            {
                TopazEnhanceRequestModel.Cgi => "CGI",
                TopazEnhanceRequestModel.HighFidelityV2 => "High Fidelity V2",
                TopazEnhanceRequestModel.LowResolutionV2 => "Low Resolution V2",
                TopazEnhanceRequestModel.StandardV2 => "Standard V2",
                TopazEnhanceRequestModel.TextRefine => "Text Refine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopazEnhanceRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "CGI" => TopazEnhanceRequestModel.Cgi,
                "High Fidelity V2" => TopazEnhanceRequestModel.HighFidelityV2,
                "Low Resolution V2" => TopazEnhanceRequestModel.LowResolutionV2,
                "Standard V2" => TopazEnhanceRequestModel.StandardV2,
                "Text Refine" => TopazEnhanceRequestModel.TextRefine,
                _ => null,
            };
        }
    }
}