using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{

    public class Applicant
    {
        //list child properties first name, last name, PPS num, DOB, gender, hours requested, days requested,
        //starting date

        [Key]
        [Display(Name = "Application Number")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter your child's First Name")]
        [Display(Name = "First Name")]
        public string CFirstName { get; set; }

        [Required(ErrorMessage = "Please enter your child's Last Name")]
        [Display(Name = "Last Name")]
        public string CLastName { get; set; }

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

        [Required]
        public string Hours { get; set; }

        public bool Monday { get; set; }

        public bool Tuesday { get; set; }

        public bool Wednesday { get; set; }

        public bool Thursday { get; set; }

        public bool Friday { get; set; }

        [Required]
        [FutureDate(ErrorMessage = "You must choose a date in the future")]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        //list parent properties First Name, Surname, relationship to child, address, Irish mobile num,
        //second contact num, other contact num, e-mail address, 2nd e-mail address

        [Required(ErrorMessage = "Please enter your First Name")]
        [Display(Name = "First Name")]
        public string PFirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last Name")]
        [Display(Name = "Last Name")]
        public string PLastName { get; set; }

        [Required]
        [Display(Name = "Relationship to Child")]
        public string Relationship { get; set; }

        [Required(ErrorMessage = "Please enter your Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your mobile phone number")]
        [Display(Name = "Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public int Mobile { get; set; }

        [Required(ErrorMessage = "Please enter your house phone number")]
        [Display(Name = "House Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public int Phone1 { get; set; }

        [Display(Name = "Other Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public int Phone2 { get; set; }

        [Required(ErrorMessage = "Please enter your Email Address")]
        [Display(Name = "E-mail Address")]
        [DataType(DataType.EmailAddress)]
        public string Email1 { get; set; }

        [Display(Name = "Alternative E-mail Address")]
        [DataType(DataType.EmailAddress)]
        public string Email2 { get; set; }
    }
}
