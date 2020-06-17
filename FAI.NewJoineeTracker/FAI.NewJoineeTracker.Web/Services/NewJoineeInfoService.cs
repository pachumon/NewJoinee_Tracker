using FAI.NewJoineeTracker.Web.Models.View;
using FAI.NewJoineeTracker.Web.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAI.NewJoineeTracker.Web.Services
{
    public class NewJoineeInfoService : INewJoineeInfoService
    {
 

        public NewJoineeInfo CreateNewJoineeInfo(NewJoineeInfo newJoineeInfo)
        {
            var maxEmpId = InMemoryData.Instance.lstNewJoinees.OrderByDescending(joinee => joinee.EmployeeId).FirstOrDefault().EmployeeId;
            newJoineeInfo.EmployeeId = maxEmpId;
            InMemoryData.Instance.lstNewJoinees.Add(newJoineeInfo);
            return newJoineeInfo;
        }

        public NewJoineeInfo DeleteNewJoineeInfo(NewJoineeInfo newJoineeInfo)
        {
            var newJoinee = InMemoryData.Instance.lstNewJoinees.Where(joinee => joinee.EmployeeId == newJoineeInfo.EmployeeId).FirstOrDefault();
            newJoinee.IsActive = false;
            return newJoineeInfo;
        }

        public List<NewJoineeInfo> GetAllNewJoinees()
        {
            return InMemoryData.Instance.lstNewJoinees.Where(joinee => joinee.IsActive).ToList();
        }

        public NewJoineeInfo GetNewJoineeInfo(int Id)
        {
            return InMemoryData.Instance.lstNewJoinees.Where(joinee => joinee.EmployeeId == Id).FirstOrDefault();
        }

        public NewJoineeInfo UpdateNewJoineeInfo(NewJoineeInfo newJoineeInfo)
        {
            var newJoinee = InMemoryData.Instance.lstNewJoinees.Where(joinee => joinee.EmployeeId == newJoineeInfo.EmployeeId).FirstOrDefault();
            var index = InMemoryData.Instance.lstNewJoinees.IndexOf(newJoinee);
            InMemoryData.Instance.lstNewJoinees[index] = newJoineeInfo;
            return newJoineeInfo;
        }
    }
}