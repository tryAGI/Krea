
#nullable enable

namespace Krea
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum Sora2RequestAspectRatio
    {
        /// <summary>
        ///
        /// </summary>
        x16_9,
        /// <summary>
        ///
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Sora2RequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Sora2RequestAspectRatio value)
        {
            return value switch
            {
                Sora2RequestAspectRatio.x16_9 => "16:9",
                Sora2RequestAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Sora2RequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => Sora2RequestAspectRatio.x16_9,
                "9:16" => Sora2RequestAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}