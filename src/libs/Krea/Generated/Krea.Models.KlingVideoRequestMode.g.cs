
#nullable enable

namespace Krea
{
    /// <summary>
    /// Default Value: master
    /// </summary>
    public enum KlingVideoRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        Master,
        /// <summary>
        /// 
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KlingVideoRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KlingVideoRequestMode value)
        {
            return value switch
            {
                KlingVideoRequestMode.Master => "master",
                KlingVideoRequestMode.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KlingVideoRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "master" => KlingVideoRequestMode.Master,
                "pro" => KlingVideoRequestMode.Pro,
                _ => null,
            };
        }
    }
}