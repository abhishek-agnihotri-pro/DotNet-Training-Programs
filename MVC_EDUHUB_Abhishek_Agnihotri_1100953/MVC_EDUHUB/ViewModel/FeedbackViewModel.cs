using System.ComponentModel.DataAnnotations;

namespace MVC_EDUHUB.ViewModel
{
    public class FeedbackViewModel
    {
        [Key]
        public int FeedbackId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string? feedback { get; set; }
        public string? UserName { get; set; }
    }
}