class Cylinder : Circlee
{
    public int Height { get; set; }
    public Cylinder(int height = 100){
        Height = height;
    }
    public Cylinder(int x, int y, int radius, int height = 100) : base(x,y,radius)
    {
        Height = height;
    }
    public new void Area()
    {
        double A = 2* Math.PI * Radius * (Radius + Height);
        Console.WriteLine($"Surface Area of Cylinder = {A:f2}");
    }
    public override string ToString()
    {
        return $"Height of Cylinder : {Height} "+ base.ToString();
    }
}