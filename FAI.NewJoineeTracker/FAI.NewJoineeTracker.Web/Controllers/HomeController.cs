using FAI.NewJoineeTracker.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FAI.NewJoineeTracker.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly NewJoineeInfoService newJoineeInfoService=null;

        public HomeController()
        {
            newJoineeInfoService = new NewJoineeInfoService();
        }
        public ActionResult Index()
        {
            var newJoineeLst = newJoineeInfoService.GetAllNewJoinees();
            return View(newJoineeLst);
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