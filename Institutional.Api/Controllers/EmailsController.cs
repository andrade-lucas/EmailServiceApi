using Institutional.Domain.Commands.Inputs;
using Institutional.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Institutional.Api.Controllers
{
    public class EmailsController : Controller
    {
        private readonly IEmailService _email;

        public EmailsController(IEmailService email)
        {
            _email = email;
        }

        [HttpPost]
        [Route("v1/SendMail")]
        public bool Post([FromBody] ContactFormInputCommand command)
        {
            try
            {
                _email.Send(command.Email, "json.software01@gmail.com", command.Subject, command.Message, command.Name);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
