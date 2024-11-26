using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using MVC_EDUHUB.Models;

namespace MVC_EDUHUB
{
    public class EnquiryRepository : IEnquiryService
    {
         private readonly AppDbContext _context;

        public EnquiryRepository(AppDbContext context)
        {
            _context=context;
        } 
        public void AddEnquiry(Enquiry enquiry)
        {
            _context.Enquiries.Add(enquiry);
            _context.SaveChanges();

        }
        
        public Enquiry GetEnquiryByEnquiryId(int id){
            var data=_context.Enquiries.FirstOrDefault(x=>x.EnquiryId==id);
            return data;
        }

        public List<Enquiry> GetEnquiriesByCourseId(int id){
            var data=_context.Enquiries.Where(x=>x.CourseId==id).ToList();
            return data;
        }
       
       public void UpdateResponse(int id,Enquiry enquiry){
            var data=this.GetEnquiryByEnquiryId(id);
            data.Response=enquiry.Response;
            _context.Enquiries.Update(data);
            _context.SaveChanges();
       }

       public void Update(int id,Enquiry enquiry){
            var data=this.GetEnquiryByEnquiryId(id);
            data.Status=enquiry.Status;
            data.Response=enquiry.Response;
            _context.Enquiries.Update(data);
            _context.SaveChanges();
       }

       public List<Enquiry> GetEnquiryByUserId(int id){
            var data=_context.Enquiries.Where(x=>x.UserId==id);
            return data.ToList();
       }
    }
}