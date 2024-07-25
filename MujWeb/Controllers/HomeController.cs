using System;
using System.Linq;
using DevExpress.Xpo;
using Microsoft.AspNetCore.Mvc;
using MujWeb.Models;

namespace MyApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public HomeController()
        {
            _unitOfWork = new UnitOfWork();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OMne()
        {
            var calculations = _unitOfWork.Query<Calculator>().OrderByDescending(c => c.Id).ToList();
            ViewBag.Calculations = calculations;
            return View();
        }
    }
}