using Microsoft.AspNetCore.Mvc;

namespace NewProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactList()
        {

            return View();
        }


    }
}
