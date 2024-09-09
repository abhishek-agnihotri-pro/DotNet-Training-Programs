class Crow : Bird
{
    public Crow(){
        Name = "Little Crow";
        Color = "grey";
        Weight = 24;
        Flying = false;
    }
    public Crow(string name, string color, int weight, bool fly) : base(name,color,weight,fly){

    }
    public override void Voice(){
        Console.WriteLine("Sparrow making sound as Hooo Hooo Hooo");
        base.BirdDetails();
    }
}