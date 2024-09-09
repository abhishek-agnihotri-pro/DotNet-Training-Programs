using System.Text;


class MyCustomException : ApplicationException{
    public MyCustomException(string msg) : base(msg){

    }
}
class Program
{
    public static void Main(string[] args){
        // int a, b, c;
        // try{
        //     Console.WriteLine("Enter 2 number : ");
        //     a = Convert.ToInt32(Console.ReadLine());
        //     b = Convert.ToInt32(Console.ReadLine());
        //     c = a / b;
        //     Console.WriteLine($"{a}+{b}= {c}");
        // }
        // catch(FormatException ex){
        //     Console.WriteLine(ex.Message);
        // }
        // catch(OverflowException ex){
        //     Console.WriteLine("Over Flow Exception Called");
        //     Console.WriteLine(ex);
        // }
        // catch(ArithmeticException ex){

        //     Console.WriteLine("Exception Message : "+ ex.Message);
        //     Console.WriteLine("Exception StackTrace :"+ ex.StackTrace);
        //     Console.WriteLine("Exception TargetSite : "+ ex.TargetSite);
        //     Console.WriteLine("Exception HelpLink : "+ ex.HelpLink);
        //     // Console.WriteLine(ex);
        // }
        // catch(Exception ex){
        //     Console.WriteLine(ex);

        // }
        // try{
        //     // f1();
        //     string ?name = Console.ReadLine();
        //     if(name != "Yash"){
        //         throw new Exception("Invalid Name entered");
        //     }
        // }
        // catch(Exception ex){
        //     Console.WriteLine("Exception Message : "+ ex.Message);
        //     Console.WriteLine("Exception StackTrace :"+ ex.StackTrace);
        //     Console.WriteLine("Exception TargetSite : "+ ex.TargetSite);
        //     // Console.WriteLine(ex);
        // }
        // finally{
        //     Console.WriteLine("Running Clean Up code");
        // }

        try{
            Console.WriteLine("Enter Ticket Number : ");
            int ticketNumber = Convert.ToInt32(Console.ReadLine());
            if(ticketNumber > 50)
                throw new MyCustomException("Ticket is not available");

        }
        catch(MyCustomException ex){
            Console.WriteLine(ex);
        }
        

    }

    public static void f1(){
        f2();
    }
    public static void f2(){
        f3();
    }
    public static void f3(){
        int a, b, c;
            Console.WriteLine("Enter 2 number : ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a / b;
            Console.WriteLine($"{a}+{b}= {c}");
    }

    }