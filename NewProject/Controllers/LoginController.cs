using Microsoft.AspNetCore.Mvc;
using NewProject.Data;

namespace NewProject.Controllers
{
    public class LoginController : Controller
    {

        private readonly NewProjectContext _context;
        public LoginController(NewProjectContext context)
        {
            _context = context;
        }

        public IActionResult CreatId()
        {
            return View();
        }


        public IActionResult ListId()
        {
            return View();
        } 
        public IActionResult SavingProduct()
        {

            var AllProduct = _context.Shops.ToList();
            return View(AllProduct);
          
        } 
        public IActionResult GiftProduct()
        {
            var AllProduct = _context.Shops.ToList();
            return View(AllProduct);
        }

        public IActionResult SocialNetwork()
        {
            return View();
        }



    }
}
