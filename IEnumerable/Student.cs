class Student
{
    public int ID { get; set; }
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"Student ID : {ID}, Name : {Name}";
    }

    public override bool Equals(object? obj)
    {
        Student? student = obj as Student;
        if(student == null ) return false;
        if((student.Name == Name) && (student.ID == ID) ){
            return true;
        }
        else return false;
    }
}