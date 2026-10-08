using System.Web.Mvc;
using WomenBagsStore.Models;

namespace WomenBagsStore.Controllers
{
    public class AccountController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                TempData["Username"] = user.Name;
                return RedirectToAction("Success");
            }
            return View(user);
        }

        public ActionResult Success()
        {
            ViewBag.User = TempData["Username"];
            return View();
        }
    }
}
