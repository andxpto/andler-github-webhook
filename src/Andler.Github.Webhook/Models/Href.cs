using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class Href
    {

        [JsonPropertyName("href")]
        public string HtmlHref { get; set; }
    }

}

