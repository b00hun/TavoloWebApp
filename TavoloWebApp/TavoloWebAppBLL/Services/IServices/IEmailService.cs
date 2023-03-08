using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavoloWebAppBLL.Services.IServices
{
    public interface IEmailService
    {
        public Task SendEmailAsync(string email, string htmlMessage);
    }
}
