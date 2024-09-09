class Employeee
{
    public static void GetEmployeeDetails(string dept, char gender, params string []names){
        int n = names.Length;
        for (int i = 0 ; i < names.Length ; i++){
            if(i == n-1){
                Console.Write($"{names[i]}");
            }
            else{
                Console.Write($"{names[i]}, ");
            }
        }
        Console.WriteLine();
        if(gender == 'F' || gender == 'F')
        Console.WriteLine($"Number of girls in {dept} department is {names.Length}");
        else
        Console.WriteLine($"Number of Boys in {dept} department is {names.Length}");

    }

    public static void Main(){
        GetEmployeeDetails("IT",'M',"Ab","Bc","Cd","De");
        GetEmployeeDetails("IT",'M',"Ab","Bc","Cd","De","Ef","Fg");
    }
}