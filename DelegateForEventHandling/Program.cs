using System.Reflection.Metadata.Ecma335;

delegate void delegateDayofWeekGreeting(DateTime d);
delegate void sumDel(int a,int b);
// delegate void mulDel(int a,int b);


class Program
{

    public static void Main(string[] args){
        // Student s = new Student(){Name="Abhisek",ID=12};
        // s.Pass += new Markdel(ShowMessage.ShowGoodmsg);
        // s.Fail += new Markdel(ShowMessage.ShowBadmsg);
        // s.EnterMarks(10);

        // Assignment 3
        // User user = new User(){Name = "Abhishek"};
        // // User.Name = "Abhishek";
        // user.Morning += new noonDelegate(ShowGreeting.GoodMorning);
        // user.AfterNoon += new noonDelegate(ShowGreeting.GoodAfterNoon);
        // user.Evening += new noonDelegate(ShowGreeting.GoodEvening);
        // user.Night += new noonDelegate(ShowGreeting.GoodNight);

        // user.EnterTime();


        //Assignment 4
        // delegateDayofWeekGreeting delegate_greeting = new delegateDayofWeekGreeting(DayOfWeekGreeting);
        // delegate_greeting(DateTime.Now);


        //Anonymous Delegate
        // sumDel obj = delegate(int a, int b){
        //     Console.WriteLine($"{a} + {b} = {a+b}");
        // };
        // obj(20,20);

        // mulDel mulDel_obj = (int a,int b) => {
        //     Console.WriteLine($"{a} * {b} = {a*b}");
        // };
        // static void mulDel_obj(int a, int b) => Console.WriteLine($"{a} * {b} = {a * b}");

        // mulDel_obj(20,20);

        // static string greeting_user_obj(string name) => $"Welcome {name}";
        // Console.WriteLine(greeting_user_obj("Abhishek"));

        // int[] numbers = {1,2,3,4,5};
        // var square = numbers.Select(x=>x*x);
        // foreach(var s in square){
        //     Console.Write(s + " ");
        // }

        // Func<int,float,double,double> obj = new Func<int, float, double, double>(AddNumbers);
        // double ans = obj.Invoke(1,2.0f,12.0);

        // Func<double,double,double> areaOfCircle = new Func<double, double, double>(AreaOfCircle);
        // Console.WriteLine($"{areaOfCircle.Invoke(3.0,3.14):f2}");

        Action<int,float,double> obj2 = new Action<int, float, double>(AddNumbersVoid);
        obj2.Invoke(1,2.4f,6.88);

        Predicate<string> obj3 = new Predicate<string>(CheckLength);
        bool res = obj3.Invoke("Abhishek");
        Console.WriteLine(res);

        Predicate<int> obj4 = new Predicate<int>(CheckEven);
        Console.WriteLine(obj4.Invoke(23));
    }

    public static bool CheckEven(int a){
        return a%2==0;
    }
    public static bool CheckLength(string name){
        return name.Length > 5;
    }
    public static void AddNumbersVoid(int a,float b, double c){
        Console.WriteLine(a+b+c);
    } 
    public static double AreaOfCircle(double r, double pi){
        return (pi*r*r);
    } 
    public static double AddNumbers(int a,float b, double c){
        return a+b+c;
    } 

    public static void DayOfWeekGreeting(DateTime day){
        Console.WriteLine($"Good {day.DayOfWeek}");
    }

    
}