using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyVal.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime dateTime)
            {
                if (dateTime > DateTime.Now)
                {
                    return new ValidationResult("The date cannot occur after today.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
