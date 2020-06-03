using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Converters
{
    public class DateTimeEpochConverter : JsonConverter<DateTime?>
    {
        // https://stackoverflow.com/a/3354915/1752882

        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                if (reader.TryGetDateTime(out var dateTime))
                {
                    return dateTime;
                }

                var epochTimeString = reader.GetString();

                if (string.IsNullOrWhiteSpace(epochTimeString))
                {
                    return null;
                }

                return DateTime.UnixEpoch.AddSeconds(double.Parse(epochTimeString));
            }

            if (reader.TokenType == JsonTokenType.Number && reader.TryGetDouble(out var epochTimeDouble))
            {
                return DateTime.UnixEpoch.AddSeconds(epochTimeDouble);
            }

            return null;
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (!value.HasValue)
            {
                writer.WriteNullValue();
            }

            TimeSpan diff = value.Value.ToUniversalTime() - DateTime.UnixEpoch;

            writer.WriteNumberValue(Math.Floor(diff.TotalSeconds));
        }
    }
}