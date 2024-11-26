using System.ComponentModel.DataAnnotations;

namespace MVC_EDUHUB.ViewModel
{
    public class MyEnquiryViewModel
    {
        [Key]
        public int EnquiryId { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public DateTime EnquiryDate { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public string? Status { get; set; }
        public string? Response { get; set; }
        public string? UserName { get; set; }
        public string? CourseName { get; set; }
    }
}
