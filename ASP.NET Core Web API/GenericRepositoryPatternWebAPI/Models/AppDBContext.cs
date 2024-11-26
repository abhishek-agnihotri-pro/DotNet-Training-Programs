using System.Configuration;
using GenericRepositoryPatternWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryPatternWebAPI.Models;
public class AppDBContext : DbContext
{
    protected readonly IConfiguration _configuration;
    public AppDBContext(IConfiguration configuration){
        _configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(_configuration.GetConnectionString("MyConstr"));
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}