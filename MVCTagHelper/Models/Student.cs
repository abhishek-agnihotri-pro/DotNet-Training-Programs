using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace MVCTagHelper.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Branch Branch { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public IEnumerable<Gender> AllGenders { get; set; }
    }
    public enum Branch
    {
        None,
        CSE,
        ETC,
        Mech
    }
    public enum Gender
    {
        Male,
        Female,
        Transgender
    }
}