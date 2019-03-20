using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Parent
    {
        //list properties First Name, Surname, relationship to child, address, Irish mobile num,
        //second contact num, other contact num, e-mail address, 2nd e-mail address

        [Required(ErrorMessage = "Please enter your First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Relationship to Child")]
        public string Relationship { get; set; }

        [Required(ErrorMessage = "Please enter your Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public int Mobile { get; set; }

        [Required]
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
