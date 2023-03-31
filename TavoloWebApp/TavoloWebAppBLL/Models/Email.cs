using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavoloWebAppBLL.Models
{
    public class Email
    {
        [EmailAddress]
        [Required(ErrorMessage ="Podaj Adres Email")]
        public string EmailAdress { get; set; }
        [Required(ErrorMessage ="Podaj swoje Imię")]
        public string Name { get; set; }
        [MaxLength(1000)]
        [Required(ErrorMessage ="Podaj pytanie :)")]
        public string Text { get; set; } = "Wiadomość kontaktowa";
        
    }
}
