using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Child
    {
        //list properties first name, last name, PPS num, DOB, gender, hours requested, days requested,
        //starting date

        [Required(ErrorMessage = "Please enter a First Name"), StringLength(100)]
        [Display(Name = "First Name")]
        [RegularExpression(@"[\w|-]{2,}", ErrorMessage = "First Name must be atleast 2 characters")]
        public string FirstName { get; set; } = "";

        [Required]
        public string LastName { get; set; }

        [Required]
        public int PPSN { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public int Hours { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
    }
}
