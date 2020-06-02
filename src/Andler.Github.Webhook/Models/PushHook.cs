using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class PushHook
    {
        [JsonPropertyName("ref")]
        public string Ref { get; set; }

        [JsonPropertyName("before")]
        public string Before { get; set; }

        [JsonPropertyName("after")]
        public string After { get; set; }

        [JsonPropertyName("created")]
        public bool Created { get; set; }

        [JsonPropertyName("deleted")]
        public bool Deleted { get; set; }

        [JsonPropertyName("forced")]
        public bool Forced { get; set; }

        [JsonPropertyName("base_ref")]
        public object BaseRef { get; set; }

        [JsonPropertyName("compare")]
        public string Compare { get; set; }

        [JsonPropertyName("commits")]
        public IList<object> Commits { get; set; }

        [JsonPropertyName("head_commit")]
        public object HeadCommit { get; set; }

        [JsonPropertyName("repository")]
        public Repository Repository { get; set; }

        [JsonPropertyName("pusher")]
        public Pusher Pusher { get; set; }

        [JsonPropertyName("sender")]
        public Sender Sender { get; set; }
    }
}