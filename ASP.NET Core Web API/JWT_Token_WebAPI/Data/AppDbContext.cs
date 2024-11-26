using JWT_Token_WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace JWT_Token_WebAPI.Data;

public class AppDbContext  : DbContext
{
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options){ }
        public DbSet<User> Users{get; set;}
        public DbSet<Product> Products{get; set;}
}