using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class PullRequestHook
    {
        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("pull_request")]
        public PullRequest PullRequest { get; set; }

        [JsonPropertyName("repository")]
        public Repository Repository { get; set; }

        [JsonPropertyName("sender")]
        public Sender Sender { get; set; }
    }
}