using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MujWeb.Models;
using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace MujWeb.Controllers
{

    public class CalculatorController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CalculatorController(ApplicationDbContext db)
        {
            _db = db;
        }
 



    public IActionResult Index()
        {
            List<Calculator> objCategoryList = _db.Calculations.ToList();
            ViewBag.Calculations = objCategoryList;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator obj)
        {
            try
            {

                switch (obj.Operation) // 1 = +, 2 = -, 3 = *, 4 = /
                {
                    case 1:
                        obj.Result = Convert.ToDouble(obj.FirstNumber.Replace('.', ',')) + Convert.ToDouble(obj.SecondNumber.Replace('.', ','));
                        break;
                    case 2:
                        obj.Result = Convert.ToDouble(obj.FirstNumber.Replace('.', ',')) - Convert.ToDouble(obj.SecondNumber.Replace('.', ','));
                        break;
                    case 3:
                        obj.Result = Convert.ToDouble(obj.FirstNumber.Replace('.', ',')) * Convert.ToDouble(obj.SecondNumber.Replace('.', ','));
                        break;
                    case 4:
                        obj.Result = Convert.ToDouble(obj.FirstNumber.Replace('.', ',')) / Convert.ToDouble(obj.SecondNumber.Replace('.', ','));
                        break;
                    default:
                        ViewBag.Result = "Error";
                        break;

                }
            }
            catch
            {
                ViewBag.Result = "Error";
            }
            if (ViewBag.Result == null) 
            { 
                ViewBag.Result = obj.Result;
                _db.Calculations.Add(obj);
                _db.SaveChanges();
            }
            var calculations = ViewBag.Calculations as List<Calculator>;
            if (calculations != null && calculations.Count > 10)
            {
                _db.Calculations.Remove(calculations[10]);
                _db.SaveChanges();
            }



            return View();
        }

    }
}
