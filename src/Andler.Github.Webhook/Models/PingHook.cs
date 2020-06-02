using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class PingHook
    {
        [JsonPropertyName("zen")]
        public string Zen { get; set; }

        [JsonPropertyName("hook_id")]
        public int HookId { get; set; }

        [JsonPropertyName("hook")]
        public Hook Hook { get; set; }

        [JsonPropertyName("repository")]
        public Repository Repository { get; set; }

        [JsonPropertyName("sender")]
        public Sender Sender { get; set; }
    }
}