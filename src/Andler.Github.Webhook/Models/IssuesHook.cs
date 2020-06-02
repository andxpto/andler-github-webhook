using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class IssueHook
    {
        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("issue")]
        public Issue Issue { get; set; }

        [JsonPropertyName("changes")]
        public Changes Changes { get; set; }

        [JsonPropertyName("repository")]
        public Repository Repository { get; set; }

        [JsonPropertyName("sender")]
        public Sender Sender { get; set; }
    }
}