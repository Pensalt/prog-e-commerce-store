using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _19010230_e_commerce_store.Models;
using Newtonsoft.Json;



namespace _19010230_e_commerce_store.Controllers
{
    public class ProductCategoriesController : Controller
    {
        private readonly prog7311Task2Context _context;

        public ProductCategoriesController(prog7311Task2Context context)
        {
            _context = context;
        }

        // GET: ProductCategories
        public async Task<IActionResult> Index()
        {
            // Handling populating the graph with the relevant product categories data.
            List<DataPoint> dataPoints = new List<DataPoint>();
            List<ProductCategory> pc = new List<ProductCategory>();

            pc = await _context.ProductCategories.ToListAsync();

            // Looping through the all entries in the productCategories table in the database.
            foreach (var item in pc)
            {
                dataPoints.Add(new DataPoint(item.CategoryName, item.TotalOrders));
            }

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints); // Serializing datapoints and sending them to the viewbag for the graph to pull from.


            return View(await _context.ProductCategories.ToListAsync());
        }

        private bool ProductCategoryExists(int id)
        {
            return _context.ProductCategories.Any(e => e.CategoryId == id);
        }
    }
}
