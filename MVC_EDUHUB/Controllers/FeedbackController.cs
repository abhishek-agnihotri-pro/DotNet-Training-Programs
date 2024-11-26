using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_EDUHUB.Models;

namespace MVC_EDUHUB.Controllers
{
    public class FeedbackController:Controller
    {
        private readonly IFeedbackService _feedbackservice;
        private readonly AppDbContext _context;

        public FeedbackController(IFeedbackService feedbackService,AppDbContext context)
        {
            _feedbackservice=feedbackService;
            _context=context;
        }

        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Feedback feedback){
            feedback.Date=DateTime.Now;
            _feedbackservice.AddFeedback(feedback);
            return RedirectToAction("List");
        }
        public IActionResult List(){
            var data= _context.FeedbackViewModels.FromSqlInterpolated($"dbo.SP_GetFeedbackByName");
            return View(data);
        }
    }   
}