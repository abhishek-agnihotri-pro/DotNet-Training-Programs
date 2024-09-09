namespace Newclassli>b;


public class Class1
{
    public DateTime date;
    public Class1 () {
        date = DateTime.Now;
    }

    public void LongDate(){
        Console.WriteLine(date.ToLongDateString());
    }

}