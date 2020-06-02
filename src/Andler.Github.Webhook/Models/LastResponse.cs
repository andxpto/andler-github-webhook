using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class LastResponse
    {

        [JsonPropertyName("code")]
        public object Code { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("message")]
        public object Message { get; set; }
    }

}
