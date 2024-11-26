namespace MVC_View_Model.Models{
    public class Category{
        public int Id { get; set; } 
        public string? Catname { get; set; }
        public List<Product> products { get; set; }
    }
}