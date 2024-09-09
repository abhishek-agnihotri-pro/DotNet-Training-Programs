enum Set_Color{
    RED, BLUE, WHITE, YELLOW, ORANGE, PINK
}
abstract class Shape 
{
    public Set_Color Color { get; set; }
    public double Area { get; set; }
    public string? Description { get; set; }

    public Shape(){
        Color = Set_Color.PINK;
        Description = "It is Big Shape with lot of Area";
    }
    public Shape(Set_Color color, string? description){
        Color = color;
        Description = description;
    }
    public abstract double CalculateArea();
    public override string ToString()
    {
        // Calulated Area : {CalculateArea():f2},
        return $"Color : {Color},  Description : {Description}";
    }    
}