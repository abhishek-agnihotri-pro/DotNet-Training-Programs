class Rectangle  : Shape
{

    public double Length { get; set; }
    public double Breadth { get; set; }
    public Rectangle(){
        Length = 4;
        Breadth = 8;
    }
    public Rectangle(double length,double breadth, Set_Color color, string? description):base(color, description){
        Length = length;
        Breadth = breadth;
    }


    public override double CalculateArea()
    {
        return Length*Breadth;
    }

    public override string ToString()
    {
        return $"Rectangle with Length : {Length} and Breadth : {Breadth} is {CalculateArea()}, " + base.ToString();
    }
}