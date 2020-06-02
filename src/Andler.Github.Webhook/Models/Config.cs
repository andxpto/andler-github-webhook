using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class Config
    {
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("insecure_ssl")]
        public string InsecureSsl { get; set; }
    }

}
