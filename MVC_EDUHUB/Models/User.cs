using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_EDUHUB.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? FullName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Mobile_Number { get; set; }
        public string? Role { get; set; }
        public string? ProfileImage { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }
    }

}