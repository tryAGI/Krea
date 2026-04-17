
#nullable enable

namespace Krea
{
    /// <summary>
    /// Default Value: jpg
    /// </summary>
    public enum TopazEnhanceRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Jpg,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopazEnhanceRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopazEnhanceRequestOutputFormat value)
        {
            return value switch
            {
                TopazEnhanceRequestOutputFormat.Jpg => "jpg",
                TopazEnhanceRequestOutputFormat.Png => "png",
                TopazEnhanceRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopazEnhanceRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpg" => TopazEnhanceRequestOutputFormat.Jpg,
                "png" => TopazEnhanceRequestOutputFormat.Png,
                "webp" => TopazEnhanceRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}