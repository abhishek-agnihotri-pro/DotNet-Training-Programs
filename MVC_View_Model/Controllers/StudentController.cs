using Microsoft.AspNetCore.Mvc;
using MVC_View_Model.Models;
using MVC_View_Model.ViewModel;

namespace MVC_View_Model.Controllers{
    public class StudentController : Controller
    {
        public ViewResult Details(){
            Student student = new Student(){
                StudentId = 1,
                Name = "Abhishek",
                Gender = "Male",
                Section = "A",
                Branch = "CSE"
            };
            Address address = new Address(){
                StudentId = 1,
                City = "Indore",
                State = "Madhya Pradesh",
                Country = "India",
                Pin = "452010"
            };
            StudentDetailViewModel studentDetails = new StudentDetailViewModel(){
                student = student,
                address = address,
                Title = "Top Rank Student",
                Header = "From the IT Branch"
            };
            return View(studentDetails);
        }
    }
}