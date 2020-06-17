using FAI.NewJoineeTracker.Web.Models.View;
using FAI.NewJoineeTracker.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FAI.NewJoineeTracker.Web.Controllers
{
    public class NewJoineeDataController : ApiController
    {
        private readonly NewJoineeInfoService newJoineeInfoService = null;

        public NewJoineeDataController()
        {
            newJoineeInfoService = new NewJoineeInfoService();
        }
        public IEnumerable<NewJoineeInfo> GetNewJoinees()
        {
            var newJoineeLst = newJoineeInfoService.GetAllNewJoinees();
            return newJoineeLst;
        }
    }
}
