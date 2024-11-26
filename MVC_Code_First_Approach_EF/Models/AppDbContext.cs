using Microsoft.EntityFrameworkCore;

namespace MVC_Code_First_Approach_EF.Models{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options){}
        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}