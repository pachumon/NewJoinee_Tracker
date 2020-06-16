using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FAI.NewJoineeTracker.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddInfo()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}