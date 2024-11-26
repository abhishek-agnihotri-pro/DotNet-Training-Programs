using System.ComponentModel.DataAnnotations;

namespace MVC_Code_First_Approach_EF.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is a must")]
        [StringLength(50)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        public int DepartmentID { get; set; }
    }
}