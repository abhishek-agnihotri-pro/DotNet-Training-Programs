
class SalesManager : Employeee
{
    public decimal Commission { get; set; }
    public decimal Sales { get; set; }

    public SalesManager(){
        Commission = 12;
        Sales = 500;
    }
    public SalesManager(int id,string firstName,string lastName,string email,string contact,Department dept,Date doj,decimal basic_salary,decimal commission, int sales):base(id,firstName,lastName,email,contact,dept,doj,basic_salary){
        Commission = commission;
        Sales = sales;
    }
    public SalesManager(decimal commission, int sales){
        Commission = commission;
        Sales = sales;
    }

    
    protected override decimal GrossSalary(){
        return Basic_Salary + (Sales*Commission/100) + 0.50m*Basic_Salary;
    }

    public override string ToString()
    {
        return base.ToString() + $", Sales : {Sales}, Commission : {Commission}";
    }
}