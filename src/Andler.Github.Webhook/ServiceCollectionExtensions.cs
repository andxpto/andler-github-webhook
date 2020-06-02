using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Andler.Github.Webhook
{
    public static class ServiceCollectionExtensions
    {
        public static void AddGithubWebhookHandler(this IServiceCollection serviceCollection)
        {
            if (!serviceCollection.Any(x => x.ServiceType == typeof(IGithubWebhookHandlerSettings)))
            {
                throw new NotImplementedException($"Add a {nameof(IGithubWebhookHandlerSettings)} implementation to the {nameof(IServiceCollection)}");
            }

            if (!serviceCollection.Any(x => x.ServiceType == typeof(IGithubEventHandler)))
            {
                throw new NotImplementedException($"Add at least one {nameof(IGithubEventHandler)} implementation to the {nameof(IServiceCollection)}");
            }

            serviceCollection.AddSingleton<IGithubWebhookHandler, GithubWebhookHandler>();
        }
    }
}
