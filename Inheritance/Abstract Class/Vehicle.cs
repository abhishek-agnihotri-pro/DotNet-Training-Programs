abstract public class Vehicle
{
    public int Seeters { get; set; }
    public string? Color { get; set; }
    public string? Name { get; set; }
    public bool Automatic { get; set; }
    public Vehicle(){
        
    }

    public Vehicle(string name, string color, int seeters, bool automatic){
        Name = name;
        Color = color;
        Seeters = seeters;
        Automatic = automatic;
    }
    public abstract void AvgSpeed();
    public virtual void VehicleDetails(){
        Console.WriteLine($"Name : {Name}, Color : {Color}, Seeters : {Seeters}, Automatic : {Automatic}");
    }
}