class Batch
{
    List<Student> StudentList;

    public Batch(){
        StudentList = new List<Student>();
        StudentList.Add(new Student(){id = 101, name = "Abhishek", gender = "Female"});
        StudentList.Add(new Student(){id = 102, name = "XYZ", gender = "Female"});
        StudentList.Add(new Student(){id = 103, name = "PQR", gender = "Male"});
        StudentList.Add(new Student(){id = 104, name = "FGH", gender = "Female"});
    }
    
    public string this[int Id]{
        // x=>x.value lamda expression
        get{
            return StudentList.FirstOrDefault(x => x.id == Id).name;
        }
        set{
            StudentList.FirstOrDefault(x => x.id == Id).name = value;
        }
    }
    public int this[string str]{
        // x=>x.value lamda expression
        get{
            return StudentList.FirstOrDefault(x => x.name.ToLower() == str.ToLower()).id;
        }

    }
}