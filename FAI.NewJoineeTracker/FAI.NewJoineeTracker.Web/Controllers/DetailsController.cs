using FAI.NewJoineeTracker.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FAI.NewJoineeTracker.Web.Controllers
{
    public class DetailsController : Controller
    {
        private readonly NewJoineeInfoService newJoineeInfoService = null;
        public DetailsController()
        {
            newJoineeInfoService = new NewJoineeInfoService();
        }
        // GET: Details
        public ActionResult Index(int joineeId)
        {
            var newJoineeInfo = newJoineeInfoService.GetNewJoineeInfo(joineeId);
            return View(newJoineeInfo);
        }
    }
}