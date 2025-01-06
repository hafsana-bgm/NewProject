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
       // Login start
        public IActionResult CreatId()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatId(Login SocialMedia)
        {
            if (SocialMedia.Email != null && SocialMedia.Password != null)
            {
                _context.Logins.Add(SocialMedia);
                _context.SaveChanges();
                return Json(new { success = true, message = "Succussfully" });
            }

            return Json(new { success = false, message = "Invalid data" });

        }


        public IActionResult ListId()
        {
            var data = _context.Logins.ToList();

            return View(data);
        } 


        //login end



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
        public IActionResult SocialNetwork(SocialMedia SocialMedia)
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
            var data = _context.SocialMedias.ToList();

            return View(data);
        }



    }
}
