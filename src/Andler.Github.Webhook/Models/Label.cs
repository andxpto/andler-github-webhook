using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class Label
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("node_id")]
        public string NodeId { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("default")]
        public bool Default { get; set; }
    }

}