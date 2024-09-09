public class Date
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    // public Date()
    // {
    //     Day = 15;
    //     Month = 8;
    //     Year = 1947;
    // }

    //Optional Parameter
    //Parameterised Constructor
    public Date(int day = 15, int month = 8, int year = 1947)
    {
        this.Day = day;
        this.Month = month;
        this.Year = year;
    }

    public override string ToString()
    {
        return $"{Day}-{Month}-{Year}";
    }
    public void Print(){
        Console.WriteLine($"Day : {Day}, Month : {Month}, Year : {Year}");
    }
}