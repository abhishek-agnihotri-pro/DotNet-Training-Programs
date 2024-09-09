class Program
{
    public static void Main(string[] args){
        Console.WriteLine("EduHub ready");
        Course c = new Course(12,"Dotnet trainng","abs",new DateTime(2010,04,12),new DateTime(2010,04,12), 1212,"Dev","Beginner");
        Console.WriteLine(c);
    }
}