class Car : IPrint, IDisplay{

    public string? Brand { get; set; }
    public string? Model { get; set; }
    void IDisplay.Print(string text){
        Console.WriteLine($"Car with Display : {Brand} {Model} is {text}");
    }
    void IPrint.Print(string text){
        Console.WriteLine($"Car with Print : {Brand} {Model} is {text}");
    }

}