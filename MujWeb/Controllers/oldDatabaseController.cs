//using Microsoft.AspNetCore.Mvc;
//using MujWeb.Models;

//namespace MujWeb.Controllers
//{
//    public class DatabaseController : Controller
//    {
//        private readonly ApplicationDbContext _db;
//        public DatabaseController(ApplicationDbContext db)
//        {
//            _db = db;
//        }


//        public IActionResult CreateUzivatel()
//        {
//            return View();
//        }
//        public IActionResult EditUzivatel(int? id)
//        {
//            if (id == null || id == 0)
//            {
//                return NotFound();
//            }
//            Uzivatel? categoryFromDb = _db.Uzivatele.Find(id);

//            if (categoryFromDb == null)
//            {
//                return NotFound();
//            }
//            return View(categoryFromDb);
//        }
//        public IActionResult DeleteUzivatel(int? id)
//        {
//            if (id == null || id == 0)
//            {
//                return NotFound();
//            }
//            Uzivatel? categoryFromDb = _db.Uzivatele.Find(id);

//            if (categoryFromDb == null)
//            {
//                return NotFound();
//            }
//            return View(categoryFromDb);
//        }

//        [HttpPost]
//        public IActionResult CreateUzivatel(Uzivatel obj)
//        {
//            if (ModelState.IsValid)
//            {
//                _db.Uzivatele.Add(obj);
//                _db.SaveChanges();
//                TempData["success"] = "Category created succesfully";
//                return RedirectToAction("Databaze", "Home");
//            }
//            else
//            {
//                return View();
//            }
//        }
//        [HttpPost]
//        public IActionResult EditUzivatel(Uzivatel obj)
//        {
//            if (ModelState.IsValid)
//            {
//                _db.Uzivatele.Update(obj);
//                _db.SaveChanges();
//                TempData["success"] = "Category edited succesfully";
//                return RedirectToAction("Databaze", "Home");
//            }
//            return View();
//        }
//        [HttpPost, ActionName("DeleteUzivatel")]

//        public IActionResult DeleteUzivatelPOST(int? id)
//        {
//            Uzivatel? obj = _db.Uzivatele.Find(id);
//            if (obj == null)
//            {
//                return NotFound();
//            }
//            _db.Uzivatele.Remove(obj);
//            _db.SaveChanges();
//            TempData["success"] = "Category deleted succesfully";
//            return RedirectToAction("Databaze", "Home");

//        }

//    }
//}
