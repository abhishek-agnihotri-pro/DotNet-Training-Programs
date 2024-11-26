using System.ComponentModel.DataAnnotations;

namespace MVC_EDUHUB.ViewModel
{
    public class StudentEnrollmentViewModel
    {
        [Key]
        public int EnrollmentId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string? Status { get; set; }
        public string? CourseName { get; set; }
    }
}