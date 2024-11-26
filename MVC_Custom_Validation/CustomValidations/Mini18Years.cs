using System.ComponentModel.DataAnnotations;
using MVC_Custom_Validation.Models;
 
namespace MVC_CustomValidation.CustomValidation
{
    public class Min18Years:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var student = (Student)validationContext.ObjectInstance;
            if(student.DOB == null)
            return new ValidationResult("Date of birth is required");
            var age = DateTime.Today.Year  - student.DOB.Year;
            return(age>=18)
            ? ValidationResult.Success
            : new ValidationResult("Student should be at least 18 years of age");
        }
    }
}