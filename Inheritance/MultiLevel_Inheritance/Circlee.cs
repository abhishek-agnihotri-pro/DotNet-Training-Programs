class Circlee : Point
{
    public int Radius { get; set; }
    public Circlee(int radius = 10){ 
        Radius = radius;
    }
    public Circlee(int x, int y, int radius = 10) : base(x,y)
    { 
        Radius = radius;
    }
    public override string ToString()
    {
        return $"Radius of Circle = {Radius} "+ base.ToString();
    }
    public virtual void Area(){
        double A = Math.PI*Radius*Radius;
        Console.WriteLine($"Area = {A:f2} sq m");
    }
}