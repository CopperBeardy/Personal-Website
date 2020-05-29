using PersonalWebsite.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Services
{
    public interface IEmailService
    {
        Task Execute(ContactMessage contactMessage);

        string ApiKey { get; set; }
    }
}
