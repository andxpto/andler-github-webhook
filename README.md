# Andler.Github.Webhook

dotnet library that help you to handle the Github webhooks with typed objects.

**Under development - no typed implementation for all the events**

### Events available

- PullRequest
- Stargazer
- Issues
- Ping
- Watch
- Others (None handled events)
- All (All events)

## Installation

Use the [nuget manager](https://www.nuget.org/packages/Andler.Github.Webhook/) to install it.

```bash
dotnet add package Andler.Github.Webhook
```

## Usage

```csharp

// Startup.cs

services.AddSingleton<IGithubWebhookHandlerSettings, GithubWebhookHandlerSettingsImplementation>();

services.AddTransient<IGithubEventHandler, GithubEventHandlerImplementation1>();
services.AddTransient<IGithubEventHandler, GithubEventHandlerImplementation2>();

services.AddGithubWebhookHandler();

// In your controller inject IGithubWebhookHandler

await _githubWebhookHandler.Handler(payload, name, id, userAgent, signature);

```

You need at least one `IGithubEventHandler` implementation. 

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://github.com/andxpto/andler-github-webhook/blob/master/LICENSE)
