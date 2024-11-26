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
        private readonly IEnquiryService _enquiryService;
        private readonly AppDbContext _context;

        public EnquiryController(IEnquiryService enquiryService, AppDbContext context)
        {
            _enquiryService = enquiryService;
            _context = context;
        }

        public IActionResult GetEnquiries(int id)
        {
            // var data = _enquiryService.GetEnquiriesByCourseId(id);
            var data = _context.MyEnquiryViewModels.FromSqlInterpolated($"dbo.SP_GetEnquiryByNamesEducator {id}");
            return View(data);
        }

        public IActionResult Edit(int id)
        {
            List<SelectListItem> Status = new List<SelectListItem>(){
                new SelectListItem{Text="Open Again",Value="Open"},
                new SelectListItem{Text="In Progress",Value="In Progress"},
                new SelectListItem{Text="Closed",Value="Closed"}
            };
            ViewBag.status = Status;
            var data = _enquiryService.GetEnquiryByEnquiryId(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(int id, Enquiry enquiry)
        {
            _enquiryService.Update(id, enquiry);
            return RedirectToAction("GetEnquiries", new { id = enquiry.CourseId });
        }

        public IActionResult Details(int id)
        {
            var data = _enquiryService.GetEnquiryByEnquiryId(id);
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
            return View();

        }

        [HttpPost]
        public IActionResult Create(Enquiry enquiry)
        {
            enquiry.CourseId = Convert.ToInt32(enquiry.CourseId);
            enquiry.EnquiryDate = DateTime.Now;
            _enquiryService.AddEnquiry(enquiry);

            return RedirectToAction("MyEnquiries", "Enquiry", new { id = enquiry.UserId });
        }

        public IActionResult MyEnquiries(int id)
        {
            // var data = _enquiryService.GetEnquiryByUserId(id);
            var data = _context.MyEnquiryViewModels.FromSqlInterpolated($"dbo.SP_GetEnquiryByCourseNameStudent {id}");
            return View(data);
        }
    }
}