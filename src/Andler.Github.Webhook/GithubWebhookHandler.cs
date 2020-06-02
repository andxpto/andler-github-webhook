using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Andler.Github.Webhook.Models;
using Andler.Github.Webhook.Models.Constants;

namespace Andler.Github.Webhook
{
    public class GithubWebhookHandler : IGithubWebhookHandler
    {
        private readonly IGithubWebhookHandlerSettings _githubWebhookHandlerSettings;

        private readonly IEnumerable<IGithubEventHandler> _githubEventHandlers;

        public GithubWebhookHandler(
            IGithubWebhookHandlerSettings githubWebhookHandlerSettings,
            IEnumerable<IGithubEventHandler> githubEventHandlers)
        {
            _githubWebhookHandlerSettings = githubWebhookHandlerSettings ?? throw new ArgumentNullException(nameof(githubWebhookHandlerSettings));
            _githubEventHandlers = githubEventHandlers ?? throw new ArgumentNullException(nameof(githubEventHandlers));
        }

        public async Task<HandlerResult> Handler(string payload, string name, string id, string userAgent, string signature)
        {
            var result = new HandlerResult();

            result.SignatureCheck = _githubWebhookHandlerSettings.CheckSignature;

            if (_githubWebhookHandlerSettings.CheckSignature && !CheckSignature(payload, signature))
            {
                result.AddErrorMessage("secret validation failed");

                return result;
            }

            //if (hook == null)
            //{
            //    result.AddErrorMessage("deserialization failed");

            //    return result;
            //}

            var headers = CreateHeaders(id, name, userAgent, signature);

            await EventDistribution(headers, payload);

            return result;
        }

        private T TypedDesirialize<T>(string payload)
        {
            try
            {
                return JsonSerializer.Deserialize<T>(payload);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private Headers CreateHeaders(string delivery, string eventName, string userAgent, string signature)
        {
            return new Headers
            {
                Delivery = Guid.Parse(delivery),
                Event = eventName,
                UserAgent = userAgent,
                Signature = signature
            };
        }

        private async Task EventDistribution(Headers headers, string payload)
        {
            foreach (var eventHandler in _githubEventHandlers)
            {
                switch (headers.Event)
                {
                    case Events.issues:
                        await eventHandler.Issues(headers, TypedDesirialize<IssueHook>(payload));
                        break;

                    case Events.pull_request:
                        await eventHandler.PullRequest(headers, TypedDesirialize<PullRequestHook>(payload));
                        break;

                    case Events.star:
                        await eventHandler.Stargazer(headers, TypedDesirialize<StarHook>(payload));
                        break;

                    case Events.ping:
                        await eventHandler.Ping(headers, TypedDesirialize<PingHook>(payload));
                        break;

                    case Events.watch:
                        await eventHandler.Watch(headers, TypedDesirialize<WatchHook>(payload));
                        break;

                    default:
                        await eventHandler.Others(headers, TypedDesirialize<DefaultHook>(payload));
                        break;
                }

                await eventHandler.All(headers, payload);
            }
        }

        private bool CheckSignature(string payload, string signature)
        {
            using HMACSHA1 hmacSha1 = new HMACSHA1(Encoding.Default.GetBytes(_githubWebhookHandlerSettings.Secret));

            var hash = hmacSha1.ComputeHash(Encoding.Default.GetBytes(payload));

            var hashString = BitConverter.ToString(hash).Replace("-", "").ToLower();

            return signature.Equals($"sha1={hashString}", StringComparison.OrdinalIgnoreCase);
        }
    }
}
