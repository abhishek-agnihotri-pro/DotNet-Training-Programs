
using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Layout_Demo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime Expire { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
    }
}