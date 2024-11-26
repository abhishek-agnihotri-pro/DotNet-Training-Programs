using Microsoft.EntityFrameworkCore;
using MVC_EDUHUB.ViewModel;

namespace MVC_EDUHUB.Models{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options){}
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enquiry> Enquiries { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<LoginViewModel> LoginViewModel { get; set; }
        public DbSet<MaterialViewModel> MaterialViewModels { get; set; }
        public DbSet<EnrollmentViewModel> EnrollmentViewModels { get; set; }
        public DbSet<FeedbackViewModel> FeedbackViewModels { get; set; }
        public DbSet<MyCourseViewModel> MyCourseViewModels { get; set; }
        public DbSet<MyEnquiryViewModel> MyEnquiryViewModels { get; set; }
        public DbSet<StudentEnrollmentViewModel> StudentEnrollmentViewModels { get; set; }
    }
}