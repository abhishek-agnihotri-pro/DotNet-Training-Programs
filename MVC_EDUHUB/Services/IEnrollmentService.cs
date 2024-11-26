using System.Collections.Generic;
using MVC_EDUHUB.Models;

namespace MVC_EDUHUB
{
    public interface IEnrollmentService
    {
        void Update(int id,Enrollment enrollment);

        Enrollment GetEnrollmentByid(int id);

        void AddEnrollment(Enrollment enrollment);

        List<Enrollment> GetEnrollmentsByUserid(int id);
    }
}