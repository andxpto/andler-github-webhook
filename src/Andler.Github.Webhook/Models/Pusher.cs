using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class Pusher
    {

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }

}
