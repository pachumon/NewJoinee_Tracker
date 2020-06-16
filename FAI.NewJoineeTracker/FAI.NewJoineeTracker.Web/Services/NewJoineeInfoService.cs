using FAI.NewJoineeTracker.Web.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAI.NewJoineeTracker.Web.Services
{
    public class NewJoineeInfoService : INewJoineeInfoService
    {
        List<NewJoineeInfo> lstNewJoinees = new List<NewJoineeInfo>();

        public NewJoineeInfoService()
        {
            lstNewJoinees = new List<NewJoineeInfo>
            {
                new NewJoineeInfo{EmployeeId=7000,Name="Johny",BusinessUnit="Direct IT",DateOfJoining=DateTime.Now.AddDays(-60),Project="Oculus",Location="Banglore", IsActive=true},
                new NewJoineeInfo{EmployeeId=7001,Name="Sally",BusinessUnit="Business Tech Solution",DateOfJoining=DateTime.Now.AddDays(-60),Project="Clarity First",Location="Salem",IsActive=true},
                new NewJoineeInfo{EmployeeId=7002,Name="Milind",BusinessUnit="Direct IT",DateOfJoining=DateTime.Now.AddDays(-60),Project="Oculus",Location="Hyderabad",IsActive=true }
            };
        }

        public NewJoineeInfo CreateNewJoineeInfo(NewJoineeInfo newJoineeInfo)
        {
            var maxEmpId = lstNewJoinees.OrderByDescending(joinee => joinee.EmployeeId).FirstOrDefault().EmployeeId;
            newJoineeInfo.EmployeeId = maxEmpId;
            lstNewJoinees.Add(newJoineeInfo);
            return newJoineeInfo;
        }

        public NewJoineeInfo DeleteNewJoineeInfo(NewJoineeInfo newJoineeInfo)
        {
            var newJoinee = lstNewJoinees.Where(joinee => joinee.EmployeeId == newJoineeInfo.EmployeeId).FirstOrDefault();
            newJoinee.IsActive = false;
            return newJoineeInfo;
        }

        public List<NewJoineeInfo> GetAllNewJoinees()
        {
            return lstNewJoinees.Where(joinee => joinee.IsActive).ToList();
        }

        public NewJoineeInfo GetNewJoineeInfo(int Id)
        {
            return lstNewJoinees.Where(joinee => joinee.EmployeeId == Id).FirstOrDefault();
        }

        public NewJoineeInfo UpdateNewJoineeInfo(NewJoineeInfo newJoineeInfo)
        {
            var newJoinee = lstNewJoinees.Where(joinee => joinee.EmployeeId == newJoineeInfo.EmployeeId).FirstOrDefault();
            newJoinee = newJoineeInfo;
            return newJoineeInfo;
        }
    }
}