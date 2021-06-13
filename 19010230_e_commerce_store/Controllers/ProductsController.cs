using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _19010230_e_commerce_store.Models;

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
            ViewData["CurrentFilter"] = searchString;
            //var prog7311Task2Context = _context.Products.Include(p => p.Category); //.CategoryName

            var products = _context.Products.Include(p => p.Category);
            //var products = from p in _context.Products select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = (Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<Product, ProductCategory>)products.Where(x => x.ProductName.Contains(searchString) || x.Category.CategoryName.Contains(searchString));
            }

            return View(await products.AsNoTracking().OrderBy(x => x.CategoryId).ToListAsync()); // Ordering by categoryID will group the categories together.
            //return View(await prog7311Task2Context.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
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

            return View(product);
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
