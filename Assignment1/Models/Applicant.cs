using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//applicant class includes child and parent details
namespace Assignment.Models
{
    public class Applicant
    {
        //list child properties first name, last name, PPS num, DOB, gender, hours requested, days requested,
        //starting date
        //regular expression used to validate PPSN, phone numbers and emails.

        //application number generated for each applicant, starting at 1.
        //used as key.
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
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Hours { get; set; }

        public bool Monday { get; set; }

        public bool Tuesday { get; set; }

        public bool Wednesday { get; set; }

        public bool Thursday { get; set; }

        public bool Friday { get; set; }

        //futuredate attribute referenced to ensure date is in the future, age attribute referenced to validate age
        [Required]
        [FutureDate]
        [Age]
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
        [RegularExpression(@"([0]{1}[8]{1}[3|5|6|7|9]{1}[0-9]{7})", ErrorMessage = "Please Enter a Valid Irish mobile Phone Number")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Please enter your house phone number")]
        [Display(Name = "House Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(^[+]{1}[0-9]{12}$)|(^[+]{1}[0-9]{11}$)|(^[0]{2}[0-9]{12}$)|(^[0]{2}[0-9]{11}$)|(^[0]{1}[0-9]{9}$)", ErrorMessage = "Please Enter a Valid Phone Number")]
        public string Phone1 { get; set; }

        [Display(Name = "Other Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(^[+]{1}[0-9]{12}$)|(^[+]{1}[0-9]{11}$)|(^[0]{2}[0-9]{12}$)|(^[0]{2}[0-9]{11}$)|(^[0]{1}[0-9]{9}$)", ErrorMessage = "Phone Number Not Valid")]
        public string Phone2 { get; set; }

        [Required(ErrorMessage = "Please enter your Email Address")]
        [Display(Name = "E-mail Address")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter a Valid Email Address")]
        public string Email1 { get; set; }

        [Display(Name = "Alternative E-mail Address")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Email Address Not Valid")]
        public string Email2 { get; set; }

        //cost property
        public string Cost { get { return GetCost(); } }

        //Get Cost method
        private string GetCost()
        {
            string cost;
            decimal amount;

            var numOfDays = 0;
            if (Monday) { numOfDays++; }
            if (Tuesday) { numOfDays++; }
            if (Wednesday) { numOfDays++; }
            if (Thursday) { numOfDays++; }
            if (Friday) { numOfDays++; }

            //calculations for full-time
            if (Hours is "Full-Time")
            {
                amount = numOfDays * 35;
                if (numOfDays > 3)
                {
                    amount = amount * (decimal)0.9;
                }
            }
            //calculations for part-time
            else
            {
                amount = numOfDays * 20;
                if (numOfDays > 3)
                {
                    amount = amount * (decimal)0.9;
                }
            }

            cost = ($"€{amount}");

            return cost;
        }
    }
}
