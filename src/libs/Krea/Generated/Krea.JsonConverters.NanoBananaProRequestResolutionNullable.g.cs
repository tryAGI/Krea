#nullable enable

namespace Krea.JsonConverters
{
    /// <inheritdoc />
    public sealed class NanoBananaProRequestResolutionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Krea.NanoBananaProRequestResolution?>
    {
        /// <inheritdoc />
        public override global::Krea.NanoBananaProRequestResolution? Read(
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
                        return global::Krea.NanoBananaProRequestResolutionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Krea.NanoBananaProRequestResolution)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Krea.NanoBananaProRequestResolution?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Krea.NanoBananaProRequestResolution? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Krea.NanoBananaProRequestResolutionExtensions.ToValueString(value.Value));
            }
        }
    }
}
