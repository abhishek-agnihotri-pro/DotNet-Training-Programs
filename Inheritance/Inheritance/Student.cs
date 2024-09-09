using System.Runtime.Serialization;

class Student:IComparable
{
    public int RollNo { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Student(){
        RollNo = 0701;
        FirstName = "Abhishek";
        LastName = "Agnihotri";
    }
    public Student(int rollno, string firstName, string lastName)
    {
        RollNo = rollno;
        FirstName = firstName;
        LastName = lastName;
    }
    public override string ToString()
    {
        return $"Name : {FirstName} {LastName}, Roll NO : {RollNo}";
    }

    public int CompareTo(object? obj)
    {
        // On the basis of roll number
        Student stu = obj as Student;
        // if(this.RollNo < stu.RollNo)
        //     return -1;
        // else return 1;

        // on the basis of firstName
        return String.Compare(this.FirstName,stu.FirstName);
    }
}