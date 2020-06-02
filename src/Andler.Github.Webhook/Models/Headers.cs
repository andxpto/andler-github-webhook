using System;

namespace Andler.Github.Webhook.Models
{
    public class Headers
    {
        public Guid Delivery { get; set; }

        public string Event { get; set; }

        public string UserAgent { get; set; }

        public string Signature { get; set; }

        public string ContentType { get; set; }

        public long ContentLength { get; set; }
    }
}