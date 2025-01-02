using Microsoft.AspNetCore.Mvc;
using NewProject.DataModels;
using NewProject.Data;

namespace NewProject.Controllers
{


    public class BlogsController : Controller
    {

        private readonly NewProjectContext _context;
        public BlogsController(NewProjectContext context)
        {
            _context = context;
        }
        
        public IActionResult Blog()
        {


            var data = _context.Blog.ToList();

            return View(data);
           
        }



        public IActionResult BlogCreat()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult BlogSubmit(Blog Furnituredata)
        {
            if (Furnituredata.BlogContent != null && Furnituredata.BlogTitle != null && Furnituredata.BlogThumbnails != null)
            {
                _context.Add(Furnituredata);
                _context.SaveChanges();

            }

            return RedirectToAction("BlogCreat");
        }


        public IActionResult BlogList()
        {

            var data = _context.Blog.ToList();

            return View(data);
            
        }

        public IActionResult BlogInfo(int? id)
        {

            if (id == null)

                return NotFound();

            var Blog = _context.Blog.FirstOrDefault(Furniture => Furniture.BlogId == id);

            return View();
        }

        public IActionResult BlogEdit(int? id)
        {
            if (id == null)
                return NotFound();

            var Furnituredata = _context.Blog.FirstOrDefault(Furniture => Furniture.BlogId == id);
            return View(Furnituredata);
        }

        [HttpPost]
        public IActionResult BlogEdit(Blog Furnituredata)
        {
            if (Furnituredata.BlogTitle != null && Furnituredata.BlogContent != null && Furnituredata.BlogThumbnails != null)
            {
                _context.Update(Furnituredata);
                _context.SaveChanges();
            }
            return RedirectToAction("BlogCreat");
        }


        public IActionResult BlogDelete(int? id)

        {
            if (id == null)
                return NotFound();

            var Furnituredata = _context.Blog.FirstOrDefault(Furniture => Furniture.BlogId == id);

            if (Furnituredata == null)
                return NotFound();

            _context.Remove(Furnituredata);
            _context.SaveChanges();

            return RedirectToAction("BlogCreat");


        }
    }
}
