using System.Collections;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
class Program
{
    public static void Main(string[] args){



        // NonGeneric Collection
        // anykind of data accepted, no size restriciton
        // boxing take place
        // value type of data is converted to ref type
        // up casting takes place


        // int[] myarr = {1,2,3,4,5};
        // ArrayList arr = new ArrayList(); // non homegonious type, Boxing is a process in non generic collection where any type of data it may be value tpye or refernce tpye get converted tinto object type, internally all this values are object
        // arr.Add(1); // it is not recommended to use non generic type to avoid more computational power
        // arr.Add("Abhishek");
        // arr.Add(true);
        // arr.Add('a');
        // arr.Add(45.34);
        // arr.Add(12.32f);
        // arr.Add(DateTime.Now);
        // arr.Add(12.323m);
        // arr.AddRange(myarr);

        // foreach(var obj in arr){
        //     Console.WriteLine(obj);
        // }
        
        // Console.WriteLine($"Total count of arr : {arr.Count}");

        // ArrayList arrObj = new ArrayList();
        // arrObj.Add(new Student(1,"Abhishek","Agnihotri",new Date(1,1,2020)));
        // arrObj.Add(new Employee(1,"Abhishek","Agnihotri",Department.IT,1200,new Date(10,6,2024)));
        
        // foreach(var obj in arrObj){
        //     Console.WriteLine(obj);
        // }

        // Stack st = new Stack();
        // st.Push("Abhishek");
        // st.Push("Agnihotri");
        // st.Push(1234);
        // st.Push("ToRemoveElement");
        // Console.WriteLine(st.Pop());
        // Console.WriteLine(st.Peek());
        // Console.WriteLine(st.Count);
        // Console.WriteLine(st.Contains("Abhishek"));
        
        // ICollection queue = new Queue();
        
        // var queue = new Queue();
        // queue.Enqueue("Abhishek");
        // queue.Enqueue("Agnihotri");
        // queue.Enqueue(1234);
        // queue.Enqueue("AddingElement");
        // Console.WriteLine(queue.Dequeue());
        // Console.WriteLine(queue.Peek());
        // Console.WriteLine(queue.Count);
        // Console.WriteLine(queue.Contains(1234));



        // Generic Collection
        // But data type declared at compile type in <> bracket, no size restriciton
        // No Boxing take place
        // List<string> names = new List<string>();

        // List<string> strings = [];
        // List<string> fruits = new List<string>(); // Generic Type
        // fruits.Add("Apple");
        // fruits.Add("Orange");
        // fruits.Add("Banana");
        // fruits.Add("Banana");
        // fruits.Add("Banana");
        // fruits.Add("Banana");
        // fruits.Add("Banana");
        // fruits.Add("Banana");
        // fruits.Add("Banana");


        // foreach(string fruit in fruits){
        //     Console.WriteLine(fruit);
        // }

        // fruits.Sort();
        // Console.WriteLine();
        // foreach(string fruit in fruits){
        //     Console.WriteLine(fruit);
        // }
        // Console.WriteLine(fruits.Count);
        // Console.WriteLine(fruits.Capacity);
        // List<Student> students = new List<Student>();
        // students.Add(new Student(1,"Abhishek","Agnihotri",new Date(1,1,2020)));
        // students.Add(new Student(12,"Abhishek","Agnihotri",new Date(1,1,2020)));
        // students.Add(new Student(3,"Abhishek","Agnihotri",new Date(1,1,2020)));
        // students.Add(new Student(5,"Abhishek","Agnihotri",new Date(1,1,2020)));
        // students.Sort();

        // foreach(Student stu in students){
        //     Console.WriteLine(stu);
        // }

        // List<Book> books = new List<Book>();
        // books.Add(new Book(12,"War and Peice","Leo Tolstoy",250));
        // books.Add(new Book(1434,"Three Mistake of My Life","Chetan Bhagat",150));
        // books.Add(new Book(3,"The Unthinkable","Dr B R Ambedkar",350));
        // books.Add(new Book(7,"Six Machine","Chris Gayle",200));
        // // books.Sort(); // comparable inside book(compareTo) based on title
        // // books.Sort(new AuthorComparer()); // using comparer based on author
        // // books.Sort(new PriceComparer()); // using comparer based on author
        // books.Sort(new TitleComparer()); // using comparer based on Title

        // //Sort By Author
        // // books.Sort((x,y) => x.Author.CompareTo(y.Author)); // Comparison Deligates

        // foreach(Book book in books){
        //     Console.WriteLine(book);
        // }

        // Stack<Book> stack = [];
        // stack.Push(new Book(12,"War and Peice","Leo Tolstoy",250));
        // stack.Push(new Book(1434,"Three Mistake of My Life","Chetan Bhagat",150));
        // stack.Push(new Book(3,"The Unthinkable","Dr B R Ambedkar",350));
        // stack.Push(new Book(7,"Six Machine","Chris Gayle",200));

        // Console.WriteLine(stack.Pop());

        // foreach(Book book in stack){
        //     Console.WriteLine(book);
        // }

        // Queue<string> queue = [];
        // queue.Enqueue("A");
        // queue.Enqueue("B");
        // queue.Enqueue("C");
        // try{
        //     Console.WriteLine(queue.Dequeue());
        //     Console.WriteLine(queue.Dequeue());
        //     Console.WriteLine(queue.Dequeue());
        //     Console.WriteLine(queue.Dequeue());

        // }
        // catch(InvalidOperationException e){
        //     Console.WriteLine(e);
        // }

        // Console.WriteLine("Hello Abhishek, even I executed");

        // Collection<int> numbers = new Collection<int>() {1,2,3,4};
        // foreach(int i in numbers){
        //     Console.WriteLine(i);
        // }

        // Private Constructor
        // Book book = Book.GetBook();
        // Console.WriteLine(book.Author);

        // Book book2 = Book.GetBook();
        // Console.WriteLine(book2.Author);

        // Hashtable hashtable = new Hashtable();

        // hashtable.Add("a",1);
        // hashtable.Add("b",1);
        // hashtable.Add("c",1);
        // hashtable.Add("d",1);
        // hashtable.Add("e",1);
        // hashtable.Add("f","abc");

        // foreach(DictionaryEntry E in hashtable){
        //     Console.WriteLine($"key : {E.Key}, Value : {E.Value}");
        // }
        // Console.WriteLine($"Total Item Count : {hashtable.Count}");

        // foreach(var key in hashtable.Keys){
        //     Console.WriteLine($"key : {key}, Value : {hashtable[key]}");
        // }
        // Console.WriteLine(hashtable.Contains("d"));
        // hashtable.Remove("e");
        // Console.WriteLine($"Total Item Count : {hashtable.Count}");

        // hashtable.Add(new Employee(1,"Abhishek","Agnihotri",Department.IT,1200,new Date(10,6,2024)),1200);
        // hashtable.Add(new Employee(2,"KK","KK",Department.IT,1200,new Date(10,6,2024)),1300);
        // hashtable.Add(new Employee(3,"AA","BB",Department.IT,1200,new Date(10,6,2024)),1400);

        // foreach(var key in hashtable.Keys){
        //     Console.WriteLine($"key : {key}, Value : {hashtable[key]}");
        // }

        // List<KeyValuePair<int,int>> list;
        // list.Add({1,1});



        // Dictonary (generic Class)
        // Dictionary<string,string> dict = new Dictionary<string, string>();
        // dict.Add("1","One");
        // dict.Add("2","Two");
        // dict.Add("3","Three");
        // dict.Add("4","Four");
        // dict.Add("5","Five");
        // foreach(KeyValuePair<string,string> kvp in dict){
        //     Console.WriteLine($"Key : {kvp.Key}, Value : {kvp.Value}");
        // }

        // ICollection emplist = new List<Employee>(); 
        // role of icollection, is to allow list class to have 4 property of icollection interface has -> Count, IsSynchronized, SyncRoot, CopyTo
        // how to use it
        
        
        // List<Employee> employees = Employee.GetEmployees();
        // foreach(Employee employee in employees){
        //     Console.WriteLine(employee);
        // }

        // Car car = new Car(){Brand = "Maruti Suzuki",Model = "Baleno"};
        // IPrint ptr = car;
        // ptr.Print("Hello Print");

        // IDisplay dis = car;
        // dis.Print("Hello Display");
        // ((IPrint)car).Print("Big Print");
        // ((IDisplay)car).Print("Big Display");

        // List<Student> employees = Student.GetEmployees();
        // write menu driven Program to Add Student to a list Remove a student 
        // From List and Display List and Exit from Program
        // while(true){
        //     Console.WriteLine("Enter 1 to Add Employee, 2 to Remove Employee By RollNo, 3 to Display List All Students, -1 to exit");
        //     int num = Convert.ToInt32(Console.ReadLine());

        //     switch(num){
        //         case -1:
        //             break;

        //         case 1:
        //             Student.AddEmployee();
        //             break;

        //         case 2:
        //             Student.RemoveEmployee();
        //             break;

        //         case 3:
        //             Student.DisplayAll();
        //             break;

        //         default:
        //             break;

        //     }
        // }

        SortedList sortedList = new SortedList(){
            {2,true},
            {1,"one"}
        };
        foreach(DictionaryEntry kvp in sortedList) Console.WriteLine(kvp.Value);

    }
}