#nullable enable

namespace Krea.JsonConverters
{
    /// <inheritdoc />
    public sealed class TopazEnhanceRequestModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Krea.TopazEnhanceRequestModel?>
    {
        /// <inheritdoc />
        public override global::Krea.TopazEnhanceRequestModel? Read(
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
                        return global::Krea.TopazEnhanceRequestModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Krea.TopazEnhanceRequestModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Krea.TopazEnhanceRequestModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Krea.TopazEnhanceRequestModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Krea.TopazEnhanceRequestModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
