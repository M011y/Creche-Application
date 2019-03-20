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

        [Required(ErrorMessage = "Please enter your child's First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your child's Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your child's PPS Number")]
        public string PPSN { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please enter your child's gender")]
        public string Gender { get; set; }

        //[Required]
        //public string Days { get; set; }
        [Required]
        public string Hours { get; set; }

        [Required(ErrorMessage = "Please enter the date your child will be starting")]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
    }
}
