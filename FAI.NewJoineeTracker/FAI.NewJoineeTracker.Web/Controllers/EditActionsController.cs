using FAI.NewJoineeTracker.Web.Models.View;
using FAI.NewJoineeTracker.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FAI.NewJoineeTracker.Web.Controllers
{
    public class EditActionsController : Controller
    {
        private readonly NewJoineeInfoService newJoineeInfoService = null;
        public EditActionsController()
        {
            newJoineeInfoService = new NewJoineeInfoService();
        }
        // GET: EditActions
        public ActionResult EditInfo(int joineeId)
        {
            var newJoineeInfo = newJoineeInfoService.GetNewJoineeInfo(joineeId);
            return View(newJoineeInfo);
        }

        [HttpPost]
        public ActionResult EditInfo(NewJoineeInfo newJoineeInfo)
        {

            if (ModelState.IsValid)
            {
                var editedJoineeInfo = newJoineeInfoService.UpdateNewJoineeInfo(newJoineeInfo);
                return RedirectToAction("Index", "Details", new { joineeId = editedJoineeInfo.EmployeeId });
            }
            return View(newJoineeInfo);
        }
    }
}