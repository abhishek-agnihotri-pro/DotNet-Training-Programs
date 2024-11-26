using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_EDUHUB.Models;

namespace MVC_EDUHUB.Controllers
{
    public class EnquiryController : Controller
    {
        // Fields for enquiry service and database context
        private readonly IEnquiryService _enquiryService;
        private readonly AppDbContext _context;

        // Constructor to initialize dependencies
        public EnquiryController(IEnquiryService enquiryService, AppDbContext context)
        {
            _enquiryService = enquiryService; // Assign enquiry service
            _context = context; // Assign database context
        }

        // Action method to get enquiries by course ID
        public IActionResult GetEnquiries(int id)
        {
            // Retrieve enquiries using stored procedure by course ID
            var data = _context.MyEnquiryViewModels.FromSqlInterpolated($"dbo.SP_GetEnquiryByNamesEducator {id}");
            return View(data); // Return view with the enquiry data
        }

        // Action method to edit an enquiry
        public IActionResult Edit(int id)
        {
            // Create a list of status options for the enquiry
            List<SelectListItem> Status = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Open Again", Value = "Open" },
                new SelectListItem { Text = "In Progress", Value = "In Progress" },
                new SelectListItem { Text = "Closed", Value = "Closed" }
            };
            ViewBag.status = Status; // Pass status options to the view

            // Retrieve the enquiry by its ID
            var data = _enquiryService.GetEnquiryByEnquiryId(id);
            return View(data); // Return view with the enquiry data
        }

        // POST action method to update an enquiry
        [HttpPost]
        public IActionResult Edit(int id, Enquiry enquiry)
        {
            _enquiryService.Update(id, enquiry); // Update the enquiry in the service
            return RedirectToAction("GetEnquiries", new { id = enquiry.CourseId }); // Redirect to enquiries list
        }

        // Action method to view details of a specific enquiry
        public IActionResult Details(int id)
        {
            var data = _enquiryService.GetEnquiryByEnquiryId(id); // Retrieve enquiry details
            return View(data); // Return view with the enquiry details
        }

        public IActionResult Delete(int id)
        {
            var data = _context.Enquiries.FirstOrDefault(e => e.EnquiryId == id);
            int idd = data.CourseId;
            _context.Enquiries.Remove(data);
            return RedirectToAction("GetEnquiries", new { id = idd});
        }

        // Action method to create a new enquiry
        public IActionResult Create()
        {
            // Retrieve list of courses to populate dropdown
            var courselist = _context.Courses.Select(c => new SelectListItem
            {
                Text = c.title, // Course title
                Value = c.courseId.ToString() // Course ID
            });
            ViewBag.CourseList = courselist; // Pass course list to the view
            return View(); // Return view for creating a new enquiry
        }

        // POST action method to save a new enquiry
        [HttpPost]
        public IActionResult Create(Enquiry enquiry)
        {
            enquiry.CourseId = Convert.ToInt32(enquiry.CourseId); // Ensure CourseId is an integer
            enquiry.EnquiryDate = DateTime.Now; // Set the current date as the enquiry date
            enquiry.Status = "Open"; 
            _enquiryService.AddEnquiry(enquiry); // Add the enquiry using the service

            // Redirect to the user's enquiries list
            return RedirectToAction("MyEnquiries", "Enquiry", new { id = enquiry.UserId });
        }

        // Action method to get enquiries made by a specific user
        public IActionResult MyEnquiries(int id)
        {
            // Retrieve enquiries using stored procedure by user ID
            var data = _context.MyEnquiryViewModels.FromSqlInterpolated($"dbo.SP_GetEnquiryByCourseNameStudent {id}");
            return View(data); // Return view with the user's enquiry data
        }
    }
}