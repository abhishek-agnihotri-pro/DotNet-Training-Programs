using System.ComponentModel.DataAnnotations;
using MVC_StoredProcedure.Models;

namespace MVC_StoredProcedure.ViewModel
{
    public class CatProductViewModel{
        [Key]
        public int ProductId { get ; set ;}
        public string CatName { get; set; }
        public string   ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}