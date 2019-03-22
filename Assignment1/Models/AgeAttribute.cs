using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//Validation attribute to check child's age
namespace Assignment.Models
{
    public class AgeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object AgeAttribute, ValidationContext validationContext)
        {
            //calculates the difference between start date (the date further in time) and birth date.
            //uses days to calculate whether the child is above 3 and under 5.
            Applicant applicant = (Applicant)validationContext.ObjectInstance;
            TimeSpan span = applicant.StartDate.Subtract(applicant.DOB);

            //returns success if child is the correct age.
            //returns error message if child is not the correct age.
            if (span.Days < 1826 && span.Days > 1094)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(GetErrorMessage());
            }
        }

        //method which returns error message
        private string GetErrorMessage()
        {
            return $"Child must be between the ages of 3 and 5 when they start";
        }
    }
}
