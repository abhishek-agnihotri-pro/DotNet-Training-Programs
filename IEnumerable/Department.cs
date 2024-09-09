using System.Collections;
using System.Diagnostics.CodeAnalysis;
public class Department : IEnumerable
{
    public int DeptID { get; set; }
    public Employee[]? Employees { get; set; }

    public Department(){
        Employees = [
            new Employee{EmpID=101,FirstName="Abhishek",LastName="Agnihotri",Dept = Depart.CS,DateOfJoining = new Date(12,12,12),Salary = 12000},
            new Employee{EmpID=102,FirstName="Pankaj",LastName="Sharma",Dept = Depart.CS,DateOfJoining = new Date(12,12,12)},
            new Employee{EmpID=103,FirstName="Arun",LastName="Lal",Dept = Depart.CS,DateOfJoining = new Date(12,12,12)},
            new Employee{EmpID=104,FirstName="Jaynam",LastName="Sangvi",Dept = Depart.CS,DateOfJoining = new Date(12,12,12)},
            new Employee{EmpID=105,FirstName="Arun",LastName="Mishra",Dept = Depart.CS,DateOfJoining = new Date(12,12,12) }
        ];
    }

    public IEnumerator GetEnumerator()
    {
        foreach(Employee? employee in Employees){
            yield return employee;
        }
    }
}
