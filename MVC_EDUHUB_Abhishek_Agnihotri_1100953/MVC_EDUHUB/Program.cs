using Microsoft.EntityFrameworkCore;
using MVC_Eduhub;
using MVC_EDUHUB;
using MVC_EDUHUB.Models;
using MVC_EDUHUB.Repository;
using MVC_EDUHUB.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
 
// Configure session options
builder.Services.AddSession(options =>
{
     options.IdleTimeout = TimeSpan.FromMinutes(1); // Set session timeout
});

var connectionString = builder.Configuration.GetConnectionString("MyConstr") ?? throw new InvalidOperationException("Connection string 'AppDBContextConnection' not found.");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IUserService,UserRepository>();
builder.Services.AddScoped<IEducatorService,EducatorRepository>();
builder.Services.AddScoped<IStudentService,StudentRepository>();
builder.Services.AddScoped<IMaterialService,MaterialRepository>();
builder.Services.AddScoped<IEnquiryService,EnquiryRepository>();
builder.Services.AddScoped<IEnrollmentService,EnrollmentRepository>();
builder.Services.AddScoped<IFeedbackService,FeedbackRepository>();
builder.Services.AddScoped<ICourseService,CourseRepository>();
 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseSession();



app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
