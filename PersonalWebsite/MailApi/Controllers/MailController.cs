using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PersonalWebsite.Services;
using SendGrid;
using SharedResources.Models;

namespace MailApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        readonly IOptions<SendGridOptions> _sendGridOptions;
        readonly IEmailService _emailService;
        public MailController(IOptions<SendGridOptions> sendGridOptions, IEmailService emailService)
        {
            _emailService = emailService;
            _sendGridOptions = sendGridOptions;
        }

        [HttpPost]
        public async Task<bool> Send(ContactMessage contactMessage)
        {

            Response Queryresult = await _emailService.Execute(contactMessage, _sendGridOptions.Value.ApiKey);
            if (!Queryresult.StatusCode.Equals(System.Net.HttpStatusCode.Accepted))
            {
                return (false);
            }
            return true;

        }
    }
}
