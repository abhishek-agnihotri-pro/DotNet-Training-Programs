namespace ClassLibrary;

public class Student
{
    public int ID { get; set; }
    public string? Name { get; set; }
    
    public int Add(int a,int b){
        return a+b;
    }
    public int Sub(int a,int b){
        return a-b;
    }
    public int Mutliply(int a,int b){
        return a*b;
    }
}
