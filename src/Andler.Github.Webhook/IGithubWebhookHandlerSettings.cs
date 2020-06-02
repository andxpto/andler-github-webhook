namespace Andler.Github.Webhook
{
    public interface IGithubWebhookHandlerSettings
    {
        string Secret { get; set; }

        bool CheckSignature { get; set; }
    }
}