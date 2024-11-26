using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Code_First_Approach_EF.Models{
    public class User{
        public int UserID { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage ="FirstName is a must")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage ="LastName is a must")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Enter valid email format")]
        public string Email { get; set; }
        [Range(minimum:18,maximum:60,ErrorMessage ="Age must be between 18 and 60")]
        public int Age { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password must be same")]
        public string ConfirmPassword { get; set; }
        [Phone(ErrorMessage ="Enter valid format of phone")]
        public string PhoneNumber { get; set; }
        [DataType(DataType.Url,ErrorMessage ="Enter correct url Address")]
        public string URL { get; set; }
    }
}