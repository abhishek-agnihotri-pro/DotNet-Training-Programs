class Sparrow : Bird
{
    public Sparrow(){
        Name = "Little Sparrow";
        Color = "grey";
        Weight = 24;
        Flying = false;
    }
    public Sparrow(string name, string color, int weight, bool fly) : base(name,color,weight,fly){

    }
    public override void Voice(){
        Console.WriteLine("Sparrow making sound as Howw Howw Howw");
        base.BirdDetails();
    }
}