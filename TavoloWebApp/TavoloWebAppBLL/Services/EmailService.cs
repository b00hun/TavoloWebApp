using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TavoloWebAppBLL.Services.IServices;

namespace TavoloWebAppBLL.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;
        public EmailService(IConfiguration config)
        {
            _config = config;
            
        }

        private string MyEmailAdress= "adres@gmail.com";
        private string EmailSubject = "Wiadomość kontaktowa";
        public Task SendEmailAsync(string email, string htmlMessage)
        {
            var message = new MimeMessage();
            message.From.Add(MailboxAddress.Parse(MyEmailAdress));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = EmailSubject;
            message.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = htmlMessage
            };

            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect(_config.GetSection("EmailHost").Value, 587, MailKit.Security.SecureSocketOptions.StartTls);
                emailClient.Authenticate(_config.GetSection("EmailUser").Value, _config.GetSection("EmailPassword").Value);
                emailClient.Send(message);
                emailClient.Disconnect(true);

            }
            return Task.CompletedTask;


        }
    }
}
