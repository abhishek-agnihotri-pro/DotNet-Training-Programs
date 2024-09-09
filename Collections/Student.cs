class Student : IComparable
{
    public int RollNo { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Marks { get; set; }
    public static List<Student> Students { get; set; }

    // public Date AdmissionDate { get; set; }

    // public Student(int id, string firstName, string lastName, Date admissionDate, int marks)
    static Student(){
        Students = new List<Student>();
    }
    public Student(int rollNo, string firstName, string lastName, int marks)
    {
        RollNo = rollNo;
        FirstName = firstName;
        LastName = lastName;
        // this.AdmissionDate = admissionDate;
        Marks = marks;
    }

    public static void AddEmployee(){
        Console.WriteLine("Please Enter Student Details in the foramt : RollNo FirstName LastName Marks");
        Console.WriteLine("or Enter 0 to stop Adding Student.");
        // List<Employee> list = new List<Employee>();
        while(true){
            string? inputStr = Console.ReadLine();
            if(inputStr == null || inputStr.Length <= 2){
                break;
            }
            string[] strlist = inputStr.Split(" ", 4, StringSplitOptions.RemoveEmptyEntries);
            // Console.WriteLine(strlist[0] + strlist[1] + strlist[2] + strlist[3]);
            Students.Add(new Student(Convert.ToInt32(strlist[0]),strlist[1],strlist[2], Convert.ToInt32(strlist[3])));
        }
    }

    public static void RemoveEmployee(){
        Console.WriteLine("Please Enter Student RollNo to remove : ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach(Student student in Students){
            if(student.RollNo == id){
                Students.Remove(student);
                break;
            }
        }
        Console.WriteLine("Student does not exist");
        Console.WriteLine("");
    }

    public static void DisplayAll(){
        foreach(Student student in Students){
            Console.WriteLine(student);
        }
        Console.WriteLine("");

    }

 

    public override string ToString()
    {
        return $"Student RollNo : {RollNo}, FirstName : {FirstName}, LastName : {LastName}, Marks : {Marks}";
        // return $"Student ID : {ID}, FirstName : {FirstName}, LastName : {LastName}, Admission Date: {AdmissionDate}, Marks : {Marks}";
    }

    public int CompareTo(object? obj)
    {
        Student? s = obj as Student;
        if(s == null) return -1;
        if(this.RollNo > s.RollNo){
            return 1;
        }
        else return -1;
        // for string comparision , can user String.Compare(a,b)
    }
}