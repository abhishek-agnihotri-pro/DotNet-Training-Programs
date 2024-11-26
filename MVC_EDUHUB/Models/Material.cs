using System.ComponentModel.DataAnnotations;

namespace MVC_EDUHUB.Models
{
    public class Material
    {
        public int MaterialId { get; set; }
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime UploadDate { get; set; }
        public string? ContentType { get; set; }
        public string? URL { get; set; }
    }
}