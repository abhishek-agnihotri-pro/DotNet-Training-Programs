using Microsoft.EntityFrameworkCore;
using MVC_PartialViewDemo;

namespace MVC_PartialViewDemo.Models{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options){}
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}