using MVC_EDUHUB.Models;

namespace MVC_EDUHUB.Services
{
    public interface IStudentService
    {
        // public User CreateUser(User newUser);
        public User GetStudent(string email,string password);
    }
}