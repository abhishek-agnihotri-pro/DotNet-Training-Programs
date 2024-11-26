using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_EDUHUB.ViewModel
{
    public class EnrollmentViewModel
    {
        [Key]
        public int EnrollmentId { get; set; }
        public int? UserId { get; set; }
        public int? CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string? Status { get; set; }
        public string? UserName { get; set; }
        public string? CourseName { get; set; }
    }
}