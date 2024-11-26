using System.ComponentModel.DataAnnotations;
using MVC_PartialViewDemo.Models;

namespace MVC_PartialViewDemo.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Display(Name = "Employee Name")]
        public string? EmployeeName { get; set; }
        [Display(Name = "Employee Salary")]
        public decimal? EmployeeSalary { get; set; }
        public virtual Department? Departments { get; set; }
    }
}