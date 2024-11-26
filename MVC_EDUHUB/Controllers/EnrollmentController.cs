using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_EDUHUB.Models;

namespace MVC_EDUHUB.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly AppDbContext _context;

        private readonly IEnrollmentService _enrollmentservice;
        public EnrollmentController(AppDbContext context, IEnrollmentService enrollmentService)
        {
            _context = context;
            _enrollmentservice = enrollmentService;
        }

        public IActionResult PendingList()
        {
            int id = Convert.ToInt32(TempData["UserId"]);
            TempData.Keep("UserId");
            // int id = 19;
            var data1 =_context.EnrollmentViewModels.FromSqlInterpolated($"dbo.SP_GetEnrollmentByName {id}");
            return View(data1);
        }

        public IActionResult AcceptedList()
        {
            int id = Convert.ToInt32(TempData["UserId"]);
            TempData.Keep("UserId");
            TempData.Keep("Educator");
            TempData.Keep("Role");
            var data1 =_context.EnrollmentViewModels.FromSqlInterpolated($"dbo.GetAcceptedEnrollmentByName {id}");
            return View(data1);
        }

        public IActionResult AcceptEnrollment(int id)
        {
            var enrollment = _context.Enrollments.FirstOrDefault(x=> x.EnrollmentId == id);
            enrollment.Status = "Accepted";
            _context.SaveChanges();
            return RedirectToAction("PendingList");
        }
        public IActionResult RejectEnrollment(int id)
        {
            var enrollment = _context.Enrollments.FirstOrDefault(x=> x.EnrollmentId == id);
            enrollment.Status = "Rejected";
            _context.SaveChanges();
            return RedirectToAction("PendingList");
        }
        public IActionResult Edit(int id)
        {
            List<SelectListItem> EnrollmentStatus = new List<SelectListItem>(){
                new SelectListItem{Text="Pending",Value="Pending"},
                new SelectListItem{Text="Accepted",Value="Accepted"}
            };
            ViewBag.EStatus = EnrollmentStatus;
            var data = _enrollmentservice.GetEnrollmentByid(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(int id, Enrollment enrollment)
        {
            _enrollmentservice.Update(id, enrollment);
            return RedirectToAction("PendingList", new { id = TempData["Userid"] });
        }

        public IActionResult MyEnrollments(int id)
        {
            var data = _context.StudentEnrollmentViewModels.FromSqlInterpolated($"dbo.SP_GetStudentEnrollmentById {id}");
            // var courseids = data.Select(c => c.CourseId).ToList();
            // var coursenames = _context.Courses.Where(c => courseids.Contains(c.courseId)).Select(c => c.title).ToList();
            // ViewBag.CourseNames = coursenames;
            return View(data);
        }
        public IActionResult Create()
        {
            var courselist = _context.Courses.Select(c => new SelectListItem
            {
                Text = c.title,
                Value = c.courseId.ToString()
            });
            ViewBag.CourseList = courselist;
            TempData.Keep("UserId");
            // TempData.Keep("Educator");
            TempData.Keep("Role");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Enrollment enrollment)
        {
            enrollment.Status = "Pending";
            enrollment.EnrollmentDate = DateTime.Now;
            _enrollmentservice.AddEnrollment(enrollment);
            return RedirectToAction("MyEnrollments", new { id = enrollment.UserId });
        }

        public IActionResult Delete(int id)
        {
            var data = _enrollmentservice.GetEnrollmentByid(id);
            return View();
        }
    }
}