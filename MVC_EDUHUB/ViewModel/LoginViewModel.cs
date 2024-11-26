using System.ComponentModel.DataAnnotations;

namespace MVC_EDUHUB.ViewModel
{
    public class LoginViewModel{
        [Required]
        [Key]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}