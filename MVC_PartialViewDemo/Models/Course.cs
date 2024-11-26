using System.ComponentModel.DataAnnotations;

namespace MVC_PartialViewDemo.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string? CourseDescription { get; set; }
        public List<Student>? Students { get; set; }
    }
}