enum Department {HR,IT,CS,AI,ML,DS}
class Employee
{
    // prop
    public int EmpID { get; set; }
    public decimal Salary { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    // public Department Dept { get; set; }
    public int Dept { get; set; }
    // public Date DateOfJoining { get; set; }

    public static int count;
    // ctor
    public Employee(){
        EmpID = 1;
        FirstName = "A";
        LastName = "A";
        Dept = 1;
        Salary = 0;
        // DateOfJoining = new Date(1,1,22);
        count++;
    }
    // public Employee(int empID, string firstName, string lastName, Department department, decimal salary, Date dateOfJoining){
    public Employee(int empID, string firstName, string lastName, int department, decimal salary){
        EmpID = empID;
        FirstName = firstName;
        LastName = lastName;
        Dept = department;
        Salary = salary;
        // DateOfJoining = dateOfJoining;
    }
    public Employee(Employee e){
        EmpID = e.EmpID;
        FirstName = e.FirstName;
        LastName = e.LastName;
        Dept = e.Dept;
        Salary = e.Salary;
        // DateOfJoining = e.DateOfJoining;
    }

    public static List<Employee> GetEmployees(){
        Console.WriteLine("Please Enter Employee Details in the below foramt");
        Console.WriteLine("ID FirstName LastName DeptID Salary");
        Console.WriteLine("or Enter -1 to exit.");
        List<Employee> list = new List<Employee>();
        while(true){
            string? inputStr = Console.ReadLine();
            if(inputStr == null || inputStr.Length <= 2){
                break;
            }
            string[] strlist = inputStr.Split(" ", 5, StringSplitOptions.RemoveEmptyEntries);
            // Console.WriteLine(strlist[0] + strlist[1] + strlist[2] + strlist[3]);
            list.Add(new Employee(Convert.ToInt32(strlist[0]),strlist[1],strlist[2], Convert.ToInt32(strlist[3]), Convert.ToDecimal(strlist[4])));
        }
        return list;

    }

    public override string ToString()
    {
        // return $"Empoyee ID : {EmpID}, FirstName : {FirstName}, LastName : {LastName}, DepartmentID : {Dept}, Salary : {Salary}, Date of Joining : {DateOfJoining.Day}-{DateOfJoining.Month}-{DateOfJoining.Year}";
        return $"Empoyee ID : {EmpID}, FirstName : {FirstName}, LastName : {LastName}, DepartmentID : {Dept}, Salary : {Salary}";
    }
    public void Print(){
        // Console.WriteLine($"Empoyee ID : {EmpID}, FirstName : {FirstName}, LastName : {LastName}, Department : {Dept}, Salary : {Salary}, Date of Joining : {DateOfJoining.Day}-{DateOfJoining.Month}-{DateOfJoining.Year}");
    }
}