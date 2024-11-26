using System.ComponentModel.DataAnnotations;
using MVC_Custom_Validation.CustomValidations;
using MVC_CustomValidation.CustomValidation;

namespace MVC_Custom_Validation.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [CustomAdmissionDate(ErrorMessage = "Admission Date must be less than or eqal")]
        public DateTime DOA { get; set; }
        [Min18Years]
        public DateTime DOB { get; set; }
    }
}