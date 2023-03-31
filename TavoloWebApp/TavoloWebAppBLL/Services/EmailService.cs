using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TavoloWebAppBLL.Models;
using TavoloWebAppBLL.Services.IServices;

namespace TavoloWebAppBLL.Services
{
    public class EmailService : /*IEmailService*/
    {
        private readonly IConfiguration _config;
        public EmailService(IConfiguration config)
        {
            _config = config;
            
        }

        
        //public Task SendEmailAsync(Email email, Project? projekt)
        //{
        //    var message = new MimeMessage();
        //    message.From.Add(MailboxAddress.Parse(email.FromEmail));
        //    message.To.Add(MailboxAddress.Parse(email.ToEmail));
        //    message.Subject = email.Subject;
        //    message.Body = new TextPart(MimeKit.Text.TextFormat.Html)
        //    {
        //        Text = email.Body
        //    };

        //    using (var emailClient = new SmtpClient())
        //    {
        //        emailClient.Connect(_config.GetSection("EmailHost").Value, 587, MailKit.Security.SecureSocketOptions.StartTls);
        //        emailClient.Authenticate(_config.GetSection("EmailUser").Value, _config.GetSection("EmailPassword").Value);
        //        emailClient.Send(message);
        //        emailClient.Disconnect(true);

        //    }
        //    return Task.CompletedTask;


        //}
    }
}
