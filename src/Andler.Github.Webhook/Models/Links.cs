using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class Links
    {

        [JsonPropertyName("self")]
        public Href Self { get; set; }

        [JsonPropertyName("html")]
        public Href Html { get; set; }

        [JsonPropertyName("issue")]
        public Href Issue { get; set; }

        [JsonPropertyName("comments")]
        public Href Comments { get; set; }

        [JsonPropertyName("review_comments")]
        public Href ReviewComments { get; set; }

        [JsonPropertyName("review_comment")]
        public Href ReviewComment { get; set; }

        [JsonPropertyName("commits")]
        public Href Commits { get; set; }

        [JsonPropertyName("statuses")]
        public Href Statuses { get; set; }
    }

}

