using MVC_EDUHUB.Models;
using MVC_EDUHUB.Services;

namespace MVC_EDUHUB.Repository
{
    public class UserRepository : IUserService
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public User CreateUser(User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }
        public User GetEducator(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(user=> user.Email == email && user.Password == password && user.Role == "Educator");
            return user;
        }
    }
}