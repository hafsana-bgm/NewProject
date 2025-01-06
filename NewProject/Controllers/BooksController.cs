using Microsoft.AspNetCore.Mvc;
using NewProject.Data;
using NewProject.DataModels;
using Microsoft.EntityFrameworkCore;

namespace NewProject.Controllers
{
    public class BooksController : Controller
    {
        private readonly NewProjectContext _context;

        public BooksController(NewProjectContext context)
        {
            _context = context;
        }


        public IActionResult BookList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BookListSubmit(Books Bookdata)
        {

            if (Bookdata.BookName != null && Bookdata.BookDescription != null)

            {
                 _context.Add(Bookdata);
                _context.SaveChanges();
            }
            return RedirectToAction("BookList");
        }


        public IActionResult BookInpt()
        {
            var data = _context.Books.ToList();

            return View(data);
        }

        public IActionResult BookInfo(int? id)
        {
            if (id == null)
                return NotFound();

            var Books = _context.Books.FirstOrDefault(shop => shop.Id == id);

            return View(Books);
        }

        //[HttpPost]
        //public IActionResult BookInfo(Books datamodel)
        //{
        //    if (datamodel.BookName != null && datamodel.BookDescription != null && datamodel.Stock != null && datamodel.BookPrice != null && datamodel.Image != null) 
        //    {
        //        _context.Add(datamodel);
        //        _context.SaveChanges();
        //    }
        //    return RedirectToAction("BookList");
        //}


        public IActionResult BookEdit(int? id)
        {
            if (id == null)
                return NotFound();
            //select * from Books Where Id = 2
            var Books = _context.Books.FirstOrDefault(shop => shop.Id == id);

            return View(Books);
        }

        
        [HttpPost]
        public IActionResult BookEdit(Books datamodel)
        {
            if (datamodel.BookName != null && datamodel.BookDescription != null && datamodel.Image != null)
            {
                _context.Update(datamodel);
                _context.SaveChanges();
            }
            return RedirectToAction("BookInpt");
        }


        public IActionResult BookDelete(int? id)

        {
            if (id == null)
                return NotFound();

            var Books = _context.Books.FirstOrDefault(shop => shop.Id == id);

            if (Books == null)
                return NotFound();

            _context.Remove(Books);
            _context.SaveChanges();

            return RedirectToAction("BookInpt");
        }

    }

}