namespace WebApplication1.Model
{
    public class Student
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DOA { get; set; }
        public DateTime DOB { get; set; }
    }
}