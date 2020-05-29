
using SendGrid;
using SendGrid.Helpers.Mail;
using SharedResources.Models;
using System;
using System.Threading.Tasks;

namespace PersonalWebsite.Services
{
    public class EmailService : IEmailService
    {
       

        public async Task<Response> Execute(ContactMessage contactMessage,string apiKey)
        {

           
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress(contactMessage.EmailAddress, contactMessage.Name);
                var subject = contactMessage.Message;
                var to = new EmailAddress("davindavies@outlook.com", "Mr D Davies");
                var plainTextContent = contactMessage.Message;
                var htmlContent = $"<p>{contactMessage.Message}</p>";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

                var response = await client.SendEmailAsync(msg);
                return response;
            

        }

        
    }
}
