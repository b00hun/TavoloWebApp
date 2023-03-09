using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavoloWebAppBLL.Models
{
    public class Email
    {
        public string FromEmail { get; set; } = "adres@gmail.com";
        public string ToEmail { get; set; } 
        public string Subject { get; set; } = "Wiadomość kontaktowa";
        public string Body { get; set; }
    }
}
