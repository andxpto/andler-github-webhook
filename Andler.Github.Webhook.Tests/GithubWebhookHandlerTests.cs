using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace Andler.Github.Webhook.Tests
{
    public class GithubWebhookHandlerTests
    {
        private readonly Mock<IGithubWebhookHandlerSettings> _iGithubWebhookHandlerSettings;
        private readonly Mock<IGithubEventHandler> _iGithubEventHandler1;
        private readonly List<IGithubEventHandler> _listGithubEventHandler;

        public GithubWebhookHandlerTests()
        {
            _iGithubWebhookHandlerSettings = new Mock<IGithubWebhookHandlerSettings>();
            _iGithubEventHandler1 = new Mock<IGithubEventHandler>();
            _listGithubEventHandler = new List<IGithubEventHandler> { _iGithubEventHandler1.Object };
        }

        [Fact]
        public async Task GithubWebhookHandlerTests_EmptyPayload()
        {
            var controller = new GithubWebhookHandler(_iGithubWebhookHandlerSettings.Object, _listGithubEventHandler);
            var exception = await Record.ExceptionAsync(async () => await controller.Handler(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty));

            Assert.StartsWith("'payload' cannot be null or whitespace.", exception.Message);
        }
    }
}
