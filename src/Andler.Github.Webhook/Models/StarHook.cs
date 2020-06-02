using System;
using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class StarHook
    {
        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("starred_at")]
        public DateTime? StarredAt { get; set; }

        [JsonPropertyName("repository")]
        public Repository Repository { get; set; }

        [JsonPropertyName("sender")]
        public Sender Sender { get; set; }
    }
}