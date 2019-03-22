using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//Validation attribute to check if date is in future
namespace Assignment.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            //the "value" (date) passed in must be greater than the date today, ie must be in the future
            return value != null && (DateTime)value > DateTime.Now;
        }
    }
}
