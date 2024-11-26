using System.Threading.Tasks;

class Program
{

    // public static void Main(string[] args){
    public static async Task Main(string[] args){
        // Thread t1 = new Thread(MethodNew);
        // Number number = new Number();
        // Thread t1 = new Thread(number.Display);
        // t1.Name = "Main Thread";
        // t1.Start();
        // Console.WriteLine(Thread.CurrentThread.Name);
        // if(t1.IsAlive){
        //     t1.Join(); //t1.Join() will make the program wait at that point until t1 has finished executing number.Display method.
        //     Console.WriteLine("Thread Alive");
        // }else{
        //     Console.WriteLine("Thread is not Alive");
        // }
        // Console.WriteLine($"{t1.Name} is running ");

        // Thread T1 = new Thread(Method1);
        // Thread T2 = new Thread(Method2);
        // Thread T3 = new Thread(Method3);
        // T1.Start();
        // T2.Start();
        // T3.Start();

        // ThreadStart ts = new ThreadStart(new Number().Display); // ThreadStart Delegate
        // Thread t_ts1 = new Thread(ts);
        // t_ts1.Start();
        // int n = 1;
        // ParameterizedThreadStart obj = new ParameterizedThreadStart(AcceptInput);
        // Thread thread_parameter = new Thread(obj);
        // thread_parameter.Start(n);

        // ParameterizedThreadStart pts = new ParameterizedThreadStart(AcceptInput);
        // Thread ptsT = new Thread(pts);
        // ptsT.Start(n);

        // Thread thread1 = new Thread(new ThreadStart(DisplayMessage));
        // thread1.Start();
        // Thread thread2 = new Thread(new ThreadStart(DisplayMessage));
        // thread2.Start();
        // Thread thread3 = new Thread(new ThreadStart(DisplayMessage));
        // thread3.Start();

        // Thread increment1 = new Thread(new ThreadStart(IncrementN));
        // increment1.Start();
        // Thread increment2 = new Thread(new ThreadStart(IncrementN));
        // increment2.Start();
        // Thread increment3 = new Thread(new ThreadStart(IncrementN));
        // increment3.Start();

        // Thread threads = new Thread[10];

        // MethodTask1();
        // MethodTask2();
        // Task.Delay(10000).Wait();
        // Console.WriteLine("Download File1");
        // Task.Delay(10000).Wait();
        // Console.WriteLine("Download File2");
        // Console.WriteLine("Enter data ");
        // string? Name = Console.ReadLine();
        // Console.WriteLine("Name :" + Name);

        Task myTask1 = Task.Run(async () =>
        {
            Console.WriteLine("Chef 1 is preparing Dish 1");
            await Task.Delay(10000); // Chef 1 takes 10 seconds to prepare Dish 1
            Console.WriteLine("Dish 1 is ready!");
        });
        
        Task myTask2 = Task.Run(async () =>
        {
            Console.WriteLine("Chef 2 is preparing Dish 2");
            await Task.Delay(10000); // Chef 1 takes 10 seconds to prepare Dish 1
            Console.WriteLine("Dish 2 is ready!");
        });

        Task myTask3 = Task.Run(async () =>
        {
            Console.WriteLine("Chef 3 is preparing Dish 3");
            await Task.Delay(1000); // Chef 1 takes 10 seconds to prepare Dish 1
            Console.WriteLine("Dish 3 is ready!");
        });

        await Task.WhenAll(myTask1,myTask2,myTask3);
        Console.WriteLine("All Dishes are ready");
    }

    public static async void MethodTask1(){
        Console.WriteLine("Downloading File1");
        await Task.Delay(3000);
        Console.WriteLine("Downloaded File1");
    }
    public static async void MethodTask2(){
        Console.WriteLine("Downloading File11");
        await Task.Delay(3000);
        Console.WriteLine("Downloaded File11");
    }
    static int n = 5;

    public static void IncrementN(){
        lock(LockObj){
            Console.WriteLine($"Before Increament N is {n}");
            Thread.Sleep(3000);
            n++;
            Console.WriteLine($"After Increament N is {n}");
            Thread.Sleep(3000);
            Console.WriteLine();
        }
    }

    public static readonly object LockObj = new object();

    public static void DisplayMessage(){
        lock(LockObj){
        Console.WriteLine($"Hi, It is a small ");
        Thread.Sleep(5000);
        Console.WriteLine($"message from DisplayMessage Method");
        }
    }
    public static void AcceptInput(object? n){
        int n_converted = 0;
        if(n != null) 
        n_converted = (int)n;
        Console.WriteLine($"n is : {n_converted}");
    }
    public static void MethodNew(){
        Console.WriteLine("MethodNew Inside");
        Thread.Sleep(TimeSpan.FromSeconds(2));
    }

    public static void Method1(){
        for(int i = 0 ; i < 3 ; i++){
            Console.WriteLine("Method 1" + i);
            Thread.Sleep(2000);
        }
        Console.WriteLine("Method 1 starting execution .. ");
        Thread.Sleep(2000);
        Console.WriteLine("Method 1 is ending ...");
    }
    public static void Method2(){
        for(int i = 0 ; i < 3 ; i++){
            Console.WriteLine("Method 2" + i);
            Thread.Sleep(2000);
        }
        Console.WriteLine("Method 2 starting execution .. ");
        Thread.Sleep(2000);
        Console.WriteLine("Method 2 is ending ...");
    }
    public static void Method3(){
        for(int i = 0 ; i < 3 ; i++){
            Console.WriteLine("Method 3" + i);
            Thread.Sleep(2000);
        }
        Console.WriteLine("Method 3 starting execution .. ");
        Thread.Sleep(2000);
        Console.WriteLine("Method 3 is ending ...");
    }
}