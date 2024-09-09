class Parrot: Bird
{
    public Parrot(){
        Name = "Lovely Parrot";
        Color = "green";
        Weight = 1;
        Flying = true;
    }
    public Parrot(string name, string color, int weight, bool fly) : base(name,color,weight,fly){
    }
    public override void Voice()
    {
        Console.WriteLine("Parrot making sound as Wow Wow Wow");
        base.BirdDetails();

    }
}