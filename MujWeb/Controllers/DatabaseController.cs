using Microsoft.AspNetCore.Mvc;
using MujWeb.Models;

namespace MujWeb.Controllers
{
    public class DatabaseController : Controller
    {
        private readonly UzivatelContext _db;
        public DatabaseController(UzivatelContext db)
        {
            _db = db;
        }

        public IActionResult CreateUzivatel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUzivatel(Uzivatel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Uzivatele.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category created succesfully";
                return RedirectToAction("Index", "Category");
            }
            else
            {
                return View();
            }
        }
    }
}
