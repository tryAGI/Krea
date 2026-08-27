
#nullable enable

namespace Krea
{
    /// <summary>
    /// Default Value: All
    /// </summary>
    public enum TopazEnhanceRequestSubjectDetection
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Background,
        /// <summary>
        ///
        /// </summary>
        Foreground,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopazEnhanceRequestSubjectDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopazEnhanceRequestSubjectDetection value)
        {
            return value switch
            {
                TopazEnhanceRequestSubjectDetection.All => "All",
                TopazEnhanceRequestSubjectDetection.Background => "Background",
                TopazEnhanceRequestSubjectDetection.Foreground => "Foreground",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopazEnhanceRequestSubjectDetection? ToEnum(string value)
        {
            return value switch
            {
                "All" => TopazEnhanceRequestSubjectDetection.All,
                "Background" => TopazEnhanceRequestSubjectDetection.Background,
                "Foreground" => TopazEnhanceRequestSubjectDetection.Foreground,
                _ => null,
            };
        }
    }
}