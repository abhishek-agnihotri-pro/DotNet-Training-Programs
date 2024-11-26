using System.Collections.Generic;
using System.Linq;
using MVC_EDUHUB.Models;

namespace MVC_EDUHUB
{
    public class FeedbackRepository:IFeedbackService
    {   
        private readonly AppDbContext _context;

        public FeedbackRepository(AppDbContext context)
        {
            _context=context;
        }
        public void AddFeedback(Feedback feedback)
        {
            _context.Feedbacks.Add(feedback);
            _context.SaveChanges();
        }

        public List<Feedback> GetAllFeedbacks(){
            return _context.Feedbacks.ToList();
        }
    }
}