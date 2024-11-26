namespace MVC_ImageUpload.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime DOJ { get; set; }
        public int deptId { get; set; }
        public string? Gender { get; set; }
        public string? Photopath { get; set; }
    }
}