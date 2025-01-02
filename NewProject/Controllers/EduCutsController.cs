using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using NewProject.Data;
using NewProject.DataModels;

namespace NewProject.Controllers
{
    public class EduCutsController : Controller
    {
        private readonly NewProjectContext _context;
        public EduCutsController(NewProjectContext context)
        {
            _context = context;
        }

        public IActionResult Home()
        {

            ViewBag.Slider = new
            {
                Slider1 = "Why do we use it",
                SliderBody1 = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                Slider2 = "Where can I get some",
                SliderBody2 = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form",
                Slider3 = "Where does it come from",
                SliderBody3 = "Contrary to popular belief, Lorem Ipsum is not simply random text."
            };


            ViewBag.Furniture = new
            {
                Title = "Our Furniture",
                Content = "which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't an"
            };    

           

            ViewBag.AboutUs = "The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.";

            var AllData = new HomeViewModel();

            AllData.Books = _context.Books.Take(3).ToList();
            AllData.Blogs = _context.Blog.ToList();

     

            return View(AllData);


        }

        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUsSubmit(Contact model)
        {


            if (model.PhoneNumber != null && model.YourName != null && model.Email != null)
            {
                _context.Add(model);
                _context.SaveChanges();
            }
         


            return RedirectToAction("ContactUs");
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult List()
        {
            var data = _context.Contact.ToList();

            return View(data);
        }
        
        public IActionResult Info(int? id)

        {
            if (id == null)
            return NotFound();

            var Contact = _context.Contact.FirstOrDefault(hafsa => hafsa.Id == id);
            return View(Contact);
        }
        [HttpPost]

        public IActionResult Info(Contact datamodel)
        {


            if (datamodel.PhoneNumber != null && datamodel.YourName != null && datamodel.Email != null)
            {
                _context.Update(datamodel);
                _context.SaveChanges();
            }



            return RedirectToAction("List");
        }

        public IActionResult Delete(int? id)

        {
            if (id == null)
                return NotFound();

            var Contact = _context.Contact.FirstOrDefault(hafsa => hafsa.Id == id);
            if (Contact == null)
                return NotFound();
            _context.Remove(Contact);
            _context.SaveChanges();

            return RedirectToAction("List");
        }


        public IActionResult SocialNetwork()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveSocialNetwork(SocialLink SocialLink)
        {
            if (ModelState.IsValid) 
            {
                return Json(new { Success = true, message = "Social link saved successfully!" });
            }
            return Json(new{ Success = false, message ="Invalid data!" });
        }


    }
}
