using Microsoft.EntityFrameworkCore;
namespace WebAPI_Flight.Model;
public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options){ }
        public DbSet<Flight> flight {get; set;}
    }
 