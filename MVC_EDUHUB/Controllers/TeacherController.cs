using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MVC_EDUHUB.Models;
using MVC_EDUHUB.Services;
using MVC_EDUHUB.ViewModel;

namespace MVC_EDUHUB.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IEducatorService _educatorservice;
        private readonly ICourseService _courseservice;
        private readonly ILogger<EducatorController> _logger;

        public TeacherController(ICourseService courseservice, ILogger<EducatorController> logger,AppDbContext context)
        {
            _context =context;
            _logger = logger;
            _courseservice = courseservice;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewAllCourses()
        {
            // _logger.LogWarning(TempData["UserId"].ToString());
            var data = _courseservice.ViewAllCourses();
            if(Convert.ToString(TempData["Role"]) == "Student"){
            ViewBag.UserRole =  "Student";
            }
            else ViewBag.UserRole = "Educator";
            TempData.Keep("Role");
            return View(data);
        }
        public IActionResult ViewMyCourses()
        {
            // _logger.LogWarning(TempData["UserId"].ToString());
            // if (TempData.TryGetValue("UserId",out object userid))
            // {
                int id=Convert.ToInt32(TempData["UserId"]);
                // var data = _courseservice.ViewMyCourses(id);
                var data = _context.MyCourseViewModels.FromSqlInterpolated($"dbo.SP_MyCourseViewModel {id}");
                TempData.Keep("UserId");
                TempData.Keep("Educator");
                TempData.Keep("Role");
                return View(data);
            // }
            
        }
        public IActionResult ViewEnrolledStudents(){
            var enrollments = _context.Enrollments.ToArray();
            List<Enrollment> enrolledStudent = new List<Enrollment>();
            var courses = _context.Courses.ToArray();
            for (int i = 0; i < enrollments.Length; i++)
            {
                int courseId = enrollments[i].CourseId;
                for(int j = 0 ; j < courses.Length ; j++){
                    if(courseId == courses[j].courseId && courses[j].userId == Convert.ToInt32(TempData["UserId"])){
                        enrolledStudent.Add(enrollments[i]);
                    }
                }
            }
            return View(enrolledStudent);
        }
        public IActionResult Create()
        {
            List<SelectListItem> level = new List<SelectListItem>(){
                new SelectListItem{Text="Beginner",Value="Beginner"},
                new SelectListItem{Text="Intermediate",Value="Intermediate"},
                new SelectListItem{Text="Advanced",Value="Advanced"}
            };
            List<SelectListItem> category = new List<SelectListItem>(){
                new SelectListItem{Text="Programming",Value="Programming"},
                new SelectListItem{Text="Data Science",Value="Data Science"},
                new SelectListItem{Text="Web Development",Value="Web Development"},
                new SelectListItem{Text="Computer Science",Value="Computer Science"},
                new SelectListItem{Text="Marketing",Value="Marketing"},
                new SelectListItem{Text="Ethics",Value="Ethics"},
                new SelectListItem{Text="Mobile Development",Value="Mobile Development"},
                new SelectListItem{Text="Cybersecurity",Value="Cybersecurity"},
                new SelectListItem{Text="Cloud Computing",Value="Cloud Computing"},
                new SelectListItem{Text="Blockchain",Value="Blockchain"},
            };
            ViewBag.level = level;
            ViewBag.category = category;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                course.userId = Convert.ToInt32(TempData["UserId"]);
                _context.Courses.Add(course);
                _context.SaveChanges();
                return RedirectToAction("ViewMyCourses");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            if (id == 0) return View();
            else
            {
                var data = _context.Courses.FirstOrDefault(y => y.courseId == id);
                return View(data);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0){
                return View();
            } 
            else
            {
                var data = _context.Courses.FirstOrDefault(x=>x.courseId==id);
                if (data == null) {
                    return NotFound();
            }
            return View(data);
            }
            }
                     
        [HttpPost]
        public IActionResult Edit(int id, Course modified)
        {
            var data = _context.Courses.FirstOrDefault(y => y.courseId == id);
            if (data == null)
            {
                return NotFound();
            }
            data.title = modified.title;
            data.description = modified.description;
            data.courseStartDate = modified.courseStartDate;
            data.courseEndDate = modified.courseEndDate;
            data.category = modified.category;
            data.level = modified.level;

            _context.SaveChanges();
            return RedirectToAction(nameof(ViewMyCourses));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.Courses.FirstOrDefault(y => y.courseId == id);
            if (data == null) return NotFound();
            else
            {
                _context.Courses.Remove(data);
                _context.SaveChanges();
                return RedirectToAction("ViewMyCourses");
            }
        }
    }
}