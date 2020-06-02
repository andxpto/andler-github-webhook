using System.Threading.Tasks;
using Andler.Github.Webhook.Models;

namespace Andler.Github.Webhook
{
    public interface IGithubWebhookHandler
    {
        Task<HandlerResult> Handler(string payload, string name, string id, string userAgent, string secret);
    }
}