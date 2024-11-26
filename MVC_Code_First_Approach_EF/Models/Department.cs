using System;
using System.ComponentModel.DataAnnotations;
 
namespace MVC_Code_First_Approach_EF.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is compulsory")]
        [StringLength(30)]
        public string Name { get; set; }
 
    }
}