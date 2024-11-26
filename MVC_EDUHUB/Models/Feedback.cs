using System.ComponentModel.DataAnnotations;

namespace MVC_EDUHUB.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string? feedback { get; set; }

    }
}