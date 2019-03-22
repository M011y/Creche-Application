using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class AgeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object AgeAttribute, ValidationContext validationContext)
        {
            Applicant applicant = (Applicant)validationContext.ObjectInstance;
            TimeSpan span = applicant.StartDate.Subtract(applicant.DOB);

            if (span.Days < 1826 && span.Days > 1094)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(GetErrorMessage());
            }
        }

        private string GetErrorMessage()
        {
            return $"Child must be between the ages of 3 and 5 when they start";
        }
    }
}
