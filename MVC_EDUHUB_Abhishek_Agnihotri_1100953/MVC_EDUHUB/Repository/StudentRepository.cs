using MVC_EDUHUB.Models;
using MVC_EDUHUB.Services;

namespace MVC_EDUHUB.Repository
{
    public class StudentRepository : IStudentService
    {
        private readonly AppDbContext _context;
        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }
        public User GetStudent(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(user=> user.Email == email && user.Password == password && user.Role == "Student");
            return user;
        }
    }
}