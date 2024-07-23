using Microsoft.AspNetCore.Mvc;
using MujWeb.Models;
using System.Diagnostics;

namespace MujWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OMne()
        {
            return View();
        }

        public IActionResult Databaze()
        {
            List<Uzivatel> objCategoryList = _db.Uzivatele.ToList();
            return View(objCategoryList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
