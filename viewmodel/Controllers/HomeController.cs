using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using viewmodel.Domain;
using viewmodel.Models;
using viewmodel.ViewModel;

namespace viewmodel.Controllers
{
    public class HomeController : Controller
    {
        private readonly NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(OrderDetailsViewModel odvm)
        {
            return View(odvm);
        }
    }
}