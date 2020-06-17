using FAI.NewJoineeTracker.Web.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAI.NewJoineeTracker.Web.utility
{
  
    public sealed class InMemoryData
    {
        private static InMemoryData instance = null;

        
        public List<NewJoineeInfo> lstNewJoinees { get; set; }= new List<NewJoineeInfo>();

        private InMemoryData()
        {
            lstNewJoinees = new List<NewJoineeInfo>
            {
                new NewJoineeInfo{EmployeeId=7000,Name="Johny",BusinessUnit="Direct IT",DateOfJoining=DateTime.Now.AddDays(-60),Project="Oculus",Location="Banglore", IsActive=true},
                new NewJoineeInfo{EmployeeId=7001,Name="Sally",BusinessUnit="Business Tech Solution",DateOfJoining=DateTime.Now.AddDays(-60),Project="Clarity First",Location="Salem",IsActive=true},
                new NewJoineeInfo{EmployeeId=7002,Name="Milind",BusinessUnit="Direct IT",DateOfJoining=DateTime.Now.AddDays(-60),Project="Oculus",Location="Hyderabad",IsActive=true }
            };
        }

        public static InMemoryData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InMemoryData();
                }
                return instance;
            }
        }
    }
}