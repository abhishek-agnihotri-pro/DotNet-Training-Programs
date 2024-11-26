using MVC_View_Model.Models;

namespace MVC_View_Model.ViewModel
{
    public class StudentDetailViewModel
    {
        public Student? student { get; set; }
        public Address? address { get; set; }
        public string? Title { get; set; }
        public string? Header { get; set; }
    }
}
