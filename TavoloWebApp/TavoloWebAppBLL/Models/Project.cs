using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TavoloWebAppBLL.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Material { get; set; }

        [DefaultValue("")]
        public string TimeOfWork { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Today;
        [ValidateNever]
        public List<Image> Images { get; set; }
    }
}
