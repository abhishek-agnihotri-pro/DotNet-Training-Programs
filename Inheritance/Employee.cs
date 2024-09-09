enum Department{
    HR,Sales,Technical,Management,Operational
}
class Employeee
{
    public int ID { get; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Contact { get; set; }
    public Department Dept { get; set; }
    public Date? DOJ { get; set; }

    public decimal Basic_Salary { get; set; }

    public Employeee(){
        ID = 1;
        FirstName = "Abhishek";
        LastName = "Agnihotri";
        Email = "abhishek.agnihotri@yash.com";
        Contact = "+91-9098080785";
        Dept = Department.Sales;
        DOJ = new Date(1,1,2023);
        Basic_Salary = 12000;
    }
    public Employeee(int id,string firstName,string lastName,string email,string contact,Department dept,Date doj,decimal basic_salary ){
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Contact = contact;
        Dept = dept;
        DOJ = doj;
        Basic_Salary = basic_salary;
    }

    protected virtual decimal GrossSalary(){
        return Basic_Salary;
    }
    public static void NetSalary(Employeee emp){
        decimal net = emp.GrossSalary() - 2000;
        Console.WriteLine($"Net Salary : {net}");
    }

    public override string ToString()
    {
        return $"Employee ID : {ID}, FirstName : {FirstName}, LastName : {LastName}, Department : {Dept}, Date_Of_Joining : {DOJ}, Email : {Email}, Gross Salary : {GrossSalary():c}";
    }



}