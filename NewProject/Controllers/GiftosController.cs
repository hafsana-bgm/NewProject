using Microsoft.AspNetCore.Mvc;
using NewProject.Data;
using NewProject.DataDatamodels;
using NewProject.DataModels;

namespace NewProject.Controllers
{
    public class GiftosController : Controller
    {

        private readonly NewProjectContext _context;
        public GiftosController(NewProjectContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Testimonial()
        {
            return View();
        } 
        public IActionResult ContactUs()
        {
            return View();
        }


        [HttpPost]
      public IActionResult ContactUsSubmit(ContactUs model)
        {
            if (model.Name !=null && model.Email !=null && model.Phone !=null)
            {
                _context.Add(model);
                _context.SaveChanges();

            }

            return RedirectToAction("ContactUs");
        }


        public IActionResult ContactList()
        {
            var data = _context.Contactus.ToList();

            return View(data);
        }


        public IActionResult ContactEdit(int? id)
        {
            if (id == null)
                return NotFound();
           
            var Contact = _context.Contactus.FirstOrDefault(shop => shop.Id == id);

            return View(Contact);
        }


        [HttpPost]
        public IActionResult ContactEdit(ContactUs datamodel)
        {
            if (datamodel.Name != null && datamodel.Email != null && datamodel.Phone != null && datamodel.Message !=null)
            {
                _context.Update(datamodel);
                _context.SaveChanges();
            }
            return RedirectToAction("ContactList");
        }


        public IActionResult ContactDelete(int? id)

        {
            if (id == null)
                return NotFound();

            var list = _context.Contactus.FirstOrDefault(shop => shop.Id == id);

            if (list == null)
                return NotFound();

            _context.Remove(list);
            _context.SaveChanges();

            return RedirectToAction("ContactList");
        }






    }
}
