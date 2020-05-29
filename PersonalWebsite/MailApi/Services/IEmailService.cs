
using System;
using System.Linq;
using System.Threading.Tasks;
using SendGrid;
using SharedResources.Models;

namespace PersonalWebsite.Services
{
    public interface IEmailService
    {
        Task<Response> Execute(ContactMessage contactMessage,string apiKey);

       
    }
}
