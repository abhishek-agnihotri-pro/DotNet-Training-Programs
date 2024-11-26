using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_EDUHUB.Models;

namespace MVC_EDUHUB.Controllers
{
    // Controller responsible for handling enrollment-related actions
    public class EnrollmentController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IEnrollmentService _enrollmentservice;

        // Constructor with dependency injection
        public EnrollmentController(AppDbContext context, IEnrollmentService enrollmentService)
        {
            _context = context;
            _enrollmentservice = enrollmentService;
        }

        // Action to display pending enrollments
        public IActionResult PendingList()
        {
            int id = Convert.ToInt32(TempData["UserId"]);
            TempData.Keep("UserId");
            // Fetch pending enrollments using a stored procedure
            var data1 = _context.EnrollmentViewModels.FromSqlInterpolated($"dbo.SP_GetEnrollmentByName {id}");
            return View(data1);
        }

        // Action to display accepted enrollments
        public IActionResult AcceptedList()
        {
            int id = Convert.ToInt32(TempData["UserId"]);
            TempData.Keep("UserId");
            TempData.Keep("Educator");
            TempData.Keep("Role");
            // Fetch accepted enrollments using a stored procedure
            var data1 = _context.EnrollmentViewModels.FromSqlInterpolated($"dbo.GetAcceptedEnrollmentByName {id}");
            return View(data1);
        }

        // Action to accept an enrollment
        public IActionResult AcceptEnrollment(int id)
        {
            var enrollment = _context.Enrollments.FirstOrDefault(x => x.EnrollmentId == id);
            enrollment.Status = "Accepted";
            _context.SaveChanges();
            return RedirectToAction("PendingList");
        }

        // Action to reject an enrollment
        public IActionResult RejectEnrollment(int id)
        {
            var enrollment = _context.Enrollments.FirstOrDefault(x => x.EnrollmentId == id);
            enrollment.Status = "Rejected";
            _context.SaveChanges();
            return RedirectToAction("PendingList");
        }

        // Action to display the edit form for an enrollment
        public IActionResult Edit(int id)
        {
            // Create a list of enrollment status options
            List<SelectListItem> EnrollmentStatus = new List<SelectListItem>(){
                new SelectListItem{Text="Pending",Value="Pending"},
                new SelectListItem{Text="Accepted",Value="Accepted"}
            };
            ViewBag.EStatus = EnrollmentStatus;
            var data = _enrollmentservice.GetEnrollmentByid(id);
            return View(data);
        }

        // Action to handle the POST request for editing an enrollment
        [HttpPost]
        public IActionResult Edit(int id, Enrollment enrollment)
        {
            _enrollmentservice.Update(id, enrollment);
            return RedirectToAction("PendingList", new { id = TempData["Userid"] });
        }

        // Action to display enrollments for a specific student
        public IActionResult MyEnrollments(int id)
        {
            // Fetch student enrollments using a stored procedure
            var data = _context.StudentEnrollmentViewModels.FromSqlInterpolated($"dbo.SP_GetStudentEnrollmentById {id}");
            return View(data);
        }

        // Action to display the create form for a new enrollment
        public IActionResult Create()
        {
            // Create a list of courses for the dropdown
            var courselist = _context.Courses.Select(c => new SelectListItem
            {
                Text = c.title,
                Value = c.courseId.ToString()
            });
            ViewBag.CourseList = courselist;
            TempData.Keep("UserId");
            TempData.Keep("Role");
            return View();
        }

        // Action to handle the POST request for creating a new enrollment
        [HttpPost]
        public IActionResult Create(Enrollment enrollment)
        {
            enrollment.Status = "Pending";
            enrollment.EnrollmentDate = DateTime.Now;
            _enrollmentservice.AddEnrollment(enrollment);
            return RedirectToAction("MyEnrollments", new { id = enrollment.UserId });
        }

        // Action to display the delete confirmation for an enrollment
        public IActionResult Delete(int id)
        {
            var data = _enrollmentservice.GetEnrollmentByid(id);
            return View();
        }
    }
}