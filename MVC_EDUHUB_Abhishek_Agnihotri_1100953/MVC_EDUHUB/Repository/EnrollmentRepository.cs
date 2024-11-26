using System.Collections.Generic;
using System.Linq;
using MVC_EDUHUB.Models;

namespace MVC_EDUHUB{
    public class EnrollmentRepository : IEnrollmentService
    {   
        private readonly AppDbContext _context;
        public EnrollmentRepository(AppDbContext context)
        {
            _context=context;
        }

        public void AddEnrollment(Enrollment enrollment)
        {
            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();
        }

        public Enrollment GetEnrollmentByid(int id){
            var data=_context.Enrollments.FirstOrDefault(x=>x.EnrollmentId==id);
            return data;
        }

        public List<Enrollment> GetEnrollmentsByUserid(int id)
        {   
           var data=_context.Enrollments.Where(x=>x.UserId==id).ToList();
            return data;
        }

        public void Update(int id, Enrollment enrollment)
        {
            var data=this.GetEnrollmentByid(id);
            data.Status=enrollment.Status;
            _context.Enrollments.Update(data);
            _context.SaveChanges();
        }
    }
}