abstract class Bird
{
    public int Weight { get; set; }
    public string? Color { get; set; }
    public string? Name { get; set; }
    public bool Flying { get; set; }

    public Bird(){
        
    }

    public Bird(string name, string color, int weight, bool fly){
        Name = name;
        Color = color;
        Weight = weight;
        Flying = fly;
    }
    public abstract void Voice();


    public virtual void BirdDetails(){
        Console.WriteLine($"Name : {Name}, Color : {Color}, Weight : {Weight}, Flying : {Flying}");
    }

}