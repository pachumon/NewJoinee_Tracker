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
        [MinLength(5)]
        [MaxLength(30)]
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        [Required]
        [MinLength(3,ErrorMessage ="Should have a minimum of 3 characters")]
        [MaxLength(30)]
        public string Project { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(30)]
        public string Location { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(30)]
        public string BusinessUnit { get; set; }
        public bool IsActive { get; set; }

    }
}