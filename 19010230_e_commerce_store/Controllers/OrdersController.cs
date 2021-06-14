using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _19010230_e_commerce_store.Models;
using Microsoft.AspNetCore.Http;


namespace _19010230_e_commerce_store.Controllers
{
    public class OrdersController : Controller
    {
        private readonly prog7311Task2Context _context;

        public OrdersController(prog7311Task2Context context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            // Users not yet logged in are shown a popup error message and will see no order history.
            if (HttpContext.Session.GetString("currentUser") is null)
            {
                ViewBag.notification = "Please log in before attempting to make a purchase!";
            }

            var prog7311Task2Context = _context.OrderInfos.Include(o => o.Product).Include(o => o.User)
                .Where(x=>x.User.UserEmail.Equals(HttpContext.Session.GetString("currentUser")));
            return View(await prog7311Task2Context.ToListAsync());

        }


        private bool OrderInfoExists(int id)
        {
            return _context.OrderInfos.Any(e => e.OrderId == id);
        }
    }
}
