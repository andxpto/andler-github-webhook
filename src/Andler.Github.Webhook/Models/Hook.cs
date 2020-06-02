using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class Hook
    {

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("events")]
        public IList<string> Events { get; set; }

        [JsonPropertyName("config")]
        public Config Config { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("test_url")]
        public string TestUrl { get; set; }

        [JsonPropertyName("ping_url")]
        public string PingUrl { get; set; }

        [JsonPropertyName("last_response")]
        public LastResponse LastResponse { get; set; }
    }
}