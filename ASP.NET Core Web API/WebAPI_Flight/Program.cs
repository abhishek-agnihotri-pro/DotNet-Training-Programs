using Microsoft.EntityFrameworkCore;
using WebAPI_Flight.Model;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("MyConstr") ?? throw new InvalidOperationException("Connection string 'AppDbContextConnection' not found.");
 
builder.Services.AddDbContext<AppDbContext>(options =>
       options.UseSqlServer(connectionString));
// Add services to the container.

builder.Services.AddControllers();

  builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
  {
      builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
  }));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corsapp");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
