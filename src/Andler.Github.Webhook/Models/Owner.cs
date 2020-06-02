using System.Text.Json.Serialization;

namespace Andler.Github.Webhook.Models
{
    public class Owner
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("company")]
        public string Company { get; set; }

        [JsonPropertyName("blog")]
        public string Blog { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("hireable")]
        public bool? Hireable { get; set; }

        [JsonPropertyName("bio")]
        public string Bio { get; set; }

        [JsonPropertyName("public_repos")]
        public long? PublicRepos { get; set; }

        [JsonPropertyName("public_gists")]
        public long? PublicGists { get; set; }

        [JsonPropertyName("followers")]
        public long? Followers { get; set; }

        [JsonPropertyName("following")]
        public long? Following { get; set; }

        [JsonPropertyName("total_private_repos")]
        public long? TotalPrivateRepos { get; set; }

        [JsonPropertyName("owned_private_repos")]
        public long? OwnedPrivateRepos { get; set; }

        [JsonPropertyName("private_gists")]
        public long? PrivateGists { get; set; }

        [JsonPropertyName("disk_usage")]
        public long? DiskUsage { get; set; }

        [JsonPropertyName("collaborators")]
        public long? Collaborators { get; set; }

        [JsonPropertyName("two_factor_authentication")]
        public bool? TwoFactorAuthentication { get; set; }

        [JsonPropertyName("login")]
        public string Login { get; set; }

        [JsonPropertyName("id")]
        public long? Id { get; set; }

        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonPropertyName("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; }

        [JsonPropertyName("followers_url")]
        public string FollowersUrl { get; set; }

        [JsonPropertyName("following_url")]
        public string FollowingUrl { get; set; }

        [JsonPropertyName("gists_url")]
        public string GistsUrl { get; set; }

        [JsonPropertyName("starred_url")]
        public string StarredUrl { get; set; }

        [JsonPropertyName("subscriptions_url")]
        public string SubscriptionsUrl { get; set; }

        [JsonPropertyName("organizations_url")]
        public string OrganizationsUrl { get; set; }

        [JsonPropertyName("repos_url")]
        public string ReposUrl { get; set; }

        [JsonPropertyName("events_url")]
        public string EventsUrl { get; set; }

        [JsonPropertyName("received_events_url")]
        public string ReceivedEventsUrl { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("site_admin")]
        public bool? SiteAdmin { get; set; }
    }
}