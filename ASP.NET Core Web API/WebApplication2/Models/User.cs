using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class User{
        [Key]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? UserRole { get; set; }
    }
}