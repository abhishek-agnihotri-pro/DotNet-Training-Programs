
// using MyClassLibSecond;

namespace OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(1,"Abhishek","909808-0783","abhishek.a@gmail.com");
            c1.addAccount(new Account(12123213,AccountType.Saving,10000,new Date(1,1,19)));
            c1.addAccount(new Account(12123214,AccountType.Current,20000,new Date(1,1,19)));
            Console.WriteLine(c1);
            
            // Class1 obj = new Class1();
            // obj.LongDate();
            // Employee emp = new Employee(1100953,"Abhishek","Agnihotri",Department.IT, 5000m,new Date(10,6,2024));
            // emp.Print();"

            // Student[] arr = new Student[5];
            // arr[0] = new Student(101,"Abhishek","Agnihotri",new Date(1,1,2008));
            // arr[1] = new Student(102,"Abhishek","Agnihotri",new Date(1,1,2008));
            // arr[2] = new Student(103,"Abhishek","Agnihotri",new Date(1,1,2008));
            // arr[3] = new Student(104,"Abhishek","Agnihotri",new Date(1,1,2008));
            // arr[4] = new Student(105,"Abhishek","Agnihotri",new Date(1,1,2008));
            
            // Batch b = new Batch();
            // Batch b = new Batch(101, arr);
            // Console.WriteLine(b);

            // ProductInfo samsung = new ProductInfo(110,"Samsung J7 Max","Easy to use and communicate",new Date(1,1,2015),new Date(1,1,2025));
            // Console.WriteLine(samsung);
            // var anonymousobj = new {name = "XYZ", age = 25};
            // Console.WriteLine($"Name: {anonymousobj.name}, Age: {anonymousobj.age} ");


            // var Today = DateTime.Now;
            // Console.WriteLine(Today.ToLongDateString());
            // Console.WriteLine(Today.DayOfWeek);
            // Console.WriteLine(Today.AddDays(-5));

            // Employee[] emp = new Employee[5];
            // for(int i = 0 ; i < 5 ; i++) emp[i] = new Employee();
            // Console.WriteLine(Employee.count);
                
            // Console.WriteLine(Car.GearSystem);

            // Rational r1 = new Rational(2,1);
            // Rational r2 = new Rational(1,2);

            // Rational r3 = r1 + r2;
            // Console.WriteLine($"Addition with r1 and r2 : {r3}");
            
            // r3 = r1 - r2;
            // Console.WriteLine($"Subtraction with r1 and r2 : {r3}");
            
            // r3 = r1 * r2;
            // Console.WriteLine($"Multiplication with r1 and r2 : {r3}");
            
            // r3 = r1 / r2;
            // Console.WriteLine($"Division with r1 and r2 : {r3}");

            // bool test = true;
            // display(test);

            // void display(bool? a) =>Console.WriteLine(a is null ? "null" : a.Value.ToString());
        //     ClassStatic.a = Convert.ToInt32(Console.ReadLine());
        //     char ch = Convert.ToChar(Console.ReadLine());
        //     ClassStatic.b = Convert.ToInt32(Console.ReadLine());
        //     switch(ch){
        //         case '+':
        //             ClassStatic.c = ClassStatic.Add();
        //             Console.WriteLine($"{ClassStatic.a} + {ClassStatic.b}  = " + ClassStatic.c);
        //             break;

        //         case '-':
        //             ClassStatic.c = ClassStatic.Subtract();
        //             Console.WriteLine($"{ClassStatic.a} - {ClassStatic.b} = " + ClassStatic.c);
        //             break;
                
        //         case '*':
        //         case 'X':
        //         case 'x':
        //             ClassStatic.c = ClassStatic.Multiplication();
        //             Console.WriteLine($"{ClassStatic.a} x {ClassStatic.b} = " + ClassStatic.c);
        //             break;
                
        //         case '/':
        //             ClassStatic.c = ClassStatic.Division();
        //             Console.WriteLine($"{ClassStatic.a} / {ClassStatic.b} = " + ClassStatic.c);
        //             break;

        //         default:
        //             Console.WriteLine("Invalid Expression");
        //             break;
        //     }

        // Date date = new Date(1,1,1);
        // Student []Students = new Student[5];
        // Students[0] = new Student (101,"A","A",date);
        // Students[1] = new Student (101,"A","A",date);
        // Students[2] = new Student (101,"A","A",date);
        // Students[3] = new Student (101,"A","A",date);
        // Students[4] = new Student (101,"A","A",date);


        // BatchStatic bs = new BatchStatic(101, new Student (101,"A","A",date),
        //                                      new Student (101,"A","A",date),
        //                                      new Student (101,"A","A",date),
        //                                      new Student (101,"A","A",date),
        //                                      new Student (101,"A","A",date),
        //                                      new Student (101,"A","A",date),
        //                                      new Student (101,"A","A",date),
        //                                      new Student (101,"A","A",date),
        //                                      new Student (101,"A","A",date)
        //                                 );
        // BatchStatic.Gender = 'm';
    
        // bs.GetDetails();

        }
    }
}