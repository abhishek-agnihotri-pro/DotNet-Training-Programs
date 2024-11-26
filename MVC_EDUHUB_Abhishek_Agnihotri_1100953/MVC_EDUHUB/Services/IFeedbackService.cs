using System.Collections.Generic;
using MVC_EDUHUB.Models;

namespace MVC_EDUHUB
{
    public interface IFeedbackService
    {
        List<Feedback> GetAllFeedbacks();

        void AddFeedback(Feedback feedback);
    }
}