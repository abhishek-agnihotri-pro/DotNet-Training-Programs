using Microsoft.EntityFrameworkCore;

using MVC_StoredProcedure.Models;
using MVC_StoredProcedure.ViewModel;


namespace MVC_StoredProcedure.Models{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options){}
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CatProductViewModel> ProductsByCategory { get; set; }
    }
}