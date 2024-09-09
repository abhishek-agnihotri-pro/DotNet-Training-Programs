class Circle  : Shape
{

    public double Radius { get; set; }
    public Circle(){
        Radius = 2;
    }
    public Circle(double radius,Set_Color color, string? description):base(color, description){
        Radius = radius;
    }


    public override double CalculateArea()
    {
        return Math.PI* Radius * Radius;
    }

    public override string ToString()
    {
        return $"Area of Circle with Radius : {Radius} is {CalculateArea():f2}, " + base.ToString();
    }
}