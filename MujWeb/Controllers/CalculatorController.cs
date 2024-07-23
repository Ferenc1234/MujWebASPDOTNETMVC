using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MujWeb.Models;
using System;


namespace MujWeb.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
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
            }
            return View();
        }

    }
}
