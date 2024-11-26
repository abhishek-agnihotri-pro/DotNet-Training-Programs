using MVC_EDUHUB.Models;
using MVC_EDUHUB.Services;

namespace MVC_EDUHUB.Repository
{
    public class CourseRepository : ICourseService
    {
        private readonly AppDbContext _context;
        public CourseRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Course> ViewAllCourses(){
            var data =  _context.Courses.ToList();
            return data;
        }
        public List<Course> ViewMyCourses(int id){
            Console.WriteLine(id);
            var data = _context.Courses.Where(c => c.userId == id).ToList();
            return data;
        }
    }
}