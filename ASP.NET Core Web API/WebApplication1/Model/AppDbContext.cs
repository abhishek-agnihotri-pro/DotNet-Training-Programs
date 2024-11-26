using Microsoft.EntityFrameworkCore;
 namespace WebApplication1.Model;
public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options){ }
        public DbSet<Student> students{get; set;}
    }
 