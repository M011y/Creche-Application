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

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Relationship { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Mobile { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Phone1 { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int Phone2 { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email1 { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email2 { get; set; }
    }
}
