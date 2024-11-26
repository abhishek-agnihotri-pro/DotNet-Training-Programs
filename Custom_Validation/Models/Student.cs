using System.ComponentModel.DataAnnotations;
using Custom_Validation.CustomValidations;

namespace Custom_Validation.Models{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [CustomAdmissionDate(ErrorMessage = "Admission Date must be less than or eqal")]
        public DateTime DOA {get; set;}
    }
}