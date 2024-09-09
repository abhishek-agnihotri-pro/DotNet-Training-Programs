
delegate void noonDelegate(string name);
class User
{
    public string? Name { get; set; }
    public event noonDelegate? Morning;
    public event noonDelegate? AfterNoon;
    public event noonDelegate? Evening;
    public event noonDelegate? Night;
    public void EnterTime(){
        Console.Write("Enter time (HH:mm): ");
        string? time = Console.ReadLine();
        string[] timeParts = time.Split(':');

        try{
            int hh = Convert.ToInt32(timeParts[0]);
            int mm = Convert.ToInt32(timeParts[1]);


            if (timeParts.Length != 2 ){
                Console.WriteLine("Invalid input. Please use the format HH:mm only.");
                return;
            }
            if (hh < 0 && hh > 23 && mm < 0 && mm >= 60){
                Console.WriteLine("Invalid time. Hours should be 0-23, minutes should be 0-59.");
                return;
            }
    
            if(hh >=6 && hh < 12){
                Morning(Name);
            }
            else if(hh >= 12 && hh <= 16){
                AfterNoon(Name);
            }
            else if(hh >= 16 && hh <= 20){
                Evening(Name);
            }
            else if(hh >= 20 && hh <= 24){
                Night(Name);
            }
            else
            {
                Console.WriteLine("Invalid time. Hours should be 0-23, minutes should be 0-59.");
            }
        }
        catch(FormatException ex){
            Console.WriteLine(ex.Message);
        }
    }

}
