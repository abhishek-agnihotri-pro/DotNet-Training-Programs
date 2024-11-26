using System.ComponentModel.DataAnnotations;
using MVC_PartialViewDemo.Models;

namespace MVC_PartialViewDemo.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "Student Name")]
        public string? StudentName { get; set; }
        [Display(Name = "Student Date of Birth")]
        public string? StudentDOB { get; set; }
        
        [Display(Name = "Student Phone Number")]
        public string? StudentPhoneNum { get; set; }
        [Display(Name = "Student Address")]
        public string? StudentAddress { get; set; }
        public virtual Course? Course { get; set; }
    }
}