using System.ComponentModel.DataAnnotations;

namespace MVC_PartialViewDemo.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string? DepartmentName { get; set; }
        public virtual List<Employee>? Employees { get; set; }
    }
}