using System.ComponentModel.DataAnnotations;

namespace JWT_Token_WebAPI.Model;

public class LogInModel
{
    [Required]
    [MinLength(6)]
    public string? Username { get; set; }
    [Required]
    [MinLength(6)]
    public string? Password { get; set; }

}