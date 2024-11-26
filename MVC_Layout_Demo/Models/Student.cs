
using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Layout_Demo.Models{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOA { get; set; }
    }
}