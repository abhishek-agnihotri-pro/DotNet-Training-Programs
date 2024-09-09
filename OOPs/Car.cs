class Car
{
    public string Model { get; set; }
    public string Brand { get; set; }
    public string Color { get; set; }
    public int LaunchYear { get; set; }
    public static bool GearSystem { get; set; }

    static Car(){
        GearSystem = true;
    }

    public Car(){
        Brand = "Tata";
        Model = "Nexon";
        Color = "White";
        LaunchYear = 2018;
    }

    public override string ToString()
    {
        return $"Brand: {Brand}, Model: {Model}, Color: {Color}, LaunchYear: {LaunchYear}, GearSystem: {GearSystem}";
    }
}