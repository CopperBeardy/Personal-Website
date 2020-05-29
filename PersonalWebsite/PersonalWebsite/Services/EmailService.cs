using Microsoft.Extensions.Configuration;
using PersonalWebsite.Models;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Services
{
    public class EmailService : IEmailService
    {
        readonly IConfiguration _configuration;
        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string ApiKey { get; set; }

        public async Task Execute(ContactMessage contactMessage)
        {

            // temporay measure to get the message working will be put in user secret for release
            string apiKey = "Insert API key";
            SendGridClient client = new SendGridClient(apiKey);
            EmailAddress from = new EmailAddress(contactMessage.EmailAddress, contactMessage.Name);
            string subject = contactMessage.Message;
            EmailAddress to = new EmailAddress("davindavies@outlook.com", "Davin Davies");
            string plainTextContent = contactMessage.Message;
            string htmlContent = $"<p>{contactMessage.Message}</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }

    }
}
