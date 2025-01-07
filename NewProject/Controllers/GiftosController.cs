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
            var AllProduct = _context.Shops.ToList();
            return View(AllProduct);
            
        } 
        public IActionResult Shop()
        {

            var AllProduct = _context.Shops.ToList();
            return View(AllProduct);
        }

       //start All Product 

        public IActionResult AllProduct()
        {
            var Product = _context.Products.ToList();

            return View(Product);
           
        }


        public IActionResult CreatProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatProductSubmit(AllProduct model)
        {
            if (model.ProductName != null && model.ProductImage != null)
            {
                _context.Add(model);
                _context.SaveChanges();

            }

            return RedirectToAction("CreatProduct");
        }

        public IActionResult ProductList()
        {
            var data = _context.Products.ToList();

            return View(data);
        }

        public IActionResult ProductEdit(int? id)
        {
            if (id == null)
                return NotFound();

            var Contact = _context.Products.FirstOrDefault(shop => shop.Id == id);

            return View(Contact);
        }

        [HttpPost]
        public IActionResult ProductEdit(AllProduct datamodel)
        {
            if (datamodel.ProductName != null && datamodel.ProductImage != null)
            {
                _context.Update(datamodel);
                _context.SaveChanges();
            }
            return RedirectToAction("ProductList");
        }

        public IActionResult ProductDetails(int? id)
        {
            if (id == null)
                return NotFound();

            var Product = _context.Products.FirstOrDefault(shop => shop.Id == id);

            return View(Product);
        }

        public IActionResult ProductDelete(int? id)

        {
            if (id == null)
                return NotFound();

            var list = _context.Products.FirstOrDefault(shop => shop.Id == id);

            if (list == null)
                return NotFound();

            _context.Remove(list);
            _context.SaveChanges();

            return RedirectToAction("ProductList");

        }
        //end all product



        // Start Shop
        public IActionResult CreatShop()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatShopSubmit(Shop model)
        {
            if (model.ProductName != null && model.ProductImage != null )
            {
                _context.Add(model);
                _context.SaveChanges();

            }

            return RedirectToAction("CreatShop");
        }


        public IActionResult ShopList()
        {
            var data = _context.Shops.ToList();

            return View(data);
        }

        public IActionResult ShopEdit(int? id)
        {
            if (id == null)
                return NotFound();

            var Contact = _context.Shops.FirstOrDefault(shop => shop.Id == id);

            return View(Contact);
        }

        [HttpPost]
        public IActionResult ShopEdit(Shop datamodel)
        {
            if (datamodel.ProductName != null && datamodel.ProductImage != null )
            {
                _context.Update(datamodel);
                _context.SaveChanges();
            }
            return RedirectToAction("ShopList");
        }

        public IActionResult ShopDelete(int? id)

        {
            if (id == null)
                return NotFound();

            var list = _context.Shops.FirstOrDefault(shop => shop.Id == id);

            if (list == null)
                return NotFound();

            _context.Remove(list);
            _context.SaveChanges();

            return RedirectToAction("ShopList");

        }

        public IActionResult ShopDetails(int? id)
        {
            if (id == null)
                return NotFound();

            var Product = _context.Shops.FirstOrDefault(shop => shop.Id == id);

            return View(Product);
        }

        // end Shop















        public IActionResult Testimonial()
        {
            return View();
        }


        //Start Contact

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

      
        //end contact


    }
}
