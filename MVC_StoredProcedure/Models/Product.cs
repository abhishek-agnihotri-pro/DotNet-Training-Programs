using System.ComponentModel.DataAnnotations;

namespace MVC_StoredProcedure.Models
{
    public class Product{
        [Key]
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}