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
        //[Key]
        //[Display(Name = "Application Number")]
        //public int ApplicationID = RandomGen.Next();

        [Required(ErrorMessage = "Please enter your child's First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your child's Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Key]
        [Required(ErrorMessage = "Please enter your child's PPS Number")]
        [RegularExpression(@"(\d{7})([A-Z]{1,2})", ErrorMessage = "Please Enter a Valid PPSN")]
        public string PPSN { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        //[Age(ErrorMessage = "Child must be between the ages of 3 and 5 when starting")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please enter your child's gender")]
        public string Gender { get; set; }

        //[Required]
        //public string Days { get; set; }
        [Required]
        public string Hours { get; set; }

        [Required]
        [FutureDate(ErrorMessage = "You must choose a date in the future")]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
    }
}
