using MVC_EDUHUB.Models;

namespace MVC_EDUHUB.Services
{
    public interface IUserService
    {
        public User CreateUser(User newUser);
        public User GetEducator(string email, string password);
    }
}