
class Program
{
    public static void Main(string[] args){
        // int [] numbers = {1000,0002,3,40000,5};
        // var result1 = from n in numbers
        //             where n > 100
        //             orderby n
        //               select n;
        // Console.WriteLine("Data from array using linq query : ");
        // foreach(int r in result1){
        //     // Console.Write(r + ", ");
        // }

        // string[] fruits = {"Guava","Pineapple","Mango","Banana","Apple"};

        // var fruits_result = from f in fruits 
        //                     orderby f
        //                     where f[1] == 'u'
        //                     // where String.Compare(f,"p") > 0
        //                     select f;
        // foreach(string fruit in fruits_result)
        // Console.WriteLine(fruit);

        string[] singers = {"Arjit Singh", "Asha Bhosale", "Amit Kumar", "Udit Naraya", "Ankit Tiwari","Kishor Kumar"};
        var res_startswith_a =  from singer in singers
                    where singer.StartsWith("A")
                    select singer;
        
        var res_contains_kumar =  from singer in singers
                    where singer.Contains("Kumar")
                    select singer;

        foreach(var singer in res_contains_kumar)
        Console.WriteLine($"Singer Contains Kumar {singer}");

        foreach(var singer in res_startswith_a)
        Console.WriteLine($"Singer Starting with A {singer}");

        int[] a = {123,23,123,5436,6343,2,7,473,13,9};
        int[] b = {123, 34,324,5643,75, 46, 23,12,13};

        var union = a.Union(b);
        foreach(var num in union) Console.Write(num + " ");

        Console.WriteLine("");
        var intersect = a.Intersect(b);
        foreach(var num in intersect) Console.Write(num + " ");

        Console.WriteLine("");
        var except = a.Except(b);
        foreach(var num in except) Console.Write(num + " ");

        var count = a.Count(); // a.max(), a.min(), a.sum();

        bool even_present = a.Any(num => num %2 == 0);
        bool more_than_1 = a.All(num => num > 1);
        Console.WriteLine(even_present);
        Console.WriteLine(more_than_1);

        List<int> ints = new List<int> {1,2,3,4,5,6,7,8,9,10};
        var ans = ints.Where(n => n > 5);
        // LINQ -> WHERE method with lamda expression
        foreach(var n in ans)
        Console.Write(n);

        var male_students = Student.GetStudents().Where(Student => Student.Gender == "Male");
        foreach(var student in male_students)
        Console.WriteLine(student.Name + " " + student.Gender);

        var girl_students = from s in Student.GetStudents()
                            where s.Gender == "Female"
                            select s;
        
        foreach(var student in girl_students)
        Console.WriteLine(student.Name + " " + student.Gender);

        var data  = from s in Student1.GetStudents().SelectMany(p => p.Programming)
                    select s;
        foreach(var str in data.Distinct())
        Console.WriteLine(str);

        var students_name = from s in GroupProject.GetProjects().SelectMany(stu => stu.GroupofStudents)
                            select s;
        foreach(var stu in students_name.Distinct())
        Console.WriteLine(stu);

        var grp_by_branch = Student.GetStudents().GroupBy(s => s.Branch);
        foreach (var grp in grp_by_branch)
        {
            Console.WriteLine(grp.Key + " " + grp.Count());
            foreach (var s in grp)
            {
                Console.WriteLine(s.Branch + " " + s.Name);
            }
        }

        // var present = a.Single(n => n > 20);
        // Console.WriteLine(present);

        // var present = a.SingleOrDefault(n => n == 2);
        // Console.WriteLine(present);

        string[] fruits = {"Guava","Pineapple","Mango","Banana","Apple"};

        try{
            var matched = fruits.Single(f => f == "Dragon Fruit");
            Console.WriteLine(matched);
        }
        catch(InvalidOperationException ex){
            Console.WriteLine(ex.Message);
        }

        var matchinmg = fruits.SingleOrDefault(f => f == "Dragon Fruit");
        Console.WriteLine(matchinmg);

        var found = a.First(n => n%2 == 0);
        Console.WriteLine(found);

        var mango_fruit_where = fruits.Where(f => f == "Mango"); // returns a list which further required to be iterated so better to use FirstOrDefault when assured to found 1 matching entry only.
        foreach(var mango in mango_fruit_where)
        Console.WriteLine(mango);

        var mango_fruit = fruits.FirstOrDefault(f => f == "Mango");
        Console.WriteLine(mango_fruit);
        

        var employees_with_salary_greaterthan_70k = Employee.GetEmployees().Where(emp => emp.Salary > 70000);
        foreach(var emp in employees_with_salary_greaterthan_70k){
            Console.WriteLine(emp.FirstName + " " + emp.Salary);
        }

        var emp_with_id_102 = Employee.GetEmployees().FirstOrDefault(emp => emp.ID == 102);
        Console.WriteLine(emp_with_id_102.ID + " " + emp_with_id_102.FirstName);

    }
}