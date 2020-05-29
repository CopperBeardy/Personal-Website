
using System;
using System.Linq;
using System.Threading.Tasks;
using SharedResources.Models;

namespace PersonalWebsite.Services
{
    public interface IEmailService
    {
        Task Execute(ContactMessage contactMessage,string apiKey);

       
    }
}
