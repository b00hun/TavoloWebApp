using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavoloWebAppBLL.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        [ForeignKey("Images")]
        public int Project_Id { get; set; }

        public Project Project { get; set; }
    }
}
