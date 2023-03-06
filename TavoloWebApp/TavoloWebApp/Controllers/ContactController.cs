using Microsoft.AspNetCore.Mvc;

namespace TavoloWebAppASP.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendEmail()
        {
            return View();
        }
    }
}
