using System.ComponentModel.DataAnnotations;

namespace MVC_EDUHUB.ViewModel
{
    public class MaterialViewModel
    {
        [Key]
        public int MaterialId { get; set; }
        public string? CourseTitle { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime UploadDate { get; set; }
        public string? ContentType { get; set; }
        public string? URL { get; set; }
    }
}