using System;
using System.Linq;
using DevExpress.Xpo;
using Microsoft.AspNetCore.Mvc;
using MujWeb.Models;

namespace MyApplication.Controllers
{
    public class DatabaseController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public DatabaseController()
        {
            _unitOfWork = new UnitOfWork();
        }

        public ActionResult Index()
        {
            var calculations = _unitOfWork.Query<Calculator>().OrderByDescending(c => c.Id).ToList();
            ViewBag.Calculations = calculations;
            return View();
        }




    }
}