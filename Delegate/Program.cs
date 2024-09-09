using System.Reflection;

class Program
{
    //step1 declaration of delegate
    delegate string delegateForHelloWorld();
    delegate string delegateForBestWishes(string text);
    delegate int delegateForSum(int a, int b);
    delegate void arithmeticDel(int a,int b);
    delegate void delegateForArea(double a,double b);

    delegate void mathDel(int a,int b);

    delegate void delegateForClassMethod(string txt);

    public static void Main(string[] args){

        //step2 instanciate the delegate
        //step3 pass the name of method to the constructor
        // delegateForHelloWorld del = new delegateForHelloWorld(HelloWorld);

        //step4 Invoke the method via delegate instance
        // string output = del();
        // Console.WriteLine(output);

        // delegateForBestWishes ourDelegate = new delegateForBestWishes(BestWishes);
        // string text = ourDelegate("Abhishek");
        // Console.WriteLine(text);

        // //overwriting the reference of previous method with the reference of new method : Unicast
        // ourDelegate += ExpectedAnswer;
        // Console.WriteLine(ourDelegate("What is your name?"));

        // delegateForSum sumDelegate = new delegateForSum(Sum);
        // int ans = sumDelegate(2,2);
        // Console.WriteLine(ans);

        // arithmeticDel del_obj = new arithmeticDel(Add);
        // del_obj += Sub;
        // del_obj += Multiply;
        // del_obj += Divivde;
        // del_obj -= Divivde;

        // del_obj(2,2);
        // delegateForArea? del_area_obj = new delegateForArea(AreaOfCircle);
        // del_area_obj(2,3.14);
        // del_area_obj -= AreaOfCircle;
        // del_area_obj += AreaOfRectangle;
        // del_area_obj += AreaOfTraingle;

        // del_area_obj(2,3);
        // del_area_obj.Invoke(2,3);

        // mathDel obj = new mathDel(Mymath.Add);
        // obj += Mymath.Sub;
        // obj += Mymath.Divivde;
        // obj += Mymath.Multiply;
        // obj(20,20);

        Message message = new Message(){Name = "Abhishek"};
        delegateForClassMethod? del = new delegateForClassMethod(message.AskQuestion);
        // del("How are you?");

        // del -= message.AskQuestion;
        // del += message.Greet;
        // del("Welcome");



    }


    public static void AreaOfCircle(double r,double pi){
        Console.WriteLine($"AreaOfCircle : {pi*r*r}"   ) ;
    }
    // public static double AreaOfSquare(int a,int a){
    //     return a*a;
    // }
    public static void AreaOfTraingle(double b,double h){
        Console.WriteLine($"AreaOfTraingle : {b*h/2}"   ) ;
    }
    public static void AreaOfRectangle(double l,double b){
        Console.WriteLine($"AreaOfRectangle : {l*b}"   ) ;
    }
    public static void Add(int a, int b){
        Console.WriteLine($"{a} + {b} = {a+b}");
    }
    public static void Sub(int a, int b){
        Console.WriteLine($"{a} - {b} = {a-b}");
    }
    public static void Multiply(int a, int b){
        Console.WriteLine($"{a} x {b} = {a*b}");
    }
    public static void Divivde(int a, int b){
        Console.WriteLine($"{a} / {b} = {a/b}");
    }
    public static int Sum(int a, int b){
        return a+b;
    }
    public static string HelloWorld(){
        return "Hello World";
    }
    public static string BestWishes(string name){
        return $"Hello and Greetings to {name}";
    }
    public static string ExpectedAnswer(string question){
        return question;
    }
}