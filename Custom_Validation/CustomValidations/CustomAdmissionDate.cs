using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Custom_Validation.CustomValidations
{
    public class CustomAdmissionDate : ValidationAttribute{
        public override bool IsValid(object? value)
        {
            DateTime dateTime = Convert.ToDateTime(value);
            return dateTime <= DateTime.Now;
        }
    }
}