using System.ComponentModel.DataAnnotations;

namespace MVC_EDUHUB.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string? Status { get; set; }

    }
}