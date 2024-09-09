public enum Depart {HR,IT,CS,AI,ML,DS}
public class Employee
{
    // prop
    public int EmpID { get; set; }
    public decimal Salary { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Depart Dept { get; set; }
    public Date DateOfJoining { get; set; }

    public static int count;
    // ctor
    public Employee(){
        EmpID = 1;
        FirstName = "A";
        LastName = "A";
        Dept = Depart.AI;
        Salary = 0;
        DateOfJoining = new Date(1,1,22);
        count++;
    }
    public Employee(int empID, string firstName, string lastName, Depart department, decimal salary, Date dateOfJoining){
        EmpID = empID;
        FirstName = firstName;
        LastName = lastName;
        Dept = department;
        Salary = salary;
        DateOfJoining = dateOfJoining;
    }
    public Employee(Employee e){
        EmpID = e.EmpID;
        FirstName = e.FirstName;
        LastName = e.LastName;
        Dept = e.Dept;
        Salary = e.Salary;
        DateOfJoining = e.DateOfJoining;
    }

    public override string ToString()
    {
        return $"Empoyee ID : {EmpID}, FirstName : {FirstName}, LastName : {LastName}, Department : {Dept}, Salary : {Salary}, Date of Joining : {DateOfJoining.Day}-{DateOfJoining.Month}-{DateOfJoining.Year}";
    }
    public void Print(){
        Console.WriteLine($"Empoyee ID : {EmpID}, FirstName : {FirstName}, LastName : {LastName}, Department : {Dept}, Salary : {Salary}, Date of Joining : {DateOfJoining.Day}-{DateOfJoining.Month}-{DateOfJoining.Year}");
    }
}