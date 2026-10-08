using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WomenBagStore.Models;

namespace WomenBagStore.Controllers
{
    public class BagsController : Controller
    {
        public ActionResult Index()
        {

            var bags = new List<Bag>
        {
            new Bag { id = 1, name = "Elegant Black", ImageFileName = "bag1.jpg", Price = 45, Colors = new List<string> { "White", "Black" } },
            new Bag { id = 2, name = "Summer Pink", ImageFileName = "bag3.jpg", Price = 35, Colors = new List<string> { "Black", "Gray", "Silver" } },

        };

            return View(bags);
        }

        [HttpPost]
        public ActionResult AddToCart(int id)
        {

            TempData["Message"] = "Bag added to cart!";
            return RedirectToAction("Index");
        }
    }
}