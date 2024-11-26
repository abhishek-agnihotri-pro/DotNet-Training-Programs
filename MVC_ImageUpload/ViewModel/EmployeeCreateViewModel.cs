namespace MVC_ImageUpload.ViewModel{
    public class EmployeeCreateViewModel{
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime DOJ { get; set; }
        public int deptId { get; set; }
        public string Gender { get; set; }
        public IFormFile Photopath { get; set; }
    }
}