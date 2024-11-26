using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using WebApplication2.services;

namespace WebApplication2.repository
{
    public class UserRepository : IUserService
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context){
            _context = context;
        }
        public async Task<User> CreateUserAsync(User user)
        {
           var userr = await _context.Users.AddAsync(user);
           _context.SaveChangesAsync();
           return userr.Entity;
        }

        public Task<User> DeleteUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllStudentAsync()
        {

            return await _context.Users.Where(u => u.UserRole == "Student").ToListAsync();
        }

        public async Task<User> GetUserAsync(int userId)
        {
             return await _context.Users.FindAsync(userId);
        }

        public Task<User> UpdateUserAsync(int userId, User user)
        {
            throw new NotImplementedException();
        }
    }
}