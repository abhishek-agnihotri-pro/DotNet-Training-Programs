public class Car : Vehicle, IPrintable{
    public Car(){
        //Brand, Model, Color, SeatCapacity, Speed
        Name = "Fortuner";
        Color = "Black";
        Seeters = 7;
        Automatic = true;
    }
    public override void AvgSpeed()
    {
        base.VehicleDetails();
        Console.WriteLine("Runs at a Speed of 60 Km / hr");
    }

    public void Print(){
        Console.WriteLine($"Name : {Name}, Color : {Color}");
    }

    public void PrintDetials()
    {
        Console.WriteLine($"Seat Capacity : {Seeters}");
    }
}