using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class DefaultHook
    {
        public string Delivery { get; set; }

        public string Event { get; set; }

        public string UserAgent { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; }

        public string Payload { get; set; }

        [JsonPropertyName("repository")]
        public Repository Repository { get; set; }
    }
}