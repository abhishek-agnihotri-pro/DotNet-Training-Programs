using System.ComponentModel.DataAnnotations;

namespace MVC_Code_First_Approach_EF.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is must")]
        [StringLength(50)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
    }
}
