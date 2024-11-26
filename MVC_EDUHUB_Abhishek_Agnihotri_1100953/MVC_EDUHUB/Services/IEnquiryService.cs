using System.Collections;
using System.Collections.Generic;
using MVC_EDUHUB.Models;

namespace MVC_EDUHUB{
    public interface IEnquiryService
    {
        void AddEnquiry(Enquiry enquiry);

        // void Update(int id,Enquiry enquiry);

        void UpdateResponse(int id,Enquiry enquiry);
        void Update(int id,Enquiry enquiry);
        List<Enquiry> GetEnquiriesByCourseId(int id);
        List<Enquiry> GetEnquiryByUserId(int id);
        Enquiry GetEnquiryByEnquiryId(int id);
    }
}