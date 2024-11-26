using System.ComponentModel.DataAnnotations;

namespace MVC_Code_First_Approach_EF.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}