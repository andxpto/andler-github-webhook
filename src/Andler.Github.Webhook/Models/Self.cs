using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class Self
    {

        [JsonPropertyName("href")]
        public string Href { get; set; }
    }

}

