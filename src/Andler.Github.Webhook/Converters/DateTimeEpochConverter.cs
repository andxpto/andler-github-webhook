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
            var epochTime = reader.GetString();

            if (string.IsNullOrWhiteSpace(epochTime))
            {
                return null;
            }

            return DateTime.UnixEpoch.AddSeconds(double.Parse(epochTime));
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