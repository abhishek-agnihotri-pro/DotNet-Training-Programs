class Program
{
    public static void Main(string[] args){

        EmployeePartial emp = new EmployeePartial{EmpID = 1100953, FirstName = "Abhishek",LastName="Agnihotri", Contact="9098080785",Email="abhishek.agnihotri@yash.com"};
        emp.DisplayEmployeeDetail();
        // Batch YashBatch = new Batch();
        // // int n = 101;
        // Department dept = new Department();
        // try{
        //     // Console.WriteLine(YashBatch["abhishek"]);
        //     Console.WriteLine(dept["abhishek"]);
        // }
        // catch(Exception ex){
        //     Console.WriteLine(ex);
        // }
    }
}