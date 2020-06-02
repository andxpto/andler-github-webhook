using System.Threading.Tasks;
using Andler.Github.Webhook.Models;

namespace Andler.Github.Webhook
{
    public interface IGithubEventHandler
    {
        Task PullRequest(Headers headers, PullRequestHook hook);

        Task Stargazer(Headers headers, StarHook hook);

        Task Issues(Headers headers, IssueHook hook);

        Task Ping(Headers headers, PingHook hook);

        Task Watch(Headers headers, WatchHook hook);

        Task Others(Headers headers, DefaultHook hook);

        Task All(Headers headers, string payload);
    }
}