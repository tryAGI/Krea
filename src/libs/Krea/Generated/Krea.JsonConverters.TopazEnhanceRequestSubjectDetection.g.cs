#nullable enable

namespace Krea.JsonConverters
{
    /// <inheritdoc />
    public sealed class TopazEnhanceRequestSubjectDetectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Krea.TopazEnhanceRequestSubjectDetection>
    {
        /// <inheritdoc />
        public override global::Krea.TopazEnhanceRequestSubjectDetection Read(
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
                        return global::Krea.TopazEnhanceRequestSubjectDetectionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Krea.TopazEnhanceRequestSubjectDetection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Krea.TopazEnhanceRequestSubjectDetection);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Krea.TopazEnhanceRequestSubjectDetection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Krea.TopazEnhanceRequestSubjectDetectionExtensions.ToValueString(value));
        }
    }
}
