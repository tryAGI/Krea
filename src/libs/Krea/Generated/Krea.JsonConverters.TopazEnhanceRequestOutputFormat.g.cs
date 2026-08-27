#nullable enable

namespace Krea.JsonConverters
{
    /// <inheritdoc />
    public sealed class TopazEnhanceRequestOutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Krea.TopazEnhanceRequestOutputFormat>
    {
        /// <inheritdoc />
        public override global::Krea.TopazEnhanceRequestOutputFormat Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Krea.TopazEnhanceRequestOutputFormatExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Krea.TopazEnhanceRequestOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Krea.TopazEnhanceRequestOutputFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Krea.TopazEnhanceRequestOutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Krea.TopazEnhanceRequestOutputFormatExtensions.ToValueString(value));
        }
    }
}
