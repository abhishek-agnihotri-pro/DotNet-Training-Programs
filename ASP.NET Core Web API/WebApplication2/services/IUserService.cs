using WebApplication2.Models;

namespace WebApplication2.services
{
    public interface IUserService{
        Task<User> GetUserAsync(int userId);
        Task<IEnumerable<User>> GetAllStudentAsync();
        Task<User> CreateUserAsync(User user);
        Task<User> UpdateUserAsync(int userId, User user);
        Task<User> DeleteUserAsync(int userId);
        

    }
}