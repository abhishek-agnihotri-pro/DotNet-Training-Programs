
delegate void Markdel();
class Student
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public int Marks { get; set; }
    public event Markdel ?Pass;
    public event Markdel ?Fail;

    public void EnterMarks(int marks){
        if(marks >= 50) Pass();
        else Fail();
    }
}