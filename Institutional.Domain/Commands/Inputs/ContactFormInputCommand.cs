using System;
using System.Collections.Generic;
using System.Text;

namespace Institutional.Domain.Commands.Inputs
{
    public class ContactFormInputCommand
    {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
