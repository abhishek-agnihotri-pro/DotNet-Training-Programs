using MVC_EDUHUB.Models;
using MVC_EDUHUB.Services;

namespace MVC_EDUHUB.Repository
{
    public class EducatorRepository : IEducatorService
    {
        private readonly AppDbContext _context;
        public EducatorRepository(AppDbContext context)
        {
            _context = context;
        }
        public User GetEducator(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(user=> user.Email == email && user.Password == password && user.Role == "Educator");
            return user;
        }
    }
}