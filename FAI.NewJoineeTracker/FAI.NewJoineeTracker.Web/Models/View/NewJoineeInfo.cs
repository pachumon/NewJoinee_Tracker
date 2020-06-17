using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FAI.NewJoineeTracker.Web.Models.View
{
    public class NewJoineeInfo
    {
        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        [Required]
        public string Project { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string BusinessUnit { get; set; }
        public bool IsActive { get; set; }

    }
}