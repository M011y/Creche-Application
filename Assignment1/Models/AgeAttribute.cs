using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class AgeAttribute : ValidationAttribute
    {
        //public override bool IsValid(object value)
        //{
            //start date - DOB must be between 3 and 5

            //var age = GetAge((DateTime)value);

            //int GetAge(DateTime bornDate)
            //{
            //    DateTime today = DateTime.Today;
            //    age = today.Year - bornDate.Year;
            //    if (bornDate > today.AddYears(-age))
            //        age--;

            //    return age;
            //}

            //return value != null && age > 2 && age < 6;
        //}
    }
}
