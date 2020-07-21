using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApproachApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Required(ErrorMessage="You can't leave it blank.")]
        [StringLength(10, MinimumLength = 3, ErrorMessage ="Enter a minimum of three and a maximum of 10 chars.")]
        [RegularExpression(@"(\S)+", ErrorMessage = "White space is not allowed.")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
    }
}