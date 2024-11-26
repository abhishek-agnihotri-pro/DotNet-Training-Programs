

using System.Collections.Generic;
using System.Linq;
using MVCinMemoryCRUD.Models;

namespace MVCinMemoryCRUD.Service
{
    public static class StudentService
    {
        public static List<Student> students;
        public static int nextID = 106;
        static StudentService()
        {
            students = new List<Student>(){
                new Student(){Id = 0, Name = "ZeroCh",Marks = 96},
                new Student(){Id = 101, Name = "Billl",Marks = 34},
                new Student(){Id = 102, Name = "Mill",Marks = 34},
                new Student(){Id = 103, Name = "Jill",Marks = 34},
                new Student(){Id = 104, Name = "Sill",Marks = 34},
                new Student(){Id = 105, Name = "Gilll",Marks = 34},
            };
        }
        public static List<Student> GetAll()
        {
            return students;
        }
        public static Student GetStudentById(int id)
        {
            var data = students.FirstOrDefault(x => x.Id == id);
            return data;
        }
        public static void Add(Student newStudent)
        {
            newStudent.Id = nextID++;
            students.Add(newStudent);
        }
        public static void Update(Student modifiedStudent)
        {
            int index = students.FindIndex(m => m.Id == modifiedStudent.Id);
            if (index == -1) return;
            else students[index] = modifiedStudent;
        }
        public static void Delete(int id)
        {
            var data = students.FirstOrDefault(s => s.Id == id);
            if (data == null) return;
            else students.Remove(data);
        }
    }
}