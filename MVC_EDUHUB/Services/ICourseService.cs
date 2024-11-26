using MVC_EDUHUB.Models;

namespace MVC_EDUHUB.Services
{
    public interface ICourseService
    {
        public List<Course> ViewAllCourses();
        public List<Course> ViewMyCourses(int id);
        // public User GetEducator(string email, string password);
    }
}