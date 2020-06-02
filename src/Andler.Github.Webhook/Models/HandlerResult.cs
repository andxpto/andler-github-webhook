using System;

namespace Andler.Github.Webhook.Models
{
    public class HandlerResult
    {
        public HandlerResult()
        {
            this.Executed = DateTime.UtcNow;
        }

        public bool Failed { get; private set; }

        public DateTime Executed { get; }

        public string Message { get; set; }

        public bool SignatureCheck { get; set; }

        public void AddErrorMessage(string message)
        {
            this.Failed = true;
            this.Message = message;
        }
    }
}