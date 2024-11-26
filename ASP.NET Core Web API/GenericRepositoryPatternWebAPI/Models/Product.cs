using System.ComponentModel.DataAnnotations;

namespace GenericRepositoryPatternWebAPI.Models;

public class Product
{
    [Key]
    public int ID { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public int CategoryID { get; set; }
}