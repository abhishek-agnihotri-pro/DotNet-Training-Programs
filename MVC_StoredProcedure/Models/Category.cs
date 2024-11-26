using System.ComponentModel.DataAnnotations;

namespace MVC_StoredProcedure.Models
{
    public class Category{
        [Key]
        public int CatId { get; set; }
        public string? CategoryName { get; set; }
    }
}