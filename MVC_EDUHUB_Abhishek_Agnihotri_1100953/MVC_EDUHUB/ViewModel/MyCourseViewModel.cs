using System.ComponentModel.DataAnnotations;

namespace MVC_EDUHUB.ViewModel
{
    public class MyCourseViewModel
    {
        [Key]
        public int courseId { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
        public DateTime courseStartDate { get; set; }
        public DateTime courseEndDate { get; set; }
        public int userId { get; set; }
        public string? category { get; set; }
        public string? level { get; set; }
        public string? UserName { get; set; }
        public string? CourseName { get; set; }
    }
}