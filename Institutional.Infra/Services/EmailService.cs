using Institutional.Domain.Services;
using System.Net;
using System.Net.Mail;

namespace Institutional.Infra.Services
{
    public class EmailService : IEmailService
    {
        public void Send(string from, string to, string subject, string body, string name)
        {
            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            mail.From = new MailAddress(from);
            mail.To.Add(new MailAddress(to));
            mail.Subject = subject;
            mail.Body = $"<h3> E-mail de: {name} ({from})</h3> <hr/> <p>Assunto: {body}</p>";

            using (var smtp = new SmtpClient("smtp.gmail.com"))
            {
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;

                smtp.Credentials = new NetworkCredential("json.software01@gmail.com", "@jsonsoftware#$");

                smtp.Send(mail);
            }
        }
    }
}
