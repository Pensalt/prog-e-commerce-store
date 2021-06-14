using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _19010230_e_commerce_store.Models;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.AspNetCore.Http;


namespace _19010230_e_commerce_store.Controllers
{
    public class ProductsController : Controller
    {
        private readonly prog7311Task2Context _context;

        public ProductsController(prog7311Task2Context context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index(string searchString)
        {
            // Handling search functionality.
            var products = from p in _context.Products select p;

            //var products = await _context.Products.Include(x => x.Category).ToListAsync(); // Trying to include categories gives an error

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(x => x.ProductName.Contains(searchString));
            }

            return View(await products.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Checkout(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            // Sessions are needed to send through the relevant information when creating an order in the POST method.
            HttpContext.Session.SetInt32("catID", product.CategoryId);
            HttpContext.Session.SetInt32("prodID", product.ProductId);

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Checkout()
        {
            string uName = HttpContext.Session.GetString("currentUser");

            if (!(uName is null))
            {

                UserInfo u = new UserInfo();
                u = await _context.UserInfos.Where(x => x.UserEmail.Equals(uName)).FirstOrDefaultAsync();
                //int userID = u.UserId;

                OrderInfo o = new OrderInfo();
                //o.OrderDate = System.DateTime; // Datetime was removed due to complications with the way SSMS handles dates, it would require signifcant formatting and often gives painful errors.
                o.ProductId = (int)HttpContext.Session.GetInt32("prodID");
                o.UserId = u.UserId;
                await _context.OrderInfos.AddAsync(o);
                await _context.SaveChangesAsync();

                ProductCategory p = new ProductCategory();
                p = await _context.ProductCategories.Where(x => x.CategoryId == (int)HttpContext.Session.GetInt32("catID")).FirstOrDefaultAsync();
                p.TotalOrders = p.TotalOrders + 1;
                _context.ProductCategories.Update(p);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Orders");
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
