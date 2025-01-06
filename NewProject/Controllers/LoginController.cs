using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using NewProject.Data;
using NewProject.DataDatamodels;

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
            var AllProduct = _context.SocialMedias.ToList();
            return View(AllProduct);
        }
        [HttpPost]
        public IActionResult c(SocialMedia SocialMedia)
        {
            if (SocialMedia.SocialName !=null && SocialMedia.SocialIcon !=null && SocialMedia.socialLink !=null)
            {
                _context.SocialMedias.Add(SocialMedia);
                _context.SaveChanges();
                return Json(new { success = true, message = "Data Saved" });
            }

            return Json(new {success = false, message = "Invalid data"});
           
        }

        public IActionResult SocialNetworkList()
        {
            return View();
        }



    }
}
