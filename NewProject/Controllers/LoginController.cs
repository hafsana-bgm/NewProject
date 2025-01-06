using Microsoft.AspNetCore.Mvc;

namespace NewProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
