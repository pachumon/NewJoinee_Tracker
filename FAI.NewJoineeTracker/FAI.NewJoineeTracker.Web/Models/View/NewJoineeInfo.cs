using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAI.NewJoineeTracker.Web.Models.View
{
    public class NewJoineeInfo
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Project { get; set; }
        public string Location { get; set; }
        public string BusinessUnit { get; set; }
        public bool IsActive { get; set; }

    }
}