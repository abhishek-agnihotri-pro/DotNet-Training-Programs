using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_EDUHUB.Models;

namespace MVC_EDUHUB.Controllers
{
    public class FeedbackController : Controller // Inheriting from Controller class to handle HTTP requests
    {
        private readonly IFeedbackService _feedbackservice; // Service for feedback operations
        private readonly AppDbContext _context; // Database context for accessing data

        // Constructor to initialize the FeedbackController with dependencies
        public FeedbackController(IFeedbackService feedbackService, AppDbContext context)
        {
            _feedbackservice = feedbackService; // Assigning feedback service to the private field
            _context = context; // Assigning database context to the private field
        }

        // GET: Create action to display feedback creation form
        public IActionResult Create()
        {
            return View(); // Returning the view for creating feedback
        }

        // POST: Create action to handle form submission for new feedback
        [HttpPost]
        public IActionResult Create(Feedback feedback)
        {
            feedback.Date = DateTime.Now; // Setting the current date and time for the feedback
            _feedbackservice.AddFeedback(feedback); // Adding feedback using the service
            return RedirectToAction("List"); // Redirecting to List action after creation
        }

        // GET: List action to display all feedback entries
        public IActionResult List()
        {
            var data = _context.FeedbackViewModels.FromSqlInterpolated($"dbo.SP_GetFeedbackByName"); // Fetching feedback data from a stored procedure
            return View(data); // Returning the view with fetched data
        }
    }   
}