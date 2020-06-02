using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class WatchHook
    {
        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("repository")]
        public Repository Repository { get; set; }

        [JsonPropertyName("sender")]
        public Sender Sender { get; set; }
    }
}