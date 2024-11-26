using Microsoft.EntityFrameworkCore;

namespace MVC_Layout_Demo.Models{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) {}
        public DbSet<Student> Students { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}