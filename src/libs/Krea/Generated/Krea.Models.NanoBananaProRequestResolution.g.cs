
#nullable enable

namespace Krea
{
    /// <summary>
    /// Default Value: 1K
    /// </summary>
    public enum NanoBananaProRequestResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1k,
        /// <summary>
        ///
        /// </summary>
        x2k,
        /// <summary>
        ///
        /// </summary>
        x4k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NanoBananaProRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NanoBananaProRequestResolution value)
        {
            return value switch
            {
                NanoBananaProRequestResolution.x1k => "1K",
                NanoBananaProRequestResolution.x2k => "2K",
                NanoBananaProRequestResolution.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NanoBananaProRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => NanoBananaProRequestResolution.x1k,
                "2K" => NanoBananaProRequestResolution.x2k,
                "4K" => NanoBananaProRequestResolution.x4k,
                _ => null,
            };
        }
    }
}