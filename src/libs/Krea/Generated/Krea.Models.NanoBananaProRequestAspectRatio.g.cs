
#nullable enable

namespace Krea
{
    /// <summary>
    ///
    /// </summary>
    public enum NanoBananaProRequestAspectRatio
    {
        /// <summary>
        ///
        /// </summary>
        x16_9,
        /// <summary>
        ///
        /// </summary>
        x1_1,
        /// <summary>
        ///
        /// </summary>
        x21_9,
        /// <summary>
        ///
        /// </summary>
        x2_3,
        /// <summary>
        ///
        /// </summary>
        x3_2,
        /// <summary>
        ///
        /// </summary>
        x3_4,
        /// <summary>
        ///
        /// </summary>
        x4_3,
        /// <summary>
        ///
        /// </summary>
        x4_5,
        /// <summary>
        ///
        /// </summary>
        x5_4,
        /// <summary>
        ///
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NanoBananaProRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NanoBananaProRequestAspectRatio value)
        {
            return value switch
            {
                NanoBananaProRequestAspectRatio.x16_9 => "16:9",
                NanoBananaProRequestAspectRatio.x1_1 => "1:1",
                NanoBananaProRequestAspectRatio.x21_9 => "21:9",
                NanoBananaProRequestAspectRatio.x2_3 => "2:3",
                NanoBananaProRequestAspectRatio.x3_2 => "3:2",
                NanoBananaProRequestAspectRatio.x3_4 => "3:4",
                NanoBananaProRequestAspectRatio.x4_3 => "4:3",
                NanoBananaProRequestAspectRatio.x4_5 => "4:5",
                NanoBananaProRequestAspectRatio.x5_4 => "5:4",
                NanoBananaProRequestAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NanoBananaProRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => NanoBananaProRequestAspectRatio.x16_9,
                "1:1" => NanoBananaProRequestAspectRatio.x1_1,
                "21:9" => NanoBananaProRequestAspectRatio.x21_9,
                "2:3" => NanoBananaProRequestAspectRatio.x2_3,
                "3:2" => NanoBananaProRequestAspectRatio.x3_2,
                "3:4" => NanoBananaProRequestAspectRatio.x3_4,
                "4:3" => NanoBananaProRequestAspectRatio.x4_3,
                "4:5" => NanoBananaProRequestAspectRatio.x4_5,
                "5:4" => NanoBananaProRequestAspectRatio.x5_4,
                "9:16" => NanoBananaProRequestAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}