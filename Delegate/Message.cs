class Message
{
    public string? Name { get; set; }
    public void AskQuestion(string question){
        Console.WriteLine($"{Name} {question}?");
    }
    public void Greet(string msg){
        Console.WriteLine($"{msg} !!! {Name}");
    }
}