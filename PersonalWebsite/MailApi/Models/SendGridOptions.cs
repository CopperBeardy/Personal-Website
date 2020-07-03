using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailApi.Models
{
    public class SendGridOptions
    {
        public const string SendGridApiKey = "SendGridApiKey";
        public string  ApiKey { get; set; }
    }
}
